using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Probable_Responsable_PC;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Respuesta;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Respuesta;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Core.Domain.Largo_de_Cabello;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Color_de_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Froma_Ojos;
using Spartane.Core.Domain.Anteojos;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Grosor_de_Labios;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Forma_de_Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tamano_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Senas_Particulares;
using Spartane.Core.Domain.Situacion_Fisica;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Probable_Responsable_PC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Probable_Responsable_PC;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cara;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_de_Cejas;
using Spartane.Web.Areas.WebApiConsumer.Largo_de_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Cantidad_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Implantacion_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Complexion;
using Spartane.Web.Areas.WebApiConsumer.Color_Piel;
using Spartane.Web.Areas.WebApiConsumer.Frente;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Color_de_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Calvicie;
using Spartane.Web.Areas.WebApiConsumer.Color_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Ojos;
using Spartane.Web.Areas.WebApiConsumer.Froma_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Anteojos;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Nariz;
using Spartane.Web.Areas.WebApiConsumer.Nariz_Base;
using Spartane.Web.Areas.WebApiConsumer.Labios;
using Spartane.Web.Areas.WebApiConsumer.Boca;
using Spartane.Web.Areas.WebApiConsumer.Grosor_de_Labios;
using Spartane.Web.Areas.WebApiConsumer.Menton;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Menton;
using Spartane.Web.Areas.WebApiConsumer.Barba;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Lobulo;
using Spartane.Web.Areas.WebApiConsumer.Bigote;
using Spartane.Web.Areas.WebApiConsumer.Senas_Particulares;
using Spartane.Web.Areas.WebApiConsumer.Situacion_Fisica;

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
    public class Probable_Responsable_PCController : Controller
    {
        #region "variable declaration"

        private IProbable_Responsable_PCService service = null;
        private IProbable_Responsable_PCApiConsumer _IProbable_Responsable_PCApiConsumer;
        private ISolicitud_de_Denuncia_CiudadanaApiConsumer _ISolicitud_de_Denuncia_CiudadanaApiConsumer;
        private ITipo_de_SolicitudApiConsumer _ITipo_de_SolicitudApiConsumer;
        private IRespuestaApiConsumer _IRespuestaApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IForma_CaraApiConsumer _IForma_CaraApiConsumer;
        private ICejasApiConsumer _ICejasApiConsumer;
        private ITamano_de_CejasApiConsumer _ITamano_de_CejasApiConsumer;
        private ILargo_de_CabelloApiConsumer _ILargo_de_CabelloApiConsumer;
        private ICantidad_CabelloApiConsumer _ICantidad_CabelloApiConsumer;
        private IImplantacion_CabelloApiConsumer _IImplantacion_CabelloApiConsumer;
        private IComplexionApiConsumer _IComplexionApiConsumer;
        private IColor_PielApiConsumer _IColor_PielApiConsumer;
        private IFrenteApiConsumer _IFrenteApiConsumer;
        private IForma_CabelloApiConsumer _IForma_CabelloApiConsumer;
        private IColor_de_CabelloApiConsumer _IColor_de_CabelloApiConsumer;
        private ICalvicieApiConsumer _ICalvicieApiConsumer;
        private IColor_OjosApiConsumer _IColor_OjosApiConsumer;
        private IOjosApiConsumer _IOjosApiConsumer;
        private IFroma_OjosApiConsumer _IFroma_OjosApiConsumer;
        private IAnteojosApiConsumer _IAnteojosApiConsumer;
        private IForma_de_NarizApiConsumer _IForma_de_NarizApiConsumer;
        private INariz_BaseApiConsumer _INariz_BaseApiConsumer;
        private ILabiosApiConsumer _ILabiosApiConsumer;
        private IBocaApiConsumer _IBocaApiConsumer;
        private IGrosor_de_LabiosApiConsumer _IGrosor_de_LabiosApiConsumer;
        private IMentonApiConsumer _IMentonApiConsumer;
        private IForma_de_MentonApiConsumer _IForma_de_MentonApiConsumer;
        private IBarbaApiConsumer _IBarbaApiConsumer;
        private IForma_OrejasApiConsumer _IForma_OrejasApiConsumer;
        private ITamano_OrejasApiConsumer _ITamano_OrejasApiConsumer;
        private ITipo_LobuloApiConsumer _ITipo_LobuloApiConsumer;
        private IBigoteApiConsumer _IBigoteApiConsumer;
        private ISenas_ParticularesApiConsumer _ISenas_ParticularesApiConsumer;
        private ISituacion_FisicaApiConsumer _ISituacion_FisicaApiConsumer;

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

        
        public Probable_Responsable_PCController(IProbable_Responsable_PCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IProbable_Responsable_PCApiConsumer Probable_Responsable_PCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitud_de_Denuncia_CiudadanaApiConsumer Solicitud_de_Denuncia_CiudadanaApiConsumer , ITipo_de_SolicitudApiConsumer Tipo_de_SolicitudApiConsumer , IRespuestaApiConsumer RespuestaApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IForma_CaraApiConsumer Forma_CaraApiConsumer , ICejasApiConsumer CejasApiConsumer , ITamano_de_CejasApiConsumer Tamano_de_CejasApiConsumer , ILargo_de_CabelloApiConsumer Largo_de_CabelloApiConsumer , ICantidad_CabelloApiConsumer Cantidad_CabelloApiConsumer , IImplantacion_CabelloApiConsumer Implantacion_CabelloApiConsumer , IComplexionApiConsumer ComplexionApiConsumer , IColor_PielApiConsumer Color_PielApiConsumer , IFrenteApiConsumer FrenteApiConsumer , IForma_CabelloApiConsumer Forma_CabelloApiConsumer , IColor_de_CabelloApiConsumer Color_de_CabelloApiConsumer , ICalvicieApiConsumer CalvicieApiConsumer , IColor_OjosApiConsumer Color_OjosApiConsumer , IOjosApiConsumer OjosApiConsumer , IFroma_OjosApiConsumer Froma_OjosApiConsumer , IAnteojosApiConsumer AnteojosApiConsumer , IForma_de_NarizApiConsumer Forma_de_NarizApiConsumer , INariz_BaseApiConsumer Nariz_BaseApiConsumer , ILabiosApiConsumer LabiosApiConsumer , IBocaApiConsumer BocaApiConsumer , IGrosor_de_LabiosApiConsumer Grosor_de_LabiosApiConsumer , IMentonApiConsumer MentonApiConsumer , IForma_de_MentonApiConsumer Forma_de_MentonApiConsumer , IBarbaApiConsumer BarbaApiConsumer , IForma_OrejasApiConsumer Forma_OrejasApiConsumer , ITamano_OrejasApiConsumer Tamano_OrejasApiConsumer , ITipo_LobuloApiConsumer Tipo_LobuloApiConsumer , IBigoteApiConsumer BigoteApiConsumer , ISenas_ParticularesApiConsumer Senas_ParticularesApiConsumer , ISituacion_FisicaApiConsumer Situacion_FisicaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IProbable_Responsable_PCApiConsumer = Probable_Responsable_PCApiConsumer;
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
            this._IRespuestaApiConsumer = RespuestaApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._IRespuestaApiConsumer = RespuestaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IForma_CaraApiConsumer = Forma_CaraApiConsumer;
            this._ICejasApiConsumer = CejasApiConsumer;
            this._ITamano_de_CejasApiConsumer = Tamano_de_CejasApiConsumer;
            this._ILargo_de_CabelloApiConsumer = Largo_de_CabelloApiConsumer;
            this._ICantidad_CabelloApiConsumer = Cantidad_CabelloApiConsumer;
            this._IImplantacion_CabelloApiConsumer = Implantacion_CabelloApiConsumer;
            this._IComplexionApiConsumer = ComplexionApiConsumer;
            this._IColor_PielApiConsumer = Color_PielApiConsumer;
            this._IFrenteApiConsumer = FrenteApiConsumer;
            this._IForma_CabelloApiConsumer = Forma_CabelloApiConsumer;
            this._IColor_de_CabelloApiConsumer = Color_de_CabelloApiConsumer;
            this._ICalvicieApiConsumer = CalvicieApiConsumer;
            this._IColor_OjosApiConsumer = Color_OjosApiConsumer;
            this._IOjosApiConsumer = OjosApiConsumer;
            this._IFroma_OjosApiConsumer = Froma_OjosApiConsumer;
            this._IAnteojosApiConsumer = AnteojosApiConsumer;
            this._IForma_de_NarizApiConsumer = Forma_de_NarizApiConsumer;
            this._INariz_BaseApiConsumer = Nariz_BaseApiConsumer;
            this._ILabiosApiConsumer = LabiosApiConsumer;
            this._IBocaApiConsumer = BocaApiConsumer;
            this._IGrosor_de_LabiosApiConsumer = Grosor_de_LabiosApiConsumer;
            this._IMentonApiConsumer = MentonApiConsumer;
            this._IForma_de_MentonApiConsumer = Forma_de_MentonApiConsumer;
            this._IBarbaApiConsumer = BarbaApiConsumer;
            this._IForma_OrejasApiConsumer = Forma_OrejasApiConsumer;
            this._ITamano_OrejasApiConsumer = Tamano_OrejasApiConsumer;
            this._ITipo_LobuloApiConsumer = Tipo_LobuloApiConsumer;
            this._IBigoteApiConsumer = BigoteApiConsumer;
            this._ISenas_ParticularesApiConsumer = Senas_ParticularesApiConsumer;
            this._ISituacion_FisicaApiConsumer = Situacion_FisicaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Probable_Responsable_PC
        [ObjectAuth(ObjectId = (ModuleObjectId)45714, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45714, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Probable_Responsable_PC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45714, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45714, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varProbable_Responsable_PC = new Probable_Responsable_PCModel();
			varProbable_Responsable_PC.Clave = Id;
			
            ViewBag.ObjectId = "45714";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Probable_Responsable_PCsData = _IProbable_Responsable_PCApiConsumer.ListaSelAll(0, 1000, "Probable_Responsable_PC.Clave=" + Id, "").Resource.Probable_Responsable_PCs;
				
				if (Probable_Responsable_PCsData != null && Probable_Responsable_PCsData.Count > 0)
                {
					var Probable_Responsable_PCData = Probable_Responsable_PCsData.First();
					varProbable_Responsable_PC= new Probable_Responsable_PCModel
					{
						Clave  = Probable_Responsable_PCData.Clave 
	                    ,Solicitud = Probable_Responsable_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Probable_Responsable_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Tipo_de_Solicitud = Probable_Responsable_PCData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Probable_Responsable_PCData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Tiene_informacion_responsable = Probable_Responsable_PCData.Tiene_informacion_responsable
                    ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tiene_informacion_responsable), "Respuesta") ??  (string)Probable_Responsable_PCData.Tiene_informacion_responsable_Respuesta.Descripcion
                    ,Quien_Resulte_Responsable = Probable_Responsable_PCData.Quien_Resulte_Responsable.GetValueOrDefault()
                    ,Persona_moral = Probable_Responsable_PCData.Persona_moral.GetValueOrDefault()
                    ,Nombres = Probable_Responsable_PCData.Nombres
                    ,Apellido_Paterno = Probable_Responsable_PCData.Apellido_Paterno
                    ,Apellido_Materno = Probable_Responsable_PCData.Apellido_Materno
                    ,Nombre_Completo = Probable_Responsable_PCData.Nombre_Completo
                    ,Alias = Probable_Responsable_PCData.Alias
                    ,Fecha_de_Nacimiento = (Probable_Responsable_PCData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Probable_Responsable_PCData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Probable_Responsable_PCData.Edad
                    ,Sexo = Probable_Responsable_PCData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Sexo), "Genero") ??  (string)Probable_Responsable_PCData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Probable_Responsable_PCData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Estado_Civil), "Estado_Civil") ??  (string)Probable_Responsable_PCData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Probable_Responsable_PCData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Probable_Responsable_PCData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Probable_Responsable_PCData.Numero_de_Identificacion
                    ,Fotografia_de_la_identificacion = Probable_Responsable_PCData.Fotografia_de_la_identificacion
                    ,CURP = Probable_Responsable_PCData.CURP
                    ,RFC = Probable_Responsable_PCData.RFC
                    ,Tiene_informacion__domicilio = Probable_Responsable_PCData.Tiene_informacion__domicilio
                    ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tiene_informacion__domicilio), "Respuesta") ??  (string)Probable_Responsable_PCData.Tiene_informacion__domicilio_Respuesta.Descripcion
                    ,Pais = Probable_Responsable_PCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Pais), "Pais") ??  (string)Probable_Responsable_PCData.Pais_Pais.Nombre
                    ,Estado = Probable_Responsable_PCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Estado), "Estado") ??  (string)Probable_Responsable_PCData.Estado_Estado.Nombre
                    ,Municipio = Probable_Responsable_PCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Municipio), "Municipio") ??  (string)Probable_Responsable_PCData.Municipio_Municipio.Nombre
                    ,Poblacion = Probable_Responsable_PCData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Poblacion), "Colonia") ??  (string)Probable_Responsable_PCData.Poblacion_Colonia.Nombre
                    ,Colonia = Probable_Responsable_PCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Colonia), "Colonia") ??  (string)Probable_Responsable_PCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Probable_Responsable_PCData.Codigo_Postal
                    ,Calle_del_Imputado = Probable_Responsable_PCData.Calle_del_Imputado
                    ,Numero_Exterior = Probable_Responsable_PCData.Numero_Exterior
                    ,Numero_Interior = Probable_Responsable_PCData.Numero_Interior
                    ,Referencia_de_Domicilio = Probable_Responsable_PCData.Referencia_de_Domicilio
                    ,Latitud = Probable_Responsable_PCData.Latitud
                    ,Longitud = Probable_Responsable_PCData.Longitud
                    ,Peso = Probable_Responsable_PCData.Peso
                    ,Estatura = Probable_Responsable_PCData.Estatura
                    ,Padecimiento_de_Enfermedad = Probable_Responsable_PCData.Padecimiento_de_Enfermedad
                    ,Forma_Cara = Probable_Responsable_PCData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Cara), "Forma_Cara") ??  (string)Probable_Responsable_PCData.Forma_Cara_Forma_Cara.Descripcion
                    ,Tipo_de_Cejas = Probable_Responsable_PCData.Tipo_de_Cejas
                    ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_de_Cejas), "Cejas") ??  (string)Probable_Responsable_PCData.Tipo_de_Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Probable_Responsable_PCData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Probable_Responsable_PCData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Largo_de_Cabello = Probable_Responsable_PCData.Largo_de_Cabello
                    ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Largo_de_Cabello), "Largo_de_Cabello") ??  (string)Probable_Responsable_PCData.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                    ,Cantidad_Cabello = Probable_Responsable_PCData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Probable_Responsable_PCData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Probable_Responsable_PCData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Probable_Responsable_PCData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Probable_Responsable_PCData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Complexion), "Complexion") ??  (string)Probable_Responsable_PCData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Probable_Responsable_PCData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Color_Piel), "Color_Piel") ??  (string)Probable_Responsable_PCData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Probable_Responsable_PCData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Frente), "Frente") ??  (string)Probable_Responsable_PCData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Probable_Responsable_PCData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Cabello), "Forma_Cabello") ??  (string)Probable_Responsable_PCData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Probable_Responsable_PCData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Color_Cabello), "Color_de_Cabello") ??  (string)Probable_Responsable_PCData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Probable_Responsable_PCData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Calvicie), "Calvicie") ??  (string)Probable_Responsable_PCData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Probable_Responsable_PCData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Color_Ojos), "Color_Ojos") ??  (string)Probable_Responsable_PCData.Color_Ojos_Color_Ojos.Descripcion
                    ,Tamano_de_Ojos = Probable_Responsable_PCData.Tamano_de_Ojos
                    ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_de_Ojos), "Ojos") ??  (string)Probable_Responsable_PCData.Tamano_de_Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Probable_Responsable_PCData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Ojos), "Froma_Ojos") ??  (string)Probable_Responsable_PCData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Anteojos = Probable_Responsable_PCData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Anteojos), "Anteojos") ??  (string)Probable_Responsable_PCData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Probable_Responsable_PCData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Probable_Responsable_PCData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Tamano_Nariz = Probable_Responsable_PCData.Tamano_Nariz
                    ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_Nariz), "Nariz_Base") ??  (string)Probable_Responsable_PCData.Tamano_Nariz_Nariz_Base.Descripcion
                    ,Labios = Probable_Responsable_PCData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Labios), "Labios") ??  (string)Probable_Responsable_PCData.Labios_Labios.Descripcion
                    ,Boca = Probable_Responsable_PCData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Boca), "Boca") ??  (string)Probable_Responsable_PCData.Boca_Boca.Descripcion
                    ,Grosor_de_Labios = Probable_Responsable_PCData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Probable_Responsable_PCData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Menton = Probable_Responsable_PCData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Menton), "Menton") ??  (string)Probable_Responsable_PCData.Menton_Menton.Descripcion
                    ,Forma_de_Menton = Probable_Responsable_PCData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Probable_Responsable_PCData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Barba = Probable_Responsable_PCData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Barba), "Barba") ??  (string)Probable_Responsable_PCData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Probable_Responsable_PCData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Orejas), "Forma_Orejas") ??  (string)Probable_Responsable_PCData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Probable_Responsable_PCData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Probable_Responsable_PCData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Probable_Responsable_PCData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Probable_Responsable_PCData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Probable_Responsable_PCData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Bigote), "Bigote") ??  (string)Probable_Responsable_PCData.Bigote_Bigote.Descripcion
                    ,Senas_Particulares = Probable_Responsable_PCData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Senas_Particulares), "Senas_Particulares") ??  (string)Probable_Responsable_PCData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Probable_Responsable_PCData.Imagen_Tatuaje
                    ,Situacion_Fisica = Probable_Responsable_PCData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Probable_Responsable_PCData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Otras_Senas_Particulares = Probable_Responsable_PCData.Otras_Senas_Particulares
                    ,Imputado_Recluido = Probable_Responsable_PCData.Imputado_Recluido

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Fotografia_de_la_identificacionSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varProbable_Responsable_PC.Fotografia_de_la_identificacion).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varProbable_Responsable_PC.Imagen_Tatuaje).Resource;

				
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
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion_responsable = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion_responsable != null && Respuestas_Tiene_informacion_responsable.Resource != null)
                ViewBag.Respuestas_Tiene_informacion_responsable = Respuestas_Tiene_informacion_responsable.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion__domicilio = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion__domicilio != null && Respuestas_Tiene_informacion__domicilio.Resource != null)
                ViewBag.Respuestas_Tiene_informacion__domicilio = Respuestas_Tiene_informacion__domicilio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Tipo_de_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Tipo_de_Cejas != null && Cejass_Tipo_de_Cejas.Resource != null)
                ViewBag.Cejass_Tipo_de_Cejas = Cejass_Tipo_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_de_CejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Cejass_Tamano_de_Cejas = _ITamano_de_CejasApiConsumer.SelAll(true);
            if (Tamano_de_Cejass_Tamano_de_Cejas != null && Tamano_de_Cejass_Tamano_de_Cejas.Resource != null)
                ViewBag.Tamano_de_Cejass_Tamano_de_Cejas = Tamano_de_Cejass_Tamano_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cantidad_Cabellos_Cantidad_Cabello = _ICantidad_CabelloApiConsumer.SelAll(true);
            if (Cantidad_Cabellos_Cantidad_Cabello != null && Cantidad_Cabellos_Cantidad_Cabello.Resource != null)
                ViewBag.Cantidad_Cabellos_Cantidad_Cabello = Cantidad_Cabellos_Cantidad_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Implantacion_Cabellos_Implantacion_Cabello = _IImplantacion_CabelloApiConsumer.SelAll(true);
            if (Implantacion_Cabellos_Implantacion_Cabello != null && Implantacion_Cabellos_Implantacion_Cabello.Resource != null)
                ViewBag.Implantacion_Cabellos_Implantacion_Cabello = Implantacion_Cabellos_Implantacion_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Complexions_Complexion = _IComplexionApiConsumer.SelAll(true);
            if (Complexions_Complexion != null && Complexions_Complexion.Resource != null)
                ViewBag.Complexions_Complexion = Complexions_Complexion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Piels_Color_Piel = _IColor_PielApiConsumer.SelAll(true);
            if (Color_Piels_Color_Piel != null && Color_Piels_Color_Piel.Resource != null)
                ViewBag.Color_Piels_Color_Piel = Color_Piels_Color_Piel.Resource.Where(m => m.Descrpicion != null).OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion") ?? m.Descrpicion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Frentes_Frente = _IFrenteApiConsumer.SelAll(true);
            if (Frentes_Frente != null && Frentes_Frente.Resource != null)
                ViewBag.Frentes_Frente = Frentes_Frente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_Cabello != null && Forma_Cabellos_Forma_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_Cabello = Forma_Cabellos_Forma_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_de_Cabellos_Color_Cabello = _IColor_de_CabelloApiConsumer.SelAll(true);
            if (Color_de_Cabellos_Color_Cabello != null && Color_de_Cabellos_Color_Cabello.Resource != null)
                ViewBag.Color_de_Cabellos_Color_Cabello = Color_de_Cabellos_Color_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calvicies_Calvicie = _ICalvicieApiConsumer.SelAll(true);
            if (Calvicies_Calvicie != null && Calvicies_Calvicie.Resource != null)
                ViewBag.Calvicies_Calvicie = Calvicies_Calvicie.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Ojoss_Color_Ojos = _IColor_OjosApiConsumer.SelAll(true);
            if (Color_Ojoss_Color_Ojos != null && Color_Ojoss_Color_Ojos.Resource != null)
                ViewBag.Color_Ojoss_Color_Ojos = Color_Ojoss_Color_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ojoss_Tamano_de_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Tamano_de_Ojos != null && Ojoss_Tamano_de_Ojos.Resource != null)
                ViewBag.Ojoss_Tamano_de_Ojos = Ojoss_Tamano_de_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Froma_Ojoss_Forma_Ojos = _IFroma_OjosApiConsumer.SelAll(true);
            if (Froma_Ojoss_Forma_Ojos != null && Froma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Froma_Ojoss_Forma_Ojos = Froma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnteojosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anteojoss_Anteojos = _IAnteojosApiConsumer.SelAll(true);
            if (Anteojoss_Anteojos != null && Anteojoss_Anteojos.Resource != null)
                ViewBag.Anteojoss_Anteojos = Anteojoss_Anteojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Anteojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Narizs_Forma_de_Nariz = _IForma_de_NarizApiConsumer.SelAll(true);
            if (Forma_de_Narizs_Forma_de_Nariz != null && Forma_de_Narizs_Forma_de_Nariz.Resource != null)
                ViewBag.Forma_de_Narizs_Forma_de_Nariz = Forma_de_Narizs_Forma_de_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Tamano_Nariz = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Tamano_Nariz != null && Nariz_Bases_Tamano_Nariz.Resource != null)
                ViewBag.Nariz_Bases_Tamano_Nariz = Nariz_Bases_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Labioss_Labios = _ILabiosApiConsumer.SelAll(true);
            if (Labioss_Labios != null && Labioss_Labios.Resource != null)
                ViewBag.Labioss_Labios = Labioss_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bocas_Boca = _IBocaApiConsumer.SelAll(true);
            if (Bocas_Boca != null && Bocas_Boca.Resource != null)
                ViewBag.Bocas_Boca = Bocas_Boca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Barbas_Barba = _IBarbaApiConsumer.SelAll(true);
            if (Barbas_Barba != null && Barbas_Barba.Resource != null)
                ViewBag.Barbas_Barba = Barbas_Barba.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Forma_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Forma_Orejas != null && Forma_Orejass_Forma_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Forma_Orejas = Forma_Orejass_Forma_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_Orejass_Tamano_Orejas = _ITamano_OrejasApiConsumer.SelAll(true);
            if (Tamano_Orejass_Tamano_Orejas != null && Tamano_Orejass_Tamano_Orejas.Resource != null)
                ViewBag.Tamano_Orejass_Tamano_Orejas = Tamano_Orejass_Tamano_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Lobulos_Tipo_Lobulo = _ITipo_LobuloApiConsumer.SelAll(true);
            if (Tipo_Lobulos_Tipo_Lobulo != null && Tipo_Lobulos_Tipo_Lobulo.Resource != null)
                ViewBag.Tipo_Lobulos_Tipo_Lobulo = Tipo_Lobulos_Tipo_Lobulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bigotes_Bigote = _IBigoteApiConsumer.SelAll(true);
            if (Bigotes_Bigote != null && Bigotes_Bigote.Resource != null)
                ViewBag.Bigotes_Bigote = Bigotes_Bigote.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varProbable_Responsable_PC);
        }
		
	[HttpGet]
        public ActionResult AddProbable_Responsable_PC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45714);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Probable_Responsable_PCModel varProbable_Responsable_PC= new Probable_Responsable_PCModel();


            if (id.ToString() != "0")
            {
                var Probable_Responsable_PCsData = _IProbable_Responsable_PCApiConsumer.ListaSelAll(0, 1000, "Probable_Responsable_PC.Clave=" + id, "").Resource.Probable_Responsable_PCs;
				
				if (Probable_Responsable_PCsData != null && Probable_Responsable_PCsData.Count > 0)
                {
					var Probable_Responsable_PCData = Probable_Responsable_PCsData.First();
					varProbable_Responsable_PC= new Probable_Responsable_PCModel
					{
						Clave  = Probable_Responsable_PCData.Clave 
	                    ,Solicitud = Probable_Responsable_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Probable_Responsable_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Tipo_de_Solicitud = Probable_Responsable_PCData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Probable_Responsable_PCData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Tiene_informacion_responsable = Probable_Responsable_PCData.Tiene_informacion_responsable
                    ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tiene_informacion_responsable), "Respuesta") ??  (string)Probable_Responsable_PCData.Tiene_informacion_responsable_Respuesta.Descripcion
                    ,Quien_Resulte_Responsable = Probable_Responsable_PCData.Quien_Resulte_Responsable.GetValueOrDefault()
                    ,Persona_moral = Probable_Responsable_PCData.Persona_moral.GetValueOrDefault()
                    ,Nombres = Probable_Responsable_PCData.Nombres
                    ,Apellido_Paterno = Probable_Responsable_PCData.Apellido_Paterno
                    ,Apellido_Materno = Probable_Responsable_PCData.Apellido_Materno
                    ,Nombre_Completo = Probable_Responsable_PCData.Nombre_Completo
                    ,Alias = Probable_Responsable_PCData.Alias
                    ,Fecha_de_Nacimiento = (Probable_Responsable_PCData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Probable_Responsable_PCData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Probable_Responsable_PCData.Edad
                    ,Sexo = Probable_Responsable_PCData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Sexo), "Genero") ??  (string)Probable_Responsable_PCData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Probable_Responsable_PCData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Estado_Civil), "Estado_Civil") ??  (string)Probable_Responsable_PCData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Probable_Responsable_PCData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Probable_Responsable_PCData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Probable_Responsable_PCData.Numero_de_Identificacion
                    ,Fotografia_de_la_identificacion = Probable_Responsable_PCData.Fotografia_de_la_identificacion
                    ,CURP = Probable_Responsable_PCData.CURP
                    ,RFC = Probable_Responsable_PCData.RFC
                    ,Tiene_informacion__domicilio = Probable_Responsable_PCData.Tiene_informacion__domicilio
                    ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tiene_informacion__domicilio), "Respuesta") ??  (string)Probable_Responsable_PCData.Tiene_informacion__domicilio_Respuesta.Descripcion
                    ,Pais = Probable_Responsable_PCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Pais), "Pais") ??  (string)Probable_Responsable_PCData.Pais_Pais.Nombre
                    ,Estado = Probable_Responsable_PCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Estado), "Estado") ??  (string)Probable_Responsable_PCData.Estado_Estado.Nombre
                    ,Municipio = Probable_Responsable_PCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Municipio), "Municipio") ??  (string)Probable_Responsable_PCData.Municipio_Municipio.Nombre
                    ,Poblacion = Probable_Responsable_PCData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Poblacion), "Colonia") ??  (string)Probable_Responsable_PCData.Poblacion_Colonia.Nombre
                    ,Colonia = Probable_Responsable_PCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Colonia), "Colonia") ??  (string)Probable_Responsable_PCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Probable_Responsable_PCData.Codigo_Postal
                    ,Calle_del_Imputado = Probable_Responsable_PCData.Calle_del_Imputado
                    ,Numero_Exterior = Probable_Responsable_PCData.Numero_Exterior
                    ,Numero_Interior = Probable_Responsable_PCData.Numero_Interior
                    ,Referencia_de_Domicilio = Probable_Responsable_PCData.Referencia_de_Domicilio
                    ,Latitud = Probable_Responsable_PCData.Latitud
                    ,Longitud = Probable_Responsable_PCData.Longitud
                    ,Peso = Probable_Responsable_PCData.Peso
                    ,Estatura = Probable_Responsable_PCData.Estatura
                    ,Padecimiento_de_Enfermedad = Probable_Responsable_PCData.Padecimiento_de_Enfermedad
                    ,Forma_Cara = Probable_Responsable_PCData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Cara), "Forma_Cara") ??  (string)Probable_Responsable_PCData.Forma_Cara_Forma_Cara.Descripcion
                    ,Tipo_de_Cejas = Probable_Responsable_PCData.Tipo_de_Cejas
                    ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_de_Cejas), "Cejas") ??  (string)Probable_Responsable_PCData.Tipo_de_Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Probable_Responsable_PCData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Probable_Responsable_PCData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Largo_de_Cabello = Probable_Responsable_PCData.Largo_de_Cabello
                    ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Largo_de_Cabello), "Largo_de_Cabello") ??  (string)Probable_Responsable_PCData.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                    ,Cantidad_Cabello = Probable_Responsable_PCData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Probable_Responsable_PCData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Probable_Responsable_PCData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Probable_Responsable_PCData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Probable_Responsable_PCData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Complexion), "Complexion") ??  (string)Probable_Responsable_PCData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Probable_Responsable_PCData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Color_Piel), "Color_Piel") ??  (string)Probable_Responsable_PCData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Probable_Responsable_PCData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Frente), "Frente") ??  (string)Probable_Responsable_PCData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Probable_Responsable_PCData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Cabello), "Forma_Cabello") ??  (string)Probable_Responsable_PCData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Probable_Responsable_PCData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Color_Cabello), "Color_de_Cabello") ??  (string)Probable_Responsable_PCData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Probable_Responsable_PCData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Calvicie), "Calvicie") ??  (string)Probable_Responsable_PCData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Probable_Responsable_PCData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Color_Ojos), "Color_Ojos") ??  (string)Probable_Responsable_PCData.Color_Ojos_Color_Ojos.Descripcion
                    ,Tamano_de_Ojos = Probable_Responsable_PCData.Tamano_de_Ojos
                    ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_de_Ojos), "Ojos") ??  (string)Probable_Responsable_PCData.Tamano_de_Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Probable_Responsable_PCData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Ojos), "Froma_Ojos") ??  (string)Probable_Responsable_PCData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Anteojos = Probable_Responsable_PCData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Anteojos), "Anteojos") ??  (string)Probable_Responsable_PCData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Probable_Responsable_PCData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Probable_Responsable_PCData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Tamano_Nariz = Probable_Responsable_PCData.Tamano_Nariz
                    ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_Nariz), "Nariz_Base") ??  (string)Probable_Responsable_PCData.Tamano_Nariz_Nariz_Base.Descripcion
                    ,Labios = Probable_Responsable_PCData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Labios), "Labios") ??  (string)Probable_Responsable_PCData.Labios_Labios.Descripcion
                    ,Boca = Probable_Responsable_PCData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Boca), "Boca") ??  (string)Probable_Responsable_PCData.Boca_Boca.Descripcion
                    ,Grosor_de_Labios = Probable_Responsable_PCData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Probable_Responsable_PCData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Menton = Probable_Responsable_PCData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Menton), "Menton") ??  (string)Probable_Responsable_PCData.Menton_Menton.Descripcion
                    ,Forma_de_Menton = Probable_Responsable_PCData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Probable_Responsable_PCData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Barba = Probable_Responsable_PCData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Barba), "Barba") ??  (string)Probable_Responsable_PCData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Probable_Responsable_PCData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Forma_Orejas), "Forma_Orejas") ??  (string)Probable_Responsable_PCData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Probable_Responsable_PCData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Probable_Responsable_PCData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Probable_Responsable_PCData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Probable_Responsable_PCData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Probable_Responsable_PCData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Bigote), "Bigote") ??  (string)Probable_Responsable_PCData.Bigote_Bigote.Descripcion
                    ,Senas_Particulares = Probable_Responsable_PCData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Senas_Particulares), "Senas_Particulares") ??  (string)Probable_Responsable_PCData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Probable_Responsable_PCData.Imagen_Tatuaje
                    ,Situacion_Fisica = Probable_Responsable_PCData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Probable_Responsable_PCData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Probable_Responsable_PCData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Otras_Senas_Particulares = Probable_Responsable_PCData.Otras_Senas_Particulares
                    ,Imputado_Recluido = Probable_Responsable_PCData.Imputado_Recluido

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Fotografia_de_la_identificacionSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varProbable_Responsable_PC.Fotografia_de_la_identificacion).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varProbable_Responsable_PC.Imagen_Tatuaje).Resource;

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
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion_responsable = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion_responsable != null && Respuestas_Tiene_informacion_responsable.Resource != null)
                ViewBag.Respuestas_Tiene_informacion_responsable = Respuestas_Tiene_informacion_responsable.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion__domicilio = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion__domicilio != null && Respuestas_Tiene_informacion__domicilio.Resource != null)
                ViewBag.Respuestas_Tiene_informacion__domicilio = Respuestas_Tiene_informacion__domicilio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Tipo_de_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Tipo_de_Cejas != null && Cejass_Tipo_de_Cejas.Resource != null)
                ViewBag.Cejass_Tipo_de_Cejas = Cejass_Tipo_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_de_CejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Cejass_Tamano_de_Cejas = _ITamano_de_CejasApiConsumer.SelAll(true);
            if (Tamano_de_Cejass_Tamano_de_Cejas != null && Tamano_de_Cejass_Tamano_de_Cejas.Resource != null)
                ViewBag.Tamano_de_Cejass_Tamano_de_Cejas = Tamano_de_Cejass_Tamano_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cantidad_Cabellos_Cantidad_Cabello = _ICantidad_CabelloApiConsumer.SelAll(true);
            if (Cantidad_Cabellos_Cantidad_Cabello != null && Cantidad_Cabellos_Cantidad_Cabello.Resource != null)
                ViewBag.Cantidad_Cabellos_Cantidad_Cabello = Cantidad_Cabellos_Cantidad_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Implantacion_Cabellos_Implantacion_Cabello = _IImplantacion_CabelloApiConsumer.SelAll(true);
            if (Implantacion_Cabellos_Implantacion_Cabello != null && Implantacion_Cabellos_Implantacion_Cabello.Resource != null)
                ViewBag.Implantacion_Cabellos_Implantacion_Cabello = Implantacion_Cabellos_Implantacion_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Complexions_Complexion = _IComplexionApiConsumer.SelAll(true);
            if (Complexions_Complexion != null && Complexions_Complexion.Resource != null)
                ViewBag.Complexions_Complexion = Complexions_Complexion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Piels_Color_Piel = _IColor_PielApiConsumer.SelAll(true);
            if (Color_Piels_Color_Piel != null && Color_Piels_Color_Piel.Resource != null)
                ViewBag.Color_Piels_Color_Piel = Color_Piels_Color_Piel.Resource.Where(m => m.Descrpicion != null).OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion") ?? m.Descrpicion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Frentes_Frente = _IFrenteApiConsumer.SelAll(true);
            if (Frentes_Frente != null && Frentes_Frente.Resource != null)
                ViewBag.Frentes_Frente = Frentes_Frente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_Cabello != null && Forma_Cabellos_Forma_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_Cabello = Forma_Cabellos_Forma_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_de_Cabellos_Color_Cabello = _IColor_de_CabelloApiConsumer.SelAll(true);
            if (Color_de_Cabellos_Color_Cabello != null && Color_de_Cabellos_Color_Cabello.Resource != null)
                ViewBag.Color_de_Cabellos_Color_Cabello = Color_de_Cabellos_Color_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calvicies_Calvicie = _ICalvicieApiConsumer.SelAll(true);
            if (Calvicies_Calvicie != null && Calvicies_Calvicie.Resource != null)
                ViewBag.Calvicies_Calvicie = Calvicies_Calvicie.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Ojoss_Color_Ojos = _IColor_OjosApiConsumer.SelAll(true);
            if (Color_Ojoss_Color_Ojos != null && Color_Ojoss_Color_Ojos.Resource != null)
                ViewBag.Color_Ojoss_Color_Ojos = Color_Ojoss_Color_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ojoss_Tamano_de_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Tamano_de_Ojos != null && Ojoss_Tamano_de_Ojos.Resource != null)
                ViewBag.Ojoss_Tamano_de_Ojos = Ojoss_Tamano_de_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Froma_Ojoss_Forma_Ojos = _IFroma_OjosApiConsumer.SelAll(true);
            if (Froma_Ojoss_Forma_Ojos != null && Froma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Froma_Ojoss_Forma_Ojos = Froma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnteojosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anteojoss_Anteojos = _IAnteojosApiConsumer.SelAll(true);
            if (Anteojoss_Anteojos != null && Anteojoss_Anteojos.Resource != null)
                ViewBag.Anteojoss_Anteojos = Anteojoss_Anteojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Anteojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Narizs_Forma_de_Nariz = _IForma_de_NarizApiConsumer.SelAll(true);
            if (Forma_de_Narizs_Forma_de_Nariz != null && Forma_de_Narizs_Forma_de_Nariz.Resource != null)
                ViewBag.Forma_de_Narizs_Forma_de_Nariz = Forma_de_Narizs_Forma_de_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Tamano_Nariz = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Tamano_Nariz != null && Nariz_Bases_Tamano_Nariz.Resource != null)
                ViewBag.Nariz_Bases_Tamano_Nariz = Nariz_Bases_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Labioss_Labios = _ILabiosApiConsumer.SelAll(true);
            if (Labioss_Labios != null && Labioss_Labios.Resource != null)
                ViewBag.Labioss_Labios = Labioss_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bocas_Boca = _IBocaApiConsumer.SelAll(true);
            if (Bocas_Boca != null && Bocas_Boca.Resource != null)
                ViewBag.Bocas_Boca = Bocas_Boca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Barbas_Barba = _IBarbaApiConsumer.SelAll(true);
            if (Barbas_Barba != null && Barbas_Barba.Resource != null)
                ViewBag.Barbas_Barba = Barbas_Barba.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Forma_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Forma_Orejas != null && Forma_Orejass_Forma_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Forma_Orejas = Forma_Orejass_Forma_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_Orejass_Tamano_Orejas = _ITamano_OrejasApiConsumer.SelAll(true);
            if (Tamano_Orejass_Tamano_Orejas != null && Tamano_Orejass_Tamano_Orejas.Resource != null)
                ViewBag.Tamano_Orejass_Tamano_Orejas = Tamano_Orejass_Tamano_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Lobulos_Tipo_Lobulo = _ITipo_LobuloApiConsumer.SelAll(true);
            if (Tipo_Lobulos_Tipo_Lobulo != null && Tipo_Lobulos_Tipo_Lobulo.Resource != null)
                ViewBag.Tipo_Lobulos_Tipo_Lobulo = Tipo_Lobulos_Tipo_Lobulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bigotes_Bigote = _IBigoteApiConsumer.SelAll(true);
            if (Bigotes_Bigote != null && Bigotes_Bigote.Resource != null)
                ViewBag.Bigotes_Bigote = Bigotes_Bigote.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddProbable_Responsable_PC", varProbable_Responsable_PC);
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
        public ActionResult GetRespuestaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRespuestaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetGeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre")?? m.Nombre,
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
        public ActionResult GetForma_CaraAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_CaraApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICejasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTamano_de_CejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITamano_de_CejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITamano_de_CejasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Cejas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLargo_de_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILargo_de_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCantidad_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICantidad_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetImplantacion_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IImplantacion_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetComplexionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IComplexionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_PielAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_PielApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion")?? m.Descrpicion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFrenteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFrenteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_de_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_de_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCalvicieAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalvicieApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_OjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetOjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFroma_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFroma_OjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAnteojosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAnteojosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAnteojosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Anteojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_de_NarizAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_de_NarizApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Nariz", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetNariz_BaseAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INariz_BaseApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLabiosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILabiosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBocaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBocaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetGrosor_de_LabiosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrosor_de_LabiosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMentonAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMentonApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_de_MentonAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_de_MentonApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBarbaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBarbaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_OrejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_OrejasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTamano_OrejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITamano_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITamano_OrejasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_Orejas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_LobuloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_LobuloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBigoteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBigoteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSenas_ParticularesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISenas_ParticularesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSituacion_FisicaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISituacion_FisicaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Probable_Responsable_PCAdvanceSearchModel model, int idFilter = -1)
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
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion_responsable = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion_responsable != null && Respuestas_Tiene_informacion_responsable.Resource != null)
                ViewBag.Respuestas_Tiene_informacion_responsable = Respuestas_Tiene_informacion_responsable.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion__domicilio = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion__domicilio != null && Respuestas_Tiene_informacion__domicilio.Resource != null)
                ViewBag.Respuestas_Tiene_informacion__domicilio = Respuestas_Tiene_informacion__domicilio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Tipo_de_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Tipo_de_Cejas != null && Cejass_Tipo_de_Cejas.Resource != null)
                ViewBag.Cejass_Tipo_de_Cejas = Cejass_Tipo_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_de_CejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Cejass_Tamano_de_Cejas = _ITamano_de_CejasApiConsumer.SelAll(true);
            if (Tamano_de_Cejass_Tamano_de_Cejas != null && Tamano_de_Cejass_Tamano_de_Cejas.Resource != null)
                ViewBag.Tamano_de_Cejass_Tamano_de_Cejas = Tamano_de_Cejass_Tamano_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cantidad_Cabellos_Cantidad_Cabello = _ICantidad_CabelloApiConsumer.SelAll(true);
            if (Cantidad_Cabellos_Cantidad_Cabello != null && Cantidad_Cabellos_Cantidad_Cabello.Resource != null)
                ViewBag.Cantidad_Cabellos_Cantidad_Cabello = Cantidad_Cabellos_Cantidad_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Implantacion_Cabellos_Implantacion_Cabello = _IImplantacion_CabelloApiConsumer.SelAll(true);
            if (Implantacion_Cabellos_Implantacion_Cabello != null && Implantacion_Cabellos_Implantacion_Cabello.Resource != null)
                ViewBag.Implantacion_Cabellos_Implantacion_Cabello = Implantacion_Cabellos_Implantacion_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Complexions_Complexion = _IComplexionApiConsumer.SelAll(true);
            if (Complexions_Complexion != null && Complexions_Complexion.Resource != null)
                ViewBag.Complexions_Complexion = Complexions_Complexion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Piels_Color_Piel = _IColor_PielApiConsumer.SelAll(true);
            if (Color_Piels_Color_Piel != null && Color_Piels_Color_Piel.Resource != null)
                ViewBag.Color_Piels_Color_Piel = Color_Piels_Color_Piel.Resource.Where(m => m.Descrpicion != null).OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion") ?? m.Descrpicion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Frentes_Frente = _IFrenteApiConsumer.SelAll(true);
            if (Frentes_Frente != null && Frentes_Frente.Resource != null)
                ViewBag.Frentes_Frente = Frentes_Frente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_Cabello != null && Forma_Cabellos_Forma_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_Cabello = Forma_Cabellos_Forma_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_de_Cabellos_Color_Cabello = _IColor_de_CabelloApiConsumer.SelAll(true);
            if (Color_de_Cabellos_Color_Cabello != null && Color_de_Cabellos_Color_Cabello.Resource != null)
                ViewBag.Color_de_Cabellos_Color_Cabello = Color_de_Cabellos_Color_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calvicies_Calvicie = _ICalvicieApiConsumer.SelAll(true);
            if (Calvicies_Calvicie != null && Calvicies_Calvicie.Resource != null)
                ViewBag.Calvicies_Calvicie = Calvicies_Calvicie.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Ojoss_Color_Ojos = _IColor_OjosApiConsumer.SelAll(true);
            if (Color_Ojoss_Color_Ojos != null && Color_Ojoss_Color_Ojos.Resource != null)
                ViewBag.Color_Ojoss_Color_Ojos = Color_Ojoss_Color_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ojoss_Tamano_de_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Tamano_de_Ojos != null && Ojoss_Tamano_de_Ojos.Resource != null)
                ViewBag.Ojoss_Tamano_de_Ojos = Ojoss_Tamano_de_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Froma_Ojoss_Forma_Ojos = _IFroma_OjosApiConsumer.SelAll(true);
            if (Froma_Ojoss_Forma_Ojos != null && Froma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Froma_Ojoss_Forma_Ojos = Froma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnteojosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anteojoss_Anteojos = _IAnteojosApiConsumer.SelAll(true);
            if (Anteojoss_Anteojos != null && Anteojoss_Anteojos.Resource != null)
                ViewBag.Anteojoss_Anteojos = Anteojoss_Anteojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Anteojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Narizs_Forma_de_Nariz = _IForma_de_NarizApiConsumer.SelAll(true);
            if (Forma_de_Narizs_Forma_de_Nariz != null && Forma_de_Narizs_Forma_de_Nariz.Resource != null)
                ViewBag.Forma_de_Narizs_Forma_de_Nariz = Forma_de_Narizs_Forma_de_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Tamano_Nariz = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Tamano_Nariz != null && Nariz_Bases_Tamano_Nariz.Resource != null)
                ViewBag.Nariz_Bases_Tamano_Nariz = Nariz_Bases_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Labioss_Labios = _ILabiosApiConsumer.SelAll(true);
            if (Labioss_Labios != null && Labioss_Labios.Resource != null)
                ViewBag.Labioss_Labios = Labioss_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bocas_Boca = _IBocaApiConsumer.SelAll(true);
            if (Bocas_Boca != null && Bocas_Boca.Resource != null)
                ViewBag.Bocas_Boca = Bocas_Boca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Barbas_Barba = _IBarbaApiConsumer.SelAll(true);
            if (Barbas_Barba != null && Barbas_Barba.Resource != null)
                ViewBag.Barbas_Barba = Barbas_Barba.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Forma_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Forma_Orejas != null && Forma_Orejass_Forma_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Forma_Orejas = Forma_Orejass_Forma_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_Orejass_Tamano_Orejas = _ITamano_OrejasApiConsumer.SelAll(true);
            if (Tamano_Orejass_Tamano_Orejas != null && Tamano_Orejass_Tamano_Orejas.Resource != null)
                ViewBag.Tamano_Orejass_Tamano_Orejas = Tamano_Orejass_Tamano_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Lobulos_Tipo_Lobulo = _ITipo_LobuloApiConsumer.SelAll(true);
            if (Tipo_Lobulos_Tipo_Lobulo != null && Tipo_Lobulos_Tipo_Lobulo.Resource != null)
                ViewBag.Tipo_Lobulos_Tipo_Lobulo = Tipo_Lobulos_Tipo_Lobulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bigotes_Bigote = _IBigoteApiConsumer.SelAll(true);
            if (Bigotes_Bigote != null && Bigotes_Bigote.Resource != null)
                ViewBag.Bigotes_Bigote = Bigotes_Bigote.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion_responsable = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion_responsable != null && Respuestas_Tiene_informacion_responsable.Resource != null)
                ViewBag.Respuestas_Tiene_informacion_responsable = Respuestas_Tiene_informacion_responsable.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Tiene_informacion__domicilio = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Tiene_informacion__domicilio != null && Respuestas_Tiene_informacion__domicilio.Resource != null)
                ViewBag.Respuestas_Tiene_informacion__domicilio = Respuestas_Tiene_informacion__domicilio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Tipo_de_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Tipo_de_Cejas != null && Cejass_Tipo_de_Cejas.Resource != null)
                ViewBag.Cejass_Tipo_de_Cejas = Cejass_Tipo_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_de_CejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Cejass_Tamano_de_Cejas = _ITamano_de_CejasApiConsumer.SelAll(true);
            if (Tamano_de_Cejass_Tamano_de_Cejas != null && Tamano_de_Cejass_Tamano_de_Cejas.Resource != null)
                ViewBag.Tamano_de_Cejass_Tamano_de_Cejas = Tamano_de_Cejass_Tamano_de_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cantidad_Cabellos_Cantidad_Cabello = _ICantidad_CabelloApiConsumer.SelAll(true);
            if (Cantidad_Cabellos_Cantidad_Cabello != null && Cantidad_Cabellos_Cantidad_Cabello.Resource != null)
                ViewBag.Cantidad_Cabellos_Cantidad_Cabello = Cantidad_Cabellos_Cantidad_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Implantacion_Cabellos_Implantacion_Cabello = _IImplantacion_CabelloApiConsumer.SelAll(true);
            if (Implantacion_Cabellos_Implantacion_Cabello != null && Implantacion_Cabellos_Implantacion_Cabello.Resource != null)
                ViewBag.Implantacion_Cabellos_Implantacion_Cabello = Implantacion_Cabellos_Implantacion_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Complexions_Complexion = _IComplexionApiConsumer.SelAll(true);
            if (Complexions_Complexion != null && Complexions_Complexion.Resource != null)
                ViewBag.Complexions_Complexion = Complexions_Complexion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Piels_Color_Piel = _IColor_PielApiConsumer.SelAll(true);
            if (Color_Piels_Color_Piel != null && Color_Piels_Color_Piel.Resource != null)
                ViewBag.Color_Piels_Color_Piel = Color_Piels_Color_Piel.Resource.Where(m => m.Descrpicion != null).OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion") ?? m.Descrpicion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Frentes_Frente = _IFrenteApiConsumer.SelAll(true);
            if (Frentes_Frente != null && Frentes_Frente.Resource != null)
                ViewBag.Frentes_Frente = Frentes_Frente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_Cabello != null && Forma_Cabellos_Forma_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_Cabello = Forma_Cabellos_Forma_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_de_Cabellos_Color_Cabello = _IColor_de_CabelloApiConsumer.SelAll(true);
            if (Color_de_Cabellos_Color_Cabello != null && Color_de_Cabellos_Color_Cabello.Resource != null)
                ViewBag.Color_de_Cabellos_Color_Cabello = Color_de_Cabellos_Color_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calvicies_Calvicie = _ICalvicieApiConsumer.SelAll(true);
            if (Calvicies_Calvicie != null && Calvicies_Calvicie.Resource != null)
                ViewBag.Calvicies_Calvicie = Calvicies_Calvicie.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Ojoss_Color_Ojos = _IColor_OjosApiConsumer.SelAll(true);
            if (Color_Ojoss_Color_Ojos != null && Color_Ojoss_Color_Ojos.Resource != null)
                ViewBag.Color_Ojoss_Color_Ojos = Color_Ojoss_Color_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ojoss_Tamano_de_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Tamano_de_Ojos != null && Ojoss_Tamano_de_Ojos.Resource != null)
                ViewBag.Ojoss_Tamano_de_Ojos = Ojoss_Tamano_de_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Froma_Ojoss_Forma_Ojos = _IFroma_OjosApiConsumer.SelAll(true);
            if (Froma_Ojoss_Forma_Ojos != null && Froma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Froma_Ojoss_Forma_Ojos = Froma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnteojosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anteojoss_Anteojos = _IAnteojosApiConsumer.SelAll(true);
            if (Anteojoss_Anteojos != null && Anteojoss_Anteojos.Resource != null)
                ViewBag.Anteojoss_Anteojos = Anteojoss_Anteojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Anteojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Narizs_Forma_de_Nariz = _IForma_de_NarizApiConsumer.SelAll(true);
            if (Forma_de_Narizs_Forma_de_Nariz != null && Forma_de_Narizs_Forma_de_Nariz.Resource != null)
                ViewBag.Forma_de_Narizs_Forma_de_Nariz = Forma_de_Narizs_Forma_de_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Tamano_Nariz = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Tamano_Nariz != null && Nariz_Bases_Tamano_Nariz.Resource != null)
                ViewBag.Nariz_Bases_Tamano_Nariz = Nariz_Bases_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Labioss_Labios = _ILabiosApiConsumer.SelAll(true);
            if (Labioss_Labios != null && Labioss_Labios.Resource != null)
                ViewBag.Labioss_Labios = Labioss_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bocas_Boca = _IBocaApiConsumer.SelAll(true);
            if (Bocas_Boca != null && Bocas_Boca.Resource != null)
                ViewBag.Bocas_Boca = Bocas_Boca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Barbas_Barba = _IBarbaApiConsumer.SelAll(true);
            if (Barbas_Barba != null && Barbas_Barba.Resource != null)
                ViewBag.Barbas_Barba = Barbas_Barba.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Forma_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Forma_Orejas != null && Forma_Orejass_Forma_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Forma_Orejas = Forma_Orejass_Forma_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITamano_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_Orejass_Tamano_Orejas = _ITamano_OrejasApiConsumer.SelAll(true);
            if (Tamano_Orejass_Tamano_Orejas != null && Tamano_Orejass_Tamano_Orejas.Resource != null)
                ViewBag.Tamano_Orejass_Tamano_Orejas = Tamano_Orejass_Tamano_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Lobulos_Tipo_Lobulo = _ITipo_LobuloApiConsumer.SelAll(true);
            if (Tipo_Lobulos_Tipo_Lobulo != null && Tipo_Lobulos_Tipo_Lobulo.Resource != null)
                ViewBag.Tipo_Lobulos_Tipo_Lobulo = Tipo_Lobulos_Tipo_Lobulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bigotes_Bigote = _IBigoteApiConsumer.SelAll(true);
            if (Bigotes_Bigote != null && Bigotes_Bigote.Resource != null)
                ViewBag.Bigotes_Bigote = Bigotes_Bigote.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Probable_Responsable_PCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Probable_Responsable_PCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Probable_Responsable_PCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Probable_Responsable_PCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IProbable_Responsable_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Probable_Responsable_PCs == null)
                result.Probable_Responsable_PCs = new List<Probable_Responsable_PC>();

            return Json(new
            {
                data = result.Probable_Responsable_PCs.Select(m => new Probable_Responsable_PCGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion_responsable_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion_responsable_Respuesta.Descripcion
			,Quien_Resulte_Responsable = m.Quien_Resulte_Responsable
			,Persona_moral = m.Persona_moral
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion__domicilio_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion__domicilio_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetProbable_Responsable_PCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProbable_Responsable_PCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Probable_Responsable_PC", m.),
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
        /// Get List of Probable_Responsable_PC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Probable_Responsable_PC Entity</returns>
        public ActionResult GetProbable_Responsable_PCList(UrlParametersModel param)
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
            _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Probable_Responsable_PCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Probable_Responsable_PCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Probable_Responsable_PCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Probable_Responsable_PCPropertyMapper oProbable_Responsable_PCPropertyMapper = new Probable_Responsable_PCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oProbable_Responsable_PCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IProbable_Responsable_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Probable_Responsable_PCs == null)
                result.Probable_Responsable_PCs = new List<Probable_Responsable_PC>();

            return Json(new
            {
                aaData = result.Probable_Responsable_PCs.Select(m => new Probable_Responsable_PCGridModel
            {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion_responsable_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion_responsable_Respuesta.Descripcion
			,Quien_Resulte_Responsable = m.Quien_Resulte_Responsable
			,Persona_moral = m.Persona_moral
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion__domicilio_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion__domicilio_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetProbable_Responsable_PC_Solicitud_Solicitud_de_Denuncia_Ciudadana(string query, string where)
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
        [HttpGet]
        public JsonResult GetProbable_Responsable_PC_Pais_Pais(string query, string where)
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
        public JsonResult GetProbable_Responsable_PC_Estado_Estado(string query, string where)
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
        public JsonResult GetProbable_Responsable_PC_Municipio_Municipio(string query, string where)
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
        public JsonResult GetProbable_Responsable_PC_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetProbable_Responsable_PC_Colonia_Colonia(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Probable_Responsable_PCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Probable_Responsable_PC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Probable_Responsable_PC.Clave <= " + filter.ToClave;
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

                where += " AND Probable_Responsable_PC.Solicitud In (" + SolicitudIds + ")";
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

                where += " AND Probable_Responsable_PC.Tipo_de_Solicitud In (" + Tipo_de_SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTiene_informacion_responsable))
            {
                switch (filter.Tiene_informacion_responsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Respuesta.Descripcion LIKE '" + filter.AdvanceTiene_informacion_responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceTiene_informacion_responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Respuesta.Descripcion = '" + filter.AdvanceTiene_informacion_responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceTiene_informacion_responsable + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTiene_informacion_responsableMultiple != null && filter.AdvanceTiene_informacion_responsableMultiple.Count() > 0)
            {
                var Tiene_informacion_responsableIds = string.Join(",", filter.AdvanceTiene_informacion_responsableMultiple);

                where += " AND Probable_Responsable_PC.Tiene_informacion_responsable In (" + Tiene_informacion_responsableIds + ")";
            }

            if (filter.Quien_Resulte_Responsable != RadioOptions.NoApply)
                where += " AND Probable_Responsable_PC.Quien_Resulte_Responsable = " + Convert.ToInt32(filter.Quien_Resulte_Responsable);

            if (filter.Persona_moral != RadioOptions.NoApply)
                where += " AND Probable_Responsable_PC.Persona_moral = " + Convert.ToInt32(filter.Persona_moral);

            if (!string.IsNullOrEmpty(filter.Nombres))
            {
                switch (filter.NombresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Nombres LIKE '" + filter.Nombres + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Nombres LIKE '%" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Nombres = '" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Nombres LIKE '%" + filter.Nombres + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Alias))
            {
                switch (filter.AliasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Alias LIKE '" + filter.Alias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Alias LIKE '%" + filter.Alias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Alias = '" + filter.Alias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Alias LIKE '%" + filter.Alias + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
            {
                var Fecha_de_NacimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_NacimientoTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento))
                    where += " AND Probable_Responsable_PC.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Probable_Responsable_PC.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Probable_Responsable_PC.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Probable_Responsable_PC.Edad <= " + filter.ToEdad;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo))
            {
                switch (filter.SexoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexoMultiple != null && filter.AdvanceSexoMultiple.Count() > 0)
            {
                var SexoIds = string.Join(",", filter.AdvanceSexoMultiple);

                where += " AND Probable_Responsable_PC.Sexo In (" + SexoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Civil))
            {
                switch (filter.Estado_CivilFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_Civil.Descripcion LIKE '" + filter.AdvanceEstado_Civil + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_Civil.Descripcion = '" + filter.AdvanceEstado_Civil + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_CivilMultiple != null && filter.AdvanceEstado_CivilMultiple.Count() > 0)
            {
                var Estado_CivilIds = string.Join(",", filter.AdvanceEstado_CivilMultiple);

                where += " AND Probable_Responsable_PC.Estado_Civil In (" + Estado_CivilIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion))
            {
                switch (filter.Tipo_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_IdentificacionMultiple != null && filter.AdvanceTipo_de_IdentificacionMultiple.Count() > 0)
            {
                var Tipo_de_IdentificacionIds = string.Join(",", filter.AdvanceTipo_de_IdentificacionMultiple);

                where += " AND Probable_Responsable_PC.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
                        break;
                }
            }

            if (filter.Fotografia_de_la_identificacion != RadioOptions.NoApply)
                where += " AND Probable_Responsable_PC.Fotografia_de_la_identificacion " + (filter.Fotografia_de_la_identificacion == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.CURP))
            {
                switch (filter.CURPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.CURP LIKE '" + filter.CURP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.CURP LIKE '%" + filter.CURP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.CURP = '" + filter.CURP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.CURP LIKE '%" + filter.CURP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC))
            {
                switch (filter.RFCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.RFC LIKE '" + filter.RFC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.RFC LIKE '%" + filter.RFC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.RFC = '" + filter.RFC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.RFC LIKE '%" + filter.RFC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTiene_informacion__domicilio))
            {
                switch (filter.Tiene_informacion__domicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Respuesta.Descripcion LIKE '" + filter.AdvanceTiene_informacion__domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceTiene_informacion__domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Respuesta.Descripcion = '" + filter.AdvanceTiene_informacion__domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceTiene_informacion__domicilio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTiene_informacion__domicilioMultiple != null && filter.AdvanceTiene_informacion__domicilioMultiple.Count() > 0)
            {
                var Tiene_informacion__domicilioIds = string.Join(",", filter.AdvanceTiene_informacion__domicilioMultiple);

                where += " AND Probable_Responsable_PC.Tiene_informacion__domicilio In (" + Tiene_informacion__domicilioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais))
            {
                switch (filter.PaisFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais + "%'";
                        break;
                }
            }
            else if (filter.AdvancePaisMultiple != null && filter.AdvancePaisMultiple.Count() > 0)
            {
                var PaisIds = string.Join(",", filter.AdvancePaisMultiple);

                where += " AND Probable_Responsable_PC.Pais In (" + PaisIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado))
            {
                switch (filter.EstadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstadoMultiple != null && filter.AdvanceEstadoMultiple.Count() > 0)
            {
                var EstadoIds = string.Join(",", filter.AdvanceEstadoMultiple);

                where += " AND Probable_Responsable_PC.Estado In (" + EstadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio))
            {
                switch (filter.MunicipioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioMultiple != null && filter.AdvanceMunicipioMultiple.Count() > 0)
            {
                var MunicipioIds = string.Join(",", filter.AdvanceMunicipioMultiple);

                where += " AND Probable_Responsable_PC.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion))
            {
                switch (filter.PoblacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacionMultiple != null && filter.AdvancePoblacionMultiple.Count() > 0)
            {
                var PoblacionIds = string.Join(",", filter.AdvancePoblacionMultiple);

                where += " AND Probable_Responsable_PC.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia))
            {
                switch (filter.ColoniaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColoniaMultiple != null && filter.AdvanceColoniaMultiple.Count() > 0)
            {
                var ColoniaIds = string.Join(",", filter.AdvanceColoniaMultiple);

                where += " AND Probable_Responsable_PC.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Probable_Responsable_PC.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Probable_Responsable_PC.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Calle_del_Imputado))
            {
                switch (filter.Calle_del_ImputadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Calle_del_Imputado LIKE '" + filter.Calle_del_Imputado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Calle_del_Imputado LIKE '%" + filter.Calle_del_Imputado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Calle_del_Imputado = '" + filter.Calle_del_Imputado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Calle_del_Imputado LIKE '%" + filter.Calle_del_Imputado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_de_Domicilio))
            {
                switch (filter.Referencia_de_DomicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Referencia_de_Domicilio LIKE '" + filter.Referencia_de_Domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Referencia_de_Domicilio LIKE '%" + filter.Referencia_de_Domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Referencia_de_Domicilio = '" + filter.Referencia_de_Domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Referencia_de_Domicilio LIKE '%" + filter.Referencia_de_Domicilio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Peso))
            {
                switch (filter.PesoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Peso LIKE '" + filter.Peso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Peso LIKE '%" + filter.Peso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Peso = '" + filter.Peso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Peso LIKE '%" + filter.Peso + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Estatura))
            {
                switch (filter.EstaturaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Estatura LIKE '" + filter.Estatura + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Estatura LIKE '%" + filter.Estatura + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Estatura = '" + filter.Estatura + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Estatura LIKE '%" + filter.Estatura + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Padecimiento_de_Enfermedad))
            {
                switch (filter.Padecimiento_de_EnfermedadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Padecimiento_de_Enfermedad LIKE '" + filter.Padecimiento_de_Enfermedad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Padecimiento_de_Enfermedad = '" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Cara))
            {
                switch (filter.Forma_CaraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Cara.Descripcion LIKE '" + filter.AdvanceForma_Cara + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Cara.Descripcion LIKE '%" + filter.AdvanceForma_Cara + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Cara.Descripcion = '" + filter.AdvanceForma_Cara + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Cara.Descripcion LIKE '%" + filter.AdvanceForma_Cara + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_CaraMultiple != null && filter.AdvanceForma_CaraMultiple.Count() > 0)
            {
                var Forma_CaraIds = string.Join(",", filter.AdvanceForma_CaraMultiple);

                where += " AND Probable_Responsable_PC.Forma_Cara In (" + Forma_CaraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Cejas))
            {
                switch (filter.Tipo_de_CejasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cejas.Descripcion LIKE '" + filter.AdvanceTipo_de_Cejas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cejas.Descripcion LIKE '%" + filter.AdvanceTipo_de_Cejas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cejas.Descripcion = '" + filter.AdvanceTipo_de_Cejas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cejas.Descripcion LIKE '%" + filter.AdvanceTipo_de_Cejas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_CejasMultiple != null && filter.AdvanceTipo_de_CejasMultiple.Count() > 0)
            {
                var Tipo_de_CejasIds = string.Join(",", filter.AdvanceTipo_de_CejasMultiple);

                where += " AND Probable_Responsable_PC.Tipo_de_Cejas In (" + Tipo_de_CejasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTamano_de_Cejas))
            {
                switch (filter.Tamano_de_CejasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tamano_de_Cejas.Descripcion LIKE '" + filter.AdvanceTamano_de_Cejas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tamano_de_Cejas.Descripcion LIKE '%" + filter.AdvanceTamano_de_Cejas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tamano_de_Cejas.Descripcion = '" + filter.AdvanceTamano_de_Cejas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tamano_de_Cejas.Descripcion LIKE '%" + filter.AdvanceTamano_de_Cejas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTamano_de_CejasMultiple != null && filter.AdvanceTamano_de_CejasMultiple.Count() > 0)
            {
                var Tamano_de_CejasIds = string.Join(",", filter.AdvanceTamano_de_CejasMultiple);

                where += " AND Probable_Responsable_PC.Tamano_de_Cejas In (" + Tamano_de_CejasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLargo_de_Cabello))
            {
                switch (filter.Largo_de_CabelloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Largo_de_Cabello.Descripcion LIKE '" + filter.AdvanceLargo_de_Cabello + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Largo_de_Cabello.Descripcion LIKE '%" + filter.AdvanceLargo_de_Cabello + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Largo_de_Cabello.Descripcion = '" + filter.AdvanceLargo_de_Cabello + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Largo_de_Cabello.Descripcion LIKE '%" + filter.AdvanceLargo_de_Cabello + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLargo_de_CabelloMultiple != null && filter.AdvanceLargo_de_CabelloMultiple.Count() > 0)
            {
                var Largo_de_CabelloIds = string.Join(",", filter.AdvanceLargo_de_CabelloMultiple);

                where += " AND Probable_Responsable_PC.Largo_de_Cabello In (" + Largo_de_CabelloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCantidad_Cabello))
            {
                switch (filter.Cantidad_CabelloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cantidad_Cabello.Descripcion LIKE '" + filter.AdvanceCantidad_Cabello + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cantidad_Cabello.Descripcion LIKE '%" + filter.AdvanceCantidad_Cabello + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cantidad_Cabello.Descripcion = '" + filter.AdvanceCantidad_Cabello + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cantidad_Cabello.Descripcion LIKE '%" + filter.AdvanceCantidad_Cabello + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCantidad_CabelloMultiple != null && filter.AdvanceCantidad_CabelloMultiple.Count() > 0)
            {
                var Cantidad_CabelloIds = string.Join(",", filter.AdvanceCantidad_CabelloMultiple);

                where += " AND Probable_Responsable_PC.Cantidad_Cabello In (" + Cantidad_CabelloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceImplantacion_Cabello))
            {
                switch (filter.Implantacion_CabelloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Implantacion_Cabello.Descripcion LIKE '" + filter.AdvanceImplantacion_Cabello + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Implantacion_Cabello.Descripcion LIKE '%" + filter.AdvanceImplantacion_Cabello + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Implantacion_Cabello.Descripcion = '" + filter.AdvanceImplantacion_Cabello + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Implantacion_Cabello.Descripcion LIKE '%" + filter.AdvanceImplantacion_Cabello + "%'";
                        break;
                }
            }
            else if (filter.AdvanceImplantacion_CabelloMultiple != null && filter.AdvanceImplantacion_CabelloMultiple.Count() > 0)
            {
                var Implantacion_CabelloIds = string.Join(",", filter.AdvanceImplantacion_CabelloMultiple);

                where += " AND Probable_Responsable_PC.Implantacion_Cabello In (" + Implantacion_CabelloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceComplexion))
            {
                switch (filter.ComplexionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Complexion.Descripcion LIKE '" + filter.AdvanceComplexion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Complexion.Descripcion LIKE '%" + filter.AdvanceComplexion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Complexion.Descripcion = '" + filter.AdvanceComplexion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Complexion.Descripcion LIKE '%" + filter.AdvanceComplexion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceComplexionMultiple != null && filter.AdvanceComplexionMultiple.Count() > 0)
            {
                var ComplexionIds = string.Join(",", filter.AdvanceComplexionMultiple);

                where += " AND Probable_Responsable_PC.Complexion In (" + ComplexionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColor_Piel))
            {
                switch (filter.Color_PielFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Color_Piel.Descrpicion LIKE '" + filter.AdvanceColor_Piel + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Color_Piel.Descrpicion LIKE '%" + filter.AdvanceColor_Piel + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Color_Piel.Descrpicion = '" + filter.AdvanceColor_Piel + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Color_Piel.Descrpicion LIKE '%" + filter.AdvanceColor_Piel + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColor_PielMultiple != null && filter.AdvanceColor_PielMultiple.Count() > 0)
            {
                var Color_PielIds = string.Join(",", filter.AdvanceColor_PielMultiple);

                where += " AND Probable_Responsable_PC.Color_Piel In (" + Color_PielIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFrente))
            {
                switch (filter.FrenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Frente.Descripcion LIKE '" + filter.AdvanceFrente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Frente.Descripcion LIKE '%" + filter.AdvanceFrente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Frente.Descripcion = '" + filter.AdvanceFrente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Frente.Descripcion LIKE '%" + filter.AdvanceFrente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFrenteMultiple != null && filter.AdvanceFrenteMultiple.Count() > 0)
            {
                var FrenteIds = string.Join(",", filter.AdvanceFrenteMultiple);

                where += " AND Probable_Responsable_PC.Frente In (" + FrenteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Cabello))
            {
                switch (filter.Forma_CabelloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Cabello.Descripcion LIKE '" + filter.AdvanceForma_Cabello + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Cabello.Descripcion LIKE '%" + filter.AdvanceForma_Cabello + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Cabello.Descripcion = '" + filter.AdvanceForma_Cabello + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Cabello.Descripcion LIKE '%" + filter.AdvanceForma_Cabello + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_CabelloMultiple != null && filter.AdvanceForma_CabelloMultiple.Count() > 0)
            {
                var Forma_CabelloIds = string.Join(",", filter.AdvanceForma_CabelloMultiple);

                where += " AND Probable_Responsable_PC.Forma_Cabello In (" + Forma_CabelloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColor_Cabello))
            {
                switch (filter.Color_CabelloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Color_de_Cabello.Descripcion LIKE '" + filter.AdvanceColor_Cabello + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Color_de_Cabello.Descripcion LIKE '%" + filter.AdvanceColor_Cabello + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Color_de_Cabello.Descripcion = '" + filter.AdvanceColor_Cabello + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Color_de_Cabello.Descripcion LIKE '%" + filter.AdvanceColor_Cabello + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColor_CabelloMultiple != null && filter.AdvanceColor_CabelloMultiple.Count() > 0)
            {
                var Color_CabelloIds = string.Join(",", filter.AdvanceColor_CabelloMultiple);

                where += " AND Probable_Responsable_PC.Color_Cabello In (" + Color_CabelloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCalvicie))
            {
                switch (filter.CalvicieFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Calvicie.Descripcion LIKE '" + filter.AdvanceCalvicie + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Calvicie.Descripcion LIKE '%" + filter.AdvanceCalvicie + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Calvicie.Descripcion = '" + filter.AdvanceCalvicie + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Calvicie.Descripcion LIKE '%" + filter.AdvanceCalvicie + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCalvicieMultiple != null && filter.AdvanceCalvicieMultiple.Count() > 0)
            {
                var CalvicieIds = string.Join(",", filter.AdvanceCalvicieMultiple);

                where += " AND Probable_Responsable_PC.Calvicie In (" + CalvicieIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColor_Ojos))
            {
                switch (filter.Color_OjosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Color_Ojos.Descripcion LIKE '" + filter.AdvanceColor_Ojos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Color_Ojos.Descripcion LIKE '%" + filter.AdvanceColor_Ojos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Color_Ojos.Descripcion = '" + filter.AdvanceColor_Ojos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Color_Ojos.Descripcion LIKE '%" + filter.AdvanceColor_Ojos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColor_OjosMultiple != null && filter.AdvanceColor_OjosMultiple.Count() > 0)
            {
                var Color_OjosIds = string.Join(",", filter.AdvanceColor_OjosMultiple);

                where += " AND Probable_Responsable_PC.Color_Ojos In (" + Color_OjosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTamano_de_Ojos))
            {
                switch (filter.Tamano_de_OjosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ojos.Descripcion LIKE '" + filter.AdvanceTamano_de_Ojos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ojos.Descripcion LIKE '%" + filter.AdvanceTamano_de_Ojos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ojos.Descripcion = '" + filter.AdvanceTamano_de_Ojos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ojos.Descripcion LIKE '%" + filter.AdvanceTamano_de_Ojos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTamano_de_OjosMultiple != null && filter.AdvanceTamano_de_OjosMultiple.Count() > 0)
            {
                var Tamano_de_OjosIds = string.Join(",", filter.AdvanceTamano_de_OjosMultiple);

                where += " AND Probable_Responsable_PC.Tamano_de_Ojos In (" + Tamano_de_OjosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Ojos))
            {
                switch (filter.Forma_OjosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Froma_Ojos.Descripcion LIKE '" + filter.AdvanceForma_Ojos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Froma_Ojos.Descripcion LIKE '%" + filter.AdvanceForma_Ojos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Froma_Ojos.Descripcion = '" + filter.AdvanceForma_Ojos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Froma_Ojos.Descripcion LIKE '%" + filter.AdvanceForma_Ojos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_OjosMultiple != null && filter.AdvanceForma_OjosMultiple.Count() > 0)
            {
                var Forma_OjosIds = string.Join(",", filter.AdvanceForma_OjosMultiple);

                where += " AND Probable_Responsable_PC.Forma_Ojos In (" + Forma_OjosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAnteojos))
            {
                switch (filter.AnteojosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Anteojos.Descripcion LIKE '" + filter.AdvanceAnteojos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Anteojos.Descripcion LIKE '%" + filter.AdvanceAnteojos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Anteojos.Descripcion = '" + filter.AdvanceAnteojos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Anteojos.Descripcion LIKE '%" + filter.AdvanceAnteojos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAnteojosMultiple != null && filter.AdvanceAnteojosMultiple.Count() > 0)
            {
                var AnteojosIds = string.Join(",", filter.AdvanceAnteojosMultiple);

                where += " AND Probable_Responsable_PC.Anteojos In (" + AnteojosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Nariz))
            {
                switch (filter.Forma_de_NarizFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_de_Nariz.Descripcion LIKE '" + filter.AdvanceForma_de_Nariz + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_de_Nariz.Descripcion LIKE '%" + filter.AdvanceForma_de_Nariz + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_de_Nariz.Descripcion = '" + filter.AdvanceForma_de_Nariz + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_de_Nariz.Descripcion LIKE '%" + filter.AdvanceForma_de_Nariz + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_NarizMultiple != null && filter.AdvanceForma_de_NarizMultiple.Count() > 0)
            {
                var Forma_de_NarizIds = string.Join(",", filter.AdvanceForma_de_NarizMultiple);

                where += " AND Probable_Responsable_PC.Forma_de_Nariz In (" + Forma_de_NarizIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTamano_Nariz))
            {
                switch (filter.Tamano_NarizFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nariz_Base.Descripcion LIKE '" + filter.AdvanceTamano_Nariz + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nariz_Base.Descripcion LIKE '%" + filter.AdvanceTamano_Nariz + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nariz_Base.Descripcion = '" + filter.AdvanceTamano_Nariz + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nariz_Base.Descripcion LIKE '%" + filter.AdvanceTamano_Nariz + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTamano_NarizMultiple != null && filter.AdvanceTamano_NarizMultiple.Count() > 0)
            {
                var Tamano_NarizIds = string.Join(",", filter.AdvanceTamano_NarizMultiple);

                where += " AND Probable_Responsable_PC.Tamano_Nariz In (" + Tamano_NarizIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLabios))
            {
                switch (filter.LabiosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Labios.Descripcion LIKE '" + filter.AdvanceLabios + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Labios.Descripcion LIKE '%" + filter.AdvanceLabios + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Labios.Descripcion = '" + filter.AdvanceLabios + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Labios.Descripcion LIKE '%" + filter.AdvanceLabios + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLabiosMultiple != null && filter.AdvanceLabiosMultiple.Count() > 0)
            {
                var LabiosIds = string.Join(",", filter.AdvanceLabiosMultiple);

                where += " AND Probable_Responsable_PC.Labios In (" + LabiosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceBoca))
            {
                switch (filter.BocaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Boca.Descripcion LIKE '" + filter.AdvanceBoca + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Boca.Descripcion LIKE '%" + filter.AdvanceBoca + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Boca.Descripcion = '" + filter.AdvanceBoca + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Boca.Descripcion LIKE '%" + filter.AdvanceBoca + "%'";
                        break;
                }
            }
            else if (filter.AdvanceBocaMultiple != null && filter.AdvanceBocaMultiple.Count() > 0)
            {
                var BocaIds = string.Join(",", filter.AdvanceBocaMultiple);

                where += " AND Probable_Responsable_PC.Boca In (" + BocaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceGrosor_de_Labios))
            {
                switch (filter.Grosor_de_LabiosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Grosor_de_Labios.Descripcion LIKE '" + filter.AdvanceGrosor_de_Labios + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Grosor_de_Labios.Descripcion LIKE '%" + filter.AdvanceGrosor_de_Labios + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Grosor_de_Labios.Descripcion = '" + filter.AdvanceGrosor_de_Labios + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Grosor_de_Labios.Descripcion LIKE '%" + filter.AdvanceGrosor_de_Labios + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGrosor_de_LabiosMultiple != null && filter.AdvanceGrosor_de_LabiosMultiple.Count() > 0)
            {
                var Grosor_de_LabiosIds = string.Join(",", filter.AdvanceGrosor_de_LabiosMultiple);

                where += " AND Probable_Responsable_PC.Grosor_de_Labios In (" + Grosor_de_LabiosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMenton))
            {
                switch (filter.MentonFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Menton.Descripcion LIKE '" + filter.AdvanceMenton + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Menton.Descripcion LIKE '%" + filter.AdvanceMenton + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Menton.Descripcion = '" + filter.AdvanceMenton + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Menton.Descripcion LIKE '%" + filter.AdvanceMenton + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMentonMultiple != null && filter.AdvanceMentonMultiple.Count() > 0)
            {
                var MentonIds = string.Join(",", filter.AdvanceMentonMultiple);

                where += " AND Probable_Responsable_PC.Menton In (" + MentonIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Menton))
            {
                switch (filter.Forma_de_MentonFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_de_Menton.Descripcion LIKE '" + filter.AdvanceForma_de_Menton + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_de_Menton.Descripcion LIKE '%" + filter.AdvanceForma_de_Menton + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_de_Menton.Descripcion = '" + filter.AdvanceForma_de_Menton + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_de_Menton.Descripcion LIKE '%" + filter.AdvanceForma_de_Menton + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_MentonMultiple != null && filter.AdvanceForma_de_MentonMultiple.Count() > 0)
            {
                var Forma_de_MentonIds = string.Join(",", filter.AdvanceForma_de_MentonMultiple);

                where += " AND Probable_Responsable_PC.Forma_de_Menton In (" + Forma_de_MentonIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceBarba))
            {
                switch (filter.BarbaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Barba.Descripcion LIKE '" + filter.AdvanceBarba + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Barba.Descripcion LIKE '%" + filter.AdvanceBarba + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Barba.Descripcion = '" + filter.AdvanceBarba + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Barba.Descripcion LIKE '%" + filter.AdvanceBarba + "%'";
                        break;
                }
            }
            else if (filter.AdvanceBarbaMultiple != null && filter.AdvanceBarbaMultiple.Count() > 0)
            {
                var BarbaIds = string.Join(",", filter.AdvanceBarbaMultiple);

                where += " AND Probable_Responsable_PC.Barba In (" + BarbaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Orejas))
            {
                switch (filter.Forma_OrejasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Orejas.Descripcion LIKE '" + filter.AdvanceForma_Orejas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Orejas.Descripcion LIKE '%" + filter.AdvanceForma_Orejas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Orejas.Descripcion = '" + filter.AdvanceForma_Orejas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Orejas.Descripcion LIKE '%" + filter.AdvanceForma_Orejas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_OrejasMultiple != null && filter.AdvanceForma_OrejasMultiple.Count() > 0)
            {
                var Forma_OrejasIds = string.Join(",", filter.AdvanceForma_OrejasMultiple);

                where += " AND Probable_Responsable_PC.Forma_Orejas In (" + Forma_OrejasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTamano_Orejas))
            {
                switch (filter.Tamano_OrejasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tamano_Orejas.Descripcion LIKE '" + filter.AdvanceTamano_Orejas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tamano_Orejas.Descripcion LIKE '%" + filter.AdvanceTamano_Orejas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tamano_Orejas.Descripcion = '" + filter.AdvanceTamano_Orejas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tamano_Orejas.Descripcion LIKE '%" + filter.AdvanceTamano_Orejas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTamano_OrejasMultiple != null && filter.AdvanceTamano_OrejasMultiple.Count() > 0)
            {
                var Tamano_OrejasIds = string.Join(",", filter.AdvanceTamano_OrejasMultiple);

                where += " AND Probable_Responsable_PC.Tamano_Orejas In (" + Tamano_OrejasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_Lobulo))
            {
                switch (filter.Tipo_LobuloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_Lobulo.Descripcion LIKE '" + filter.AdvanceTipo_Lobulo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_Lobulo.Descripcion LIKE '%" + filter.AdvanceTipo_Lobulo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_Lobulo.Descripcion = '" + filter.AdvanceTipo_Lobulo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_Lobulo.Descripcion LIKE '%" + filter.AdvanceTipo_Lobulo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_LobuloMultiple != null && filter.AdvanceTipo_LobuloMultiple.Count() > 0)
            {
                var Tipo_LobuloIds = string.Join(",", filter.AdvanceTipo_LobuloMultiple);

                where += " AND Probable_Responsable_PC.Tipo_Lobulo In (" + Tipo_LobuloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceBigote))
            {
                switch (filter.BigoteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Bigote.Descripcion LIKE '" + filter.AdvanceBigote + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Bigote.Descripcion LIKE '%" + filter.AdvanceBigote + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Bigote.Descripcion = '" + filter.AdvanceBigote + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Bigote.Descripcion LIKE '%" + filter.AdvanceBigote + "%'";
                        break;
                }
            }
            else if (filter.AdvanceBigoteMultiple != null && filter.AdvanceBigoteMultiple.Count() > 0)
            {
                var BigoteIds = string.Join(",", filter.AdvanceBigoteMultiple);

                where += " AND Probable_Responsable_PC.Bigote In (" + BigoteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSenas_Particulares))
            {
                switch (filter.Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Senas_Particulares.Descripcion LIKE '" + filter.AdvanceSenas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Senas_Particulares.Descripcion LIKE '%" + filter.AdvanceSenas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Senas_Particulares.Descripcion = '" + filter.AdvanceSenas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Senas_Particulares.Descripcion LIKE '%" + filter.AdvanceSenas_Particulares + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSenas_ParticularesMultiple != null && filter.AdvanceSenas_ParticularesMultiple.Count() > 0)
            {
                var Senas_ParticularesIds = string.Join(",", filter.AdvanceSenas_ParticularesMultiple);

                where += " AND Probable_Responsable_PC.Senas_Particulares In (" + Senas_ParticularesIds + ")";
            }

            if (filter.Imagen_Tatuaje != RadioOptions.NoApply)
                where += " AND Probable_Responsable_PC.Imagen_Tatuaje " + (filter.Imagen_Tatuaje == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.AdvanceSituacion_Fisica))
            {
                switch (filter.Situacion_FisicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Situacion_Fisica.Descripcion LIKE '" + filter.AdvanceSituacion_Fisica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Situacion_Fisica.Descripcion LIKE '%" + filter.AdvanceSituacion_Fisica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Situacion_Fisica.Descripcion = '" + filter.AdvanceSituacion_Fisica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Situacion_Fisica.Descripcion LIKE '%" + filter.AdvanceSituacion_Fisica + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSituacion_FisicaMultiple != null && filter.AdvanceSituacion_FisicaMultiple.Count() > 0)
            {
                var Situacion_FisicaIds = string.Join(",", filter.AdvanceSituacion_FisicaMultiple);

                where += " AND Probable_Responsable_PC.Situacion_Fisica In (" + Situacion_FisicaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Otras_Senas_Particulares))
            {
                switch (filter.Otras_Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Otras_Senas_Particulares LIKE '" + filter.Otras_Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Otras_Senas_Particulares = '" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Imputado_Recluido))
            {
                switch (filter.Imputado_RecluidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Probable_Responsable_PC.Imputado_Recluido LIKE '" + filter.Imputado_Recluido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Probable_Responsable_PC.Imputado_Recluido LIKE '%" + filter.Imputado_Recluido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Probable_Responsable_PC.Imputado_Recluido = '" + filter.Imputado_Recluido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Probable_Responsable_PC.Imputado_Recluido LIKE '%" + filter.Imputado_Recluido + "%'";
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
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Probable_Responsable_PC varProbable_Responsable_PC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IProbable_Responsable_PCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Probable_Responsable_PCModel varProbable_Responsable_PC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varProbable_Responsable_PC.Fotografia_de_la_identificacionRemoveAttachment != 0 && varProbable_Responsable_PC.Fotografia_de_la_identificacionFile == null)
                    {
                        varProbable_Responsable_PC.Fotografia_de_la_identificacion = 0;
                    }

                    if (varProbable_Responsable_PC.Fotografia_de_la_identificacionFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varProbable_Responsable_PC.Fotografia_de_la_identificacionFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varProbable_Responsable_PC.Fotografia_de_la_identificacion = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varProbable_Responsable_PC.Fotografia_de_la_identificacionFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varProbable_Responsable_PC.Imagen_TatuajeRemoveAttachment != 0 && varProbable_Responsable_PC.Imagen_TatuajeFile == null)
                    {
                        varProbable_Responsable_PC.Imagen_Tatuaje = 0;
                    }

                    if (varProbable_Responsable_PC.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varProbable_Responsable_PC.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varProbable_Responsable_PC.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varProbable_Responsable_PC.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Probable_Responsable_PCInfo = new Probable_Responsable_PC
                    {
                        Clave = varProbable_Responsable_PC.Clave
                        ,Solicitud = varProbable_Responsable_PC.Solicitud
                        ,Tipo_de_Solicitud = varProbable_Responsable_PC.Tipo_de_Solicitud
                        ,Tiene_informacion_responsable = varProbable_Responsable_PC.Tiene_informacion_responsable
                        ,Quien_Resulte_Responsable = varProbable_Responsable_PC.Quien_Resulte_Responsable
                        ,Persona_moral = varProbable_Responsable_PC.Persona_moral
                        ,Nombres = varProbable_Responsable_PC.Nombres
                        ,Apellido_Paterno = varProbable_Responsable_PC.Apellido_Paterno
                        ,Apellido_Materno = varProbable_Responsable_PC.Apellido_Materno
                        ,Nombre_Completo = varProbable_Responsable_PC.Nombre_Completo
                        ,Alias = varProbable_Responsable_PC.Alias
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varProbable_Responsable_PC.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varProbable_Responsable_PC.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varProbable_Responsable_PC.Edad
                        ,Sexo = varProbable_Responsable_PC.Sexo
                        ,Estado_Civil = varProbable_Responsable_PC.Estado_Civil
                        ,Tipo_de_Identificacion = varProbable_Responsable_PC.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varProbable_Responsable_PC.Numero_de_Identificacion
                        ,Fotografia_de_la_identificacion = (varProbable_Responsable_PC.Fotografia_de_la_identificacion.HasValue && varProbable_Responsable_PC.Fotografia_de_la_identificacion != 0) ? ((int?)Convert.ToInt32(varProbable_Responsable_PC.Fotografia_de_la_identificacion.Value)) : null

                        ,CURP = varProbable_Responsable_PC.CURP
                        ,RFC = varProbable_Responsable_PC.RFC
                        ,Tiene_informacion__domicilio = varProbable_Responsable_PC.Tiene_informacion__domicilio
                        ,Pais = varProbable_Responsable_PC.Pais
                        ,Estado = varProbable_Responsable_PC.Estado
                        ,Municipio = varProbable_Responsable_PC.Municipio
                        ,Poblacion = varProbable_Responsable_PC.Poblacion
                        ,Colonia = varProbable_Responsable_PC.Colonia
                        ,Codigo_Postal = varProbable_Responsable_PC.Codigo_Postal
                        ,Calle_del_Imputado = varProbable_Responsable_PC.Calle_del_Imputado
                        ,Numero_Exterior = varProbable_Responsable_PC.Numero_Exterior
                        ,Numero_Interior = varProbable_Responsable_PC.Numero_Interior
                        ,Referencia_de_Domicilio = varProbable_Responsable_PC.Referencia_de_Domicilio
                        ,Latitud = varProbable_Responsable_PC.Latitud
                        ,Longitud = varProbable_Responsable_PC.Longitud
                        ,Peso = varProbable_Responsable_PC.Peso
                        ,Estatura = varProbable_Responsable_PC.Estatura
                        ,Padecimiento_de_Enfermedad = varProbable_Responsable_PC.Padecimiento_de_Enfermedad
                        ,Forma_Cara = varProbable_Responsable_PC.Forma_Cara
                        ,Tipo_de_Cejas = varProbable_Responsable_PC.Tipo_de_Cejas
                        ,Tamano_de_Cejas = varProbable_Responsable_PC.Tamano_de_Cejas
                        ,Largo_de_Cabello = varProbable_Responsable_PC.Largo_de_Cabello
                        ,Cantidad_Cabello = varProbable_Responsable_PC.Cantidad_Cabello
                        ,Implantacion_Cabello = varProbable_Responsable_PC.Implantacion_Cabello
                        ,Complexion = varProbable_Responsable_PC.Complexion
                        ,Color_Piel = varProbable_Responsable_PC.Color_Piel
                        ,Frente = varProbable_Responsable_PC.Frente
                        ,Forma_Cabello = varProbable_Responsable_PC.Forma_Cabello
                        ,Color_Cabello = varProbable_Responsable_PC.Color_Cabello
                        ,Calvicie = varProbable_Responsable_PC.Calvicie
                        ,Color_Ojos = varProbable_Responsable_PC.Color_Ojos
                        ,Tamano_de_Ojos = varProbable_Responsable_PC.Tamano_de_Ojos
                        ,Forma_Ojos = varProbable_Responsable_PC.Forma_Ojos
                        ,Anteojos = varProbable_Responsable_PC.Anteojos
                        ,Forma_de_Nariz = varProbable_Responsable_PC.Forma_de_Nariz
                        ,Tamano_Nariz = varProbable_Responsable_PC.Tamano_Nariz
                        ,Labios = varProbable_Responsable_PC.Labios
                        ,Boca = varProbable_Responsable_PC.Boca
                        ,Grosor_de_Labios = varProbable_Responsable_PC.Grosor_de_Labios
                        ,Menton = varProbable_Responsable_PC.Menton
                        ,Forma_de_Menton = varProbable_Responsable_PC.Forma_de_Menton
                        ,Barba = varProbable_Responsable_PC.Barba
                        ,Forma_Orejas = varProbable_Responsable_PC.Forma_Orejas
                        ,Tamano_Orejas = varProbable_Responsable_PC.Tamano_Orejas
                        ,Tipo_Lobulo = varProbable_Responsable_PC.Tipo_Lobulo
                        ,Bigote = varProbable_Responsable_PC.Bigote
                        ,Senas_Particulares = varProbable_Responsable_PC.Senas_Particulares
                        ,Imagen_Tatuaje = (varProbable_Responsable_PC.Imagen_Tatuaje.HasValue && varProbable_Responsable_PC.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varProbable_Responsable_PC.Imagen_Tatuaje.Value)) : null

                        ,Situacion_Fisica = varProbable_Responsable_PC.Situacion_Fisica
                        ,Otras_Senas_Particulares = varProbable_Responsable_PC.Otras_Senas_Particulares
                        ,Imputado_Recluido = varProbable_Responsable_PC.Imputado_Recluido

                    };

                    result = !IsNew ?
                        _IProbable_Responsable_PCApiConsumer.Update(Probable_Responsable_PCInfo, null, null).Resource.ToString() :
                         _IProbable_Responsable_PCApiConsumer.Insert(Probable_Responsable_PCInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Probable_Responsable_PC script
        /// </summary>
        /// <param name="oProbable_Responsable_PCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Probable_Responsable_PCModuleAttributeList)
        {
            for (int i = 0; i < Probable_Responsable_PCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Probable_Responsable_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Probable_Responsable_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Probable_Responsable_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Probable_Responsable_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strProbable_Responsable_PCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Probable_Responsable_PC.js")))
            {
                strProbable_Responsable_PCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Probable_Responsable_PC element attributes
            string userChangeJson = jsSerialize.Serialize(Probable_Responsable_PCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strProbable_Responsable_PCScript.IndexOf("inpuElementArray");
            string splittedString = strProbable_Responsable_PCScript.Substring(indexOfArray, strProbable_Responsable_PCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strProbable_Responsable_PCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strProbable_Responsable_PCScript.Substring(indexOfArrayHistory, strProbable_Responsable_PCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strProbable_Responsable_PCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strProbable_Responsable_PCScript.Substring(endIndexOfMainElement + indexOfArray, strProbable_Responsable_PCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Probable_Responsable_PCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Probable_Responsable_PC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Probable_Responsable_PC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Probable_Responsable_PC.js")))
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
        public ActionResult Probable_Responsable_PCPropertyBag()
        {
            return PartialView("Probable_Responsable_PCPropertyBag", "Probable_Responsable_PC");
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
                var whereClauseFormat = "Object = 45714 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Probable_Responsable_PC.Clave= " + RecordId;
                            var result = _IProbable_Responsable_PCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Probable_Responsable_PCPropertyMapper());
			
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
                    (Probable_Responsable_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Probable_Responsable_PCPropertyMapper oProbable_Responsable_PCPropertyMapper = new Probable_Responsable_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oProbable_Responsable_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IProbable_Responsable_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Probable_Responsable_PCs == null)
                result.Probable_Responsable_PCs = new List<Probable_Responsable_PC>();

            var data = result.Probable_Responsable_PCs.Select(m => new Probable_Responsable_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion_responsable_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion_responsable_Respuesta.Descripcion
			,Quien_Resulte_Responsable = m.Quien_Resulte_Responsable
			,Persona_moral = m.Persona_moral
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion__domicilio_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion__domicilio_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45714, arrayColumnsVisible), "Probable_Responsable_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45714, arrayColumnsVisible), "Probable_Responsable_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45714, arrayColumnsVisible), "Probable_Responsable_PCList_" + DateTime.Now.ToString());
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

            _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Probable_Responsable_PCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Probable_Responsable_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Probable_Responsable_PCPropertyMapper oProbable_Responsable_PCPropertyMapper = new Probable_Responsable_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oProbable_Responsable_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IProbable_Responsable_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Probable_Responsable_PCs == null)
                result.Probable_Responsable_PCs = new List<Probable_Responsable_PC>();

            var data = result.Probable_Responsable_PCs.Select(m => new Probable_Responsable_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion_responsable_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion_responsable_Respuesta.Descripcion
			,Quien_Resulte_Responsable = m.Quien_Resulte_Responsable
			,Persona_moral = m.Persona_moral
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion__domicilio_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion__domicilio_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

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
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProbable_Responsable_PCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Probable_Responsable_PC_Datos_GeneralesModel varProbable_Responsable_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varProbable_Responsable_PC.Fotografia_de_la_identificacionRemoveAttachment != 0 && varProbable_Responsable_PC.Fotografia_de_la_identificacionFile == null)
                    {
                        varProbable_Responsable_PC.Fotografia_de_la_identificacion = 0;
                    }

                    if (varProbable_Responsable_PC.Fotografia_de_la_identificacionFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varProbable_Responsable_PC.Fotografia_de_la_identificacionFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varProbable_Responsable_PC.Fotografia_de_la_identificacion = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varProbable_Responsable_PC.Fotografia_de_la_identificacionFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Probable_Responsable_PC_Datos_GeneralesInfo = new Probable_Responsable_PC_Datos_Generales
                {
                    Clave = varProbable_Responsable_PC.Clave
                                            ,Solicitud = varProbable_Responsable_PC.Solicitud
                        ,Tipo_de_Solicitud = varProbable_Responsable_PC.Tipo_de_Solicitud
                        ,Tiene_informacion_responsable = varProbable_Responsable_PC.Tiene_informacion_responsable
                        ,Quien_Resulte_Responsable = varProbable_Responsable_PC.Quien_Resulte_Responsable
                        ,Persona_moral = varProbable_Responsable_PC.Persona_moral
                        ,Nombres = varProbable_Responsable_PC.Nombres
                        ,Apellido_Paterno = varProbable_Responsable_PC.Apellido_Paterno
                        ,Apellido_Materno = varProbable_Responsable_PC.Apellido_Materno
                        ,Nombre_Completo = varProbable_Responsable_PC.Nombre_Completo
                        ,Alias = varProbable_Responsable_PC.Alias
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varProbable_Responsable_PC.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varProbable_Responsable_PC.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varProbable_Responsable_PC.Edad
                        ,Sexo = varProbable_Responsable_PC.Sexo
                        ,Estado_Civil = varProbable_Responsable_PC.Estado_Civil
                        ,Tipo_de_Identificacion = varProbable_Responsable_PC.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varProbable_Responsable_PC.Numero_de_Identificacion
                        ,Fotografia_de_la_identificacion = (varProbable_Responsable_PC.Fotografia_de_la_identificacion.HasValue && varProbable_Responsable_PC.Fotografia_de_la_identificacion != 0) ? ((int?)Convert.ToInt32(varProbable_Responsable_PC.Fotografia_de_la_identificacion.Value)) : null

                        ,CURP = varProbable_Responsable_PC.CURP
                        ,RFC = varProbable_Responsable_PC.RFC
                        ,Tiene_informacion__domicilio = varProbable_Responsable_PC.Tiene_informacion__domicilio
                    
                };

                result = _IProbable_Responsable_PCApiConsumer.Update_Datos_Generales(Probable_Responsable_PC_Datos_GeneralesInfo).Resource.ToString();
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
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProbable_Responsable_PCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Probable_Responsable_PC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_Solicitud = m.Tipo_de_Solicitud
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Tiene_informacion_responsable = m.Tiene_informacion_responsable
                        ,Tiene_informacion_responsableDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion_responsable_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion_responsable_Respuesta.Descripcion
			,Quien_Resulte_Responsable = m.Quien_Resulte_Responsable
			,Persona_moral = m.Persona_moral
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Tiene_informacion__domicilio = m.Tiene_informacion__domicilio
                        ,Tiene_informacion__domicilioDescripcion = CultureHelper.GetTraduction(m.Tiene_informacion__domicilio_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Tiene_informacion__domicilio_Respuesta.Descripcion

                    
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
        public ActionResult Post_Domicilio(Probable_Responsable_PC_DomicilioModel varProbable_Responsable_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Probable_Responsable_PC_DomicilioInfo = new Probable_Responsable_PC_Domicilio
                {
                    Clave = varProbable_Responsable_PC.Clave
                                            ,Pais = varProbable_Responsable_PC.Pais
                        ,Estado = varProbable_Responsable_PC.Estado
                        ,Municipio = varProbable_Responsable_PC.Municipio
                        ,Poblacion = varProbable_Responsable_PC.Poblacion
                        ,Colonia = varProbable_Responsable_PC.Colonia
                        ,Codigo_Postal = varProbable_Responsable_PC.Codigo_Postal
                        ,Calle_del_Imputado = varProbable_Responsable_PC.Calle_del_Imputado
                        ,Numero_Exterior = varProbable_Responsable_PC.Numero_Exterior
                        ,Numero_Interior = varProbable_Responsable_PC.Numero_Interior
                        ,Referencia_de_Domicilio = varProbable_Responsable_PC.Referencia_de_Domicilio
                        ,Latitud = varProbable_Responsable_PC.Latitud
                        ,Longitud = varProbable_Responsable_PC.Longitud
                    
                };

                result = _IProbable_Responsable_PCApiConsumer.Update_Domicilio(Probable_Responsable_PC_DomicilioInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Domicilio(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProbable_Responsable_PCApiConsumer.Get_Domicilio(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Probable_Responsable_PC_DomicilioModel
                {
                    Clave = m.Clave
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud

                    
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
        public ActionResult Post_Datos_de_Media_Filiacion(Probable_Responsable_PC_Datos_de_Media_FiliacionModel varProbable_Responsable_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varProbable_Responsable_PC.Imagen_TatuajeRemoveAttachment != 0 && varProbable_Responsable_PC.Imagen_TatuajeFile == null)
                    {
                        varProbable_Responsable_PC.Imagen_Tatuaje = 0;
                    }

                    if (varProbable_Responsable_PC.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varProbable_Responsable_PC.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varProbable_Responsable_PC.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varProbable_Responsable_PC.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Probable_Responsable_PC_Datos_de_Media_FiliacionInfo = new Probable_Responsable_PC_Datos_de_Media_Filiacion
                {
                    Clave = varProbable_Responsable_PC.Clave
                                            ,Peso = varProbable_Responsable_PC.Peso
                        ,Estatura = varProbable_Responsable_PC.Estatura
                        ,Padecimiento_de_Enfermedad = varProbable_Responsable_PC.Padecimiento_de_Enfermedad
                        ,Forma_Cara = varProbable_Responsable_PC.Forma_Cara
                        ,Tipo_de_Cejas = varProbable_Responsable_PC.Tipo_de_Cejas
                        ,Tamano_de_Cejas = varProbable_Responsable_PC.Tamano_de_Cejas
                        ,Largo_de_Cabello = varProbable_Responsable_PC.Largo_de_Cabello
                        ,Cantidad_Cabello = varProbable_Responsable_PC.Cantidad_Cabello
                        ,Implantacion_Cabello = varProbable_Responsable_PC.Implantacion_Cabello
                        ,Complexion = varProbable_Responsable_PC.Complexion
                        ,Color_Piel = varProbable_Responsable_PC.Color_Piel
                        ,Frente = varProbable_Responsable_PC.Frente
                        ,Forma_Cabello = varProbable_Responsable_PC.Forma_Cabello
                        ,Color_Cabello = varProbable_Responsable_PC.Color_Cabello
                        ,Calvicie = varProbable_Responsable_PC.Calvicie
                        ,Color_Ojos = varProbable_Responsable_PC.Color_Ojos
                        ,Tamano_de_Ojos = varProbable_Responsable_PC.Tamano_de_Ojos
                        ,Forma_Ojos = varProbable_Responsable_PC.Forma_Ojos
                        ,Anteojos = varProbable_Responsable_PC.Anteojos
                        ,Forma_de_Nariz = varProbable_Responsable_PC.Forma_de_Nariz
                        ,Tamano_Nariz = varProbable_Responsable_PC.Tamano_Nariz
                        ,Labios = varProbable_Responsable_PC.Labios
                        ,Boca = varProbable_Responsable_PC.Boca
                        ,Grosor_de_Labios = varProbable_Responsable_PC.Grosor_de_Labios
                        ,Menton = varProbable_Responsable_PC.Menton
                        ,Forma_de_Menton = varProbable_Responsable_PC.Forma_de_Menton
                        ,Barba = varProbable_Responsable_PC.Barba
                        ,Forma_Orejas = varProbable_Responsable_PC.Forma_Orejas
                        ,Tamano_Orejas = varProbable_Responsable_PC.Tamano_Orejas
                        ,Tipo_Lobulo = varProbable_Responsable_PC.Tipo_Lobulo
                        ,Bigote = varProbable_Responsable_PC.Bigote
                        ,Senas_Particulares = varProbable_Responsable_PC.Senas_Particulares
                        ,Imagen_Tatuaje = (varProbable_Responsable_PC.Imagen_Tatuaje.HasValue && varProbable_Responsable_PC.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varProbable_Responsable_PC.Imagen_Tatuaje.Value)) : null

                        ,Situacion_Fisica = varProbable_Responsable_PC.Situacion_Fisica
                        ,Otras_Senas_Particulares = varProbable_Responsable_PC.Otras_Senas_Particulares
                        ,Imputado_Recluido = varProbable_Responsable_PC.Imputado_Recluido
                    
                };

                result = _IProbable_Responsable_PCApiConsumer.Update_Datos_de_Media_Filiacion(Probable_Responsable_PC_Datos_de_Media_FiliacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_Media_Filiacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProbable_Responsable_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProbable_Responsable_PCApiConsumer.Get_Datos_de_Media_Filiacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Probable_Responsable_PC_Datos_de_Media_FiliacionModel
                {
                    Clave = m.Clave
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_Cara = m.Forma_Cara
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_Cejas = m.Tipo_de_Cejas
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_Cejas = m.Tamano_de_Cejas
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Largo_de_Cabello = m.Largo_de_Cabello
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Cantidad_Cabello = m.Cantidad_Cabello
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_Cabello = m.Implantacion_Cabello
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,Complexion = m.Complexion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_Piel = m.Color_Piel
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,Frente = m.Frente
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_Cabello = m.Forma_Cabello
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_Cabello = m.Color_Cabello
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,Calvicie = m.Calvicie
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_Ojos = m.Color_Ojos
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_Ojos = m.Tamano_de_Ojos
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_Ojos = m.Forma_Ojos
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Anteojos = m.Anteojos
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_Nariz = m.Forma_de_Nariz
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_Nariz = m.Tamano_Nariz
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Nariz_Base.Descripcion
                        ,Labios = m.Labios
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,Boca = m.Boca
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,Grosor_de_Labios = m.Grosor_de_Labios
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,Menton = m.Menton
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,Forma_de_Menton = m.Forma_de_Menton
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,Barba = m.Barba
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_Orejas = m.Forma_Orejas
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_Orejas = m.Tamano_Orejas
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_Lobulo = m.Tipo_Lobulo
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,Bigote = m.Bigote
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Senas_Particulares = m.Senas_Particulares
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
                        ,Situacion_Fisica = m.Situacion_Fisica
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

                    
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

