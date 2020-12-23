using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Institucion_Emisora;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Detalle_de_Domicilio;

using Spartane.Core.Domain.Tipo_de_Domicilio;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;






using Spartane.Core.Domain.Detalle_de_telefono;

using Spartane.Core.Domain.Tipo_de_Telefono;



using Spartane.Core.Domain.Detalle_de_Otro_Nombre;






using Spartane.Core.Domain.Tipo_de_Orden;
using Spartane.Core.Domain.Ambito;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Especialidad_MP;
using Spartane.Core.Domain.Tipo_de_Cuantia;
using Spartane.Core.Domain.Detalle_de_Delito_Mandamiento_Judicial;

using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Modalidad_Delito;

using Spartane.Core.Domain.Detalle_de_Amparo;

using Spartane.Core.Domain.Tipo_de_Amparo;


using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Resolucion;

using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
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
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tamano_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Core.Domain.Fuerzo;
using Spartane.Core.Domain.Tipo_de_Mandamiento;
using Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso;
using Spartane.Core.Domain.Tipo_de_Proceso;
using Spartane.Core.Domain.Tipo_de_Extradiccion;
using Spartane.Core.Domain.Detalle_de_Fotos;





using Spartane.Core.Domain.Detalle_de_Documentos_Mandamiento_Judicial;




using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Institucion_Emisora;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Juzgado;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Domicilio;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Domicilio;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_telefono;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Telefono;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Otro_Nombre;


using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Orden;
using Spartane.Web.Areas.WebApiConsumer.Ambito;
using Spartane.Web.Areas.WebApiConsumer.Juzgado;
using Spartane.Web.Areas.WebApiConsumer.Especialidad_MP;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Cuantia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito_Mandamiento_Judicial;

using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Amparo;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Amparo;

using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Resolucion;

using Spartane.Web.Areas.WebApiConsumer.Forma_Cara;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
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
using Spartane.Web.Areas.WebApiConsumer.Nariz_Base;
using Spartane.Web.Areas.WebApiConsumer.Labios;
using Spartane.Web.Areas.WebApiConsumer.Boca;
using Spartane.Web.Areas.WebApiConsumer.Menton;
using Spartane.Web.Areas.WebApiConsumer.Barba;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Lobulo;
using Spartane.Web.Areas.WebApiConsumer.Bigote;
using Spartane.Web.Areas.WebApiConsumer.Situacion_Fisica;
using Spartane.Web.Areas.WebApiConsumer.Fuerzo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Mandamiento;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_Cancelacion_del_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Extradiccion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Fotos;





using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_Mandamiento_Judicial;




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
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IInstitucion_EmisoraApiConsumer _IInstitucion_EmisoraApiConsumer;
        private IJuzgadoApiConsumer _IJuzgadoApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IDetalle_de_DomicilioApiConsumer _IDetalle_de_DomicilioApiConsumer;

        private ITipo_de_DomicilioApiConsumer _ITipo_de_DomicilioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;

        private IDetalle_de_telefonoApiConsumer _IDetalle_de_telefonoApiConsumer;

        private ITipo_de_TelefonoApiConsumer _ITipo_de_TelefonoApiConsumer;

        private IDetalle_de_Otro_NombreApiConsumer _IDetalle_de_Otro_NombreApiConsumer;


        private ITipo_de_OrdenApiConsumer _ITipo_de_OrdenApiConsumer;
        private IAmbitoApiConsumer _IAmbitoApiConsumer;
        private IEspecialidad_MPApiConsumer _IEspecialidad_MPApiConsumer;
        private ITipo_de_CuantiaApiConsumer _ITipo_de_CuantiaApiConsumer;
        private IDetalle_de_Delito_Mandamiento_JudicialApiConsumer _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer;

        private IDelitoApiConsumer _IDelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;

        private IDetalle_de_AmparoApiConsumer _IDetalle_de_AmparoApiConsumer;

        private ITipo_de_AmparoApiConsumer _ITipo_de_AmparoApiConsumer;

        private ITipo_de_ResolucionApiConsumer _ITipo_de_ResolucionApiConsumer;

        private IForma_CaraApiConsumer _IForma_CaraApiConsumer;
        private ICejasApiConsumer _ICejasApiConsumer;
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
        private INariz_BaseApiConsumer _INariz_BaseApiConsumer;
        private ILabiosApiConsumer _ILabiosApiConsumer;
        private IBocaApiConsumer _IBocaApiConsumer;
        private IMentonApiConsumer _IMentonApiConsumer;
        private IBarbaApiConsumer _IBarbaApiConsumer;
        private IForma_OrejasApiConsumer _IForma_OrejasApiConsumer;
        private ITamano_OrejasApiConsumer _ITamano_OrejasApiConsumer;
        private ITipo_LobuloApiConsumer _ITipo_LobuloApiConsumer;
        private IBigoteApiConsumer _IBigoteApiConsumer;
        private ISituacion_FisicaApiConsumer _ISituacion_FisicaApiConsumer;
        private IFuerzoApiConsumer _IFuerzoApiConsumer;
        private ITipo_de_MandamientoApiConsumer _ITipo_de_MandamientoApiConsumer;
        private IMotivo_de_Cancelacion_del_ProcesoApiConsumer _IMotivo_de_Cancelacion_del_ProcesoApiConsumer;
        private ITipo_de_ProcesoApiConsumer _ITipo_de_ProcesoApiConsumer;
        private ITipo_de_ExtradiccionApiConsumer _ITipo_de_ExtradiccionApiConsumer;
        private IDetalle_de_FotosApiConsumer _IDetalle_de_FotosApiConsumer;





        private IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer;




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

        
        public Registro_de_Mandamiento_JudicialController(IRegistro_de_Mandamiento_JudicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_Mandamiento_JudicialApiConsumer Registro_de_Mandamiento_JudicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IInstitucion_EmisoraApiConsumer Institucion_EmisoraApiConsumer , IJuzgadoApiConsumer JuzgadoApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IDetalle_de_DomicilioApiConsumer Detalle_de_DomicilioApiConsumer , ITipo_de_DomicilioApiConsumer Tipo_de_DomicilioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer  , IDetalle_de_telefonoApiConsumer Detalle_de_telefonoApiConsumer , ITipo_de_TelefonoApiConsumer Tipo_de_TelefonoApiConsumer  , IDetalle_de_Otro_NombreApiConsumer Detalle_de_Otro_NombreApiConsumer  , ITipo_de_OrdenApiConsumer Tipo_de_OrdenApiConsumer , IAmbitoApiConsumer AmbitoApiConsumer , IEspecialidad_MPApiConsumer Especialidad_MPApiConsumer , ITipo_de_CuantiaApiConsumer Tipo_de_CuantiaApiConsumer , IDetalle_de_Delito_Mandamiento_JudicialApiConsumer Detalle_de_Delito_Mandamiento_JudicialApiConsumer , IDelitoApiConsumer DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer  , IDetalle_de_AmparoApiConsumer Detalle_de_AmparoApiConsumer , ITipo_de_AmparoApiConsumer Tipo_de_AmparoApiConsumer , ITipo_de_ResolucionApiConsumer Tipo_de_ResolucionApiConsumer  , IForma_CaraApiConsumer Forma_CaraApiConsumer , ICejasApiConsumer CejasApiConsumer , ICantidad_CabelloApiConsumer Cantidad_CabelloApiConsumer , IImplantacion_CabelloApiConsumer Implantacion_CabelloApiConsumer , IComplexionApiConsumer ComplexionApiConsumer , IColor_PielApiConsumer Color_PielApiConsumer , IFrenteApiConsumer FrenteApiConsumer , IForma_CabelloApiConsumer Forma_CabelloApiConsumer , IColor_de_CabelloApiConsumer Color_de_CabelloApiConsumer , ICalvicieApiConsumer CalvicieApiConsumer , IColor_OjosApiConsumer Color_OjosApiConsumer , IOjosApiConsumer OjosApiConsumer , IFroma_OjosApiConsumer Froma_OjosApiConsumer , INariz_BaseApiConsumer Nariz_BaseApiConsumer , ILabiosApiConsumer LabiosApiConsumer , IBocaApiConsumer BocaApiConsumer , IMentonApiConsumer MentonApiConsumer , IBarbaApiConsumer BarbaApiConsumer , IForma_OrejasApiConsumer Forma_OrejasApiConsumer , ITamano_OrejasApiConsumer Tamano_OrejasApiConsumer , ITipo_LobuloApiConsumer Tipo_LobuloApiConsumer , IBigoteApiConsumer BigoteApiConsumer , ISituacion_FisicaApiConsumer Situacion_FisicaApiConsumer , IFuerzoApiConsumer FuerzoApiConsumer , ITipo_de_MandamientoApiConsumer Tipo_de_MandamientoApiConsumer , IMotivo_de_Cancelacion_del_ProcesoApiConsumer Motivo_de_Cancelacion_del_ProcesoApiConsumer , ITipo_de_ProcesoApiConsumer Tipo_de_ProcesoApiConsumer , ITipo_de_ExtradiccionApiConsumer Tipo_de_ExtradiccionApiConsumer , IDetalle_de_FotosApiConsumer Detalle_de_FotosApiConsumer  , IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer Detalle_de_Documentos_Mandamiento_JudicialApiConsumer  )
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
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IInstitucion_EmisoraApiConsumer = Institucion_EmisoraApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IJuzgadoApiConsumer = JuzgadoApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IDetalle_de_DomicilioApiConsumer = Detalle_de_DomicilioApiConsumer;

            this._ITipo_de_DomicilioApiConsumer = Tipo_de_DomicilioApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._IDetalle_de_telefonoApiConsumer = Detalle_de_telefonoApiConsumer;

            this._ITipo_de_TelefonoApiConsumer = Tipo_de_TelefonoApiConsumer;

            this._IDetalle_de_Otro_NombreApiConsumer = Detalle_de_Otro_NombreApiConsumer;


            this._ITipo_de_OrdenApiConsumer = Tipo_de_OrdenApiConsumer;
            this._IAmbitoApiConsumer = AmbitoApiConsumer;
            this._IJuzgadoApiConsumer = JuzgadoApiConsumer;
            this._IEspecialidad_MPApiConsumer = Especialidad_MPApiConsumer;
            this._ITipo_de_CuantiaApiConsumer = Tipo_de_CuantiaApiConsumer;
            this._IDetalle_de_Delito_Mandamiento_JudicialApiConsumer = Detalle_de_Delito_Mandamiento_JudicialApiConsumer;

            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;

            this._IDetalle_de_AmparoApiConsumer = Detalle_de_AmparoApiConsumer;

            this._ITipo_de_AmparoApiConsumer = Tipo_de_AmparoApiConsumer;

            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._ITipo_de_ResolucionApiConsumer = Tipo_de_ResolucionApiConsumer;

            this._IForma_CaraApiConsumer = Forma_CaraApiConsumer;
            this._ICejasApiConsumer = CejasApiConsumer;
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
            this._INariz_BaseApiConsumer = Nariz_BaseApiConsumer;
            this._ILabiosApiConsumer = LabiosApiConsumer;
            this._IBocaApiConsumer = BocaApiConsumer;
            this._IMentonApiConsumer = MentonApiConsumer;
            this._IBarbaApiConsumer = BarbaApiConsumer;
            this._IForma_OrejasApiConsumer = Forma_OrejasApiConsumer;
            this._ITamano_OrejasApiConsumer = Tamano_OrejasApiConsumer;
            this._ITipo_LobuloApiConsumer = Tipo_LobuloApiConsumer;
            this._IBigoteApiConsumer = BigoteApiConsumer;
            this._ISituacion_FisicaApiConsumer = Situacion_FisicaApiConsumer;
            this._IFuerzoApiConsumer = FuerzoApiConsumer;
            this._ITipo_de_MandamientoApiConsumer = Tipo_de_MandamientoApiConsumer;
            this._IMotivo_de_Cancelacion_del_ProcesoApiConsumer = Motivo_de_Cancelacion_del_ProcesoApiConsumer;
            this._ITipo_de_ProcesoApiConsumer = Tipo_de_ProcesoApiConsumer;
            this._ITipo_de_ExtradiccionApiConsumer = Tipo_de_ExtradiccionApiConsumer;
            this._IDetalle_de_FotosApiConsumer = Detalle_de_FotosApiConsumer;





            this._IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer = Detalle_de_Documentos_Mandamiento_JudicialApiConsumer;




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

            var permissionDetalle_de_Domicilio = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45668, ModuleId);
            ViewBag.PermissionDetalle_de_Domicilio = permissionDetalle_de_Domicilio;
            var permissionDetalle_de_telefono = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45678, ModuleId);
            ViewBag.PermissionDetalle_de_telefono = permissionDetalle_de_telefono;
            var permissionDetalle_de_Otro_Nombre = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45673, ModuleId);
            ViewBag.PermissionDetalle_de_Otro_Nombre = permissionDetalle_de_Otro_Nombre;
            var permissionDetalle_de_Delito_Mandamiento_Judicial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45665, ModuleId);
            ViewBag.PermissionDetalle_de_Delito_Mandamiento_Judicial = permissionDetalle_de_Delito_Mandamiento_Judicial;
            var permissionDetalle_de_Amparo = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663, ModuleId);
            ViewBag.PermissionDetalle_de_Amparo = permissionDetalle_de_Amparo;
            var permissionDetalle_de_Fotos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45669, ModuleId);
            ViewBag.PermissionDetalle_de_Fotos = permissionDetalle_de_Fotos;
            var permissionDetalle_de_Documentos_Mandamiento_Judicial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45679, ModuleId);
            ViewBag.PermissionDetalle_de_Documentos_Mandamiento_Judicial = permissionDetalle_de_Documentos_Mandamiento_Judicial;


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
	                    ,Folio_de_la_Orden_de_Aprehension = Registro_de_Mandamiento_JudicialData.Folio_de_la_Orden_de_Aprehension
                    ,Pais_al_que_Pertenece_la_Informacion = Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion
                    ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion), "Pais") ??  (string)Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                    ,Estado_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion
                    ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion_Estado.Nombre
                    ,Municipio_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion
                    ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion), "Municipio") ??  (string)Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                    ,Institucion_que_Remite = Registro_de_Mandamiento_JudicialData.Institucion_que_Remite
                    ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Institucion_que_Remite), "Institucion_Emisora") ??  (string)Registro_de_Mandamiento_JudicialData.Institucion_que_Remite_Institucion_Emisora.Nombre
                    ,Entidad_que_Emite_Mandamiento = Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento
                    ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento_Estado.Nombre
                    ,Juzgado_que_Emitio_Mandamiento = Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento
                    ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento), "Juzgado") ??  (string)Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
                    ,Numero_de_Mandamiento = Registro_de_Mandamiento_JudicialData.Numero_de_Mandamiento
                    ,Oficio_de_Juzgado = Registro_de_Mandamiento_JudicialData.Oficio_de_Juzgado
                    ,Nombre = Registro_de_Mandamiento_JudicialData.Nombre
                    ,Alias = Registro_de_Mandamiento_JudicialData.Alias
                    ,Apellido_Paterno = Registro_de_Mandamiento_JudicialData.Apellido_Paterno
                    ,Apellido_Materno = Registro_de_Mandamiento_JudicialData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Registro_de_Mandamiento_JudicialData.Edad
                    ,Estatura = Registro_de_Mandamiento_JudicialData.Estatura
                    ,Peso = Registro_de_Mandamiento_JudicialData.Peso
                    ,Usa_Anteojos = Registro_de_Mandamiento_JudicialData.Usa_Anteojos.GetValueOrDefault()
                    ,Sexo = Registro_de_Mandamiento_JudicialData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Sexo), "Genero") ??  (string)Registro_de_Mandamiento_JudicialData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Registro_de_Mandamiento_JudicialData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_Civil), "Estado_Civil") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Registro_de_Mandamiento_JudicialData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Registro_de_Mandamiento_JudicialData.Numero_de_Identificacion
                    ,Nacionalidad = Registro_de_Mandamiento_JudicialData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Nacionalidad), "Nacionalidad") ??  (string)Registro_de_Mandamiento_JudicialData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Registro_de_Mandamiento_JudicialData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Escolaridad), "Escolaridad") ??  (string)Registro_de_Mandamiento_JudicialData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Registro_de_Mandamiento_JudicialData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Ocupacion), "Ocupacion") ??  (string)Registro_de_Mandamiento_JudicialData.Ocupacion_Ocupacion.Descripcion
                    ,Pais_de_Nacimiento = Registro_de_Mandamiento_JudicialData.Pais_de_Nacimiento
                    ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Pais_de_Nacimiento), "Pais") ??  (string)Registro_de_Mandamiento_JudicialData.Pais_de_Nacimiento_Pais.Nombre
                    ,Estado_de_Nacimiento = Registro_de_Mandamiento_JudicialData.Estado_de_Nacimiento
                    ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_de_Nacimiento), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_de_Nacimiento_Estado.Nombre
                    ,Tipo_de_Orden = Registro_de_Mandamiento_JudicialData.Tipo_de_Orden
                    ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Orden), "Tipo_de_Orden") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                    ,Fecha_de_Orden = (Registro_de_Mandamiento_JudicialData.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Orden = Registro_de_Mandamiento_JudicialData.Hora_de_Orden
                    ,Dirigida_Por = Registro_de_Mandamiento_JudicialData.Dirigida_Por
                    ,Ambito = Registro_de_Mandamiento_JudicialData.Ambito
                    ,AmbitoAmbitox = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Ambito), "Ambito") ??  (string)Registro_de_Mandamiento_JudicialData.Ambito_Ambito.Ambitox
                    ,Juzgado = Registro_de_Mandamiento_JudicialData.Juzgado
                    ,JuzgadoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Juzgado), "Juzgado") ??  (string)Registro_de_Mandamiento_JudicialData.Juzgado_Juzgado.Nombre
                    ,Juez = Registro_de_Mandamiento_JudicialData.Juez
                    ,Especialidad = Registro_de_Mandamiento_JudicialData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Especialidad), "Especialidad_MP") ??  (string)Registro_de_Mandamiento_JudicialData.Especialidad_Especialidad_MP.Descripcion
                    ,Numero_de_Causa = Registro_de_Mandamiento_JudicialData.Numero_de_Causa
                    ,Fecha_de_Oficio = (Registro_de_Mandamiento_JudicialData.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                    ,Tipo_de_Cuantia = Registro_de_Mandamiento_JudicialData.Tipo_de_Cuantia
                    ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Cuantia), "Tipo_de_Cuantia") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
                    ,Observaciones = Registro_de_Mandamiento_JudicialData.Observaciones
                    ,Forma_Cara = Registro_de_Mandamiento_JudicialData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Cara), "Forma_Cara") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Cara_Forma_Cara.Descripcion
                    ,Cejas = Registro_de_Mandamiento_JudicialData.Cejas
                    ,CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Cejas), "Cejas") ??  (string)Registro_de_Mandamiento_JudicialData.Cejas_Cejas.Descripcion
                    ,Cantidad_Cabello = Registro_de_Mandamiento_JudicialData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Registro_de_Mandamiento_JudicialData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Registro_de_Mandamiento_JudicialData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Complexion), "Complexion") ??  (string)Registro_de_Mandamiento_JudicialData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Registro_de_Mandamiento_JudicialData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Color_Piel), "Color_Piel") ??  (string)Registro_de_Mandamiento_JudicialData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Registro_de_Mandamiento_JudicialData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Frente), "Frente") ??  (string)Registro_de_Mandamiento_JudicialData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Registro_de_Mandamiento_JudicialData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Cabello), "Forma_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Registro_de_Mandamiento_JudicialData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Color_Cabello), "Color_de_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Registro_de_Mandamiento_JudicialData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Calvicie), "Calvicie") ??  (string)Registro_de_Mandamiento_JudicialData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Registro_de_Mandamiento_JudicialData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Color_Ojos), "Color_Ojos") ??  (string)Registro_de_Mandamiento_JudicialData.Color_Ojos_Color_Ojos.Descripcion
                    ,Ojos = Registro_de_Mandamiento_JudicialData.Ojos
                    ,OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Ojos), "Ojos") ??  (string)Registro_de_Mandamiento_JudicialData.Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Registro_de_Mandamiento_JudicialData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Ojos), "Froma_Ojos") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Nariz_Base = Registro_de_Mandamiento_JudicialData.Nariz_Base
                    ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Nariz_Base), "Nariz_Base") ??  (string)Registro_de_Mandamiento_JudicialData.Nariz_Base_Nariz_Base.Descripcion
                    ,Labios = Registro_de_Mandamiento_JudicialData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Labios), "Labios") ??  (string)Registro_de_Mandamiento_JudicialData.Labios_Labios.Descripcion
                    ,Boca = Registro_de_Mandamiento_JudicialData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Boca), "Boca") ??  (string)Registro_de_Mandamiento_JudicialData.Boca_Boca.Descripcion
                    ,Menton = Registro_de_Mandamiento_JudicialData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Menton), "Menton") ??  (string)Registro_de_Mandamiento_JudicialData.Menton_Menton.Descripcion
                    ,Barba = Registro_de_Mandamiento_JudicialData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Barba), "Barba") ??  (string)Registro_de_Mandamiento_JudicialData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Registro_de_Mandamiento_JudicialData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Orejas), "Forma_Orejas") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Registro_de_Mandamiento_JudicialData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Registro_de_Mandamiento_JudicialData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Registro_de_Mandamiento_JudicialData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Registro_de_Mandamiento_JudicialData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Bigote), "Bigote") ??  (string)Registro_de_Mandamiento_JudicialData.Bigote_Bigote.Descripcion
                    ,Situacion_Fisica = Registro_de_Mandamiento_JudicialData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Registro_de_Mandamiento_JudicialData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Fecha_de_Libramiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                    ,Fuerzo = Registro_de_Mandamiento_JudicialData.Fuerzo
                    ,FuerzoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Fuerzo), "Fuerzo") ??  (string)Registro_de_Mandamiento_JudicialData.Fuerzo_Fuerzo.Descripcion
                    ,Tipo_Mandato = Registro_de_Mandamiento_JudicialData.Tipo_Mandato
                    ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_Mandato), "Tipo_de_Mandamiento") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                    ,Numero_de_Proceso_Judicial = Registro_de_Mandamiento_JudicialData.Numero_de_Proceso_Judicial
                    ,Numero_de_Averiguacion = Registro_de_Mandamiento_JudicialData.Numero_de_Averiguacion
                    ,Fecha_de_Captura = (Registro_de_Mandamiento_JudicialData.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Recepcion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Prescripcion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Cumplimiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Oficio_de_Cumplimiento = Registro_de_Mandamiento_JudicialData.Oficio_de_Cumplimiento
                    ,Fecha_de_Cancelacion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                    ,Motivo_de_Cancelacion = Registro_de_Mandamiento_JudicialData.Motivo_de_Cancelacion
                    ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Motivo_de_Cancelacion), "Motivo_de_Cancelacion_del_Proceso") ??  (string)Registro_de_Mandamiento_JudicialData.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
                    ,Oficio_de_Cancelacion = Registro_de_Mandamiento_JudicialData.Oficio_de_Cancelacion
                    ,Tipo_de_Proceso = Registro_de_Mandamiento_JudicialData.Tipo_de_Proceso
                    ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Proceso), "Tipo_de_Proceso") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                    ,Proceso_de_Extradiccion = Registro_de_Mandamiento_JudicialData.Proceso_de_Extradiccion
                    ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Proceso_de_Extradiccion), "Tipo_de_Extradiccion") ??  (string)Registro_de_Mandamiento_JudicialData.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
                    ,Observacionesx = Registro_de_Mandamiento_JudicialData.Observacionesx
                    ,Huellas_Digitales = Registro_de_Mandamiento_JudicialData.Huellas_Digitales
                    ,Mano_Izquierda_dedos = Registro_de_Mandamiento_JudicialData.Mano_Izquierda_dedos
                    ,Mano_Derecha_Pulgar = Registro_de_Mandamiento_JudicialData.Mano_Derecha_Pulgar
                    ,Mano_Derecha_Dedos = Registro_de_Mandamiento_JudicialData.Mano_Derecha_Dedos

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_OrdenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Ordens_Tipo_de_Orden = _ITipo_de_OrdenApiConsumer.SelAll(true);
            if (Tipo_de_Ordens_Tipo_de_Orden != null && Tipo_de_Ordens_Tipo_de_Orden.Resource != null)
                ViewBag.Tipo_de_Ordens_Tipo_de_Orden = Tipo_de_Ordens_Tipo_de_Orden.Resource.Where(m => m.Tipo_de_Ordenx != null).OrderBy(m => m.Tipo_de_Ordenx).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Orden", "Tipo_de_Ordenx") ?? m.Tipo_de_Ordenx.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAmbitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ambitos_Ambito = _IAmbitoApiConsumer.SelAll(true);
            if (Ambitos_Ambito != null && Ambitos_Ambito.Resource != null)
                ViewBag.Ambitos_Ambito = Ambitos_Ambito.Resource.Where(m => m.Ambitox != null).OrderBy(m => m.Ambitox).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ambito", "Ambitox") ?? m.Ambitox.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CuantiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Cuantias_Tipo_de_Cuantia = _ITipo_de_CuantiaApiConsumer.SelAll(true);
            if (Tipo_de_Cuantias_Tipo_de_Cuantia != null && Tipo_de_Cuantias_Tipo_de_Cuantia.Resource != null)
                ViewBag.Tipo_de_Cuantias_Tipo_de_Cuantia = Tipo_de_Cuantias_Tipo_de_Cuantia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Cuantia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Ojoss_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Ojos != null && Ojoss_Ojos.Resource != null)
                ViewBag.Ojoss_Ojos = Ojoss_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Nariz_Base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_Base != null && Nariz_Bases_Nariz_Base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_Base = Nariz_Bases_Nariz_Base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuerzoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuerzos_Fuerzo = _IFuerzoApiConsumer.SelAll(true);
            if (Fuerzos_Fuerzo != null && Fuerzos_Fuerzo.Resource != null)
                ViewBag.Fuerzos_Fuerzo = Fuerzos_Fuerzo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuerzo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SelAll(true);
            if (Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion != null && Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource != null)
                ViewBag.Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Cancelacion_del_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Procesos_Tipo_de_Proceso = _ITipo_de_ProcesoApiConsumer.SelAll(true);
            if (Tipo_de_Procesos_Tipo_de_Proceso != null && Tipo_de_Procesos_Tipo_de_Proceso.Resource != null)
                ViewBag.Tipo_de_Procesos_Tipo_de_Proceso = Tipo_de_Procesos_Tipo_de_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ExtradiccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Extradiccions_Proceso_de_Extradiccion = _ITipo_de_ExtradiccionApiConsumer.SelAll(true);
            if (Tipo_de_Extradiccions_Proceso_de_Extradiccion != null && Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource != null)
                ViewBag.Tipo_de_Extradiccions_Proceso_de_Extradiccion = Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Extradiccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var permissionDetalle_de_Domicilio = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45668, ModuleId);
            ViewBag.PermissionDetalle_de_Domicilio = permissionDetalle_de_Domicilio;
            var permissionDetalle_de_telefono = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45678, ModuleId);
            ViewBag.PermissionDetalle_de_telefono = permissionDetalle_de_telefono;
            var permissionDetalle_de_Otro_Nombre = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45673, ModuleId);
            ViewBag.PermissionDetalle_de_Otro_Nombre = permissionDetalle_de_Otro_Nombre;
            var permissionDetalle_de_Delito_Mandamiento_Judicial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45665, ModuleId);
            ViewBag.PermissionDetalle_de_Delito_Mandamiento_Judicial = permissionDetalle_de_Delito_Mandamiento_Judicial;
            var permissionDetalle_de_Amparo = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663, ModuleId);
            ViewBag.PermissionDetalle_de_Amparo = permissionDetalle_de_Amparo;
            var permissionDetalle_de_Fotos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45669, ModuleId);
            ViewBag.PermissionDetalle_de_Fotos = permissionDetalle_de_Fotos;
            var permissionDetalle_de_Documentos_Mandamiento_Judicial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45679, ModuleId);
            ViewBag.PermissionDetalle_de_Documentos_Mandamiento_Judicial = permissionDetalle_de_Documentos_Mandamiento_Judicial;


            if (id.ToString() != "0")
            {
                var Registro_de_Mandamiento_JudicialsData = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, "Registro_de_Mandamiento_Judicial.Clave=" + id, "").Resource.Registro_de_Mandamiento_Judicials;
				
				if (Registro_de_Mandamiento_JudicialsData != null && Registro_de_Mandamiento_JudicialsData.Count > 0)
                {
					var Registro_de_Mandamiento_JudicialData = Registro_de_Mandamiento_JudicialsData.First();
					varRegistro_de_Mandamiento_Judicial= new Registro_de_Mandamiento_JudicialModel
					{
						Clave  = Registro_de_Mandamiento_JudicialData.Clave 
	                    ,Folio_de_la_Orden_de_Aprehension = Registro_de_Mandamiento_JudicialData.Folio_de_la_Orden_de_Aprehension
                    ,Pais_al_que_Pertenece_la_Informacion = Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion
                    ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion), "Pais") ??  (string)Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                    ,Estado_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion
                    ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion_Estado.Nombre
                    ,Municipio_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion
                    ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion), "Municipio") ??  (string)Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                    ,Institucion_que_Remite = Registro_de_Mandamiento_JudicialData.Institucion_que_Remite
                    ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Institucion_que_Remite), "Institucion_Emisora") ??  (string)Registro_de_Mandamiento_JudicialData.Institucion_que_Remite_Institucion_Emisora.Nombre
                    ,Entidad_que_Emite_Mandamiento = Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento
                    ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento_Estado.Nombre
                    ,Juzgado_que_Emitio_Mandamiento = Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento
                    ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento), "Juzgado") ??  (string)Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
                    ,Numero_de_Mandamiento = Registro_de_Mandamiento_JudicialData.Numero_de_Mandamiento
                    ,Oficio_de_Juzgado = Registro_de_Mandamiento_JudicialData.Oficio_de_Juzgado
                    ,Nombre = Registro_de_Mandamiento_JudicialData.Nombre
                    ,Alias = Registro_de_Mandamiento_JudicialData.Alias
                    ,Apellido_Paterno = Registro_de_Mandamiento_JudicialData.Apellido_Paterno
                    ,Apellido_Materno = Registro_de_Mandamiento_JudicialData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Registro_de_Mandamiento_JudicialData.Edad
                    ,Estatura = Registro_de_Mandamiento_JudicialData.Estatura
                    ,Peso = Registro_de_Mandamiento_JudicialData.Peso
                    ,Usa_Anteojos = Registro_de_Mandamiento_JudicialData.Usa_Anteojos.GetValueOrDefault()
                    ,Sexo = Registro_de_Mandamiento_JudicialData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Sexo), "Genero") ??  (string)Registro_de_Mandamiento_JudicialData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Registro_de_Mandamiento_JudicialData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_Civil), "Estado_Civil") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Registro_de_Mandamiento_JudicialData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Registro_de_Mandamiento_JudicialData.Numero_de_Identificacion
                    ,Nacionalidad = Registro_de_Mandamiento_JudicialData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Nacionalidad), "Nacionalidad") ??  (string)Registro_de_Mandamiento_JudicialData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Registro_de_Mandamiento_JudicialData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Escolaridad), "Escolaridad") ??  (string)Registro_de_Mandamiento_JudicialData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Registro_de_Mandamiento_JudicialData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Ocupacion), "Ocupacion") ??  (string)Registro_de_Mandamiento_JudicialData.Ocupacion_Ocupacion.Descripcion
                    ,Pais_de_Nacimiento = Registro_de_Mandamiento_JudicialData.Pais_de_Nacimiento
                    ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Pais_de_Nacimiento), "Pais") ??  (string)Registro_de_Mandamiento_JudicialData.Pais_de_Nacimiento_Pais.Nombre
                    ,Estado_de_Nacimiento = Registro_de_Mandamiento_JudicialData.Estado_de_Nacimiento
                    ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_de_Nacimiento), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_de_Nacimiento_Estado.Nombre
                    ,Tipo_de_Orden = Registro_de_Mandamiento_JudicialData.Tipo_de_Orden
                    ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Orden), "Tipo_de_Orden") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                    ,Fecha_de_Orden = (Registro_de_Mandamiento_JudicialData.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Orden = Registro_de_Mandamiento_JudicialData.Hora_de_Orden
                    ,Dirigida_Por = Registro_de_Mandamiento_JudicialData.Dirigida_Por
                    ,Ambito = Registro_de_Mandamiento_JudicialData.Ambito
                    ,AmbitoAmbitox = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Ambito), "Ambito") ??  (string)Registro_de_Mandamiento_JudicialData.Ambito_Ambito.Ambitox
                    ,Juzgado = Registro_de_Mandamiento_JudicialData.Juzgado
                    ,JuzgadoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Juzgado), "Juzgado") ??  (string)Registro_de_Mandamiento_JudicialData.Juzgado_Juzgado.Nombre
                    ,Juez = Registro_de_Mandamiento_JudicialData.Juez
                    ,Especialidad = Registro_de_Mandamiento_JudicialData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Especialidad), "Especialidad_MP") ??  (string)Registro_de_Mandamiento_JudicialData.Especialidad_Especialidad_MP.Descripcion
                    ,Numero_de_Causa = Registro_de_Mandamiento_JudicialData.Numero_de_Causa
                    ,Fecha_de_Oficio = (Registro_de_Mandamiento_JudicialData.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                    ,Tipo_de_Cuantia = Registro_de_Mandamiento_JudicialData.Tipo_de_Cuantia
                    ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Cuantia), "Tipo_de_Cuantia") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
                    ,Observaciones = Registro_de_Mandamiento_JudicialData.Observaciones
                    ,Forma_Cara = Registro_de_Mandamiento_JudicialData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Cara), "Forma_Cara") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Cara_Forma_Cara.Descripcion
                    ,Cejas = Registro_de_Mandamiento_JudicialData.Cejas
                    ,CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Cejas), "Cejas") ??  (string)Registro_de_Mandamiento_JudicialData.Cejas_Cejas.Descripcion
                    ,Cantidad_Cabello = Registro_de_Mandamiento_JudicialData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Registro_de_Mandamiento_JudicialData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Registro_de_Mandamiento_JudicialData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Complexion), "Complexion") ??  (string)Registro_de_Mandamiento_JudicialData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Registro_de_Mandamiento_JudicialData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Color_Piel), "Color_Piel") ??  (string)Registro_de_Mandamiento_JudicialData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Registro_de_Mandamiento_JudicialData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Frente), "Frente") ??  (string)Registro_de_Mandamiento_JudicialData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Registro_de_Mandamiento_JudicialData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Cabello), "Forma_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Registro_de_Mandamiento_JudicialData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Color_Cabello), "Color_de_Cabello") ??  (string)Registro_de_Mandamiento_JudicialData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Registro_de_Mandamiento_JudicialData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Calvicie), "Calvicie") ??  (string)Registro_de_Mandamiento_JudicialData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Registro_de_Mandamiento_JudicialData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Color_Ojos), "Color_Ojos") ??  (string)Registro_de_Mandamiento_JudicialData.Color_Ojos_Color_Ojos.Descripcion
                    ,Ojos = Registro_de_Mandamiento_JudicialData.Ojos
                    ,OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Ojos), "Ojos") ??  (string)Registro_de_Mandamiento_JudicialData.Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Registro_de_Mandamiento_JudicialData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Ojos), "Froma_Ojos") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Nariz_Base = Registro_de_Mandamiento_JudicialData.Nariz_Base
                    ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Nariz_Base), "Nariz_Base") ??  (string)Registro_de_Mandamiento_JudicialData.Nariz_Base_Nariz_Base.Descripcion
                    ,Labios = Registro_de_Mandamiento_JudicialData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Labios), "Labios") ??  (string)Registro_de_Mandamiento_JudicialData.Labios_Labios.Descripcion
                    ,Boca = Registro_de_Mandamiento_JudicialData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Boca), "Boca") ??  (string)Registro_de_Mandamiento_JudicialData.Boca_Boca.Descripcion
                    ,Menton = Registro_de_Mandamiento_JudicialData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Menton), "Menton") ??  (string)Registro_de_Mandamiento_JudicialData.Menton_Menton.Descripcion
                    ,Barba = Registro_de_Mandamiento_JudicialData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Barba), "Barba") ??  (string)Registro_de_Mandamiento_JudicialData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Registro_de_Mandamiento_JudicialData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Forma_Orejas), "Forma_Orejas") ??  (string)Registro_de_Mandamiento_JudicialData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Registro_de_Mandamiento_JudicialData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Registro_de_Mandamiento_JudicialData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Registro_de_Mandamiento_JudicialData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Registro_de_Mandamiento_JudicialData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Bigote), "Bigote") ??  (string)Registro_de_Mandamiento_JudicialData.Bigote_Bigote.Descripcion
                    ,Situacion_Fisica = Registro_de_Mandamiento_JudicialData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Registro_de_Mandamiento_JudicialData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Fecha_de_Libramiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                    ,Fuerzo = Registro_de_Mandamiento_JudicialData.Fuerzo
                    ,FuerzoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Fuerzo), "Fuerzo") ??  (string)Registro_de_Mandamiento_JudicialData.Fuerzo_Fuerzo.Descripcion
                    ,Tipo_Mandato = Registro_de_Mandamiento_JudicialData.Tipo_Mandato
                    ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_Mandato), "Tipo_de_Mandamiento") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                    ,Numero_de_Proceso_Judicial = Registro_de_Mandamiento_JudicialData.Numero_de_Proceso_Judicial
                    ,Numero_de_Averiguacion = Registro_de_Mandamiento_JudicialData.Numero_de_Averiguacion
                    ,Fecha_de_Captura = (Registro_de_Mandamiento_JudicialData.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Recepcion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Prescripcion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Cumplimiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Oficio_de_Cumplimiento = Registro_de_Mandamiento_JudicialData.Oficio_de_Cumplimiento
                    ,Fecha_de_Cancelacion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                    ,Motivo_de_Cancelacion = Registro_de_Mandamiento_JudicialData.Motivo_de_Cancelacion
                    ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Motivo_de_Cancelacion), "Motivo_de_Cancelacion_del_Proceso") ??  (string)Registro_de_Mandamiento_JudicialData.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
                    ,Oficio_de_Cancelacion = Registro_de_Mandamiento_JudicialData.Oficio_de_Cancelacion
                    ,Tipo_de_Proceso = Registro_de_Mandamiento_JudicialData.Tipo_de_Proceso
                    ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_de_Proceso), "Tipo_de_Proceso") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                    ,Proceso_de_Extradiccion = Registro_de_Mandamiento_JudicialData.Proceso_de_Extradiccion
                    ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Proceso_de_Extradiccion), "Tipo_de_Extradiccion") ??  (string)Registro_de_Mandamiento_JudicialData.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
                    ,Observacionesx = Registro_de_Mandamiento_JudicialData.Observacionesx
                    ,Huellas_Digitales = Registro_de_Mandamiento_JudicialData.Huellas_Digitales
                    ,Mano_Izquierda_dedos = Registro_de_Mandamiento_JudicialData.Mano_Izquierda_dedos
                    ,Mano_Derecha_Pulgar = Registro_de_Mandamiento_JudicialData.Mano_Derecha_Pulgar
                    ,Mano_Derecha_Dedos = Registro_de_Mandamiento_JudicialData.Mano_Derecha_Dedos

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_OrdenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Ordens_Tipo_de_Orden = _ITipo_de_OrdenApiConsumer.SelAll(true);
            if (Tipo_de_Ordens_Tipo_de_Orden != null && Tipo_de_Ordens_Tipo_de_Orden.Resource != null)
                ViewBag.Tipo_de_Ordens_Tipo_de_Orden = Tipo_de_Ordens_Tipo_de_Orden.Resource.Where(m => m.Tipo_de_Ordenx != null).OrderBy(m => m.Tipo_de_Ordenx).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Orden", "Tipo_de_Ordenx") ?? m.Tipo_de_Ordenx.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAmbitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ambitos_Ambito = _IAmbitoApiConsumer.SelAll(true);
            if (Ambitos_Ambito != null && Ambitos_Ambito.Resource != null)
                ViewBag.Ambitos_Ambito = Ambitos_Ambito.Resource.Where(m => m.Ambitox != null).OrderBy(m => m.Ambitox).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ambito", "Ambitox") ?? m.Ambitox.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CuantiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Cuantias_Tipo_de_Cuantia = _ITipo_de_CuantiaApiConsumer.SelAll(true);
            if (Tipo_de_Cuantias_Tipo_de_Cuantia != null && Tipo_de_Cuantias_Tipo_de_Cuantia.Resource != null)
                ViewBag.Tipo_de_Cuantias_Tipo_de_Cuantia = Tipo_de_Cuantias_Tipo_de_Cuantia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Cuantia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Ojoss_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Ojos != null && Ojoss_Ojos.Resource != null)
                ViewBag.Ojoss_Ojos = Ojoss_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Nariz_Base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_Base != null && Nariz_Bases_Nariz_Base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_Base = Nariz_Bases_Nariz_Base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuerzoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuerzos_Fuerzo = _IFuerzoApiConsumer.SelAll(true);
            if (Fuerzos_Fuerzo != null && Fuerzos_Fuerzo.Resource != null)
                ViewBag.Fuerzos_Fuerzo = Fuerzos_Fuerzo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuerzo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SelAll(true);
            if (Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion != null && Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource != null)
                ViewBag.Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Cancelacion_del_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Procesos_Tipo_de_Proceso = _ITipo_de_ProcesoApiConsumer.SelAll(true);
            if (Tipo_de_Procesos_Tipo_de_Proceso != null && Tipo_de_Procesos_Tipo_de_Proceso.Resource != null)
                ViewBag.Tipo_de_Procesos_Tipo_de_Proceso = Tipo_de_Procesos_Tipo_de_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ExtradiccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Extradiccions_Proceso_de_Extradiccion = _ITipo_de_ExtradiccionApiConsumer.SelAll(true);
            if (Tipo_de_Extradiccions_Proceso_de_Extradiccion != null && Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource != null)
                ViewBag.Tipo_de_Extradiccions_Proceso_de_Extradiccion = Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Extradiccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
        public ActionResult GetEscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetOcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_OrdenAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_OrdenApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_OrdenApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Tipo_de_Ordenx).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Orden", "Tipo_de_Ordenx")?? m.Tipo_de_Ordenx,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAmbitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAmbitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAmbitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Ambitox).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ambito", "Ambitox")?? m.Ambitox,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEspecialidad_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecialidad_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_CuantiaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_CuantiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_CuantiaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Cuantia", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetFuerzoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFuerzoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFuerzoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuerzo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
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
        public ActionResult GetMotivo_de_Cancelacion_del_ProcesoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Cancelacion_del_Proceso", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_ProcesoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ProcesoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Proceso", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_ExtradiccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ExtradiccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ExtradiccionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Extradiccion", "Descripcion")?? m.Descripcion,
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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_OrdenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Ordens_Tipo_de_Orden = _ITipo_de_OrdenApiConsumer.SelAll(true);
            if (Tipo_de_Ordens_Tipo_de_Orden != null && Tipo_de_Ordens_Tipo_de_Orden.Resource != null)
                ViewBag.Tipo_de_Ordens_Tipo_de_Orden = Tipo_de_Ordens_Tipo_de_Orden.Resource.Where(m => m.Tipo_de_Ordenx != null).OrderBy(m => m.Tipo_de_Ordenx).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Orden", "Tipo_de_Ordenx") ?? m.Tipo_de_Ordenx.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAmbitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ambitos_Ambito = _IAmbitoApiConsumer.SelAll(true);
            if (Ambitos_Ambito != null && Ambitos_Ambito.Resource != null)
                ViewBag.Ambitos_Ambito = Ambitos_Ambito.Resource.Where(m => m.Ambitox != null).OrderBy(m => m.Ambitox).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ambito", "Ambitox") ?? m.Ambitox.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CuantiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Cuantias_Tipo_de_Cuantia = _ITipo_de_CuantiaApiConsumer.SelAll(true);
            if (Tipo_de_Cuantias_Tipo_de_Cuantia != null && Tipo_de_Cuantias_Tipo_de_Cuantia.Resource != null)
                ViewBag.Tipo_de_Cuantias_Tipo_de_Cuantia = Tipo_de_Cuantias_Tipo_de_Cuantia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Cuantia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Ojoss_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Ojos != null && Ojoss_Ojos.Resource != null)
                ViewBag.Ojoss_Ojos = Ojoss_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Nariz_Base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_Base != null && Nariz_Bases_Nariz_Base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_Base = Nariz_Bases_Nariz_Base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuerzoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuerzos_Fuerzo = _IFuerzoApiConsumer.SelAll(true);
            if (Fuerzos_Fuerzo != null && Fuerzos_Fuerzo.Resource != null)
                ViewBag.Fuerzos_Fuerzo = Fuerzos_Fuerzo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuerzo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SelAll(true);
            if (Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion != null && Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource != null)
                ViewBag.Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Cancelacion_del_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Procesos_Tipo_de_Proceso = _ITipo_de_ProcesoApiConsumer.SelAll(true);
            if (Tipo_de_Procesos_Tipo_de_Proceso != null && Tipo_de_Procesos_Tipo_de_Proceso.Resource != null)
                ViewBag.Tipo_de_Procesos_Tipo_de_Proceso = Tipo_de_Procesos_Tipo_de_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ExtradiccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Extradiccions_Proceso_de_Extradiccion = _ITipo_de_ExtradiccionApiConsumer.SelAll(true);
            if (Tipo_de_Extradiccions_Proceso_de_Extradiccion != null && Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource != null)
                ViewBag.Tipo_de_Extradiccions_Proceso_de_Extradiccion = Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Extradiccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_OrdenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Ordens_Tipo_de_Orden = _ITipo_de_OrdenApiConsumer.SelAll(true);
            if (Tipo_de_Ordens_Tipo_de_Orden != null && Tipo_de_Ordens_Tipo_de_Orden.Resource != null)
                ViewBag.Tipo_de_Ordens_Tipo_de_Orden = Tipo_de_Ordens_Tipo_de_Orden.Resource.Where(m => m.Tipo_de_Ordenx != null).OrderBy(m => m.Tipo_de_Ordenx).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Orden", "Tipo_de_Ordenx") ?? m.Tipo_de_Ordenx.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAmbitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ambitos_Ambito = _IAmbitoApiConsumer.SelAll(true);
            if (Ambitos_Ambito != null && Ambitos_Ambito.Resource != null)
                ViewBag.Ambitos_Ambito = Ambitos_Ambito.Resource.Where(m => m.Ambitox != null).OrderBy(m => m.Ambitox).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ambito", "Ambitox") ?? m.Ambitox.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CuantiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Cuantias_Tipo_de_Cuantia = _ITipo_de_CuantiaApiConsumer.SelAll(true);
            if (Tipo_de_Cuantias_Tipo_de_Cuantia != null && Tipo_de_Cuantias_Tipo_de_Cuantia.Resource != null)
                ViewBag.Tipo_de_Cuantias_Tipo_de_Cuantia = Tipo_de_Cuantias_Tipo_de_Cuantia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Cuantia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Ojoss_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Ojos != null && Ojoss_Ojos.Resource != null)
                ViewBag.Ojoss_Ojos = Ojoss_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Nariz_Base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_Base != null && Nariz_Bases_Nariz_Base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_Base = Nariz_Bases_Nariz_Base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuerzoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuerzos_Fuerzo = _IFuerzoApiConsumer.SelAll(true);
            if (Fuerzos_Fuerzo != null && Fuerzos_Fuerzo.Resource != null)
                ViewBag.Fuerzos_Fuerzo = Fuerzos_Fuerzo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuerzo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = _IMotivo_de_Cancelacion_del_ProcesoApiConsumer.SelAll(true);
            if (Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion != null && Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource != null)
                ViewBag.Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion = Motivo_de_Cancelacion_del_Procesos_Motivo_de_Cancelacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Cancelacion_del_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Procesos_Tipo_de_Proceso = _ITipo_de_ProcesoApiConsumer.SelAll(true);
            if (Tipo_de_Procesos_Tipo_de_Proceso != null && Tipo_de_Procesos_Tipo_de_Proceso.Resource != null)
                ViewBag.Tipo_de_Procesos_Tipo_de_Proceso = Tipo_de_Procesos_Tipo_de_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ExtradiccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Extradiccions_Proceso_de_Extradiccion = _ITipo_de_ExtradiccionApiConsumer.SelAll(true);
            if (Tipo_de_Extradiccions_Proceso_de_Extradiccion != null && Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource != null)
                ViewBag.Tipo_de_Extradiccions_Proceso_de_Extradiccion = Tipo_de_Extradiccions_Proceso_de_Extradiccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Extradiccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
			,Folio_de_la_Orden_de_Aprehension = m.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
			,Nombre = m.Nombre
			,Alias = m.Alias
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
			,Estatura = m.Estatura
			,Peso = m.Peso
			,Usa_Anteojos = m.Usa_Anteojos
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(m.Pais_de_Nacimiento_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Nacimiento_Pais.Nombre
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(m.Tipo_de_Orden_Tipo_de_Orden.Clave.ToString(), "Tipo_de_Ordenx") ?? (string)m.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                        ,Fecha_de_Orden = (m.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Orden = m.Hora_de_Orden
			,Dirigida_Por = m.Dirigida_Por
                        ,AmbitoAmbitox = CultureHelper.GetTraduction(m.Ambito_Ambito.Clave.ToString(), "Ambitox") ?? (string)m.Ambito_Ambito.Ambitox
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
			,Juez = m.Juez
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,Numero_de_Causa = m.Numero_de_Causa
                        ,Fecha_de_Oficio = (m.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                        ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cuantia_Tipo_de_Cuantia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
			,Observaciones = m.Observaciones
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                        ,FuerzoDescripcion = CultureHelper.GetTraduction(m.Fuerzo_Fuerzo.Clave.ToString(), "Descripcion") ?? (string)m.Fuerzo_Fuerzo.Descripcion
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
			,Numero_de_Averiguacion = m.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (m.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Prescripcion = (m.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Cumplimiento = m.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (m.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                        ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
			,Oficio_de_Cancelacion = m.Oficio_de_Cancelacion
                        ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Proceso_Tipo_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                        ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
			,Observacionesx = m.Observacionesx
			,Huellas_Digitales = m.Huellas_Digitales
			,Mano_Izquierda_dedos = m.Mano_Izquierda_dedos
			,Mano_Derecha_Pulgar = m.Mano_Derecha_Pulgar
			,Mano_Derecha_Dedos = m.Mano_Derecha_Dedos

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
			,Folio_de_la_Orden_de_Aprehension = m.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
			,Nombre = m.Nombre
			,Alias = m.Alias
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
			,Estatura = m.Estatura
			,Peso = m.Peso
			,Usa_Anteojos = m.Usa_Anteojos
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(m.Pais_de_Nacimiento_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Nacimiento_Pais.Nombre
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(m.Tipo_de_Orden_Tipo_de_Orden.Clave.ToString(), "Tipo_de_Ordenx") ?? (string)m.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                        ,Fecha_de_Orden = (m.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Orden = m.Hora_de_Orden
			,Dirigida_Por = m.Dirigida_Por
                        ,AmbitoAmbitox = CultureHelper.GetTraduction(m.Ambito_Ambito.Clave.ToString(), "Ambitox") ?? (string)m.Ambito_Ambito.Ambitox
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
			,Juez = m.Juez
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,Numero_de_Causa = m.Numero_de_Causa
                        ,Fecha_de_Oficio = (m.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                        ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cuantia_Tipo_de_Cuantia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
			,Observaciones = m.Observaciones
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                        ,FuerzoDescripcion = CultureHelper.GetTraduction(m.Fuerzo_Fuerzo.Clave.ToString(), "Descripcion") ?? (string)m.Fuerzo_Fuerzo.Descripcion
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
			,Numero_de_Averiguacion = m.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (m.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Prescripcion = (m.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Cumplimiento = m.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (m.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                        ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
			,Oficio_de_Cancelacion = m.Oficio_de_Cancelacion
                        ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Proceso_Tipo_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                        ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
			,Observacionesx = m.Observacionesx
			,Huellas_Digitales = m.Huellas_Digitales
			,Mano_Izquierda_dedos = m.Mano_Izquierda_dedos
			,Mano_Derecha_Pulgar = m.Mano_Derecha_Pulgar
			,Mano_Derecha_Dedos = m.Mano_Derecha_Dedos

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
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
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Nacionalidad_Nacionalidad(string query, string where)
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
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Pais_de_Nacimiento_Pais(string query, string where)
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
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Estado_de_Nacimiento_Estado(string query, string where)
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
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Domicilio_Pais_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Domicilio_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Domicilio_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Domicilio_Colonia_Colonia(string query, string where)
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

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Mandamiento_Judicial_Delito_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Amparo_Entidad_que_Emitio_Amparo_Estado(string query, string where)
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

//Grid GetAutoComplete

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

            if (!string.IsNullOrEmpty(filter.Folio_de_la_Orden_de_Aprehension))
            {
                switch (filter.Folio_de_la_Orden_de_AprehensionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension LIKE '" + filter.Folio_de_la_Orden_de_Aprehension + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension LIKE '%" + filter.Folio_de_la_Orden_de_Aprehension + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension = '" + filter.Folio_de_la_Orden_de_Aprehension + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension LIKE '%" + filter.Folio_de_la_Orden_de_Aprehension + "%'";
                        break;
                }
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

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Alias))
            {
                switch (filter.AliasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Alias LIKE '" + filter.Alias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Alias LIKE '%" + filter.Alias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Alias = '" + filter.Alias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Alias LIKE '%" + filter.Alias + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
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
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Registro_de_Mandamiento_Judicial.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Registro_de_Mandamiento_Judicial.Edad <= " + filter.ToEdad;
            }

            if (!string.IsNullOrEmpty(filter.FromEstatura) || !string.IsNullOrEmpty(filter.ToEstatura))
            {
                if (!string.IsNullOrEmpty(filter.FromEstatura))
                    where += " AND Registro_de_Mandamiento_Judicial.Estatura >= " + filter.FromEstatura;
                if (!string.IsNullOrEmpty(filter.ToEstatura))
                    where += " AND Registro_de_Mandamiento_Judicial.Estatura <= " + filter.ToEstatura;
            }

            if (!string.IsNullOrEmpty(filter.FromPeso) || !string.IsNullOrEmpty(filter.ToPeso))
            {
                if (!string.IsNullOrEmpty(filter.FromPeso))
                    where += " AND Registro_de_Mandamiento_Judicial.Peso >= " + filter.FromPeso;
                if (!string.IsNullOrEmpty(filter.ToPeso))
                    where += " AND Registro_de_Mandamiento_Judicial.Peso <= " + filter.ToPeso;
            }

            if (filter.Usa_Anteojos != RadioOptions.NoApply)
                where += " AND Registro_de_Mandamiento_Judicial.Usa_Anteojos = " + Convert.ToInt32(filter.Usa_Anteojos);

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

                where += " AND Registro_de_Mandamiento_Judicial.Sexo In (" + SexoIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad))
            {
                switch (filter.NacionalidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidadMultiple != null && filter.AdvanceNacionalidadMultiple.Count() > 0)
            {
                var NacionalidadIds = string.Join(",", filter.AdvanceNacionalidadMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Nacionalidad In (" + NacionalidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad))
            {
                switch (filter.EscolaridadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridadMultiple != null && filter.AdvanceEscolaridadMultiple.Count() > 0)
            {
                var EscolaridadIds = string.Join(",", filter.AdvanceEscolaridadMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Escolaridad In (" + EscolaridadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOcupacion))
            {
                switch (filter.OcupacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ocupacion.Descripcion LIKE '" + filter.AdvanceOcupacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ocupacion.Descripcion = '" + filter.AdvanceOcupacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOcupacionMultiple != null && filter.AdvanceOcupacionMultiple.Count() > 0)
            {
                var OcupacionIds = string.Join(",", filter.AdvanceOcupacionMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Ocupacion In (" + OcupacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_Nacimiento))
            {
                switch (filter.Pais_de_NacimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_Nacimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Nacimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_Nacimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Nacimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_NacimientoMultiple != null && filter.AdvancePais_de_NacimientoMultiple.Count() > 0)
            {
                var Pais_de_NacimientoIds = string.Join(",", filter.AdvancePais_de_NacimientoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Pais_de_Nacimiento In (" + Pais_de_NacimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_de_Nacimiento))
            {
                switch (filter.Estado_de_NacimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_de_Nacimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_Nacimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_de_Nacimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_Nacimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_de_NacimientoMultiple != null && filter.AdvanceEstado_de_NacimientoMultiple.Count() > 0)
            {
                var Estado_de_NacimientoIds = string.Join(",", filter.AdvanceEstado_de_NacimientoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Estado_de_Nacimiento In (" + Estado_de_NacimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Orden))
            {
                switch (filter.Tipo_de_OrdenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Orden.Tipo_de_Ordenx LIKE '" + filter.AdvanceTipo_de_Orden + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Orden.Tipo_de_Ordenx LIKE '%" + filter.AdvanceTipo_de_Orden + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Orden.Tipo_de_Ordenx = '" + filter.AdvanceTipo_de_Orden + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Orden.Tipo_de_Ordenx LIKE '%" + filter.AdvanceTipo_de_Orden + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_OrdenMultiple != null && filter.AdvanceTipo_de_OrdenMultiple.Count() > 0)
            {
                var Tipo_de_OrdenIds = string.Join(",", filter.AdvanceTipo_de_OrdenMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Tipo_de_Orden In (" + Tipo_de_OrdenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Orden) || !string.IsNullOrEmpty(filter.ToFecha_de_Orden))
            {
                var Fecha_de_OrdenFrom = DateTime.ParseExact(filter.FromFecha_de_Orden, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_OrdenTo = DateTime.ParseExact(filter.ToFecha_de_Orden, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Orden))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Orden >= '" + Fecha_de_OrdenFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Orden))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Orden <= '" + Fecha_de_OrdenTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Orden) || !string.IsNullOrEmpty(filter.ToHora_de_Orden))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Orden))
                    where += " AND Convert(TIME,Registro_de_Mandamiento_Judicial.Hora_de_Orden) >='" + filter.FromHora_de_Orden + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Orden))
                    where += " AND Convert(TIME,Registro_de_Mandamiento_Judicial.Hora_de_Orden) <='" + filter.ToHora_de_Orden + "'";
            }

            if (!string.IsNullOrEmpty(filter.Dirigida_Por))
            {
                switch (filter.Dirigida_PorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Dirigida_Por LIKE '" + filter.Dirigida_Por + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Dirigida_Por LIKE '%" + filter.Dirigida_Por + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Dirigida_Por = '" + filter.Dirigida_Por + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Dirigida_Por LIKE '%" + filter.Dirigida_Por + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAmbito))
            {
                switch (filter.AmbitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ambito.Ambitox LIKE '" + filter.AdvanceAmbito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ambito.Ambitox LIKE '%" + filter.AdvanceAmbito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ambito.Ambitox = '" + filter.AdvanceAmbito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ambito.Ambitox LIKE '%" + filter.AdvanceAmbito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAmbitoMultiple != null && filter.AdvanceAmbitoMultiple.Count() > 0)
            {
                var AmbitoIds = string.Join(",", filter.AdvanceAmbitoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Ambito In (" + AmbitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceJuzgado))
            {
                switch (filter.JuzgadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Juzgado.Nombre LIKE '" + filter.AdvanceJuzgado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Juzgado.Nombre LIKE '%" + filter.AdvanceJuzgado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Juzgado.Nombre = '" + filter.AdvanceJuzgado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Juzgado.Nombre LIKE '%" + filter.AdvanceJuzgado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceJuzgadoMultiple != null && filter.AdvanceJuzgadoMultiple.Count() > 0)
            {
                var JuzgadoIds = string.Join(",", filter.AdvanceJuzgadoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Juzgado In (" + JuzgadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Juez))
            {
                switch (filter.JuezFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Juez LIKE '" + filter.Juez + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Juez LIKE '%" + filter.Juez + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Juez = '" + filter.Juez + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Juez LIKE '%" + filter.Juez + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecialidad))
            {
                switch (filter.EspecialidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especialidad_MP.Descripcion LIKE '" + filter.AdvanceEspecialidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especialidad_MP.Descripcion LIKE '%" + filter.AdvanceEspecialidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especialidad_MP.Descripcion = '" + filter.AdvanceEspecialidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especialidad_MP.Descripcion LIKE '%" + filter.AdvanceEspecialidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecialidadMultiple != null && filter.AdvanceEspecialidadMultiple.Count() > 0)
            {
                var EspecialidadIds = string.Join(",", filter.AdvanceEspecialidadMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Especialidad In (" + EspecialidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Causa))
            {
                switch (filter.Numero_de_CausaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Causa LIKE '" + filter.Numero_de_Causa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Causa LIKE '%" + filter.Numero_de_Causa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Causa = '" + filter.Numero_de_Causa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Causa LIKE '%" + filter.Numero_de_Causa + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Oficio) || !string.IsNullOrEmpty(filter.ToFecha_de_Oficio))
            {
                var Fecha_de_OficioFrom = DateTime.ParseExact(filter.FromFecha_de_Oficio, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_OficioTo = DateTime.ParseExact(filter.ToFecha_de_Oficio, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Oficio))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Oficio >= '" + Fecha_de_OficioFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Oficio))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Oficio <= '" + Fecha_de_OficioTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Cuantia))
            {
                switch (filter.Tipo_de_CuantiaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Cuantia.Descripcion LIKE '" + filter.AdvanceTipo_de_Cuantia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Cuantia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Cuantia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Cuantia.Descripcion = '" + filter.AdvanceTipo_de_Cuantia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Cuantia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Cuantia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_CuantiaMultiple != null && filter.AdvanceTipo_de_CuantiaMultiple.Count() > 0)
            {
                var Tipo_de_CuantiaIds = string.Join(",", filter.AdvanceTipo_de_CuantiaMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Tipo_de_Cuantia In (" + Tipo_de_CuantiaIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Forma_Cara In (" + Forma_CaraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCejas))
            {
                switch (filter.CejasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cejas.Descripcion LIKE '" + filter.AdvanceCejas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cejas.Descripcion LIKE '%" + filter.AdvanceCejas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cejas.Descripcion = '" + filter.AdvanceCejas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cejas.Descripcion LIKE '%" + filter.AdvanceCejas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCejasMultiple != null && filter.AdvanceCejasMultiple.Count() > 0)
            {
                var CejasIds = string.Join(",", filter.AdvanceCejasMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Cejas In (" + CejasIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Cantidad_Cabello In (" + Cantidad_CabelloIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Implantacion_Cabello In (" + Implantacion_CabelloIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Complexion In (" + ComplexionIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Color_Piel In (" + Color_PielIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Frente In (" + FrenteIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Forma_Cabello In (" + Forma_CabelloIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Color_Cabello In (" + Color_CabelloIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Calvicie In (" + CalvicieIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Color_Ojos In (" + Color_OjosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOjos))
            {
                switch (filter.OjosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ojos.Descripcion LIKE '" + filter.AdvanceOjos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ojos.Descripcion LIKE '%" + filter.AdvanceOjos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ojos.Descripcion = '" + filter.AdvanceOjos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ojos.Descripcion LIKE '%" + filter.AdvanceOjos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOjosMultiple != null && filter.AdvanceOjosMultiple.Count() > 0)
            {
                var OjosIds = string.Join(",", filter.AdvanceOjosMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Ojos In (" + OjosIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Forma_Ojos In (" + Forma_OjosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNariz_Base))
            {
                switch (filter.Nariz_BaseFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nariz_Base.Descripcion LIKE '" + filter.AdvanceNariz_Base + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nariz_Base.Descripcion LIKE '%" + filter.AdvanceNariz_Base + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nariz_Base.Descripcion = '" + filter.AdvanceNariz_Base + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nariz_Base.Descripcion LIKE '%" + filter.AdvanceNariz_Base + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNariz_BaseMultiple != null && filter.AdvanceNariz_BaseMultiple.Count() > 0)
            {
                var Nariz_BaseIds = string.Join(",", filter.AdvanceNariz_BaseMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Nariz_Base In (" + Nariz_BaseIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Labios In (" + LabiosIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Boca In (" + BocaIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Menton In (" + MentonIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Barba In (" + BarbaIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Forma_Orejas In (" + Forma_OrejasIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Tamano_Orejas In (" + Tamano_OrejasIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Tipo_Lobulo In (" + Tipo_LobuloIds + ")";
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

                where += " AND Registro_de_Mandamiento_Judicial.Bigote In (" + BigoteIds + ")";
            }

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

                where += " AND Registro_de_Mandamiento_Judicial.Situacion_Fisica In (" + Situacion_FisicaIds + ")";
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

            if (!string.IsNullOrEmpty(filter.AdvanceFuerzo))
            {
                switch (filter.FuerzoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Fuerzo.Descripcion LIKE '" + filter.AdvanceFuerzo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Fuerzo.Descripcion LIKE '%" + filter.AdvanceFuerzo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Fuerzo.Descripcion = '" + filter.AdvanceFuerzo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Fuerzo.Descripcion LIKE '%" + filter.AdvanceFuerzo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFuerzoMultiple != null && filter.AdvanceFuerzoMultiple.Count() > 0)
            {
                var FuerzoIds = string.Join(",", filter.AdvanceFuerzoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Fuerzo In (" + FuerzoIds + ")";
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

            if (!string.IsNullOrEmpty(filter.Numero_de_Averiguacion))
            {
                switch (filter.Numero_de_AveriguacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Averiguacion LIKE '" + filter.Numero_de_Averiguacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Averiguacion LIKE '%" + filter.Numero_de_Averiguacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Averiguacion = '" + filter.Numero_de_Averiguacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Averiguacion LIKE '%" + filter.Numero_de_Averiguacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Captura) || !string.IsNullOrEmpty(filter.ToFecha_de_Captura))
            {
                var Fecha_de_CapturaFrom = DateTime.ParseExact(filter.FromFecha_de_Captura, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CapturaTo = DateTime.ParseExact(filter.ToFecha_de_Captura, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Captura))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Captura >= '" + Fecha_de_CapturaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Captura))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Captura <= '" + Fecha_de_CapturaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Recepcion) || !string.IsNullOrEmpty(filter.ToFecha_de_Recepcion))
            {
                var Fecha_de_RecepcionFrom = DateTime.ParseExact(filter.FromFecha_de_Recepcion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RecepcionTo = DateTime.ParseExact(filter.ToFecha_de_Recepcion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Recepcion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Recepcion >= '" + Fecha_de_RecepcionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Recepcion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Recepcion <= '" + Fecha_de_RecepcionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Prescripcion) || !string.IsNullOrEmpty(filter.ToFecha_de_Prescripcion))
            {
                var Fecha_de_PrescripcionFrom = DateTime.ParseExact(filter.FromFecha_de_Prescripcion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_PrescripcionTo = DateTime.ParseExact(filter.ToFecha_de_Prescripcion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Prescripcion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Prescripcion >= '" + Fecha_de_PrescripcionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Prescripcion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Prescripcion <= '" + Fecha_de_PrescripcionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento))
            {
                var Fecha_de_CumplimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Cumplimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CumplimientoTo = DateTime.ParseExact(filter.ToFecha_de_Cumplimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento >= '" + Fecha_de_CumplimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento <= '" + Fecha_de_CumplimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Oficio_de_Cumplimiento))
            {
                switch (filter.Oficio_de_CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento LIKE '" + filter.Oficio_de_Cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento LIKE '%" + filter.Oficio_de_Cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento = '" + filter.Oficio_de_Cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento LIKE '%" + filter.Oficio_de_Cumplimiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cancelacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Cancelacion))
            {
                var Fecha_de_CancelacionFrom = DateTime.ParseExact(filter.FromFecha_de_Cancelacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CancelacionTo = DateTime.ParseExact(filter.ToFecha_de_Cancelacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cancelacion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Cancelacion >= '" + Fecha_de_CancelacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cancelacion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Cancelacion <= '" + Fecha_de_CancelacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMotivo_de_Cancelacion))
            {
                switch (filter.Motivo_de_CancelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Motivo_de_Cancelacion_del_Proceso.Descripcion LIKE '" + filter.AdvanceMotivo_de_Cancelacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Motivo_de_Cancelacion_del_Proceso.Descripcion LIKE '%" + filter.AdvanceMotivo_de_Cancelacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Motivo_de_Cancelacion_del_Proceso.Descripcion = '" + filter.AdvanceMotivo_de_Cancelacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Motivo_de_Cancelacion_del_Proceso.Descripcion LIKE '%" + filter.AdvanceMotivo_de_Cancelacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMotivo_de_CancelacionMultiple != null && filter.AdvanceMotivo_de_CancelacionMultiple.Count() > 0)
            {
                var Motivo_de_CancelacionIds = string.Join(",", filter.AdvanceMotivo_de_CancelacionMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Motivo_de_Cancelacion In (" + Motivo_de_CancelacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Oficio_de_Cancelacion))
            {
                switch (filter.Oficio_de_CancelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cancelacion LIKE '" + filter.Oficio_de_Cancelacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cancelacion LIKE '%" + filter.Oficio_de_Cancelacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cancelacion = '" + filter.Oficio_de_Cancelacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Cancelacion LIKE '%" + filter.Oficio_de_Cancelacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Proceso))
            {
                switch (filter.Tipo_de_ProcesoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Proceso.Descripcion LIKE '" + filter.AdvanceTipo_de_Proceso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Proceso.Descripcion LIKE '%" + filter.AdvanceTipo_de_Proceso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Proceso.Descripcion = '" + filter.AdvanceTipo_de_Proceso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Proceso.Descripcion LIKE '%" + filter.AdvanceTipo_de_Proceso + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ProcesoMultiple != null && filter.AdvanceTipo_de_ProcesoMultiple.Count() > 0)
            {
                var Tipo_de_ProcesoIds = string.Join(",", filter.AdvanceTipo_de_ProcesoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Tipo_de_Proceso In (" + Tipo_de_ProcesoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProceso_de_Extradiccion))
            {
                switch (filter.Proceso_de_ExtradiccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Extradiccion.Descripcion LIKE '" + filter.AdvanceProceso_de_Extradiccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Extradiccion.Descripcion LIKE '%" + filter.AdvanceProceso_de_Extradiccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Extradiccion.Descripcion = '" + filter.AdvanceProceso_de_Extradiccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Extradiccion.Descripcion LIKE '%" + filter.AdvanceProceso_de_Extradiccion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProceso_de_ExtradiccionMultiple != null && filter.AdvanceProceso_de_ExtradiccionMultiple.Count() > 0)
            {
                var Proceso_de_ExtradiccionIds = string.Join(",", filter.AdvanceProceso_de_ExtradiccionMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Proceso_de_Extradiccion In (" + Proceso_de_ExtradiccionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observacionesx))
            {
                switch (filter.ObservacionesxFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Observacionesx LIKE '" + filter.Observacionesx + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Observacionesx LIKE '%" + filter.Observacionesx + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Observacionesx = '" + filter.Observacionesx + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Observacionesx LIKE '%" + filter.Observacionesx + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromHuellas_Digitales) || !string.IsNullOrEmpty(filter.ToHuellas_Digitales))
            {
                if (!string.IsNullOrEmpty(filter.FromHuellas_Digitales))
                    where += " AND Registro_de_Mandamiento_Judicial.Huellas_Digitales >= " + filter.FromHuellas_Digitales;
                if (!string.IsNullOrEmpty(filter.ToHuellas_Digitales))
                    where += " AND Registro_de_Mandamiento_Judicial.Huellas_Digitales <= " + filter.ToHuellas_Digitales;
            }

            if (!string.IsNullOrEmpty(filter.FromMano_Izquierda_dedos) || !string.IsNullOrEmpty(filter.ToMano_Izquierda_dedos))
            {
                if (!string.IsNullOrEmpty(filter.FromMano_Izquierda_dedos))
                    where += " AND Registro_de_Mandamiento_Judicial.Mano_Izquierda_dedos >= " + filter.FromMano_Izquierda_dedos;
                if (!string.IsNullOrEmpty(filter.ToMano_Izquierda_dedos))
                    where += " AND Registro_de_Mandamiento_Judicial.Mano_Izquierda_dedos <= " + filter.ToMano_Izquierda_dedos;
            }

            if (!string.IsNullOrEmpty(filter.FromMano_Derecha_Pulgar) || !string.IsNullOrEmpty(filter.ToMano_Derecha_Pulgar))
            {
                if (!string.IsNullOrEmpty(filter.FromMano_Derecha_Pulgar))
                    where += " AND Registro_de_Mandamiento_Judicial.Mano_Derecha_Pulgar >= " + filter.FromMano_Derecha_Pulgar;
                if (!string.IsNullOrEmpty(filter.ToMano_Derecha_Pulgar))
                    where += " AND Registro_de_Mandamiento_Judicial.Mano_Derecha_Pulgar <= " + filter.ToMano_Derecha_Pulgar;
            }

            if (!string.IsNullOrEmpty(filter.FromMano_Derecha_Dedos) || !string.IsNullOrEmpty(filter.ToMano_Derecha_Dedos))
            {
                if (!string.IsNullOrEmpty(filter.FromMano_Derecha_Dedos))
                    where += " AND Registro_de_Mandamiento_Judicial.Mano_Derecha_Dedos >= " + filter.FromMano_Derecha_Dedos;
                if (!string.IsNullOrEmpty(filter.ToMano_Derecha_Dedos))
                    where += " AND Registro_de_Mandamiento_Judicial.Mano_Derecha_Dedos <= " + filter.ToMano_Derecha_Dedos;
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Domicilio(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_DomicilioGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_DomicilioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Domicilio.Registro_Orden_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Domicilio.Registro_Orden_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_DomicilioApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Domicilios == null)
                result.Detalle_de_Domicilios = new List<Detalle_de_Domicilio>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Domicilios.Select(m => new Detalle_de_DomicilioGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Domicilio = m.Tipo_de_Domicilio
                        ,Tipo_de_DomicilioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Domicilio_Tipo_de_Domicilio.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Domicilio_Tipo_de_Domicilio.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Observaciones_Comentarios = m.Observaciones_Comentarios

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_DomicilioGridModel> GetDetalle_de_DomicilioData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_DomicilioGridModel> resultData = new List<Detalle_de_DomicilioGridModel>();
            string where = "Detalle_de_Domicilio.Registro_Orden_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Domicilio.Registro_Orden_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_DomicilioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_DomicilioApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Domicilios != null)
            {
                resultData = result.Detalle_de_Domicilios.Select(m => new Detalle_de_DomicilioGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Domicilio = m.Tipo_de_Domicilio
                        ,Tipo_de_DomicilioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Domicilio_Tipo_de_Domicilio.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Domicilio_Tipo_de_Domicilio.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Observaciones_Comentarios = m.Observaciones_Comentarios


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_telefono(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_telefonoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_telefono.Registro_de_Orden_de_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_telefono.Registro_de_Orden_de_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_telefonoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_telefonos == null)
                result.Detalle_de_telefonos = new List<Detalle_de_telefono>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_telefonos.Select(m => new Detalle_de_telefonoGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Telefono = m.Tipo_de_Telefono
                        ,Tipo_de_TelefonoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Telefono_Tipo_de_Telefono.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
			,Telefono = m.Telefono
			,Extension = m.Extension

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_telefonoGridModel> GetDetalle_de_telefonoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_telefonoGridModel> resultData = new List<Detalle_de_telefonoGridModel>();
            string where = "Detalle_de_telefono.Registro_de_Orden_de_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_telefono.Registro_de_Orden_de_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_telefonoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_telefonos != null)
            {
                resultData = result.Detalle_de_telefonos.Select(m => new Detalle_de_telefonoGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Telefono = m.Tipo_de_Telefono
                        ,Tipo_de_TelefonoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Telefono_Tipo_de_Telefono.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
			,Telefono = m.Telefono
			,Extension = m.Extension


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Otro_Nombre(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Otro_NombreGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Otro_NombreApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Otro_Nombre.Orden_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Otro_Nombre.Orden_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_Otro_NombreApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Otro_Nombres == null)
                result.Detalle_de_Otro_Nombres = new List<Detalle_de_Otro_Nombre>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Otro_Nombres.Select(m => new Detalle_de_Otro_NombreGridModel
                {
                    Clave = m.Clave

			,Otro_Nombre_del_Individuo = m.Otro_Nombre_del_Individuo
			,Otro_Apellido_Paterno_del_Individuo = m.Otro_Apellido_Paterno_del_Individuo
			,Otro_Apellido_Materno_del_Individuo = m.Otro_Apellido_Materno_del_Individuo
			,Otro_Alias_del_Individuo = m.Otro_Alias_del_Individuo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Otro_NombreGridModel> GetDetalle_de_Otro_NombreData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Otro_NombreGridModel> resultData = new List<Detalle_de_Otro_NombreGridModel>();
            string where = "Detalle_de_Otro_Nombre.Orden_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Otro_Nombre.Orden_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Otro_NombreApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Otro_NombreApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Otro_Nombres != null)
            {
                resultData = result.Detalle_de_Otro_Nombres.Select(m => new Detalle_de_Otro_NombreGridModel
                    {
                        Clave = m.Clave

			,Otro_Nombre_del_Individuo = m.Otro_Nombre_del_Individuo
			,Otro_Apellido_Paterno_del_Individuo = m.Otro_Apellido_Paterno_del_Individuo
			,Otro_Apellido_Materno_del_Individuo = m.Otro_Apellido_Materno_del_Individuo
			,Otro_Alias_del_Individuo = m.Otro_Alias_del_Individuo


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Delito_Mandamiento_Judicial(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Delito_Mandamiento_JudicialGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Delito_Mandamiento_Judicials == null)
                result.Detalle_de_Delito_Mandamiento_Judicials = new List<Detalle_de_Delito_Mandamiento_Judicial>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Delito_Mandamiento_Judicials.Select(m => new Detalle_de_Delito_Mandamiento_JudicialGridModel
                {
                    Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Modalidad = m.Modalidad
                        ,ModalidadDescripcion = CultureHelper.GetTraduction(m.Modalidad_Modalidad_Delito.Clave.ToString(), "Descripcion") ??(string)m.Modalidad_Modalidad_Delito.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Delito_Mandamiento_JudicialGridModel> GetDetalle_de_Delito_Mandamiento_JudicialData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Delito_Mandamiento_JudicialGridModel> resultData = new List<Detalle_de_Delito_Mandamiento_JudicialGridModel>();
            string where = "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Delito_Mandamiento_Judicials != null)
            {
                resultData = result.Detalle_de_Delito_Mandamiento_Judicials.Select(m => new Detalle_de_Delito_Mandamiento_JudicialGridModel
                    {
                        Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Modalidad = m.Modalidad
                        ,ModalidadDescripcion = CultureHelper.GetTraduction(m.Modalidad_Modalidad_Delito.Clave.ToString(), "Descripcion") ??(string)m.Modalidad_Modalidad_Delito.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Amparo(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_AmparoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Amparo.Orden_de_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Amparo.Orden_de_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Amparo = m.Tipo_de_Amparo
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
			,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_Amparo = m.Entidad_que_Emitio_Amparo
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Nombre") ??(string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ??(string)m.Resolucion_Tipo_de_Resolucion.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_AmparoGridModel> GetDetalle_de_AmparoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_AmparoGridModel> resultData = new List<Detalle_de_AmparoGridModel>();
            string where = "Detalle_de_Amparo.Orden_de_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Amparo.Orden_de_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Amparos != null)
            {
                resultData = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Amparo = m.Tipo_de_Amparo
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
			,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_Amparo = m.Entidad_que_Emitio_Amparo
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Nombre") ??(string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ??(string)m.Resolucion_Tipo_de_Resolucion.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Fotos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_FotosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_FotosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Fotoss == null)
                result.Detalle_de_Fotoss = new List<Detalle_de_Fotos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Fotoss.Select(m => new Detalle_de_FotosGridModel
                {
                    Clave = m.Clave

			,Foto_Perfil_IzquierdoFileInfo = m.Foto_Perfil_Izquierdo > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Foto_Perfil_Izquierdo).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
			,Foto_Perfil_DerechoFileInfo = m.Foto_Perfil_Derecho > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Foto_Perfil_Derecho).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
			,Foto_de_FrenteFileInfo = m.Foto_de_Frente > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Foto_de_Frente).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_FotosGridModel> GetDetalle_de_FotosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_FotosGridModel> resultData = new List<Detalle_de_FotosGridModel>();
            string where = "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_FotosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Fotoss != null)
            {
                resultData = result.Detalle_de_Fotoss.Select(m => new Detalle_de_FotosGridModel
                    {
                        Clave = m.Clave

			,Foto_Perfil_IzquierdoFileInfo = m.Foto_Perfil_Izquierdo > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Foto_Perfil_Izquierdo).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
			,Foto_Perfil_DerechoFileInfo = m.Foto_Perfil_Derecho > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Foto_Perfil_Derecho).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
			,Foto_de_FrenteFileInfo = m.Foto_de_Frente > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Foto_de_Frente).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Documentos_Mandamiento_Judicial(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Documentos_Mandamiento_JudicialGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension='" + RelationId + "'";
            }
            var result = _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Documentos_Mandamiento_Judicials == null)
                result.Detalle_de_Documentos_Mandamiento_Judicials = new List<Detalle_de_Documentos_Mandamiento_Judicial>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Documentos_Mandamiento_Judicials.Select(m => new Detalle_de_Documentos_Mandamiento_JudicialGridModel
                {
                    Clave = m.Clave

			,DocumentosFileInfo = m.Documentos > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Documentos).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Documentos_Mandamiento_JudicialGridModel> GetDetalle_de_Documentos_Mandamiento_JudicialData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Documentos_Mandamiento_JudicialGridModel> resultData = new List<Detalle_de_Documentos_Mandamiento_JudicialGridModel>();
            string where = "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Documentos_Mandamiento_Judicials != null)
            {
                resultData = result.Detalle_de_Documentos_Mandamiento_Judicials.Select(m => new Detalle_de_Documentos_Mandamiento_JudicialGridModel
                    {
                        Clave = m.Clave

			,DocumentosFileInfo = m.Documentos > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Documentos).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }


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
                    _IDetalle_de_DomicilioApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Domicilio.Registro_Orden_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Domicilio.Registro_Orden_Aprehension='" + id + "'";
                    }
                    var Detalle_de_DomicilioInfo =
                        _IDetalle_de_DomicilioApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_DomicilioInfo.Detalle_de_Domicilios.Count > 0)
                    {
                        var resultDetalle_de_Domicilio = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_DomicilioItem in Detalle_de_DomicilioInfo.Detalle_de_Domicilios)
                            resultDetalle_de_Domicilio = resultDetalle_de_Domicilio
                                              && _IDetalle_de_DomicilioApiConsumer.Delete(Detalle_de_DomicilioItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Domicilio)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_telefono.Registro_de_Orden_de_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_telefono.Registro_de_Orden_de_Aprehension='" + id + "'";
                    }
                    var Detalle_de_telefonoInfo =
                        _IDetalle_de_telefonoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_telefonoInfo.Detalle_de_telefonos.Count > 0)
                    {
                        var resultDetalle_de_telefono = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_telefonoItem in Detalle_de_telefonoInfo.Detalle_de_telefonos)
                            resultDetalle_de_telefono = resultDetalle_de_telefono
                                              && _IDetalle_de_telefonoApiConsumer.Delete(Detalle_de_telefonoItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_telefono)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Otro_NombreApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Otro_Nombre.Orden_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Otro_Nombre.Orden_Aprehension='" + id + "'";
                    }
                    var Detalle_de_Otro_NombreInfo =
                        _IDetalle_de_Otro_NombreApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Otro_NombreInfo.Detalle_de_Otro_Nombres.Count > 0)
                    {
                        var resultDetalle_de_Otro_Nombre = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Otro_NombreItem in Detalle_de_Otro_NombreInfo.Detalle_de_Otro_Nombres)
                            resultDetalle_de_Otro_Nombre = resultDetalle_de_Otro_Nombre
                                              && _IDetalle_de_Otro_NombreApiConsumer.Delete(Detalle_de_Otro_NombreItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Otro_Nombre)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension='" + id + "'";
                    }
                    var Detalle_de_Delito_Mandamiento_JudicialInfo =
                        _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Delito_Mandamiento_JudicialInfo.Detalle_de_Delito_Mandamiento_Judicials.Count > 0)
                    {
                        var resultDetalle_de_Delito_Mandamiento_Judicial = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Delito_Mandamiento_JudicialItem in Detalle_de_Delito_Mandamiento_JudicialInfo.Detalle_de_Delito_Mandamiento_Judicials)
                            resultDetalle_de_Delito_Mandamiento_Judicial = resultDetalle_de_Delito_Mandamiento_Judicial
                                              && _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Delete(Detalle_de_Delito_Mandamiento_JudicialItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Delito_Mandamiento_Judicial)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Amparo.Orden_de_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Amparo.Orden_de_Aprehension='" + id + "'";
                    }
                    var Detalle_de_AmparoInfo =
                        _IDetalle_de_AmparoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_AmparoInfo.Detalle_de_Amparos.Count > 0)
                    {
                        var resultDetalle_de_Amparo = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_AmparoItem in Detalle_de_AmparoInfo.Detalle_de_Amparos)
                            resultDetalle_de_Amparo = resultDetalle_de_Amparo
                                              && _IDetalle_de_AmparoApiConsumer.Delete(Detalle_de_AmparoItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Amparo)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension='" + id + "'";
                    }
                    var Detalle_de_FotosInfo =
                        _IDetalle_de_FotosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_FotosInfo.Detalle_de_Fotoss.Count > 0)
                    {
                        var resultDetalle_de_Fotos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_FotosItem in Detalle_de_FotosInfo.Detalle_de_Fotoss)
                            resultDetalle_de_Fotos = resultDetalle_de_Fotos
                                              && _IDetalle_de_FotosApiConsumer.Delete(Detalle_de_FotosItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Fotos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension='" + id + "'";
                    }
                    var Detalle_de_Documentos_Mandamiento_JudicialInfo =
                        _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Documentos_Mandamiento_JudicialInfo.Detalle_de_Documentos_Mandamiento_Judicials.Count > 0)
                    {
                        var resultDetalle_de_Documentos_Mandamiento_Judicial = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Documentos_Mandamiento_JudicialItem in Detalle_de_Documentos_Mandamiento_JudicialInfo.Detalle_de_Documentos_Mandamiento_Judicials)
                            resultDetalle_de_Documentos_Mandamiento_Judicial = resultDetalle_de_Documentos_Mandamiento_Judicial
                                              && _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.Delete(Detalle_de_Documentos_Mandamiento_JudicialItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Documentos_Mandamiento_Judicial)
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
                        ,Folio_de_la_Orden_de_Aprehension = varRegistro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_Informacion = varRegistro_de_Mandamiento_Judicial.Pais_al_que_Pertenece_la_Informacion
                        ,Estado_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Estado_que_Envia_la_Informacion
                        ,Municipio_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Municipio_que_Envia_la_Informacion
                        ,Institucion_que_Remite = varRegistro_de_Mandamiento_Judicial.Institucion_que_Remite
                        ,Entidad_que_Emite_Mandamiento = varRegistro_de_Mandamiento_Judicial.Entidad_que_Emite_Mandamiento
                        ,Juzgado_que_Emitio_Mandamiento = varRegistro_de_Mandamiento_Judicial.Juzgado_que_Emitio_Mandamiento
                        ,Numero_de_Mandamiento = varRegistro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Oficio_de_Juzgado = varRegistro_de_Mandamiento_Judicial.Oficio_de_Juzgado
                        ,Nombre = varRegistro_de_Mandamiento_Judicial.Nombre
                        ,Alias = varRegistro_de_Mandamiento_Judicial.Alias
                        ,Apellido_Paterno = varRegistro_de_Mandamiento_Judicial.Apellido_Paterno
                        ,Apellido_Materno = varRegistro_de_Mandamiento_Judicial.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varRegistro_de_Mandamiento_Judicial.Edad
                        ,Estatura = varRegistro_de_Mandamiento_Judicial.Estatura
                        ,Peso = varRegistro_de_Mandamiento_Judicial.Peso
                        ,Usa_Anteojos = varRegistro_de_Mandamiento_Judicial.Usa_Anteojos
                        ,Sexo = varRegistro_de_Mandamiento_Judicial.Sexo
                        ,Estado_Civil = varRegistro_de_Mandamiento_Judicial.Estado_Civil
                        ,Tipo_de_Identificacion = varRegistro_de_Mandamiento_Judicial.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varRegistro_de_Mandamiento_Judicial.Numero_de_Identificacion
                        ,Nacionalidad = varRegistro_de_Mandamiento_Judicial.Nacionalidad
                        ,Escolaridad = varRegistro_de_Mandamiento_Judicial.Escolaridad
                        ,Ocupacion = varRegistro_de_Mandamiento_Judicial.Ocupacion
                        ,Pais_de_Nacimiento = varRegistro_de_Mandamiento_Judicial.Pais_de_Nacimiento
                        ,Estado_de_Nacimiento = varRegistro_de_Mandamiento_Judicial.Estado_de_Nacimiento
                        ,Tipo_de_Orden = varRegistro_de_Mandamiento_Judicial.Tipo_de_Orden
                        ,Fecha_de_Orden = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Orden)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Orden, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Orden = varRegistro_de_Mandamiento_Judicial.Hora_de_Orden
                        ,Dirigida_Por = varRegistro_de_Mandamiento_Judicial.Dirigida_Por
                        ,Ambito = varRegistro_de_Mandamiento_Judicial.Ambito
                        ,Juzgado = varRegistro_de_Mandamiento_Judicial.Juzgado
                        ,Juez = varRegistro_de_Mandamiento_Judicial.Juez
                        ,Especialidad = varRegistro_de_Mandamiento_Judicial.Especialidad
                        ,Numero_de_Causa = varRegistro_de_Mandamiento_Judicial.Numero_de_Causa
                        ,Fecha_de_Oficio = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Oficio)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Oficio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Tipo_de_Cuantia = varRegistro_de_Mandamiento_Judicial.Tipo_de_Cuantia
                        ,Observaciones = varRegistro_de_Mandamiento_Judicial.Observaciones
                        ,Forma_Cara = varRegistro_de_Mandamiento_Judicial.Forma_Cara
                        ,Cejas = varRegistro_de_Mandamiento_Judicial.Cejas
                        ,Cantidad_Cabello = varRegistro_de_Mandamiento_Judicial.Cantidad_Cabello
                        ,Implantacion_Cabello = varRegistro_de_Mandamiento_Judicial.Implantacion_Cabello
                        ,Complexion = varRegistro_de_Mandamiento_Judicial.Complexion
                        ,Color_Piel = varRegistro_de_Mandamiento_Judicial.Color_Piel
                        ,Frente = varRegistro_de_Mandamiento_Judicial.Frente
                        ,Forma_Cabello = varRegistro_de_Mandamiento_Judicial.Forma_Cabello
                        ,Color_Cabello = varRegistro_de_Mandamiento_Judicial.Color_Cabello
                        ,Calvicie = varRegistro_de_Mandamiento_Judicial.Calvicie
                        ,Color_Ojos = varRegistro_de_Mandamiento_Judicial.Color_Ojos
                        ,Ojos = varRegistro_de_Mandamiento_Judicial.Ojos
                        ,Forma_Ojos = varRegistro_de_Mandamiento_Judicial.Forma_Ojos
                        ,Nariz_Base = varRegistro_de_Mandamiento_Judicial.Nariz_Base
                        ,Labios = varRegistro_de_Mandamiento_Judicial.Labios
                        ,Boca = varRegistro_de_Mandamiento_Judicial.Boca
                        ,Menton = varRegistro_de_Mandamiento_Judicial.Menton
                        ,Barba = varRegistro_de_Mandamiento_Judicial.Barba
                        ,Forma_Orejas = varRegistro_de_Mandamiento_Judicial.Forma_Orejas
                        ,Tamano_Orejas = varRegistro_de_Mandamiento_Judicial.Tamano_Orejas
                        ,Tipo_Lobulo = varRegistro_de_Mandamiento_Judicial.Tipo_Lobulo
                        ,Bigote = varRegistro_de_Mandamiento_Judicial.Bigote
                        ,Situacion_Fisica = varRegistro_de_Mandamiento_Judicial.Situacion_Fisica
                        ,Fecha_de_Libramiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fuerzo = varRegistro_de_Mandamiento_Judicial.Fuerzo
                        ,Tipo_Mandato = varRegistro_de_Mandamiento_Judicial.Tipo_Mandato
                        ,Numero_de_Proceso_Judicial = varRegistro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial
                        ,Numero_de_Averiguacion = varRegistro_de_Mandamiento_Judicial.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Captura)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Captura, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Recepcion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Recepcion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Recepcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Prescripcion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Prescripcion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Prescripcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Cumplimiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Oficio_de_Cumplimiento = varRegistro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cancelacion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cancelacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Motivo_de_Cancelacion = varRegistro_de_Mandamiento_Judicial.Motivo_de_Cancelacion
                        ,Oficio_de_Cancelacion = varRegistro_de_Mandamiento_Judicial.Oficio_de_Cancelacion
                        ,Tipo_de_Proceso = varRegistro_de_Mandamiento_Judicial.Tipo_de_Proceso
                        ,Proceso_de_Extradiccion = varRegistro_de_Mandamiento_Judicial.Proceso_de_Extradiccion
                        ,Observacionesx = varRegistro_de_Mandamiento_Judicial.Observacionesx
                        ,Huellas_Digitales = varRegistro_de_Mandamiento_Judicial.Huellas_Digitales
                        ,Mano_Izquierda_dedos = varRegistro_de_Mandamiento_Judicial.Mano_Izquierda_dedos
                        ,Mano_Derecha_Pulgar = varRegistro_de_Mandamiento_Judicial.Mano_Derecha_Pulgar
                        ,Mano_Derecha_Dedos = varRegistro_de_Mandamiento_Judicial.Mano_Derecha_Dedos

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
        public bool CopyDetalle_de_Domicilio(int MasterId, int referenceId, List<Detalle_de_DomicilioGridModelPost> Detalle_de_DomicilioItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_DomicilioApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_DomicilioData = _IDetalle_de_DomicilioApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Domicilio.Registro_Orden_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_DomicilioData == null || Detalle_de_DomicilioData.Detalle_de_Domicilios.Count == 0)
                    return true;

                var result = true;

                Detalle_de_DomicilioGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Domicilio in Detalle_de_DomicilioData.Detalle_de_Domicilios)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Domicilio Detalle_de_Domicilio1 = varDetalle_de_Domicilio;

                    if (Detalle_de_DomicilioItems != null && Detalle_de_DomicilioItems.Any(m => m.Clave == Detalle_de_Domicilio1.Clave))
                    {
                        modelDataToChange = Detalle_de_DomicilioItems.FirstOrDefault(m => m.Clave == Detalle_de_Domicilio1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Domicilio.Registro_Orden_Aprehension = MasterId;
                    var insertId = _IDetalle_de_DomicilioApiConsumer.Insert(varDetalle_de_Domicilio,null,null).Resource;
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
        public ActionResult PostDetalle_de_Domicilio(List<Detalle_de_DomicilioGridModelPost> Detalle_de_DomicilioItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Domicilio(MasterId, referenceId, Detalle_de_DomicilioItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_DomicilioItems != null && Detalle_de_DomicilioItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_DomicilioApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_DomicilioItem in Detalle_de_DomicilioItems)
                    {












                        //Removal Request
                        if (Detalle_de_DomicilioItem.Removed)
                        {
                            result = result && _IDetalle_de_DomicilioApiConsumer.Delete(Detalle_de_DomicilioItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_DomicilioItem.Clave = 0;

                        var Detalle_de_DomicilioData = new Detalle_de_Domicilio
                        {
                            Registro_Orden_Aprehension = MasterId
                            ,Clave = Detalle_de_DomicilioItem.Clave
                            ,Tipo_de_Domicilio = (Convert.ToInt32(Detalle_de_DomicilioItem.Tipo_de_Domicilio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_DomicilioItem.Tipo_de_Domicilio))
                            ,Pais = (Convert.ToInt32(Detalle_de_DomicilioItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_DomicilioItem.Pais))
                            ,Estado = (Convert.ToInt32(Detalle_de_DomicilioItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_DomicilioItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_DomicilioItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_DomicilioItem.Municipio))
                            ,Colonia = (Convert.ToInt32(Detalle_de_DomicilioItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_DomicilioItem.Colonia))
                            ,Codigo_Postal = Detalle_de_DomicilioItem.Codigo_Postal
                            ,Calle = Detalle_de_DomicilioItem.Calle
                            ,Numero_Exterior = Detalle_de_DomicilioItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_DomicilioItem.Numero_Interior
                            ,Observaciones_Comentarios = Detalle_de_DomicilioItem.Observaciones_Comentarios

                        };

                        var resultId = Detalle_de_DomicilioItem.Clave > 0
                           ? _IDetalle_de_DomicilioApiConsumer.Update(Detalle_de_DomicilioData,null,null).Resource
                           : _IDetalle_de_DomicilioApiConsumer.Insert(Detalle_de_DomicilioData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Domicilio_Tipo_de_DomicilioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DomicilioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DomicilioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Domicilio", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Domicilio_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Domicilio_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Domicilio_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Domicilio_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_de_telefono(int MasterId, int referenceId, List<Detalle_de_telefonoGridModelPost> Detalle_de_telefonoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_telefonoData = _IDetalle_de_telefonoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_telefono.Registro_de_Orden_de_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_telefonoData == null || Detalle_de_telefonoData.Detalle_de_telefonos.Count == 0)
                    return true;

                var result = true;

                Detalle_de_telefonoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_telefono in Detalle_de_telefonoData.Detalle_de_telefonos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_telefono Detalle_de_telefono1 = varDetalle_de_telefono;

                    if (Detalle_de_telefonoItems != null && Detalle_de_telefonoItems.Any(m => m.Clave == Detalle_de_telefono1.Clave))
                    {
                        modelDataToChange = Detalle_de_telefonoItems.FirstOrDefault(m => m.Clave == Detalle_de_telefono1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_telefono.Registro_de_Orden_de_Aprehension = MasterId;
                    var insertId = _IDetalle_de_telefonoApiConsumer.Insert(varDetalle_de_telefono,null,null).Resource;
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
        public ActionResult PostDetalle_de_telefono(List<Detalle_de_telefonoGridModelPost> Detalle_de_telefonoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_telefono(MasterId, referenceId, Detalle_de_telefonoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_telefonoItems != null && Detalle_de_telefonoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_telefonoItem in Detalle_de_telefonoItems)
                    {





                        //Removal Request
                        if (Detalle_de_telefonoItem.Removed)
                        {
                            result = result && _IDetalle_de_telefonoApiConsumer.Delete(Detalle_de_telefonoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_telefonoItem.Clave = 0;

                        var Detalle_de_telefonoData = new Detalle_de_telefono
                        {
                            Registro_de_Orden_de_Aprehension = MasterId
                            ,Clave = Detalle_de_telefonoItem.Clave
                            ,Tipo_de_Telefono = (Convert.ToInt32(Detalle_de_telefonoItem.Tipo_de_Telefono) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_telefonoItem.Tipo_de_Telefono))
                            ,Telefono = Detalle_de_telefonoItem.Telefono
                            ,Extension = Detalle_de_telefonoItem.Extension

                        };

                        var resultId = Detalle_de_telefonoItem.Clave > 0
                           ? _IDetalle_de_telefonoApiConsumer.Update(Detalle_de_telefonoData,null,null).Resource
                           : _IDetalle_de_telefonoApiConsumer.Insert(Detalle_de_telefonoData,null,null).Resource;

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
        public ActionResult GetDetalle_de_telefono_Tipo_de_TelefonoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_TelefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_TelefonoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Telefono", "Descripcion");
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
        public bool CopyDetalle_de_Otro_Nombre(int MasterId, int referenceId, List<Detalle_de_Otro_NombreGridModelPost> Detalle_de_Otro_NombreItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Otro_NombreApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Otro_NombreData = _IDetalle_de_Otro_NombreApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Otro_Nombre.Orden_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_Otro_NombreData == null || Detalle_de_Otro_NombreData.Detalle_de_Otro_Nombres.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Otro_NombreGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Otro_Nombre in Detalle_de_Otro_NombreData.Detalle_de_Otro_Nombres)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Otro_Nombre Detalle_de_Otro_Nombre1 = varDetalle_de_Otro_Nombre;

                    if (Detalle_de_Otro_NombreItems != null && Detalle_de_Otro_NombreItems.Any(m => m.Clave == Detalle_de_Otro_Nombre1.Clave))
                    {
                        modelDataToChange = Detalle_de_Otro_NombreItems.FirstOrDefault(m => m.Clave == Detalle_de_Otro_Nombre1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Otro_Nombre.Orden_Aprehension = MasterId;
                    var insertId = _IDetalle_de_Otro_NombreApiConsumer.Insert(varDetalle_de_Otro_Nombre,null,null).Resource;
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
        public ActionResult PostDetalle_de_Otro_Nombre(List<Detalle_de_Otro_NombreGridModelPost> Detalle_de_Otro_NombreItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Otro_Nombre(MasterId, referenceId, Detalle_de_Otro_NombreItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Otro_NombreItems != null && Detalle_de_Otro_NombreItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Otro_NombreApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Otro_NombreItem in Detalle_de_Otro_NombreItems)
                    {






                        //Removal Request
                        if (Detalle_de_Otro_NombreItem.Removed)
                        {
                            result = result && _IDetalle_de_Otro_NombreApiConsumer.Delete(Detalle_de_Otro_NombreItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Otro_NombreItem.Clave = 0;

                        var Detalle_de_Otro_NombreData = new Detalle_de_Otro_Nombre
                        {
                            Orden_Aprehension = MasterId
                            ,Clave = Detalle_de_Otro_NombreItem.Clave
                            ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreItem.Otro_Nombre_del_Individuo
                            ,Otro_Apellido_Paterno_del_Individuo = Detalle_de_Otro_NombreItem.Otro_Apellido_Paterno_del_Individuo
                            ,Otro_Apellido_Materno_del_Individuo = Detalle_de_Otro_NombreItem.Otro_Apellido_Materno_del_Individuo
                            ,Otro_Alias_del_Individuo = Detalle_de_Otro_NombreItem.Otro_Alias_del_Individuo

                        };

                        var resultId = Detalle_de_Otro_NombreItem.Clave > 0
                           ? _IDetalle_de_Otro_NombreApiConsumer.Update(Detalle_de_Otro_NombreData,null,null).Resource
                           : _IDetalle_de_Otro_NombreApiConsumer.Insert(Detalle_de_Otro_NombreData,null,null).Resource;

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







        [NonAction]
        public bool CopyDetalle_de_Delito_Mandamiento_Judicial(int MasterId, int referenceId, List<Detalle_de_Delito_Mandamiento_JudicialGridModelPost> Detalle_de_Delito_Mandamiento_JudicialItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Delito_Mandamiento_JudicialData = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_Delito_Mandamiento_JudicialData == null || Detalle_de_Delito_Mandamiento_JudicialData.Detalle_de_Delito_Mandamiento_Judicials.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Delito_Mandamiento_JudicialGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Delito_Mandamiento_Judicial in Detalle_de_Delito_Mandamiento_JudicialData.Detalle_de_Delito_Mandamiento_Judicials)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Delito_Mandamiento_Judicial Detalle_de_Delito_Mandamiento_Judicial1 = varDetalle_de_Delito_Mandamiento_Judicial;

                    if (Detalle_de_Delito_Mandamiento_JudicialItems != null && Detalle_de_Delito_Mandamiento_JudicialItems.Any(m => m.Clave == Detalle_de_Delito_Mandamiento_Judicial1.Clave))
                    {
                        modelDataToChange = Detalle_de_Delito_Mandamiento_JudicialItems.FirstOrDefault(m => m.Clave == Detalle_de_Delito_Mandamiento_Judicial1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Delito_Mandamiento_Judicial.Orden_Aprehension = MasterId;
                    var insertId = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Insert(varDetalle_de_Delito_Mandamiento_Judicial,null,null).Resource;
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
        public ActionResult PostDetalle_de_Delito_Mandamiento_Judicial(List<Detalle_de_Delito_Mandamiento_JudicialGridModelPost> Detalle_de_Delito_Mandamiento_JudicialItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Delito_Mandamiento_Judicial(MasterId, referenceId, Detalle_de_Delito_Mandamiento_JudicialItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Delito_Mandamiento_JudicialItems != null && Detalle_de_Delito_Mandamiento_JudicialItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Delito_Mandamiento_JudicialItem in Detalle_de_Delito_Mandamiento_JudicialItems)
                    {




                        //Removal Request
                        if (Detalle_de_Delito_Mandamiento_JudicialItem.Removed)
                        {
                            result = result && _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Delete(Detalle_de_Delito_Mandamiento_JudicialItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Delito_Mandamiento_JudicialItem.Clave = 0;

                        var Detalle_de_Delito_Mandamiento_JudicialData = new Detalle_de_Delito_Mandamiento_Judicial
                        {
                            Orden_Aprehension = MasterId
                            ,Clave = Detalle_de_Delito_Mandamiento_JudicialItem.Clave
                            ,Delito = (Convert.ToInt32(Detalle_de_Delito_Mandamiento_JudicialItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Delito_Mandamiento_JudicialItem.Delito))
                            ,Modalidad = (Convert.ToInt16(Detalle_de_Delito_Mandamiento_JudicialItem.Modalidad) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Delito_Mandamiento_JudicialItem.Modalidad))

                        };

                        var resultId = Detalle_de_Delito_Mandamiento_JudicialItem.Clave > 0
                           ? _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Update(Detalle_de_Delito_Mandamiento_JudicialData,null,null).Resource
                           : _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Insert(Detalle_de_Delito_Mandamiento_JudicialData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Delito_Mandamiento_Judicial_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Delito_Mandamiento_Judicial_Modalidad_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modalidad_Delito", "Descripcion");
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
        public bool CopyDetalle_de_Amparo(int MasterId, int referenceId, List<Detalle_de_AmparoGridModelPost> Detalle_de_AmparoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_AmparoData = _IDetalle_de_AmparoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Amparo.Orden_de_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_AmparoData == null || Detalle_de_AmparoData.Detalle_de_Amparos.Count == 0)
                    return true;

                var result = true;

                Detalle_de_AmparoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Amparo in Detalle_de_AmparoData.Detalle_de_Amparos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Amparo Detalle_de_Amparo1 = varDetalle_de_Amparo;

                    if (Detalle_de_AmparoItems != null && Detalle_de_AmparoItems.Any(m => m.Clave == Detalle_de_Amparo1.Clave))
                    {
                        modelDataToChange = Detalle_de_AmparoItems.FirstOrDefault(m => m.Clave == Detalle_de_Amparo1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Amparo.Orden_de_Aprehension = MasterId;
                    var insertId = _IDetalle_de_AmparoApiConsumer.Insert(varDetalle_de_Amparo,null,null).Resource;
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
        public ActionResult PostDetalle_de_Amparo(List<Detalle_de_AmparoGridModelPost> Detalle_de_AmparoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Amparo(MasterId, referenceId, Detalle_de_AmparoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_AmparoItems != null && Detalle_de_AmparoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_AmparoItem in Detalle_de_AmparoItems)
                    {







                        //Removal Request
                        if (Detalle_de_AmparoItem.Removed)
                        {
                            result = result && _IDetalle_de_AmparoApiConsumer.Delete(Detalle_de_AmparoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_AmparoItem.Clave = 0;

                        var Detalle_de_AmparoData = new Detalle_de_Amparo
                        {
                            Orden_de_Aprehension = MasterId
                            ,Clave = Detalle_de_AmparoItem.Clave
                            ,Tipo_de_Amparo = (Convert.ToInt32(Detalle_de_AmparoItem.Tipo_de_Amparo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_AmparoItem.Tipo_de_Amparo))
                            ,Numero_de_Amparo = Detalle_de_AmparoItem.Numero_de_Amparo
                            ,Fecha_Amparo = (Detalle_de_AmparoItem.Fecha_Amparo!= null) ? DateTime.ParseExact(Detalle_de_AmparoItem.Fecha_Amparo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Entidad_que_Emitio_Amparo = (Convert.ToInt32(Detalle_de_AmparoItem.Entidad_que_Emitio_Amparo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_AmparoItem.Entidad_que_Emitio_Amparo))
                            ,Resolucion = (Convert.ToInt32(Detalle_de_AmparoItem.Resolucion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_AmparoItem.Resolucion))

                        };

                        var resultId = Detalle_de_AmparoItem.Clave > 0
                           ? _IDetalle_de_AmparoApiConsumer.Update(Detalle_de_AmparoData,null,null).Resource
                           : _IDetalle_de_AmparoApiConsumer.Insert(Detalle_de_AmparoData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Amparo_Tipo_de_AmparoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AmparoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Amparo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Amparo_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Amparo_Tipo_de_ResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ResolucionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Resolucion", "Descripcion");
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
        public bool CopyDetalle_de_Fotos(int MasterId, int referenceId, List<Detalle_de_FotosGridModelPost> Detalle_de_FotosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_FotosData = _IDetalle_de_FotosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Fotos.Registro_de_Orden_de_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_FotosData == null || Detalle_de_FotosData.Detalle_de_Fotoss.Count == 0)
                    return true;

                var result = true;

                Detalle_de_FotosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Fotos in Detalle_de_FotosData.Detalle_de_Fotoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Fotos Detalle_de_Fotos1 = varDetalle_de_Fotos;

                    if (Detalle_de_FotosItems != null && Detalle_de_FotosItems.Any(m => m.Clave == Detalle_de_Fotos1.Clave))
                    {
                        modelDataToChange = Detalle_de_FotosItems.FirstOrDefault(m => m.Clave == Detalle_de_Fotos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Fotos.Registro_de_Orden_de_Aprehension = MasterId;
                    var insertId = _IDetalle_de_FotosApiConsumer.Insert(varDetalle_de_Fotos,null,null).Resource;
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
        public ActionResult PostDetalle_de_Fotos(List<Detalle_de_FotosGridModelPost> Detalle_de_FotosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Fotos(MasterId, referenceId, Detalle_de_FotosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_FotosItems != null && Detalle_de_FotosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_FotosItem in Detalle_de_FotosItems)
                    {

                        #region Foto_Perfil_IzquierdoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.Control != null && !Detalle_de_FotosItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.Control);
                            Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_de_FotosItem.Removed && Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.RemoveFile)
                        {
                            Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.FileId = 0;
                        }
                        #endregion Foto_Perfil_IzquierdoInfo
                        #region Foto_Perfil_DerechoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.Control != null && !Detalle_de_FotosItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.Control);
                            Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_de_FotosItem.Removed && Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.RemoveFile)
                        {
                            Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.FileId = 0;
                        }
                        #endregion Foto_Perfil_DerechoInfo
                        #region Foto_de_FrenteInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_de_FotosItem.Foto_de_FrenteInfo.Control != null && !Detalle_de_FotosItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_de_FotosItem.Foto_de_FrenteInfo.Control);
                            Detalle_de_FotosItem.Foto_de_FrenteInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_de_FotosItem.Foto_de_FrenteInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_de_FotosItem.Removed && Detalle_de_FotosItem.Foto_de_FrenteInfo.RemoveFile)
                        {
                            Detalle_de_FotosItem.Foto_de_FrenteInfo.FileId = 0;
                        }
                        #endregion Foto_de_FrenteInfo

                        //Removal Request
                        if (Detalle_de_FotosItem.Removed)
                        {
                            result = result && _IDetalle_de_FotosApiConsumer.Delete(Detalle_de_FotosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_FotosItem.Clave = 0;

                        var Detalle_de_FotosData = new Detalle_de_Fotos
                        {
                            Registro_de_Orden_de_Aprehension = MasterId
                            ,Clave = Detalle_de_FotosItem.Clave
                            ,Foto_Perfil_Izquierdo = Detalle_de_FotosItem.Foto_Perfil_IzquierdoInfo.FileId
                            ,Foto_Perfil_Derecho = Detalle_de_FotosItem.Foto_Perfil_DerechoInfo.FileId
                            ,Foto_de_Frente = Detalle_de_FotosItem.Foto_de_FrenteInfo.FileId

                        };

                        var resultId = Detalle_de_FotosItem.Clave > 0
                           ? _IDetalle_de_FotosApiConsumer.Update(Detalle_de_FotosData,null,null).Resource
                           : _IDetalle_de_FotosApiConsumer.Insert(Detalle_de_FotosData,null,null).Resource;

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






        [NonAction]
        public bool CopyDetalle_de_Documentos_Mandamiento_Judicial(int MasterId, int referenceId, List<Detalle_de_Documentos_Mandamiento_JudicialGridModelPost> Detalle_de_Documentos_Mandamiento_JudicialItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Documentos_Mandamiento_JudicialData = _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension=" + referenceId,"").Resource;
                if (Detalle_de_Documentos_Mandamiento_JudicialData == null || Detalle_de_Documentos_Mandamiento_JudicialData.Detalle_de_Documentos_Mandamiento_Judicials.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Documentos_Mandamiento_JudicialGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Documentos_Mandamiento_Judicial in Detalle_de_Documentos_Mandamiento_JudicialData.Detalle_de_Documentos_Mandamiento_Judicials)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Documentos_Mandamiento_Judicial Detalle_de_Documentos_Mandamiento_Judicial1 = varDetalle_de_Documentos_Mandamiento_Judicial;

                    if (Detalle_de_Documentos_Mandamiento_JudicialItems != null && Detalle_de_Documentos_Mandamiento_JudicialItems.Any(m => m.Clave == Detalle_de_Documentos_Mandamiento_Judicial1.Clave))
                    {
                        modelDataToChange = Detalle_de_Documentos_Mandamiento_JudicialItems.FirstOrDefault(m => m.Clave == Detalle_de_Documentos_Mandamiento_Judicial1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Documentos_Mandamiento_Judicial.Registro_de_Orden_de_Aprehension = MasterId;
                    var insertId = _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.Insert(varDetalle_de_Documentos_Mandamiento_Judicial,null,null).Resource;
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
        public ActionResult PostDetalle_de_Documentos_Mandamiento_Judicial(List<Detalle_de_Documentos_Mandamiento_JudicialGridModelPost> Detalle_de_Documentos_Mandamiento_JudicialItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Documentos_Mandamiento_Judicial(MasterId, referenceId, Detalle_de_Documentos_Mandamiento_JudicialItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Documentos_Mandamiento_JudicialItems != null && Detalle_de_Documentos_Mandamiento_JudicialItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Documentos_Mandamiento_JudicialItem in Detalle_de_Documentos_Mandamiento_JudicialItems)
                    {

                        #region DocumentosInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.Control != null && !Detalle_de_Documentos_Mandamiento_JudicialItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.Control);
                            Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_de_Documentos_Mandamiento_JudicialItem.Removed && Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.RemoveFile)
                        {
                            Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.FileId = 0;
                        }
                        #endregion DocumentosInfo

                        //Removal Request
                        if (Detalle_de_Documentos_Mandamiento_JudicialItem.Removed)
                        {
                            result = result && _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.Delete(Detalle_de_Documentos_Mandamiento_JudicialItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Documentos_Mandamiento_JudicialItem.Clave = 0;

                        var Detalle_de_Documentos_Mandamiento_JudicialData = new Detalle_de_Documentos_Mandamiento_Judicial
                        {
                            Registro_de_Orden_de_Aprehension = MasterId
                            ,Clave = Detalle_de_Documentos_Mandamiento_JudicialItem.Clave
                            ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialItem.DocumentosInfo.FileId

                        };

                        var resultId = Detalle_de_Documentos_Mandamiento_JudicialItem.Clave > 0
                           ? _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.Update(Detalle_de_Documentos_Mandamiento_JudicialData,null,null).Resource
                           : _IDetalle_de_Documentos_Mandamiento_JudicialApiConsumer.Insert(Detalle_de_Documentos_Mandamiento_JudicialData,null,null).Resource;

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
        public ActionResult AddDetalle_de_Domicilio(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Domicilio/AddDetalle_de_Domicilio");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_telefono(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_telefono/AddDetalle_de_telefono");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Otro_Nombre(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Otro_Nombre/AddDetalle_de_Otro_Nombre");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Delito_Mandamiento_Judicial(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Delito_Mandamiento_Judicial/AddDetalle_de_Delito_Mandamiento_Judicial");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Amparo(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Amparo/AddDetalle_de_Amparo");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Fotos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Fotos/AddDetalle_de_Fotos");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Documentos_Mandamiento_Judicial(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Documentos_Mandamiento_Judicial/AddDetalle_de_Documentos_Mandamiento_Judicial");
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
			,Folio_de_la_Orden_de_Aprehension = m.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
			,Nombre = m.Nombre
			,Alias = m.Alias
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
			,Estatura = m.Estatura
			,Peso = m.Peso
			,Usa_Anteojos = m.Usa_Anteojos
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(m.Pais_de_Nacimiento_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Nacimiento_Pais.Nombre
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(m.Tipo_de_Orden_Tipo_de_Orden.Clave.ToString(), "Tipo_de_Ordenx") ?? (string)m.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                        ,Fecha_de_Orden = (m.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Orden = m.Hora_de_Orden
			,Dirigida_Por = m.Dirigida_Por
                        ,AmbitoAmbitox = CultureHelper.GetTraduction(m.Ambito_Ambito.Clave.ToString(), "Ambitox") ?? (string)m.Ambito_Ambito.Ambitox
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
			,Juez = m.Juez
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,Numero_de_Causa = m.Numero_de_Causa
                        ,Fecha_de_Oficio = (m.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                        ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cuantia_Tipo_de_Cuantia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
			,Observaciones = m.Observaciones
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                        ,FuerzoDescripcion = CultureHelper.GetTraduction(m.Fuerzo_Fuerzo.Clave.ToString(), "Descripcion") ?? (string)m.Fuerzo_Fuerzo.Descripcion
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
			,Numero_de_Averiguacion = m.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (m.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Prescripcion = (m.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Cumplimiento = m.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (m.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                        ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
			,Oficio_de_Cancelacion = m.Oficio_de_Cancelacion
                        ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Proceso_Tipo_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                        ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
			,Observacionesx = m.Observacionesx
			,Huellas_Digitales = m.Huellas_Digitales
			,Mano_Izquierda_dedos = m.Mano_Izquierda_dedos
			,Mano_Derecha_Pulgar = m.Mano_Derecha_Pulgar
			,Mano_Derecha_Dedos = m.Mano_Derecha_Dedos

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
			,Folio_de_la_Orden_de_Aprehension = m.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
			,Nombre = m.Nombre
			,Alias = m.Alias
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
			,Estatura = m.Estatura
			,Peso = m.Peso
			,Usa_Anteojos = m.Usa_Anteojos
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(m.Pais_de_Nacimiento_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Nacimiento_Pais.Nombre
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(m.Tipo_de_Orden_Tipo_de_Orden.Clave.ToString(), "Tipo_de_Ordenx") ?? (string)m.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                        ,Fecha_de_Orden = (m.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Orden = m.Hora_de_Orden
			,Dirigida_Por = m.Dirigida_Por
                        ,AmbitoAmbitox = CultureHelper.GetTraduction(m.Ambito_Ambito.Clave.ToString(), "Ambitox") ?? (string)m.Ambito_Ambito.Ambitox
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
			,Juez = m.Juez
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,Numero_de_Causa = m.Numero_de_Causa
                        ,Fecha_de_Oficio = (m.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                        ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cuantia_Tipo_de_Cuantia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
			,Observaciones = m.Observaciones
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Tamano_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Tamano_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                        ,FuerzoDescripcion = CultureHelper.GetTraduction(m.Fuerzo_Fuerzo.Clave.ToString(), "Descripcion") ?? (string)m.Fuerzo_Fuerzo.Descripcion
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
			,Numero_de_Averiguacion = m.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (m.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Prescripcion = (m.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Cumplimiento = m.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (m.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                        ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
			,Oficio_de_Cancelacion = m.Oficio_de_Cancelacion
                        ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Proceso_Tipo_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                        ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
			,Observacionesx = m.Observacionesx
			,Huellas_Digitales = m.Huellas_Digitales
			,Mano_Izquierda_dedos = m.Mano_Izquierda_dedos
			,Mano_Derecha_Pulgar = m.Mano_Derecha_Pulgar
			,Mano_Derecha_Dedos = m.Mano_Derecha_Dedos

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
                                            ,Folio_de_la_Orden_de_Aprehension = varRegistro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_Informacion = varRegistro_de_Mandamiento_Judicial.Pais_al_que_Pertenece_la_Informacion
                        ,Estado_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Estado_que_Envia_la_Informacion
                        ,Municipio_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Municipio_que_Envia_la_Informacion
                        ,Institucion_que_Remite = varRegistro_de_Mandamiento_Judicial.Institucion_que_Remite
                        ,Entidad_que_Emite_Mandamiento = varRegistro_de_Mandamiento_Judicial.Entidad_que_Emite_Mandamiento
                        ,Juzgado_que_Emitio_Mandamiento = varRegistro_de_Mandamiento_Judicial.Juzgado_que_Emitio_Mandamiento
                        ,Numero_de_Mandamiento = varRegistro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Oficio_de_Juzgado = varRegistro_de_Mandamiento_Judicial.Oficio_de_Juzgado
                        ,Nombre = varRegistro_de_Mandamiento_Judicial.Nombre
                        ,Alias = varRegistro_de_Mandamiento_Judicial.Alias
                        ,Apellido_Paterno = varRegistro_de_Mandamiento_Judicial.Apellido_Paterno
                        ,Apellido_Materno = varRegistro_de_Mandamiento_Judicial.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varRegistro_de_Mandamiento_Judicial.Edad
                        ,Estatura = varRegistro_de_Mandamiento_Judicial.Estatura
                        ,Peso = varRegistro_de_Mandamiento_Judicial.Peso
                        ,Usa_Anteojos = varRegistro_de_Mandamiento_Judicial.Usa_Anteojos
                        ,Sexo = varRegistro_de_Mandamiento_Judicial.Sexo
                        ,Estado_Civil = varRegistro_de_Mandamiento_Judicial.Estado_Civil
                        ,Tipo_de_Identificacion = varRegistro_de_Mandamiento_Judicial.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varRegistro_de_Mandamiento_Judicial.Numero_de_Identificacion
                        ,Nacionalidad = varRegistro_de_Mandamiento_Judicial.Nacionalidad
                        ,Escolaridad = varRegistro_de_Mandamiento_Judicial.Escolaridad
                        ,Ocupacion = varRegistro_de_Mandamiento_Judicial.Ocupacion
                        ,Pais_de_Nacimiento = varRegistro_de_Mandamiento_Judicial.Pais_de_Nacimiento
                        ,Estado_de_Nacimiento = varRegistro_de_Mandamiento_Judicial.Estado_de_Nacimiento
                    
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
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Folio_de_la_Orden_de_Aprehension = m.Folio_de_la_Orden_de_Aprehension
                        ,Pais_al_que_Pertenece_la_Informacion = m.Pais_al_que_Pertenece_la_Informacion
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_Informacion = m.Estado_que_Envia_la_Informacion
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_Informacion = m.Municipio_que_Envia_la_Informacion
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_Remite = m.Institucion_que_Remite
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
                        ,Entidad_que_Emite_Mandamiento = m.Entidad_que_Emite_Mandamiento
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_Mandamiento = m.Juzgado_que_Emitio_Mandamiento
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
			,Nombre = m.Nombre
			,Alias = m.Alias
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
			,Estatura = m.Estatura
			,Peso = m.Peso
			,Usa_Anteojos = m.Usa_Anteojos
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais_de_Nacimiento = m.Pais_de_Nacimiento
                        ,Pais_de_NacimientoNombre = CultureHelper.GetTraduction(m.Pais_de_Nacimiento_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Nacimiento_Pais.Nombre
                        ,Estado_de_Nacimiento = m.Estado_de_Nacimiento
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Domicilio(Registro_de_Mandamiento_Judicial_DomicilioModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_DomicilioInfo = new Registro_de_Mandamiento_Judicial_Domicilio
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Domicilio(Registro_de_Mandamiento_Judicial_DomicilioInfo).Resource.ToString();
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
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Domicilio(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_DomicilioModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Telefonos(Registro_de_Mandamiento_Judicial_TelefonosModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_TelefonosInfo = new Registro_de_Mandamiento_Judicial_Telefonos
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Telefonos(Registro_de_Mandamiento_Judicial_TelefonosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Telefonos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Telefonos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_TelefonosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Otros_Nombres(Registro_de_Mandamiento_Judicial_Otros_NombresModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_Otros_NombresInfo = new Registro_de_Mandamiento_Judicial_Otros_Nombres
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Otros_Nombres(Registro_de_Mandamiento_Judicial_Otros_NombresInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Otros_Nombres(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Otros_Nombres(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_Otros_NombresModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_la_Orden(Registro_de_Mandamiento_Judicial_Datos_de_la_OrdenModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_Datos_de_la_OrdenInfo = new Registro_de_Mandamiento_Judicial_Datos_de_la_Orden
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                            ,Tipo_de_Orden = varRegistro_de_Mandamiento_Judicial.Tipo_de_Orden
                        ,Fecha_de_Orden = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Orden)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Orden, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Orden = varRegistro_de_Mandamiento_Judicial.Hora_de_Orden
                        ,Dirigida_Por = varRegistro_de_Mandamiento_Judicial.Dirigida_Por
                        ,Ambito = varRegistro_de_Mandamiento_Judicial.Ambito
                        ,Juzgado = varRegistro_de_Mandamiento_Judicial.Juzgado
                        ,Juez = varRegistro_de_Mandamiento_Judicial.Juez
                        ,Especialidad = varRegistro_de_Mandamiento_Judicial.Especialidad
                        ,Numero_de_Causa = varRegistro_de_Mandamiento_Judicial.Numero_de_Causa
                        ,Fecha_de_Oficio = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Oficio)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Oficio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Tipo_de_Cuantia = varRegistro_de_Mandamiento_Judicial.Tipo_de_Cuantia
                        ,Observaciones = varRegistro_de_Mandamiento_Judicial.Observaciones
                    
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Datos_de_la_Orden(Registro_de_Mandamiento_Judicial_Datos_de_la_OrdenInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_la_Orden(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Datos_de_la_Orden(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_Datos_de_la_OrdenModel
                {
                    Clave = m.Clave
                        ,Tipo_de_Orden = m.Tipo_de_Orden
                        ,Tipo_de_OrdenTipo_de_Ordenx = CultureHelper.GetTraduction(m.Tipo_de_Orden_Tipo_de_Orden.Clave.ToString(), "Tipo_de_Ordenx") ?? (string)m.Tipo_de_Orden_Tipo_de_Orden.Tipo_de_Ordenx
                        ,Fecha_de_Orden = (m.Fecha_de_Orden == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Orden).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Orden = m.Hora_de_Orden
			,Dirigida_Por = m.Dirigida_Por
                        ,Ambito = m.Ambito
                        ,AmbitoAmbitox = CultureHelper.GetTraduction(m.Ambito_Ambito.Clave.ToString(), "Ambitox") ?? (string)m.Ambito_Ambito.Ambitox
                        ,Juzgado = m.Juzgado
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
			,Juez = m.Juez
                        ,Especialidad = m.Especialidad
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,Numero_de_Causa = m.Numero_de_Causa
                        ,Fecha_de_Oficio = (m.Fecha_de_Oficio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Oficio).ToString(ConfigurationProperty.DateFormat))
                        ,Tipo_de_Cuantia = m.Tipo_de_Cuantia
                        ,Tipo_de_CuantiaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cuantia_Tipo_de_Cuantia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cuantia_Tipo_de_Cuantia.Descripcion
			,Observaciones = m.Observaciones

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Delito(Registro_de_Mandamiento_Judicial_DelitoModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_DelitoInfo = new Registro_de_Mandamiento_Judicial_Delito
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Delito(Registro_de_Mandamiento_Judicial_DelitoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Delito(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Delito(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_DelitoModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Amparo(Registro_de_Mandamiento_Judicial_AmparoModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_AmparoInfo = new Registro_de_Mandamiento_Judicial_Amparo
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Amparo(Registro_de_Mandamiento_Judicial_AmparoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Amparo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Amparo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_AmparoModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Media_Filiacion(Registro_de_Mandamiento_Judicial_Media_FiliacionModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_Media_FiliacionInfo = new Registro_de_Mandamiento_Judicial_Media_Filiacion
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                            ,Forma_Cara = varRegistro_de_Mandamiento_Judicial.Forma_Cara
                        ,Cejas = varRegistro_de_Mandamiento_Judicial.Cejas
                        ,Cantidad_Cabello = varRegistro_de_Mandamiento_Judicial.Cantidad_Cabello
                        ,Implantacion_Cabello = varRegistro_de_Mandamiento_Judicial.Implantacion_Cabello
                        ,Complexion = varRegistro_de_Mandamiento_Judicial.Complexion
                        ,Color_Piel = varRegistro_de_Mandamiento_Judicial.Color_Piel
                        ,Frente = varRegistro_de_Mandamiento_Judicial.Frente
                        ,Forma_Cabello = varRegistro_de_Mandamiento_Judicial.Forma_Cabello
                        ,Color_Cabello = varRegistro_de_Mandamiento_Judicial.Color_Cabello
                        ,Calvicie = varRegistro_de_Mandamiento_Judicial.Calvicie
                        ,Color_Ojos = varRegistro_de_Mandamiento_Judicial.Color_Ojos
                        ,Ojos = varRegistro_de_Mandamiento_Judicial.Ojos
                        ,Forma_Ojos = varRegistro_de_Mandamiento_Judicial.Forma_Ojos
                        ,Nariz_Base = varRegistro_de_Mandamiento_Judicial.Nariz_Base
                        ,Labios = varRegistro_de_Mandamiento_Judicial.Labios
                        ,Boca = varRegistro_de_Mandamiento_Judicial.Boca
                        ,Menton = varRegistro_de_Mandamiento_Judicial.Menton
                        ,Barba = varRegistro_de_Mandamiento_Judicial.Barba
                        ,Forma_Orejas = varRegistro_de_Mandamiento_Judicial.Forma_Orejas
                        ,Tamano_Orejas = varRegistro_de_Mandamiento_Judicial.Tamano_Orejas
                        ,Tipo_Lobulo = varRegistro_de_Mandamiento_Judicial.Tipo_Lobulo
                        ,Bigote = varRegistro_de_Mandamiento_Judicial.Bigote
                        ,Situacion_Fisica = varRegistro_de_Mandamiento_Judicial.Situacion_Fisica
                    
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Media_Filiacion(Registro_de_Mandamiento_Judicial_Media_FiliacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Media_Filiacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Media_Filiacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_Media_FiliacionModel
                {
                    Clave = m.Clave
                        ,Forma_Cara = m.Forma_Cara
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Cejas = m.Cejas
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
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
                        ,Ojos = m.Ojos
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Ojos_Ojos.Descripcion
                        ,Forma_Ojos = m.Forma_Ojos
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_Base = m.Nariz_Base
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,Labios = m.Labios
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,Boca = m.Boca
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,Menton = m.Menton
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
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
                        ,Situacion_Fisica = m.Situacion_Fisica
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

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
                                            ,Fecha_de_Libramiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fuerzo = varRegistro_de_Mandamiento_Judicial.Fuerzo
                        ,Tipo_Mandato = varRegistro_de_Mandamiento_Judicial.Tipo_Mandato
                        ,Numero_de_Proceso_Judicial = varRegistro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial
                        ,Numero_de_Averiguacion = varRegistro_de_Mandamiento_Judicial.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Captura)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Captura, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Recepcion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Recepcion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Recepcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Prescripcion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Prescripcion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Prescripcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Cumplimiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Oficio_de_Cumplimiento = varRegistro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cancelacion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Cancelacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Motivo_de_Cancelacion = varRegistro_de_Mandamiento_Judicial.Motivo_de_Cancelacion
                        ,Oficio_de_Cancelacion = varRegistro_de_Mandamiento_Judicial.Oficio_de_Cancelacion
                        ,Tipo_de_Proceso = varRegistro_de_Mandamiento_Judicial.Tipo_de_Proceso
                        ,Proceso_de_Extradiccion = varRegistro_de_Mandamiento_Judicial.Proceso_de_Extradiccion
                        ,Observacionesx = varRegistro_de_Mandamiento_Judicial.Observacionesx
                    
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
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_ProcesoModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                        ,Fuerzo = m.Fuerzo
                        ,FuerzoDescripcion = CultureHelper.GetTraduction(m.Fuerzo_Fuerzo.Clave.ToString(), "Descripcion") ?? (string)m.Fuerzo_Fuerzo.Descripcion
                        ,Tipo_Mandato = m.Tipo_Mandato
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
			,Numero_de_Averiguacion = m.Numero_de_Averiguacion
                        ,Fecha_de_Captura = (m.Fecha_de_Captura == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Captura).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Prescripcion = (m.Fecha_de_Prescripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Prescripcion).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Cumplimiento = m.Oficio_de_Cumplimiento
                        ,Fecha_de_Cancelacion = (m.Fecha_de_Cancelacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cancelacion).ToString(ConfigurationProperty.DateFormat))
                        ,Motivo_de_Cancelacion = m.Motivo_de_Cancelacion
                        ,Motivo_de_CancelacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Cancelacion_Motivo_de_Cancelacion_del_Proceso.Descripcion
			,Oficio_de_Cancelacion = m.Oficio_de_Cancelacion
                        ,Tipo_de_Proceso = m.Tipo_de_Proceso
                        ,Tipo_de_ProcesoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Proceso_Tipo_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Proceso_Tipo_de_Proceso.Descripcion
                        ,Proceso_de_Extradiccion = m.Proceso_de_Extradiccion
                        ,Proceso_de_ExtradiccionDescripcion = CultureHelper.GetTraduction(m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_de_Extradiccion_Tipo_de_Extradiccion.Descripcion
			,Observacionesx = m.Observacionesx

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fotos(Registro_de_Mandamiento_Judicial_FotosModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_FotosInfo = new Registro_de_Mandamiento_Judicial_Fotos
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Fotos(Registro_de_Mandamiento_Judicial_FotosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fotos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Fotos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_FotosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Documentos(Registro_de_Mandamiento_Judicial_DocumentosModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_DocumentosInfo = new Registro_de_Mandamiento_Judicial_Documentos
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                        
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Documentos(Registro_de_Mandamiento_Judicial_DocumentosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Documentos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Documentos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_DocumentosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Huellas_Digitales(Registro_de_Mandamiento_Judicial_Huellas_DigitalesModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_Huellas_DigitalesInfo = new Registro_de_Mandamiento_Judicial_Huellas_Digitales
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                            ,Huellas_Digitales = varRegistro_de_Mandamiento_Judicial.Huellas_Digitales
                        ,Mano_Izquierda_dedos = varRegistro_de_Mandamiento_Judicial.Mano_Izquierda_dedos
                        ,Mano_Derecha_Pulgar = varRegistro_de_Mandamiento_Judicial.Mano_Derecha_Pulgar
                        ,Mano_Derecha_Dedos = varRegistro_de_Mandamiento_Judicial.Mano_Derecha_Dedos
                    
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Huellas_Digitales(Registro_de_Mandamiento_Judicial_Huellas_DigitalesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Huellas_Digitales(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Huellas_Digitales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Domicilio;
                var Detalle_de_DomicilioData = GetDetalle_de_DomicilioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Domicilio);
                int RowCount_Detalle_de_telefono;
                var Detalle_de_telefonoData = GetDetalle_de_telefonoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_telefono);
                int RowCount_Detalle_de_Otro_Nombre;
                var Detalle_de_Otro_NombreData = GetDetalle_de_Otro_NombreData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Otro_Nombre);
                int RowCount_Detalle_de_Delito_Mandamiento_Judicial;
                var Detalle_de_Delito_Mandamiento_JudicialData = GetDetalle_de_Delito_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Delito_Mandamiento_Judicial);
                int RowCount_Detalle_de_Amparo;
                var Detalle_de_AmparoData = GetDetalle_de_AmparoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Amparo);
                int RowCount_Detalle_de_Fotos;
                var Detalle_de_FotosData = GetDetalle_de_FotosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos);
                int RowCount_Detalle_de_Documentos_Mandamiento_Judicial;
                var Detalle_de_Documentos_Mandamiento_JudicialData = GetDetalle_de_Documentos_Mandamiento_JudicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_Mandamiento_Judicial);

                var result = new Registro_de_Mandamiento_Judicial_Huellas_DigitalesModel
                {
                    Clave = m.Clave
			,Huellas_Digitales = m.Huellas_Digitales
			,Mano_Izquierda_dedos = m.Mano_Izquierda_dedos
			,Mano_Derecha_Pulgar = m.Mano_Derecha_Pulgar
			,Mano_Derecha_Dedos = m.Mano_Derecha_Dedos

                    
                };
				var resultData = new
                {
                    data = result
                    ,Domicilio = Detalle_de_DomicilioData
                    ,Telefonos = Detalle_de_telefonoData
                    ,Otro_Nombre_del_Individuo = Detalle_de_Otro_NombreData
                    ,Delitos = Detalle_de_Delito_Mandamiento_JudicialData
                    ,Amparo = Detalle_de_AmparoData
                    ,Fotos = Detalle_de_FotosData
                    ,Documentos = Detalle_de_Documentos_Mandamiento_JudicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

