using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Quejas_de_MP;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_Quejas_MP;
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
using Spartane.Core.Domain.Forma_Ojos;
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
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Quejas_de_MP;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Quejas_de_MP;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Quejas_MP;
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
using Spartane.Web.Areas.WebApiConsumer.Forma_Ojos;
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
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

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
    public class Quejas_de_MPController : Controller
    {
        #region "variable declaration"

        private IQuejas_de_MPService service = null;
        private IQuejas_de_MPApiConsumer _IQuejas_de_MPApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IEstatus_Quejas_MPApiConsumer _IEstatus_Quejas_MPApiConsumer;
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
        private IForma_OjosApiConsumer _IForma_OjosApiConsumer;
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
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;

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

        
        public Quejas_de_MPController(IQuejas_de_MPService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IQuejas_de_MPApiConsumer Quejas_de_MPApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IEstatus_Quejas_MPApiConsumer Estatus_Quejas_MPApiConsumer , IForma_CaraApiConsumer Forma_CaraApiConsumer , ICejasApiConsumer CejasApiConsumer , ITamano_de_CejasApiConsumer Tamano_de_CejasApiConsumer , ILargo_de_CabelloApiConsumer Largo_de_CabelloApiConsumer , ICantidad_CabelloApiConsumer Cantidad_CabelloApiConsumer , IImplantacion_CabelloApiConsumer Implantacion_CabelloApiConsumer , IComplexionApiConsumer ComplexionApiConsumer , IColor_PielApiConsumer Color_PielApiConsumer , IFrenteApiConsumer FrenteApiConsumer , IForma_CabelloApiConsumer Forma_CabelloApiConsumer , IColor_de_CabelloApiConsumer Color_de_CabelloApiConsumer , ICalvicieApiConsumer CalvicieApiConsumer , IColor_OjosApiConsumer Color_OjosApiConsumer , IOjosApiConsumer OjosApiConsumer , IForma_OjosApiConsumer Forma_OjosApiConsumer , IAnteojosApiConsumer AnteojosApiConsumer , IForma_de_NarizApiConsumer Forma_de_NarizApiConsumer , INariz_BaseApiConsumer Nariz_BaseApiConsumer , ILabiosApiConsumer LabiosApiConsumer , IBocaApiConsumer BocaApiConsumer , IGrosor_de_LabiosApiConsumer Grosor_de_LabiosApiConsumer , IMentonApiConsumer MentonApiConsumer , IForma_de_MentonApiConsumer Forma_de_MentonApiConsumer , IBarbaApiConsumer BarbaApiConsumer , IForma_OrejasApiConsumer Forma_OrejasApiConsumer , ITamano_OrejasApiConsumer Tamano_OrejasApiConsumer , ITipo_LobuloApiConsumer Tipo_LobuloApiConsumer , IBigoteApiConsumer BigoteApiConsumer , ISenas_ParticularesApiConsumer Senas_ParticularesApiConsumer , ISituacion_FisicaApiConsumer Situacion_FisicaApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IGeneroApiConsumer GeneroApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEstadoApiConsumer EstadoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IQuejas_de_MPApiConsumer = Quejas_de_MPApiConsumer;
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
            this._IEstatus_Quejas_MPApiConsumer = Estatus_Quejas_MPApiConsumer;
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
            this._IForma_OjosApiConsumer = Forma_OjosApiConsumer;
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
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Quejas_de_MP
        [ObjectAuth(ObjectId = (ModuleObjectId)45738, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45738, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Quejas_de_MP/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45738, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45738, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varQuejas_de_MP = new Quejas_de_MPModel();
			varQuejas_de_MP.Clave = Id;
			
            ViewBag.ObjectId = "45738";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Quejas_de_MPsData = _IQuejas_de_MPApiConsumer.ListaSelAll(0, 1000, "Quejas_de_MP.Clave=" + Id, "").Resource.Quejas_de_MPs;
				
				if (Quejas_de_MPsData != null && Quejas_de_MPsData.Count > 0)
                {
					var Quejas_de_MPData = Quejas_de_MPsData.First();
					varQuejas_de_MP= new Quejas_de_MPModel
					{
						Clave  = Quejas_de_MPData.Clave 
	                    ,Fecha_de_Registro = (Quejas_de_MPData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Quejas_de_MPData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Quejas_de_MPData.Hora_de_Registro
                    ,Usuario_que_Registra = Quejas_de_MPData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Usuario_que_Registra), "Spartan_User") ??  (string)Quejas_de_MPData.Usuario_que_Registra_Spartan_User.Name
                    ,Nombres = Quejas_de_MPData.Nombres
                    ,Apellido_Paterno = Quejas_de_MPData.Apellido_Paterno
                    ,Apellido_Materno = Quejas_de_MPData.Apellido_Materno
                    ,Nombre_Completo = Quejas_de_MPData.Nombre_Completo
                    ,Correo_Electronico = Quejas_de_MPData.Correo_Electronico
                    ,Celular = Quejas_de_MPData.Celular
                    ,Estatus = Quejas_de_MPData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Estatus), "Estatus_Quejas_MP") ??  (string)Quejas_de_MPData.Estatus_Estatus_Quejas_MP.Descripcion
                    ,Peso = Quejas_de_MPData.Peso
                    ,Estatura = Quejas_de_MPData.Estatura
                    ,Padecimiento_de_Enfermedad = Quejas_de_MPData.Padecimiento_de_Enfermedad
                    ,Forma_Cara = Quejas_de_MPData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Cara), "Forma_Cara") ??  (string)Quejas_de_MPData.Forma_Cara_Forma_Cara.Descripcion
                    ,Tipo_de_Cejas = Quejas_de_MPData.Tipo_de_Cejas
                    ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tipo_de_Cejas), "Cejas") ??  (string)Quejas_de_MPData.Tipo_de_Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Quejas_de_MPData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Quejas_de_MPData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Largo_de_Cabello = Quejas_de_MPData.Largo_de_Cabello
                    ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Largo_de_Cabello), "Largo_de_Cabello") ??  (string)Quejas_de_MPData.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                    ,Cantidad_Cabello = Quejas_de_MPData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Quejas_de_MPData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Quejas_de_MPData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Quejas_de_MPData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Quejas_de_MPData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Complexion), "Complexion") ??  (string)Quejas_de_MPData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Quejas_de_MPData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Color_Piel), "Color_Piel") ??  (string)Quejas_de_MPData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Quejas_de_MPData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Frente), "Frente") ??  (string)Quejas_de_MPData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Quejas_de_MPData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Cabello), "Forma_Cabello") ??  (string)Quejas_de_MPData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Quejas_de_MPData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Color_Cabello), "Color_de_Cabello") ??  (string)Quejas_de_MPData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Quejas_de_MPData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Calvicie), "Calvicie") ??  (string)Quejas_de_MPData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Quejas_de_MPData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Color_Ojos), "Color_Ojos") ??  (string)Quejas_de_MPData.Color_Ojos_Color_Ojos.Descripcion
                    ,Tamano_de_Ojos = Quejas_de_MPData.Tamano_de_Ojos
                    ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_de_Ojos), "Ojos") ??  (string)Quejas_de_MPData.Tamano_de_Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Quejas_de_MPData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Ojos), "Forma_Ojos") ??  (string)Quejas_de_MPData.Forma_Ojos_Forma_Ojos.Descripcion
                    ,Anteojos = Quejas_de_MPData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Anteojos), "Anteojos") ??  (string)Quejas_de_MPData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Quejas_de_MPData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Quejas_de_MPData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Tamano_Nariz = Quejas_de_MPData.Tamano_Nariz
                    ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_Nariz), "Nariz_Base") ??  (string)Quejas_de_MPData.Tamano_Nariz_Nariz_Base.Descripcion
                    ,Labios = Quejas_de_MPData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Labios), "Labios") ??  (string)Quejas_de_MPData.Labios_Labios.Descripcion
                    ,Boca = Quejas_de_MPData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Boca), "Boca") ??  (string)Quejas_de_MPData.Boca_Boca.Descripcion
                    ,Grosor_de_Labios = Quejas_de_MPData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Quejas_de_MPData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Menton = Quejas_de_MPData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Menton), "Menton") ??  (string)Quejas_de_MPData.Menton_Menton.Descripcion
                    ,Forma_de_Menton = Quejas_de_MPData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Quejas_de_MPData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Barba = Quejas_de_MPData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Barba), "Barba") ??  (string)Quejas_de_MPData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Quejas_de_MPData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Orejas), "Forma_Orejas") ??  (string)Quejas_de_MPData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Quejas_de_MPData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Quejas_de_MPData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Quejas_de_MPData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Quejas_de_MPData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Quejas_de_MPData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Bigote), "Bigote") ??  (string)Quejas_de_MPData.Bigote_Bigote.Descripcion
                    ,Senas_Particulares = Quejas_de_MPData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Senas_Particulares), "Senas_Particulares") ??  (string)Quejas_de_MPData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Quejas_de_MPData.Imagen_Tatuaje
                    ,Situacion_Fisica = Quejas_de_MPData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Quejas_de_MPData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Otras_Senas_Particulares = Quejas_de_MPData.Otras_Senas_Particulares
                    ,Descripcion_de_los_Hechos = Quejas_de_MPData.Descripcion_de_los_Hechos
                    ,Fecha_de_los_Hechos = (Quejas_de_MPData.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(Quejas_de_MPData.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_los_Hechos = Quejas_de_MPData.Hora_de_los_Hechos
                    ,Municipio_hechos = Quejas_de_MPData.Municipio_hechos
                    ,Municipio_hechosNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Municipio_hechos), "Municipio") ??  (string)Quejas_de_MPData.Municipio_hechos_Municipio.Nombre
                    ,Poblacion_hechos = Quejas_de_MPData.Poblacion_hechos
                    ,Poblacion_hechosNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Poblacion_hechos), "Colonia") ??  (string)Quejas_de_MPData.Poblacion_hechos_Colonia.Nombre
                    ,Colonia_hechos = Quejas_de_MPData.Colonia_hechos
                    ,Colonia_hechosNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Colonia_hechos), "Colonia") ??  (string)Quejas_de_MPData.Colonia_hechos_Colonia.Nombre
                    ,Calle_hechos = Quejas_de_MPData.Calle_hechos
                    ,Entre_Calle_hechos = Quejas_de_MPData.Entre_Calle_hechos
                    ,Y_Calle_hechos = Quejas_de_MPData.Y_Calle_hechos
                    ,Numero_Exterior_hechos = Quejas_de_MPData.Numero_Exterior_hechos
                    ,Numero_Interior_hechos = Quejas_de_MPData.Numero_Interior_hechos
                    ,Codigo_Postal_hechos = Quejas_de_MPData.Codigo_Postal_hechos
                    ,Referencia = Quejas_de_MPData.Referencia
                    ,CURP_Identificacion = Quejas_de_MPData.CURP_Identificacion
                    ,Nombres_Identificacion = Quejas_de_MPData.Nombres_Identificacion
                    ,Apellido_Paterno_Identificacion = Quejas_de_MPData.Apellido_Paterno_Identificacion
                    ,Apellido_Materno_Identificacion = Quejas_de_MPData.Apellido_Materno_Identificacion
                    ,Alias = Quejas_de_MPData.Alias
                    ,Fecha_Nacimiento_Identificacion = (Quejas_de_MPData.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(Quejas_de_MPData.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_Identificacion = Quejas_de_MPData.Edad_Identificacion
                    ,Genero_Identificacion = Quejas_de_MPData.Genero_Identificacion
                    ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Genero_Identificacion), "Genero") ??  (string)Quejas_de_MPData.Genero_Identificacion_Genero.Descripcion
                    ,Celular_Identificacion = Quejas_de_MPData.Celular_Identificacion
                    ,Correo_Identificacion = Quejas_de_MPData.Correo_Identificacion
                    ,Tipo_de_Identificacion_Identificacion = Quejas_de_MPData.Tipo_de_Identificacion_Identificacion
                    ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tipo_de_Identificacion_Identificacion), "Tipo_de_Identificacion") ??  (string)Quejas_de_MPData.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_Identificacion_Identificacion = Quejas_de_MPData.Numero_Identificacion_Identificacion
                    ,Nacionalidad_Identificacion = Quejas_de_MPData.Nacionalidad_Identificacion
                    ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Nacionalidad_Identificacion), "Nacionalidad") ??  (string)Quejas_de_MPData.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                    ,Entidad_de_Nacimiento_Identificacion = Quejas_de_MPData.Entidad_de_Nacimiento_Identificacion
                    ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Entidad_de_Nacimiento_Identificacion), "Estado") ??  (string)Quejas_de_MPData.Entidad_de_Nacimiento_Identificacion_Estado.Nombre
                    ,Municipio = Quejas_de_MPData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Municipio), "Municipio") ??  (string)Quejas_de_MPData.Municipio_Municipio.Nombre
                    ,Poblacion = Quejas_de_MPData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Poblacion), "Colonia") ??  (string)Quejas_de_MPData.Poblacion_Colonia.Nombre
                    ,Colonia = Quejas_de_MPData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Colonia), "Colonia") ??  (string)Quejas_de_MPData.Colonia_Colonia.Nombre
                    ,Calle = Quejas_de_MPData.Calle
                    ,Entre_Calle = Quejas_de_MPData.Entre_Calle
                    ,Y_Calle = Quejas_de_MPData.Y_Calle
                    ,Numero_Exterior = Quejas_de_MPData.Numero_Exterior
                    ,Numero_Interior = Quejas_de_MPData.Numero_Interior
                    ,Codigo_Postal = Quejas_de_MPData.Codigo_Postal
                    ,Referencias_de_domicilio = Quejas_de_MPData.Referencias_de_domicilio

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varQuejas_de_MP.Imagen_Tatuaje).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_Quejas_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Quejas_MPs_Estatus = _IEstatus_Quejas_MPApiConsumer.SelAll(true);
            if (Estatus_Quejas_MPs_Estatus != null && Estatus_Quejas_MPs_Estatus.Resource != null)
                ViewBag.Estatus_Quejas_MPs_Estatus = Estatus_Quejas_MPs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Quejas_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IForma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Ojoss_Forma_Ojos = _IForma_OjosApiConsumer.SelAll(true);
            if (Forma_Ojoss_Forma_Ojos != null && Forma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Forma_Ojoss_Forma_Ojos = Forma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Genero_Identificacion = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Genero_Identificacion != null && Generos_Genero_Identificacion.Resource != null)
                ViewBag.Generos_Genero_Identificacion = Generos_Genero_Identificacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varQuejas_de_MP);
        }
		
	[HttpGet]
        public ActionResult AddQuejas_de_MP(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45738);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
			Quejas_de_MPModel varQuejas_de_MP= new Quejas_de_MPModel();


            if (id.ToString() != "0")
            {
                var Quejas_de_MPsData = _IQuejas_de_MPApiConsumer.ListaSelAll(0, 1000, "Quejas_de_MP.Clave=" + id, "").Resource.Quejas_de_MPs;
				
				if (Quejas_de_MPsData != null && Quejas_de_MPsData.Count > 0)
                {
					var Quejas_de_MPData = Quejas_de_MPsData.First();
					varQuejas_de_MP= new Quejas_de_MPModel
					{
						Clave  = Quejas_de_MPData.Clave 
	                    ,Fecha_de_Registro = (Quejas_de_MPData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Quejas_de_MPData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Quejas_de_MPData.Hora_de_Registro
                    ,Usuario_que_Registra = Quejas_de_MPData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Usuario_que_Registra), "Spartan_User") ??  (string)Quejas_de_MPData.Usuario_que_Registra_Spartan_User.Name
                    ,Nombres = Quejas_de_MPData.Nombres
                    ,Apellido_Paterno = Quejas_de_MPData.Apellido_Paterno
                    ,Apellido_Materno = Quejas_de_MPData.Apellido_Materno
                    ,Nombre_Completo = Quejas_de_MPData.Nombre_Completo
                    ,Correo_Electronico = Quejas_de_MPData.Correo_Electronico
                    ,Celular = Quejas_de_MPData.Celular
                    ,Estatus = Quejas_de_MPData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Estatus), "Estatus_Quejas_MP") ??  (string)Quejas_de_MPData.Estatus_Estatus_Quejas_MP.Descripcion
                    ,Peso = Quejas_de_MPData.Peso
                    ,Estatura = Quejas_de_MPData.Estatura
                    ,Padecimiento_de_Enfermedad = Quejas_de_MPData.Padecimiento_de_Enfermedad
                    ,Forma_Cara = Quejas_de_MPData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Cara), "Forma_Cara") ??  (string)Quejas_de_MPData.Forma_Cara_Forma_Cara.Descripcion
                    ,Tipo_de_Cejas = Quejas_de_MPData.Tipo_de_Cejas
                    ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tipo_de_Cejas), "Cejas") ??  (string)Quejas_de_MPData.Tipo_de_Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Quejas_de_MPData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Quejas_de_MPData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Largo_de_Cabello = Quejas_de_MPData.Largo_de_Cabello
                    ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Largo_de_Cabello), "Largo_de_Cabello") ??  (string)Quejas_de_MPData.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                    ,Cantidad_Cabello = Quejas_de_MPData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Quejas_de_MPData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Quejas_de_MPData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Quejas_de_MPData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Quejas_de_MPData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Complexion), "Complexion") ??  (string)Quejas_de_MPData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Quejas_de_MPData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Color_Piel), "Color_Piel") ??  (string)Quejas_de_MPData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Quejas_de_MPData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Frente), "Frente") ??  (string)Quejas_de_MPData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Quejas_de_MPData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Cabello), "Forma_Cabello") ??  (string)Quejas_de_MPData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Quejas_de_MPData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Color_Cabello), "Color_de_Cabello") ??  (string)Quejas_de_MPData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Quejas_de_MPData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Calvicie), "Calvicie") ??  (string)Quejas_de_MPData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Quejas_de_MPData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Color_Ojos), "Color_Ojos") ??  (string)Quejas_de_MPData.Color_Ojos_Color_Ojos.Descripcion
                    ,Tamano_de_Ojos = Quejas_de_MPData.Tamano_de_Ojos
                    ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_de_Ojos), "Ojos") ??  (string)Quejas_de_MPData.Tamano_de_Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Quejas_de_MPData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Ojos), "Forma_Ojos") ??  (string)Quejas_de_MPData.Forma_Ojos_Forma_Ojos.Descripcion
                    ,Anteojos = Quejas_de_MPData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Anteojos), "Anteojos") ??  (string)Quejas_de_MPData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Quejas_de_MPData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Quejas_de_MPData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Tamano_Nariz = Quejas_de_MPData.Tamano_Nariz
                    ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_Nariz), "Nariz_Base") ??  (string)Quejas_de_MPData.Tamano_Nariz_Nariz_Base.Descripcion
                    ,Labios = Quejas_de_MPData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Labios), "Labios") ??  (string)Quejas_de_MPData.Labios_Labios.Descripcion
                    ,Boca = Quejas_de_MPData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Boca), "Boca") ??  (string)Quejas_de_MPData.Boca_Boca.Descripcion
                    ,Grosor_de_Labios = Quejas_de_MPData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Quejas_de_MPData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Menton = Quejas_de_MPData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Menton), "Menton") ??  (string)Quejas_de_MPData.Menton_Menton.Descripcion
                    ,Forma_de_Menton = Quejas_de_MPData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Quejas_de_MPData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Barba = Quejas_de_MPData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Barba), "Barba") ??  (string)Quejas_de_MPData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Quejas_de_MPData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Forma_Orejas), "Forma_Orejas") ??  (string)Quejas_de_MPData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Quejas_de_MPData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Quejas_de_MPData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Quejas_de_MPData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Quejas_de_MPData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Quejas_de_MPData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Bigote), "Bigote") ??  (string)Quejas_de_MPData.Bigote_Bigote.Descripcion
                    ,Senas_Particulares = Quejas_de_MPData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Senas_Particulares), "Senas_Particulares") ??  (string)Quejas_de_MPData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Quejas_de_MPData.Imagen_Tatuaje
                    ,Situacion_Fisica = Quejas_de_MPData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Quejas_de_MPData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Otras_Senas_Particulares = Quejas_de_MPData.Otras_Senas_Particulares
                    ,Descripcion_de_los_Hechos = Quejas_de_MPData.Descripcion_de_los_Hechos
                    ,Fecha_de_los_Hechos = (Quejas_de_MPData.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(Quejas_de_MPData.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_los_Hechos = Quejas_de_MPData.Hora_de_los_Hechos
                    ,Municipio_hechos = Quejas_de_MPData.Municipio_hechos
                    ,Municipio_hechosNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Municipio_hechos), "Municipio") ??  (string)Quejas_de_MPData.Municipio_hechos_Municipio.Nombre
                    ,Poblacion_hechos = Quejas_de_MPData.Poblacion_hechos
                    ,Poblacion_hechosNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Poblacion_hechos), "Colonia") ??  (string)Quejas_de_MPData.Poblacion_hechos_Colonia.Nombre
                    ,Colonia_hechos = Quejas_de_MPData.Colonia_hechos
                    ,Colonia_hechosNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Colonia_hechos), "Colonia") ??  (string)Quejas_de_MPData.Colonia_hechos_Colonia.Nombre
                    ,Calle_hechos = Quejas_de_MPData.Calle_hechos
                    ,Entre_Calle_hechos = Quejas_de_MPData.Entre_Calle_hechos
                    ,Y_Calle_hechos = Quejas_de_MPData.Y_Calle_hechos
                    ,Numero_Exterior_hechos = Quejas_de_MPData.Numero_Exterior_hechos
                    ,Numero_Interior_hechos = Quejas_de_MPData.Numero_Interior_hechos
                    ,Codigo_Postal_hechos = Quejas_de_MPData.Codigo_Postal_hechos
                    ,Referencia = Quejas_de_MPData.Referencia
                    ,CURP_Identificacion = Quejas_de_MPData.CURP_Identificacion
                    ,Nombres_Identificacion = Quejas_de_MPData.Nombres_Identificacion
                    ,Apellido_Paterno_Identificacion = Quejas_de_MPData.Apellido_Paterno_Identificacion
                    ,Apellido_Materno_Identificacion = Quejas_de_MPData.Apellido_Materno_Identificacion
                    ,Alias = Quejas_de_MPData.Alias
                    ,Fecha_Nacimiento_Identificacion = (Quejas_de_MPData.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(Quejas_de_MPData.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_Identificacion = Quejas_de_MPData.Edad_Identificacion
                    ,Genero_Identificacion = Quejas_de_MPData.Genero_Identificacion
                    ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Genero_Identificacion), "Genero") ??  (string)Quejas_de_MPData.Genero_Identificacion_Genero.Descripcion
                    ,Celular_Identificacion = Quejas_de_MPData.Celular_Identificacion
                    ,Correo_Identificacion = Quejas_de_MPData.Correo_Identificacion
                    ,Tipo_de_Identificacion_Identificacion = Quejas_de_MPData.Tipo_de_Identificacion_Identificacion
                    ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Tipo_de_Identificacion_Identificacion), "Tipo_de_Identificacion") ??  (string)Quejas_de_MPData.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_Identificacion_Identificacion = Quejas_de_MPData.Numero_Identificacion_Identificacion
                    ,Nacionalidad_Identificacion = Quejas_de_MPData.Nacionalidad_Identificacion
                    ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Nacionalidad_Identificacion), "Nacionalidad") ??  (string)Quejas_de_MPData.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                    ,Entidad_de_Nacimiento_Identificacion = Quejas_de_MPData.Entidad_de_Nacimiento_Identificacion
                    ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Entidad_de_Nacimiento_Identificacion), "Estado") ??  (string)Quejas_de_MPData.Entidad_de_Nacimiento_Identificacion_Estado.Nombre
                    ,Municipio = Quejas_de_MPData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Municipio), "Municipio") ??  (string)Quejas_de_MPData.Municipio_Municipio.Nombre
                    ,Poblacion = Quejas_de_MPData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Poblacion), "Colonia") ??  (string)Quejas_de_MPData.Poblacion_Colonia.Nombre
                    ,Colonia = Quejas_de_MPData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Quejas_de_MPData.Colonia), "Colonia") ??  (string)Quejas_de_MPData.Colonia_Colonia.Nombre
                    ,Calle = Quejas_de_MPData.Calle
                    ,Entre_Calle = Quejas_de_MPData.Entre_Calle
                    ,Y_Calle = Quejas_de_MPData.Y_Calle
                    ,Numero_Exterior = Quejas_de_MPData.Numero_Exterior
                    ,Numero_Interior = Quejas_de_MPData.Numero_Interior
                    ,Codigo_Postal = Quejas_de_MPData.Codigo_Postal
                    ,Referencias_de_domicilio = Quejas_de_MPData.Referencias_de_domicilio

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varQuejas_de_MP.Imagen_Tatuaje).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_Quejas_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Quejas_MPs_Estatus = _IEstatus_Quejas_MPApiConsumer.SelAll(true);
            if (Estatus_Quejas_MPs_Estatus != null && Estatus_Quejas_MPs_Estatus.Resource != null)
                ViewBag.Estatus_Quejas_MPs_Estatus = Estatus_Quejas_MPs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Quejas_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IForma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Ojoss_Forma_Ojos = _IForma_OjosApiConsumer.SelAll(true);
            if (Forma_Ojoss_Forma_Ojos != null && Forma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Forma_Ojoss_Forma_Ojos = Forma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Genero_Identificacion = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Genero_Identificacion != null && Generos_Genero_Identificacion.Resource != null)
                ViewBag.Generos_Genero_Identificacion = Generos_Genero_Identificacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddQuejas_de_MP", varQuejas_de_MP);
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
        public ActionResult GetEstatus_Quejas_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_Quejas_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_Quejas_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Quejas_MP", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetForma_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_OjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Ojos", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetNacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC")?? m.NacionalidadC,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Quejas_de_MPAdvanceSearchModel model, int idFilter = -1)
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

            _IEstatus_Quejas_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Quejas_MPs_Estatus = _IEstatus_Quejas_MPApiConsumer.SelAll(true);
            if (Estatus_Quejas_MPs_Estatus != null && Estatus_Quejas_MPs_Estatus.Resource != null)
                ViewBag.Estatus_Quejas_MPs_Estatus = Estatus_Quejas_MPs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Quejas_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IForma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Ojoss_Forma_Ojos = _IForma_OjosApiConsumer.SelAll(true);
            if (Forma_Ojoss_Forma_Ojos != null && Forma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Forma_Ojoss_Forma_Ojos = Forma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Genero_Identificacion = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Genero_Identificacion != null && Generos_Genero_Identificacion.Resource != null)
                ViewBag.Generos_Genero_Identificacion = Generos_Genero_Identificacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_Quejas_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Quejas_MPs_Estatus = _IEstatus_Quejas_MPApiConsumer.SelAll(true);
            if (Estatus_Quejas_MPs_Estatus != null && Estatus_Quejas_MPs_Estatus.Resource != null)
                ViewBag.Estatus_Quejas_MPs_Estatus = Estatus_Quejas_MPs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Quejas_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IForma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Ojoss_Forma_Ojos = _IForma_OjosApiConsumer.SelAll(true);
            if (Forma_Ojoss_Forma_Ojos != null && Forma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Forma_Ojoss_Forma_Ojos = Forma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Genero_Identificacion = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Genero_Identificacion != null && Generos_Genero_Identificacion.Resource != null)
                ViewBag.Generos_Genero_Identificacion = Generos_Genero_Identificacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Quejas_de_MPAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Quejas_de_MPAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Quejas_de_MPAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Quejas_de_MPPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IQuejas_de_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Quejas_de_MPs == null)
                result.Quejas_de_MPs = new List<Quejas_de_MP>();

            return Json(new
            {
                data = result.Quejas_de_MPs.Select(m => new Quejas_de_MPGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Correo_Electronico = m.Correo_Electronico
			,Celular = m.Celular
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Quejas_MP.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Quejas_MP.Descripcion
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
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Forma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Forma_Ojos.Descripcion
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
			,Descripcion_de_los_Hechos = m.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (m.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_los_Hechos = m.Hora_de_los_Hechos
                        ,Municipio_hechosNombre = CultureHelper.GetTraduction(m.Municipio_hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_hechos_Municipio.Nombre
                        ,Poblacion_hechosNombre = CultureHelper.GetTraduction(m.Poblacion_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_hechos_Colonia.Nombre
                        ,Colonia_hechosNombre = CultureHelper.GetTraduction(m.Colonia_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_hechos_Colonia.Nombre
			,Calle_hechos = m.Calle_hechos
			,Entre_Calle_hechos = m.Entre_Calle_hechos
			,Y_Calle_hechos = m.Y_Calle_hechos
			,Numero_Exterior_hechos = m.Numero_Exterior_hechos
			,Numero_Interior_hechos = m.Numero_Interior_hechos
			,Codigo_Postal_hechos = m.Codigo_Postal_hechos
			,Referencia = m.Referencia
			,CURP_Identificacion = m.CURP_Identificacion
			,Nombres_Identificacion = m.Nombres_Identificacion
			,Apellido_Paterno_Identificacion = m.Apellido_Paterno_Identificacion
			,Apellido_Materno_Identificacion = m.Apellido_Materno_Identificacion
			,Alias = m.Alias
                        ,Fecha_Nacimiento_Identificacion = (m.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
			,Edad_Identificacion = m.Edad_Identificacion
                        ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(m.Genero_Identificacion_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Genero_Identificacion_Genero.Descripcion
			,Celular_Identificacion = m.Celular_Identificacion
			,Correo_Identificacion = m.Correo_Identificacion
                        ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_Identificacion_Identificacion = m.Numero_Identificacion_Identificacion
                        ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Identificacion_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                        ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(m.Entidad_de_Nacimiento_Identificacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_de_Nacimiento_Identificacion_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Codigo_Postal = m.Codigo_Postal
			,Referencias_de_domicilio = m.Referencias_de_domicilio

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetQuejas_de_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IQuejas_de_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Quejas_de_MP", m.),
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
        /// Get List of Quejas_de_MP from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Quejas_de_MP Entity</returns>
        public ActionResult GetQuejas_de_MPList(UrlParametersModel param)
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
            _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Quejas_de_MPPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Quejas_de_MPAdvanceSearchModel))
                {
					var advanceFilter =
                    (Quejas_de_MPAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Quejas_de_MPPropertyMapper oQuejas_de_MPPropertyMapper = new Quejas_de_MPPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oQuejas_de_MPPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IQuejas_de_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Quejas_de_MPs == null)
                result.Quejas_de_MPs = new List<Quejas_de_MP>();

            return Json(new
            {
                aaData = result.Quejas_de_MPs.Select(m => new Quejas_de_MPGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Correo_Electronico = m.Correo_Electronico
			,Celular = m.Celular
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Quejas_MP.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Quejas_MP.Descripcion
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
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Forma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Forma_Ojos.Descripcion
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
			,Descripcion_de_los_Hechos = m.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (m.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_los_Hechos = m.Hora_de_los_Hechos
                        ,Municipio_hechosNombre = CultureHelper.GetTraduction(m.Municipio_hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_hechos_Municipio.Nombre
                        ,Poblacion_hechosNombre = CultureHelper.GetTraduction(m.Poblacion_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_hechos_Colonia.Nombre
                        ,Colonia_hechosNombre = CultureHelper.GetTraduction(m.Colonia_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_hechos_Colonia.Nombre
			,Calle_hechos = m.Calle_hechos
			,Entre_Calle_hechos = m.Entre_Calle_hechos
			,Y_Calle_hechos = m.Y_Calle_hechos
			,Numero_Exterior_hechos = m.Numero_Exterior_hechos
			,Numero_Interior_hechos = m.Numero_Interior_hechos
			,Codigo_Postal_hechos = m.Codigo_Postal_hechos
			,Referencia = m.Referencia
			,CURP_Identificacion = m.CURP_Identificacion
			,Nombres_Identificacion = m.Nombres_Identificacion
			,Apellido_Paterno_Identificacion = m.Apellido_Paterno_Identificacion
			,Apellido_Materno_Identificacion = m.Apellido_Materno_Identificacion
			,Alias = m.Alias
                        ,Fecha_Nacimiento_Identificacion = (m.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
			,Edad_Identificacion = m.Edad_Identificacion
                        ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(m.Genero_Identificacion_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Genero_Identificacion_Genero.Descripcion
			,Celular_Identificacion = m.Celular_Identificacion
			,Correo_Identificacion = m.Correo_Identificacion
                        ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_Identificacion_Identificacion = m.Numero_Identificacion_Identificacion
                        ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Identificacion_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                        ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(m.Entidad_de_Nacimiento_Identificacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_de_Nacimiento_Identificacion_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Codigo_Postal = m.Codigo_Postal
			,Referencias_de_domicilio = m.Referencias_de_domicilio

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetQuejas_de_MP_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Municipio_hechos_Municipio(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Poblacion_hechos_Colonia(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Colonia_hechos_Colonia(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Nacionalidad_Identificacion_Nacionalidad(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Nacionalidad.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Nacionalidad.NacionalidadC as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _INacionalidadApiConsumer.ListaSelAll(1, 20,elWhere , " Nacionalidad.NacionalidadC ASC ").Resource;
               
                foreach (var item in result.Nacionalidads)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                    item.NacionalidadC =trans ??item.NacionalidadC;
                }
                return Json(result.Nacionalidads.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetQuejas_de_MP_Entidad_de_Nacimiento_Identificacion_Estado(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Municipio_Municipio(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetQuejas_de_MP_Colonia_Colonia(string query, string where)
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
        public string GetAdvanceFilter(Quejas_de_MPAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Quejas_de_MP.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Quejas_de_MP.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Quejas_de_MP.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Quejas_de_MP.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Quejas_de_MP.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Quejas_de_MP.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Quejas_de_MP.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombres))
            {
                switch (filter.NombresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Nombres LIKE '" + filter.Nombres + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Nombres LIKE '%" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Nombres = '" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Nombres LIKE '%" + filter.Nombres + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Quejas_MP.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Quejas_MP.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Quejas_MP.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Quejas_MP.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Quejas_de_MP.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Peso))
            {
                switch (filter.PesoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Peso LIKE '" + filter.Peso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Peso LIKE '%" + filter.Peso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Peso = '" + filter.Peso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Peso LIKE '%" + filter.Peso + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Estatura))
            {
                switch (filter.EstaturaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Estatura LIKE '" + filter.Estatura + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Estatura LIKE '%" + filter.Estatura + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Estatura = '" + filter.Estatura + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Estatura LIKE '%" + filter.Estatura + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Padecimiento_de_Enfermedad))
            {
                switch (filter.Padecimiento_de_EnfermedadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Padecimiento_de_Enfermedad LIKE '" + filter.Padecimiento_de_Enfermedad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Padecimiento_de_Enfermedad = '" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "%'";
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

                where += " AND Quejas_de_MP.Forma_Cara In (" + Forma_CaraIds + ")";
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

                where += " AND Quejas_de_MP.Tipo_de_Cejas In (" + Tipo_de_CejasIds + ")";
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

                where += " AND Quejas_de_MP.Tamano_de_Cejas In (" + Tamano_de_CejasIds + ")";
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

                where += " AND Quejas_de_MP.Largo_de_Cabello In (" + Largo_de_CabelloIds + ")";
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

                where += " AND Quejas_de_MP.Cantidad_Cabello In (" + Cantidad_CabelloIds + ")";
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

                where += " AND Quejas_de_MP.Implantacion_Cabello In (" + Implantacion_CabelloIds + ")";
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

                where += " AND Quejas_de_MP.Complexion In (" + ComplexionIds + ")";
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

                where += " AND Quejas_de_MP.Color_Piel In (" + Color_PielIds + ")";
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

                where += " AND Quejas_de_MP.Frente In (" + FrenteIds + ")";
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

                where += " AND Quejas_de_MP.Forma_Cabello In (" + Forma_CabelloIds + ")";
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

                where += " AND Quejas_de_MP.Color_Cabello In (" + Color_CabelloIds + ")";
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

                where += " AND Quejas_de_MP.Calvicie In (" + CalvicieIds + ")";
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

                where += " AND Quejas_de_MP.Color_Ojos In (" + Color_OjosIds + ")";
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

                where += " AND Quejas_de_MP.Tamano_de_Ojos In (" + Tamano_de_OjosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Ojos))
            {
                switch (filter.Forma_OjosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Ojos.Descripcion LIKE '" + filter.AdvanceForma_Ojos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Ojos.Descripcion LIKE '%" + filter.AdvanceForma_Ojos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Ojos.Descripcion = '" + filter.AdvanceForma_Ojos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Ojos.Descripcion LIKE '%" + filter.AdvanceForma_Ojos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_OjosMultiple != null && filter.AdvanceForma_OjosMultiple.Count() > 0)
            {
                var Forma_OjosIds = string.Join(",", filter.AdvanceForma_OjosMultiple);

                where += " AND Quejas_de_MP.Forma_Ojos In (" + Forma_OjosIds + ")";
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

                where += " AND Quejas_de_MP.Anteojos In (" + AnteojosIds + ")";
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

                where += " AND Quejas_de_MP.Forma_de_Nariz In (" + Forma_de_NarizIds + ")";
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

                where += " AND Quejas_de_MP.Tamano_Nariz In (" + Tamano_NarizIds + ")";
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

                where += " AND Quejas_de_MP.Labios In (" + LabiosIds + ")";
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

                where += " AND Quejas_de_MP.Boca In (" + BocaIds + ")";
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

                where += " AND Quejas_de_MP.Grosor_de_Labios In (" + Grosor_de_LabiosIds + ")";
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

                where += " AND Quejas_de_MP.Menton In (" + MentonIds + ")";
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

                where += " AND Quejas_de_MP.Forma_de_Menton In (" + Forma_de_MentonIds + ")";
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

                where += " AND Quejas_de_MP.Barba In (" + BarbaIds + ")";
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

                where += " AND Quejas_de_MP.Forma_Orejas In (" + Forma_OrejasIds + ")";
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

                where += " AND Quejas_de_MP.Tamano_Orejas In (" + Tamano_OrejasIds + ")";
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

                where += " AND Quejas_de_MP.Tipo_Lobulo In (" + Tipo_LobuloIds + ")";
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

                where += " AND Quejas_de_MP.Bigote In (" + BigoteIds + ")";
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

                where += " AND Quejas_de_MP.Senas_Particulares In (" + Senas_ParticularesIds + ")";
            }

            if (filter.Imagen_Tatuaje != RadioOptions.NoApply)
                where += " AND Quejas_de_MP.Imagen_Tatuaje " + (filter.Imagen_Tatuaje == RadioOptions.Yes ? ">" : "==") + " 0";

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

                where += " AND Quejas_de_MP.Situacion_Fisica In (" + Situacion_FisicaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Otras_Senas_Particulares))
            {
                switch (filter.Otras_Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Otras_Senas_Particulares LIKE '" + filter.Otras_Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Otras_Senas_Particulares = '" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Descripcion_de_los_Hechos))
            {
                switch (filter.Descripcion_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Descripcion_de_los_Hechos LIKE '" + filter.Descripcion_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Descripcion_de_los_Hechos LIKE '%" + filter.Descripcion_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Descripcion_de_los_Hechos = '" + filter.Descripcion_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Descripcion_de_los_Hechos LIKE '%" + filter.Descripcion_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_los_Hechos) || !string.IsNullOrEmpty(filter.ToFecha_de_los_Hechos))
            {
                var Fecha_de_los_HechosFrom = DateTime.ParseExact(filter.FromFecha_de_los_Hechos, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_los_HechosTo = DateTime.ParseExact(filter.ToFecha_de_los_Hechos, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_los_Hechos))
                    where += " AND Quejas_de_MP.Fecha_de_los_Hechos >= '" + Fecha_de_los_HechosFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_los_Hechos))
                    where += " AND Quejas_de_MP.Fecha_de_los_Hechos <= '" + Fecha_de_los_HechosTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_los_Hechos) || !string.IsNullOrEmpty(filter.ToHora_de_los_Hechos))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_los_Hechos))
                    where += " AND Convert(TIME,Quejas_de_MP.Hora_de_los_Hechos) >='" + filter.FromHora_de_los_Hechos + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_los_Hechos))
                    where += " AND Convert(TIME,Quejas_de_MP.Hora_de_los_Hechos) <='" + filter.ToHora_de_los_Hechos + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_hechos))
            {
                switch (filter.Municipio_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_hechosMultiple != null && filter.AdvanceMunicipio_hechosMultiple.Count() > 0)
            {
                var Municipio_hechosIds = string.Join(",", filter.AdvanceMunicipio_hechosMultiple);

                where += " AND Quejas_de_MP.Municipio_hechos In (" + Municipio_hechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion_hechos))
            {
                switch (filter.Poblacion_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacion_hechosMultiple != null && filter.AdvancePoblacion_hechosMultiple.Count() > 0)
            {
                var Poblacion_hechosIds = string.Join(",", filter.AdvancePoblacion_hechosMultiple);

                where += " AND Quejas_de_MP.Poblacion_hechos In (" + Poblacion_hechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_hechos))
            {
                switch (filter.Colonia_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_hechosMultiple != null && filter.AdvanceColonia_hechosMultiple.Count() > 0)
            {
                var Colonia_hechosIds = string.Join(",", filter.AdvanceColonia_hechosMultiple);

                where += " AND Quejas_de_MP.Colonia_hechos In (" + Colonia_hechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle_hechos))
            {
                switch (filter.Calle_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Calle_hechos LIKE '" + filter.Calle_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Calle_hechos LIKE '%" + filter.Calle_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Calle_hechos = '" + filter.Calle_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Calle_hechos LIKE '%" + filter.Calle_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_hechos))
            {
                switch (filter.Entre_Calle_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Entre_Calle_hechos LIKE '" + filter.Entre_Calle_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Entre_Calle_hechos LIKE '%" + filter.Entre_Calle_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Entre_Calle_hechos = '" + filter.Entre_Calle_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Entre_Calle_hechos LIKE '%" + filter.Entre_Calle_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle_hechos))
            {
                switch (filter.Y_Calle_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Y_Calle_hechos LIKE '" + filter.Y_Calle_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Y_Calle_hechos LIKE '%" + filter.Y_Calle_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Y_Calle_hechos = '" + filter.Y_Calle_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Y_Calle_hechos LIKE '%" + filter.Y_Calle_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_hechos))
            {
                switch (filter.Numero_Exterior_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Numero_Exterior_hechos LIKE '" + filter.Numero_Exterior_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Numero_Exterior_hechos LIKE '%" + filter.Numero_Exterior_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Numero_Exterior_hechos = '" + filter.Numero_Exterior_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Numero_Exterior_hechos LIKE '%" + filter.Numero_Exterior_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_hechos))
            {
                switch (filter.Numero_Interior_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Numero_Interior_hechos LIKE '" + filter.Numero_Interior_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Numero_Interior_hechos LIKE '%" + filter.Numero_Interior_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Numero_Interior_hechos = '" + filter.Numero_Interior_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Numero_Interior_hechos LIKE '%" + filter.Numero_Interior_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_hechos) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_hechos))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_hechos))
                    where += " AND Quejas_de_MP.Codigo_Postal_hechos >= " + filter.FromCodigo_Postal_hechos;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_hechos))
                    where += " AND Quejas_de_MP.Codigo_Postal_hechos <= " + filter.ToCodigo_Postal_hechos;
            }

            if (!string.IsNullOrEmpty(filter.Referencia))
            {
                switch (filter.ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Referencia LIKE '" + filter.Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Referencia LIKE '%" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Referencia = '" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Referencia LIKE '%" + filter.Referencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CURP_Identificacion))
            {
                switch (filter.CURP_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.CURP_Identificacion LIKE '" + filter.CURP_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.CURP_Identificacion LIKE '%" + filter.CURP_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.CURP_Identificacion = '" + filter.CURP_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.CURP_Identificacion LIKE '%" + filter.CURP_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombres_Identificacion))
            {
                switch (filter.Nombres_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Nombres_Identificacion LIKE '" + filter.Nombres_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Nombres_Identificacion LIKE '%" + filter.Nombres_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Nombres_Identificacion = '" + filter.Nombres_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Nombres_Identificacion LIKE '%" + filter.Nombres_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_Identificacion))
            {
                switch (filter.Apellido_Paterno_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Apellido_Paterno_Identificacion LIKE '" + filter.Apellido_Paterno_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Apellido_Paterno_Identificacion LIKE '%" + filter.Apellido_Paterno_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Apellido_Paterno_Identificacion = '" + filter.Apellido_Paterno_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Apellido_Paterno_Identificacion LIKE '%" + filter.Apellido_Paterno_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_Identificacion))
            {
                switch (filter.Apellido_Materno_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Apellido_Materno_Identificacion LIKE '" + filter.Apellido_Materno_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Apellido_Materno_Identificacion LIKE '%" + filter.Apellido_Materno_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Apellido_Materno_Identificacion = '" + filter.Apellido_Materno_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Apellido_Materno_Identificacion LIKE '%" + filter.Apellido_Materno_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Alias))
            {
                switch (filter.AliasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Alias LIKE '" + filter.Alias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Alias LIKE '%" + filter.Alias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Alias = '" + filter.Alias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Alias LIKE '%" + filter.Alias + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Nacimiento_Identificacion) || !string.IsNullOrEmpty(filter.ToFecha_Nacimiento_Identificacion))
            {
                var Fecha_Nacimiento_IdentificacionFrom = DateTime.ParseExact(filter.FromFecha_Nacimiento_Identificacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Nacimiento_IdentificacionTo = DateTime.ParseExact(filter.ToFecha_Nacimiento_Identificacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Nacimiento_Identificacion))
                    where += " AND Quejas_de_MP.Fecha_Nacimiento_Identificacion >= '" + Fecha_Nacimiento_IdentificacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Nacimiento_Identificacion))
                    where += " AND Quejas_de_MP.Fecha_Nacimiento_Identificacion <= '" + Fecha_Nacimiento_IdentificacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad_Identificacion) || !string.IsNullOrEmpty(filter.ToEdad_Identificacion))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad_Identificacion))
                    where += " AND Quejas_de_MP.Edad_Identificacion >= " + filter.FromEdad_Identificacion;
                if (!string.IsNullOrEmpty(filter.ToEdad_Identificacion))
                    where += " AND Quejas_de_MP.Edad_Identificacion <= " + filter.ToEdad_Identificacion;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceGenero_Identificacion))
            {
                switch (filter.Genero_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceGenero_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceGenero_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceGenero_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceGenero_Identificacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGenero_IdentificacionMultiple != null && filter.AdvanceGenero_IdentificacionMultiple.Count() > 0)
            {
                var Genero_IdentificacionIds = string.Join(",", filter.AdvanceGenero_IdentificacionMultiple);

                where += " AND Quejas_de_MP.Genero_Identificacion In (" + Genero_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Celular_Identificacion))
            {
                switch (filter.Celular_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Celular_Identificacion LIKE '" + filter.Celular_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Celular_Identificacion LIKE '%" + filter.Celular_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Celular_Identificacion = '" + filter.Celular_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Celular_Identificacion LIKE '%" + filter.Celular_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Identificacion))
            {
                switch (filter.Correo_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Correo_Identificacion LIKE '" + filter.Correo_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Correo_Identificacion LIKE '%" + filter.Correo_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Correo_Identificacion = '" + filter.Correo_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Correo_Identificacion LIKE '%" + filter.Correo_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion_Identificacion))
            {
                switch (filter.Tipo_de_Identificacion_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_Identificacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Identificacion_IdentificacionMultiple != null && filter.AdvanceTipo_de_Identificacion_IdentificacionMultiple.Count() > 0)
            {
                var Tipo_de_Identificacion_IdentificacionIds = string.Join(",", filter.AdvanceTipo_de_Identificacion_IdentificacionMultiple);

                where += " AND Quejas_de_MP.Tipo_de_Identificacion_Identificacion In (" + Tipo_de_Identificacion_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_Identificacion_Identificacion))
            {
                switch (filter.Numero_Identificacion_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Numero_Identificacion_Identificacion LIKE '" + filter.Numero_Identificacion_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Numero_Identificacion_Identificacion LIKE '%" + filter.Numero_Identificacion_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Numero_Identificacion_Identificacion = '" + filter.Numero_Identificacion_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Numero_Identificacion_Identificacion LIKE '%" + filter.Numero_Identificacion_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad_Identificacion))
            {
                switch (filter.Nacionalidad_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_Identificacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidad_IdentificacionMultiple != null && filter.AdvanceNacionalidad_IdentificacionMultiple.Count() > 0)
            {
                var Nacionalidad_IdentificacionIds = string.Join(",", filter.AdvanceNacionalidad_IdentificacionMultiple);

                where += " AND Quejas_de_MP.Nacionalidad_Identificacion In (" + Nacionalidad_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEntidad_de_Nacimiento_Identificacion))
            {
                switch (filter.Entidad_de_Nacimiento_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEntidad_de_Nacimiento_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_de_Nacimiento_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEntidad_de_Nacimiento_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_de_Nacimiento_Identificacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEntidad_de_Nacimiento_IdentificacionMultiple != null && filter.AdvanceEntidad_de_Nacimiento_IdentificacionMultiple.Count() > 0)
            {
                var Entidad_de_Nacimiento_IdentificacionIds = string.Join(",", filter.AdvanceEntidad_de_Nacimiento_IdentificacionMultiple);

                where += " AND Quejas_de_MP.Entidad_de_Nacimiento_Identificacion In (" + Entidad_de_Nacimiento_IdentificacionIds + ")";
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

                where += " AND Quejas_de_MP.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Quejas_de_MP.Poblacion In (" + PoblacionIds + ")";
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

                where += " AND Quejas_de_MP.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Codigo_Postal))
            {
                switch (filter.Codigo_PostalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Codigo_Postal LIKE '" + filter.Codigo_Postal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Codigo_Postal LIKE '%" + filter.Codigo_Postal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Codigo_Postal = '" + filter.Codigo_Postal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Codigo_Postal LIKE '%" + filter.Codigo_Postal + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencias_de_domicilio))
            {
                switch (filter.Referencias_de_domicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Quejas_de_MP.Referencias_de_domicilio LIKE '" + filter.Referencias_de_domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Quejas_de_MP.Referencias_de_domicilio LIKE '%" + filter.Referencias_de_domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Quejas_de_MP.Referencias_de_domicilio = '" + filter.Referencias_de_domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Quejas_de_MP.Referencias_de_domicilio LIKE '%" + filter.Referencias_de_domicilio + "%'";
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
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

                Quejas_de_MP varQuejas_de_MP = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IQuejas_de_MPApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Quejas_de_MPModel varQuejas_de_MP)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varQuejas_de_MP.Imagen_TatuajeRemoveAttachment != 0 && varQuejas_de_MP.Imagen_TatuajeFile == null)
                    {
                        varQuejas_de_MP.Imagen_Tatuaje = 0;
                    }

                    if (varQuejas_de_MP.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varQuejas_de_MP.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varQuejas_de_MP.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varQuejas_de_MP.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Quejas_de_MPInfo = new Quejas_de_MP
                    {
                        Clave = varQuejas_de_MP.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varQuejas_de_MP.Fecha_de_Registro)) ? DateTime.ParseExact(varQuejas_de_MP.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varQuejas_de_MP.Hora_de_Registro
                        ,Usuario_que_Registra = varQuejas_de_MP.Usuario_que_Registra
                        ,Nombres = varQuejas_de_MP.Nombres
                        ,Apellido_Paterno = varQuejas_de_MP.Apellido_Paterno
                        ,Apellido_Materno = varQuejas_de_MP.Apellido_Materno
                        ,Nombre_Completo = varQuejas_de_MP.Nombre_Completo
                        ,Correo_Electronico = varQuejas_de_MP.Correo_Electronico
                        ,Celular = varQuejas_de_MP.Celular
                        ,Estatus = varQuejas_de_MP.Estatus
                        ,Peso = varQuejas_de_MP.Peso
                        ,Estatura = varQuejas_de_MP.Estatura
                        ,Padecimiento_de_Enfermedad = varQuejas_de_MP.Padecimiento_de_Enfermedad
                        ,Forma_Cara = varQuejas_de_MP.Forma_Cara
                        ,Tipo_de_Cejas = varQuejas_de_MP.Tipo_de_Cejas
                        ,Tamano_de_Cejas = varQuejas_de_MP.Tamano_de_Cejas
                        ,Largo_de_Cabello = varQuejas_de_MP.Largo_de_Cabello
                        ,Cantidad_Cabello = varQuejas_de_MP.Cantidad_Cabello
                        ,Implantacion_Cabello = varQuejas_de_MP.Implantacion_Cabello
                        ,Complexion = varQuejas_de_MP.Complexion
                        ,Color_Piel = varQuejas_de_MP.Color_Piel
                        ,Frente = varQuejas_de_MP.Frente
                        ,Forma_Cabello = varQuejas_de_MP.Forma_Cabello
                        ,Color_Cabello = varQuejas_de_MP.Color_Cabello
                        ,Calvicie = varQuejas_de_MP.Calvicie
                        ,Color_Ojos = varQuejas_de_MP.Color_Ojos
                        ,Tamano_de_Ojos = varQuejas_de_MP.Tamano_de_Ojos
                        ,Forma_Ojos = varQuejas_de_MP.Forma_Ojos
                        ,Anteojos = varQuejas_de_MP.Anteojos
                        ,Forma_de_Nariz = varQuejas_de_MP.Forma_de_Nariz
                        ,Tamano_Nariz = varQuejas_de_MP.Tamano_Nariz
                        ,Labios = varQuejas_de_MP.Labios
                        ,Boca = varQuejas_de_MP.Boca
                        ,Grosor_de_Labios = varQuejas_de_MP.Grosor_de_Labios
                        ,Menton = varQuejas_de_MP.Menton
                        ,Forma_de_Menton = varQuejas_de_MP.Forma_de_Menton
                        ,Barba = varQuejas_de_MP.Barba
                        ,Forma_Orejas = varQuejas_de_MP.Forma_Orejas
                        ,Tamano_Orejas = varQuejas_de_MP.Tamano_Orejas
                        ,Tipo_Lobulo = varQuejas_de_MP.Tipo_Lobulo
                        ,Bigote = varQuejas_de_MP.Bigote
                        ,Senas_Particulares = varQuejas_de_MP.Senas_Particulares
                        ,Imagen_Tatuaje = (varQuejas_de_MP.Imagen_Tatuaje.HasValue && varQuejas_de_MP.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varQuejas_de_MP.Imagen_Tatuaje.Value)) : null

                        ,Situacion_Fisica = varQuejas_de_MP.Situacion_Fisica
                        ,Otras_Senas_Particulares = varQuejas_de_MP.Otras_Senas_Particulares
                        ,Descripcion_de_los_Hechos = varQuejas_de_MP.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (!String.IsNullOrEmpty(varQuejas_de_MP.Fecha_de_los_Hechos)) ? DateTime.ParseExact(varQuejas_de_MP.Fecha_de_los_Hechos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_los_Hechos = varQuejas_de_MP.Hora_de_los_Hechos
                        ,Municipio_hechos = varQuejas_de_MP.Municipio_hechos
                        ,Poblacion_hechos = varQuejas_de_MP.Poblacion_hechos
                        ,Colonia_hechos = varQuejas_de_MP.Colonia_hechos
                        ,Calle_hechos = varQuejas_de_MP.Calle_hechos
                        ,Entre_Calle_hechos = varQuejas_de_MP.Entre_Calle_hechos
                        ,Y_Calle_hechos = varQuejas_de_MP.Y_Calle_hechos
                        ,Numero_Exterior_hechos = varQuejas_de_MP.Numero_Exterior_hechos
                        ,Numero_Interior_hechos = varQuejas_de_MP.Numero_Interior_hechos
                        ,Codigo_Postal_hechos = varQuejas_de_MP.Codigo_Postal_hechos
                        ,Referencia = varQuejas_de_MP.Referencia
                        ,CURP_Identificacion = varQuejas_de_MP.CURP_Identificacion
                        ,Nombres_Identificacion = varQuejas_de_MP.Nombres_Identificacion
                        ,Apellido_Paterno_Identificacion = varQuejas_de_MP.Apellido_Paterno_Identificacion
                        ,Apellido_Materno_Identificacion = varQuejas_de_MP.Apellido_Materno_Identificacion
                        ,Alias = varQuejas_de_MP.Alias
                        ,Fecha_Nacimiento_Identificacion = (!String.IsNullOrEmpty(varQuejas_de_MP.Fecha_Nacimiento_Identificacion)) ? DateTime.ParseExact(varQuejas_de_MP.Fecha_Nacimiento_Identificacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_Identificacion = varQuejas_de_MP.Edad_Identificacion
                        ,Genero_Identificacion = varQuejas_de_MP.Genero_Identificacion
                        ,Celular_Identificacion = varQuejas_de_MP.Celular_Identificacion
                        ,Correo_Identificacion = varQuejas_de_MP.Correo_Identificacion
                        ,Tipo_de_Identificacion_Identificacion = varQuejas_de_MP.Tipo_de_Identificacion_Identificacion
                        ,Numero_Identificacion_Identificacion = varQuejas_de_MP.Numero_Identificacion_Identificacion
                        ,Nacionalidad_Identificacion = varQuejas_de_MP.Nacionalidad_Identificacion
                        ,Entidad_de_Nacimiento_Identificacion = varQuejas_de_MP.Entidad_de_Nacimiento_Identificacion
                        ,Municipio = varQuejas_de_MP.Municipio
                        ,Poblacion = varQuejas_de_MP.Poblacion
                        ,Colonia = varQuejas_de_MP.Colonia
                        ,Calle = varQuejas_de_MP.Calle
                        ,Entre_Calle = varQuejas_de_MP.Entre_Calle
                        ,Y_Calle = varQuejas_de_MP.Y_Calle
                        ,Numero_Exterior = varQuejas_de_MP.Numero_Exterior
                        ,Numero_Interior = varQuejas_de_MP.Numero_Interior
                        ,Codigo_Postal = varQuejas_de_MP.Codigo_Postal
                        ,Referencias_de_domicilio = varQuejas_de_MP.Referencias_de_domicilio

                    };

                    result = !IsNew ?
                        _IQuejas_de_MPApiConsumer.Update(Quejas_de_MPInfo, null, null).Resource.ToString() :
                         _IQuejas_de_MPApiConsumer.Insert(Quejas_de_MPInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Quejas_de_MP script
        /// </summary>
        /// <param name="oQuejas_de_MPElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Quejas_de_MPModuleAttributeList)
        {
            for (int i = 0; i < Quejas_de_MPModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Quejas_de_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Quejas_de_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Quejas_de_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Quejas_de_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Quejas_de_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Quejas_de_MPModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Quejas_de_MPModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Quejas_de_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Quejas_de_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Quejas_de_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Quejas_de_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strQuejas_de_MPScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Quejas_de_MP.js")))
            {
                strQuejas_de_MPScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Quejas_de_MP element attributes
            string userChangeJson = jsSerialize.Serialize(Quejas_de_MPModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strQuejas_de_MPScript.IndexOf("inpuElementArray");
            string splittedString = strQuejas_de_MPScript.Substring(indexOfArray, strQuejas_de_MPScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Quejas_de_MPModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Quejas_de_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strQuejas_de_MPScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strQuejas_de_MPScript.Substring(indexOfArrayHistory, strQuejas_de_MPScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strQuejas_de_MPScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strQuejas_de_MPScript.Substring(endIndexOfMainElement + indexOfArray, strQuejas_de_MPScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Quejas_de_MPModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Quejas_de_MPModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Quejas_de_MP.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Quejas_de_MP.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Quejas_de_MP.js")))
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
        public ActionResult Quejas_de_MPPropertyBag()
        {
            return PartialView("Quejas_de_MPPropertyBag", "Quejas_de_MP");
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
                var whereClauseFormat = "Object = 45738 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Quejas_de_MP.Clave= " + RecordId;
                            var result = _IQuejas_de_MPApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Quejas_de_MPPropertyMapper());
			
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
                    (Quejas_de_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Quejas_de_MPPropertyMapper oQuejas_de_MPPropertyMapper = new Quejas_de_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oQuejas_de_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IQuejas_de_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Quejas_de_MPs == null)
                result.Quejas_de_MPs = new List<Quejas_de_MP>();

            var data = result.Quejas_de_MPs.Select(m => new Quejas_de_MPGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Correo_Electronico = m.Correo_Electronico
			,Celular = m.Celular
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Quejas_MP.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Quejas_MP.Descripcion
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
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Forma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Forma_Ojos.Descripcion
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
			,Descripcion_de_los_Hechos = m.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (m.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_los_Hechos = m.Hora_de_los_Hechos
                        ,Municipio_hechosNombre = CultureHelper.GetTraduction(m.Municipio_hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_hechos_Municipio.Nombre
                        ,Poblacion_hechosNombre = CultureHelper.GetTraduction(m.Poblacion_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_hechos_Colonia.Nombre
                        ,Colonia_hechosNombre = CultureHelper.GetTraduction(m.Colonia_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_hechos_Colonia.Nombre
			,Calle_hechos = m.Calle_hechos
			,Entre_Calle_hechos = m.Entre_Calle_hechos
			,Y_Calle_hechos = m.Y_Calle_hechos
			,Numero_Exterior_hechos = m.Numero_Exterior_hechos
			,Numero_Interior_hechos = m.Numero_Interior_hechos
			,Codigo_Postal_hechos = m.Codigo_Postal_hechos
			,Referencia = m.Referencia
			,CURP_Identificacion = m.CURP_Identificacion
			,Nombres_Identificacion = m.Nombres_Identificacion
			,Apellido_Paterno_Identificacion = m.Apellido_Paterno_Identificacion
			,Apellido_Materno_Identificacion = m.Apellido_Materno_Identificacion
			,Alias = m.Alias
                        ,Fecha_Nacimiento_Identificacion = (m.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
			,Edad_Identificacion = m.Edad_Identificacion
                        ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(m.Genero_Identificacion_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Genero_Identificacion_Genero.Descripcion
			,Celular_Identificacion = m.Celular_Identificacion
			,Correo_Identificacion = m.Correo_Identificacion
                        ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_Identificacion_Identificacion = m.Numero_Identificacion_Identificacion
                        ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Identificacion_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                        ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(m.Entidad_de_Nacimiento_Identificacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_de_Nacimiento_Identificacion_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Codigo_Postal = m.Codigo_Postal
			,Referencias_de_domicilio = m.Referencias_de_domicilio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45738, arrayColumnsVisible), "Quejas_de_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45738, arrayColumnsVisible), "Quejas_de_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45738, arrayColumnsVisible), "Quejas_de_MPList_" + DateTime.Now.ToString());
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

            _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Quejas_de_MPPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Quejas_de_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Quejas_de_MPPropertyMapper oQuejas_de_MPPropertyMapper = new Quejas_de_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oQuejas_de_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IQuejas_de_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Quejas_de_MPs == null)
                result.Quejas_de_MPs = new List<Quejas_de_MP>();

            var data = result.Quejas_de_MPs.Select(m => new Quejas_de_MPGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Correo_Electronico = m.Correo_Electronico
			,Celular = m.Celular
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Quejas_MP.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Quejas_MP.Descripcion
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
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Forma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Forma_Ojos.Descripcion
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
			,Descripcion_de_los_Hechos = m.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (m.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_los_Hechos = m.Hora_de_los_Hechos
                        ,Municipio_hechosNombre = CultureHelper.GetTraduction(m.Municipio_hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_hechos_Municipio.Nombre
                        ,Poblacion_hechosNombre = CultureHelper.GetTraduction(m.Poblacion_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_hechos_Colonia.Nombre
                        ,Colonia_hechosNombre = CultureHelper.GetTraduction(m.Colonia_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_hechos_Colonia.Nombre
			,Calle_hechos = m.Calle_hechos
			,Entre_Calle_hechos = m.Entre_Calle_hechos
			,Y_Calle_hechos = m.Y_Calle_hechos
			,Numero_Exterior_hechos = m.Numero_Exterior_hechos
			,Numero_Interior_hechos = m.Numero_Interior_hechos
			,Codigo_Postal_hechos = m.Codigo_Postal_hechos
			,Referencia = m.Referencia
			,CURP_Identificacion = m.CURP_Identificacion
			,Nombres_Identificacion = m.Nombres_Identificacion
			,Apellido_Paterno_Identificacion = m.Apellido_Paterno_Identificacion
			,Apellido_Materno_Identificacion = m.Apellido_Materno_Identificacion
			,Alias = m.Alias
                        ,Fecha_Nacimiento_Identificacion = (m.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
			,Edad_Identificacion = m.Edad_Identificacion
                        ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(m.Genero_Identificacion_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Genero_Identificacion_Genero.Descripcion
			,Celular_Identificacion = m.Celular_Identificacion
			,Correo_Identificacion = m.Correo_Identificacion
                        ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_Identificacion_Identificacion = m.Numero_Identificacion_Identificacion
                        ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Identificacion_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                        ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(m.Entidad_de_Nacimiento_Identificacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_de_Nacimiento_Identificacion_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Codigo_Postal = m.Codigo_Postal
			,Referencias_de_domicilio = m.Referencias_de_domicilio

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
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IQuejas_de_MPApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Quejas_de_MP_Datos_GeneralesModel varQuejas_de_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Quejas_de_MP_Datos_GeneralesInfo = new Quejas_de_MP_Datos_Generales
                {
                    Clave = varQuejas_de_MP.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varQuejas_de_MP.Fecha_de_Registro)) ? DateTime.ParseExact(varQuejas_de_MP.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varQuejas_de_MP.Hora_de_Registro
                        ,Usuario_que_Registra = varQuejas_de_MP.Usuario_que_Registra
                        ,Nombres = varQuejas_de_MP.Nombres
                        ,Apellido_Paterno = varQuejas_de_MP.Apellido_Paterno
                        ,Apellido_Materno = varQuejas_de_MP.Apellido_Materno
                        ,Nombre_Completo = varQuejas_de_MP.Nombre_Completo
                        ,Correo_Electronico = varQuejas_de_MP.Correo_Electronico
                        ,Celular = varQuejas_de_MP.Celular
                        ,Estatus = varQuejas_de_MP.Estatus
                    
                };

                result = _IQuejas_de_MPApiConsumer.Update_Datos_Generales(Quejas_de_MP_Datos_GeneralesInfo).Resource.ToString();
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
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IQuejas_de_MPApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Quejas_de_MP_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Correo_Electronico = m.Correo_Electronico
			,Celular = m.Celular
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Quejas_MP.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Quejas_MP.Descripcion

                    
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
        public ActionResult Post_Rasgos_Fisicos(Quejas_de_MP_Rasgos_FisicosModel varQuejas_de_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varQuejas_de_MP.Imagen_TatuajeRemoveAttachment != 0 && varQuejas_de_MP.Imagen_TatuajeFile == null)
                    {
                        varQuejas_de_MP.Imagen_Tatuaje = 0;
                    }

                    if (varQuejas_de_MP.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varQuejas_de_MP.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varQuejas_de_MP.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varQuejas_de_MP.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Quejas_de_MP_Rasgos_FisicosInfo = new Quejas_de_MP_Rasgos_Fisicos
                {
                    Clave = varQuejas_de_MP.Clave
                                            ,Peso = varQuejas_de_MP.Peso
                        ,Estatura = varQuejas_de_MP.Estatura
                        ,Padecimiento_de_Enfermedad = varQuejas_de_MP.Padecimiento_de_Enfermedad
                        ,Forma_Cara = varQuejas_de_MP.Forma_Cara
                        ,Tipo_de_Cejas = varQuejas_de_MP.Tipo_de_Cejas
                        ,Tamano_de_Cejas = varQuejas_de_MP.Tamano_de_Cejas
                        ,Largo_de_Cabello = varQuejas_de_MP.Largo_de_Cabello
                        ,Cantidad_Cabello = varQuejas_de_MP.Cantidad_Cabello
                        ,Implantacion_Cabello = varQuejas_de_MP.Implantacion_Cabello
                        ,Complexion = varQuejas_de_MP.Complexion
                        ,Color_Piel = varQuejas_de_MP.Color_Piel
                        ,Frente = varQuejas_de_MP.Frente
                        ,Forma_Cabello = varQuejas_de_MP.Forma_Cabello
                        ,Color_Cabello = varQuejas_de_MP.Color_Cabello
                        ,Calvicie = varQuejas_de_MP.Calvicie
                        ,Color_Ojos = varQuejas_de_MP.Color_Ojos
                        ,Tamano_de_Ojos = varQuejas_de_MP.Tamano_de_Ojos
                        ,Forma_Ojos = varQuejas_de_MP.Forma_Ojos
                        ,Anteojos = varQuejas_de_MP.Anteojos
                        ,Forma_de_Nariz = varQuejas_de_MP.Forma_de_Nariz
                        ,Tamano_Nariz = varQuejas_de_MP.Tamano_Nariz
                        ,Labios = varQuejas_de_MP.Labios
                        ,Boca = varQuejas_de_MP.Boca
                        ,Grosor_de_Labios = varQuejas_de_MP.Grosor_de_Labios
                        ,Menton = varQuejas_de_MP.Menton
                        ,Forma_de_Menton = varQuejas_de_MP.Forma_de_Menton
                        ,Barba = varQuejas_de_MP.Barba
                        ,Forma_Orejas = varQuejas_de_MP.Forma_Orejas
                        ,Tamano_Orejas = varQuejas_de_MP.Tamano_Orejas
                        ,Tipo_Lobulo = varQuejas_de_MP.Tipo_Lobulo
                        ,Bigote = varQuejas_de_MP.Bigote
                        ,Senas_Particulares = varQuejas_de_MP.Senas_Particulares
                        ,Imagen_Tatuaje = (varQuejas_de_MP.Imagen_Tatuaje.HasValue && varQuejas_de_MP.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varQuejas_de_MP.Imagen_Tatuaje.Value)) : null

                        ,Situacion_Fisica = varQuejas_de_MP.Situacion_Fisica
                        ,Otras_Senas_Particulares = varQuejas_de_MP.Otras_Senas_Particulares
                    
                };

                result = _IQuejas_de_MPApiConsumer.Update_Rasgos_Fisicos(Quejas_de_MP_Rasgos_FisicosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Rasgos_Fisicos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IQuejas_de_MPApiConsumer.Get_Rasgos_Fisicos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Quejas_de_MP_Rasgos_FisicosModel
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
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Forma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Forma_Ojos.Descripcion
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
        public ActionResult Post_Hechos_Sucedidos(Quejas_de_MP_Hechos_SucedidosModel varQuejas_de_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Quejas_de_MP_Hechos_SucedidosInfo = new Quejas_de_MP_Hechos_Sucedidos
                {
                    Clave = varQuejas_de_MP.Clave
                                            ,Descripcion_de_los_Hechos = varQuejas_de_MP.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (!String.IsNullOrEmpty(varQuejas_de_MP.Fecha_de_los_Hechos)) ? DateTime.ParseExact(varQuejas_de_MP.Fecha_de_los_Hechos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_los_Hechos = varQuejas_de_MP.Hora_de_los_Hechos
                        ,Municipio_hechos = varQuejas_de_MP.Municipio_hechos
                        ,Poblacion_hechos = varQuejas_de_MP.Poblacion_hechos
                        ,Colonia_hechos = varQuejas_de_MP.Colonia_hechos
                        ,Calle_hechos = varQuejas_de_MP.Calle_hechos
                        ,Entre_Calle_hechos = varQuejas_de_MP.Entre_Calle_hechos
                        ,Y_Calle_hechos = varQuejas_de_MP.Y_Calle_hechos
                        ,Numero_Exterior_hechos = varQuejas_de_MP.Numero_Exterior_hechos
                        ,Numero_Interior_hechos = varQuejas_de_MP.Numero_Interior_hechos
                        ,Codigo_Postal_hechos = varQuejas_de_MP.Codigo_Postal_hechos
                        ,Referencia = varQuejas_de_MP.Referencia
                    
                };

                result = _IQuejas_de_MPApiConsumer.Update_Hechos_Sucedidos(Quejas_de_MP_Hechos_SucedidosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Hechos_Sucedidos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IQuejas_de_MPApiConsumer.Get_Hechos_Sucedidos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Quejas_de_MP_Hechos_SucedidosModel
                {
                    Clave = m.Clave
			,Descripcion_de_los_Hechos = m.Descripcion_de_los_Hechos
                        ,Fecha_de_los_Hechos = (m.Fecha_de_los_Hechos == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_los_Hechos).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_los_Hechos = m.Hora_de_los_Hechos
                        ,Municipio_hechos = m.Municipio_hechos
                        ,Municipio_hechosNombre = CultureHelper.GetTraduction(m.Municipio_hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_hechos_Municipio.Nombre
                        ,Poblacion_hechos = m.Poblacion_hechos
                        ,Poblacion_hechosNombre = CultureHelper.GetTraduction(m.Poblacion_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_hechos_Colonia.Nombre
                        ,Colonia_hechos = m.Colonia_hechos
                        ,Colonia_hechosNombre = CultureHelper.GetTraduction(m.Colonia_hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_hechos_Colonia.Nombre
			,Calle_hechos = m.Calle_hechos
			,Entre_Calle_hechos = m.Entre_Calle_hechos
			,Y_Calle_hechos = m.Y_Calle_hechos
			,Numero_Exterior_hechos = m.Numero_Exterior_hechos
			,Numero_Interior_hechos = m.Numero_Interior_hechos
			,Codigo_Postal_hechos = m.Codigo_Postal_hechos
			,Referencia = m.Referencia

                    
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
        public ActionResult Post_Identificacion_del_Servidor_Publico(Quejas_de_MP_Identificacion_del_Servidor_PublicoModel varQuejas_de_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Quejas_de_MP_Identificacion_del_Servidor_PublicoInfo = new Quejas_de_MP_Identificacion_del_Servidor_Publico
                {
                    Clave = varQuejas_de_MP.Clave
                                            ,CURP_Identificacion = varQuejas_de_MP.CURP_Identificacion
                        ,Nombres_Identificacion = varQuejas_de_MP.Nombres_Identificacion
                        ,Apellido_Paterno_Identificacion = varQuejas_de_MP.Apellido_Paterno_Identificacion
                        ,Apellido_Materno_Identificacion = varQuejas_de_MP.Apellido_Materno_Identificacion
                        ,Alias = varQuejas_de_MP.Alias
                        ,Fecha_Nacimiento_Identificacion = (!String.IsNullOrEmpty(varQuejas_de_MP.Fecha_Nacimiento_Identificacion)) ? DateTime.ParseExact(varQuejas_de_MP.Fecha_Nacimiento_Identificacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_Identificacion = varQuejas_de_MP.Edad_Identificacion
                        ,Genero_Identificacion = varQuejas_de_MP.Genero_Identificacion
                        ,Celular_Identificacion = varQuejas_de_MP.Celular_Identificacion
                        ,Correo_Identificacion = varQuejas_de_MP.Correo_Identificacion
                        ,Tipo_de_Identificacion_Identificacion = varQuejas_de_MP.Tipo_de_Identificacion_Identificacion
                        ,Numero_Identificacion_Identificacion = varQuejas_de_MP.Numero_Identificacion_Identificacion
                        ,Nacionalidad_Identificacion = varQuejas_de_MP.Nacionalidad_Identificacion
                        ,Entidad_de_Nacimiento_Identificacion = varQuejas_de_MP.Entidad_de_Nacimiento_Identificacion
                    
                };

                result = _IQuejas_de_MPApiConsumer.Update_Identificacion_del_Servidor_Publico(Quejas_de_MP_Identificacion_del_Servidor_PublicoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Identificacion_del_Servidor_Publico(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IQuejas_de_MPApiConsumer.Get_Identificacion_del_Servidor_Publico(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Quejas_de_MP_Identificacion_del_Servidor_PublicoModel
                {
                    Clave = m.Clave
			,CURP_Identificacion = m.CURP_Identificacion
			,Nombres_Identificacion = m.Nombres_Identificacion
			,Apellido_Paterno_Identificacion = m.Apellido_Paterno_Identificacion
			,Apellido_Materno_Identificacion = m.Apellido_Materno_Identificacion
			,Alias = m.Alias
                        ,Fecha_Nacimiento_Identificacion = (m.Fecha_Nacimiento_Identificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento_Identificacion).ToString(ConfigurationProperty.DateFormat))
			,Edad_Identificacion = m.Edad_Identificacion
                        ,Genero_Identificacion = m.Genero_Identificacion
                        ,Genero_IdentificacionDescripcion = CultureHelper.GetTraduction(m.Genero_Identificacion_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Genero_Identificacion_Genero.Descripcion
			,Celular_Identificacion = m.Celular_Identificacion
			,Correo_Identificacion = m.Correo_Identificacion
                        ,Tipo_de_Identificacion_Identificacion = m.Tipo_de_Identificacion_Identificacion
                        ,Tipo_de_Identificacion_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_Identificacion_Identificacion = m.Numero_Identificacion_Identificacion
                        ,Nacionalidad_Identificacion = m.Nacionalidad_Identificacion
                        ,Nacionalidad_IdentificacionNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Identificacion_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Identificacion_Nacionalidad.NacionalidadC
                        ,Entidad_de_Nacimiento_Identificacion = m.Entidad_de_Nacimiento_Identificacion
                        ,Entidad_de_Nacimiento_IdentificacionNombre = CultureHelper.GetTraduction(m.Entidad_de_Nacimiento_Identificacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_de_Nacimiento_Identificacion_Estado.Nombre

                    
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
        public ActionResult Post_Domicilio_del_Servidor_Publico(Quejas_de_MP_Domicilio_del_Servidor_PublicoModel varQuejas_de_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Quejas_de_MP_Domicilio_del_Servidor_PublicoInfo = new Quejas_de_MP_Domicilio_del_Servidor_Publico
                {
                    Clave = varQuejas_de_MP.Clave
                                            ,Municipio = varQuejas_de_MP.Municipio
                        ,Poblacion = varQuejas_de_MP.Poblacion
                        ,Colonia = varQuejas_de_MP.Colonia
                        ,Calle = varQuejas_de_MP.Calle
                        ,Entre_Calle = varQuejas_de_MP.Entre_Calle
                        ,Y_Calle = varQuejas_de_MP.Y_Calle
                        ,Numero_Exterior = varQuejas_de_MP.Numero_Exterior
                        ,Numero_Interior = varQuejas_de_MP.Numero_Interior
                        ,Codigo_Postal = varQuejas_de_MP.Codigo_Postal
                        ,Referencias_de_domicilio = varQuejas_de_MP.Referencias_de_domicilio
                    
                };

                result = _IQuejas_de_MPApiConsumer.Update_Domicilio_del_Servidor_Publico(Quejas_de_MP_Domicilio_del_Servidor_PublicoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Domicilio_del_Servidor_Publico(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQuejas_de_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IQuejas_de_MPApiConsumer.Get_Domicilio_del_Servidor_Publico(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Quejas_de_MP_Domicilio_del_Servidor_PublicoModel
                {
                    Clave = m.Clave
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Codigo_Postal = m.Codigo_Postal
			,Referencias_de_domicilio = m.Referencias_de_domicilio

                    
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

