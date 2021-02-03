using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Otros_Nombres_Requerido_MASC;



using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Otros_Domicilios_Requeridos_MASC;

using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;






using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Corporacion;
using Spartane.Core.Domain.Etnia;
using Spartane.Core.Domain.Religion;
using Spartane.Core.Domain.Servicio_Medico;
using Spartane.Core.Domain.Especialidad;
using Spartane.Core.Domain.Estudios_Superiores;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Calidad_Migratoria;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Adicciones_Requerido_MASC;

using Spartane.Core.Domain.Adicciones;

using Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC;

using Spartane.Core.Domain.Lugares;


using Spartane.Core.Domain.Datos_Personales_Adicionales_Requerido_MASC;



using Spartane.Core.Domain.Redes_Sociales;


using Spartane.Core.Domain.Otras_Identificaciones_Requerido_MASC;

using Spartane.Core.Domain.Tipo_de_Identificacion;


using Spartane.Core.Domain.Discapacidades_Mentales;
using Spartane.Core.Domain.Discapacidades_Fisicas;
using Spartane.Core.Domain.Discapacidades_Sensoriales;
using Spartane.Core.Domain.Discapacidades_Psicosociales;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Core.Domain.Anteojos;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Grosor_de_Labios;
using Spartane.Core.Domain.Forma_de_Menton;
using Spartane.Core.Domain.Senas_Particulares;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Solicitud_Requerido;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Requerido;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Otros_Nombres_Requerido_MASC;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Requeridos_MASC;

using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Corporacion;
using Spartane.Web.Areas.WebApiConsumer.Etnia;
using Spartane.Web.Areas.WebApiConsumer.Religion;
using Spartane.Web.Areas.WebApiConsumer.Servicio_Medico;
using Spartane.Web.Areas.WebApiConsumer.Especialidad;
using Spartane.Web.Areas.WebApiConsumer.Estudios_Superiores;
using Spartane.Web.Areas.WebApiConsumer.Idioma;
using Spartane.Web.Areas.WebApiConsumer.Calidad_Migratoria;
using Spartane.Web.Areas.WebApiConsumer.Dialecto;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_Requerido_MASC;

using Spartane.Web.Areas.WebApiConsumer.Adicciones;

using Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Requerido_MASC;

using Spartane.Web.Areas.WebApiConsumer.Lugares;

using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Requerido_MASC;

using Spartane.Web.Areas.WebApiConsumer.Redes_Sociales;

using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Requerido_MASC;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;

using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Mentales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Fisicas;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Sensoriales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Psicosociales;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_de_Cejas;
using Spartane.Web.Areas.WebApiConsumer.Anteojos;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Nariz;
using Spartane.Web.Areas.WebApiConsumer.Nariz_Base;
using Spartane.Web.Areas.WebApiConsumer.Grosor_de_Labios;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Menton;
using Spartane.Web.Areas.WebApiConsumer.Senas_Particulares;

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
    public class Detalle_de_Solicitud_RequeridoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Solicitud_RequeridoService service = null;
        private IDetalle_de_Solicitud_RequeridoApiConsumer _IDetalle_de_Solicitud_RequeridoApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IOtros_Nombres_Requerido_MASCApiConsumer _IOtros_Nombres_Requerido_MASCApiConsumer;


        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IOtros_Domicilios_Requeridos_MASCApiConsumer _IOtros_Domicilios_Requeridos_MASCApiConsumer;


        private ITipo_de_InimputabilidadApiConsumer _ITipo_de_InimputabilidadApiConsumer;
        private ICorporacionApiConsumer _ICorporacionApiConsumer;
        private IEtniaApiConsumer _IEtniaApiConsumer;
        private IReligionApiConsumer _IReligionApiConsumer;
        private IServicio_MedicoApiConsumer _IServicio_MedicoApiConsumer;
        private IEspecialidadApiConsumer _IEspecialidadApiConsumer;
        private IEstudios_SuperioresApiConsumer _IEstudios_SuperioresApiConsumer;
        private IIdiomaApiConsumer _IIdiomaApiConsumer;
        private ICalidad_MigratoriaApiConsumer _ICalidad_MigratoriaApiConsumer;
        private IDialectoApiConsumer _IDialectoApiConsumer;
        private IAdicciones_Requerido_MASCApiConsumer _IAdicciones_Requerido_MASCApiConsumer;

        private IAdiccionesApiConsumer _IAdiccionesApiConsumer;

        private ILugares_Frecuentes_Requerido_MASCApiConsumer _ILugares_Frecuentes_Requerido_MASCApiConsumer;

        private ILugaresApiConsumer _ILugaresApiConsumer;

        private IDatos_Personales_Adicionales_Requerido_MASCApiConsumer _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer;

        private IRedes_SocialesApiConsumer _IRedes_SocialesApiConsumer;

        private IOtras_Identificaciones_Requerido_MASCApiConsumer _IOtras_Identificaciones_Requerido_MASCApiConsumer;


        private IDiscapacidades_MentalesApiConsumer _IDiscapacidades_MentalesApiConsumer;
        private IDiscapacidades_FisicasApiConsumer _IDiscapacidades_FisicasApiConsumer;
        private IDiscapacidades_SensorialesApiConsumer _IDiscapacidades_SensorialesApiConsumer;
        private IDiscapacidades_PsicosocialesApiConsumer _IDiscapacidades_PsicosocialesApiConsumer;
        private ICejasApiConsumer _ICejasApiConsumer;
        private ITamano_de_CejasApiConsumer _ITamano_de_CejasApiConsumer;
        private IAnteojosApiConsumer _IAnteojosApiConsumer;
        private IForma_de_NarizApiConsumer _IForma_de_NarizApiConsumer;
        private INariz_BaseApiConsumer _INariz_BaseApiConsumer;
        private IGrosor_de_LabiosApiConsumer _IGrosor_de_LabiosApiConsumer;
        private IForma_de_MentonApiConsumer _IForma_de_MentonApiConsumer;
        private ISenas_ParticularesApiConsumer _ISenas_ParticularesApiConsumer;

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

        
        public Detalle_de_Solicitud_RequeridoController(IDetalle_de_Solicitud_RequeridoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Solicitud_RequeridoApiConsumer Detalle_de_Solicitud_RequeridoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IOtros_Nombres_Requerido_MASCApiConsumer Otros_Nombres_Requerido_MASCApiConsumer  , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IOtros_Domicilios_Requeridos_MASCApiConsumer Otros_Domicilios_Requeridos_MASCApiConsumer  , ITipo_de_InimputabilidadApiConsumer Tipo_de_InimputabilidadApiConsumer , ICorporacionApiConsumer CorporacionApiConsumer , IEtniaApiConsumer EtniaApiConsumer , IReligionApiConsumer ReligionApiConsumer , IServicio_MedicoApiConsumer Servicio_MedicoApiConsumer , IEspecialidadApiConsumer EspecialidadApiConsumer , IEstudios_SuperioresApiConsumer Estudios_SuperioresApiConsumer , IIdiomaApiConsumer IdiomaApiConsumer , ICalidad_MigratoriaApiConsumer Calidad_MigratoriaApiConsumer , IDialectoApiConsumer DialectoApiConsumer , IAdicciones_Requerido_MASCApiConsumer Adicciones_Requerido_MASCApiConsumer , IAdiccionesApiConsumer AdiccionesApiConsumer  , ILugares_Frecuentes_Requerido_MASCApiConsumer Lugares_Frecuentes_Requerido_MASCApiConsumer , ILugaresApiConsumer LugaresApiConsumer  , IDatos_Personales_Adicionales_Requerido_MASCApiConsumer Datos_Personales_Adicionales_Requerido_MASCApiConsumer , IRedes_SocialesApiConsumer Redes_SocialesApiConsumer  , IOtras_Identificaciones_Requerido_MASCApiConsumer Otras_Identificaciones_Requerido_MASCApiConsumer  , IDiscapacidades_MentalesApiConsumer Discapacidades_MentalesApiConsumer , IDiscapacidades_FisicasApiConsumer Discapacidades_FisicasApiConsumer , IDiscapacidades_SensorialesApiConsumer Discapacidades_SensorialesApiConsumer , IDiscapacidades_PsicosocialesApiConsumer Discapacidades_PsicosocialesApiConsumer , ICejasApiConsumer CejasApiConsumer , ITamano_de_CejasApiConsumer Tamano_de_CejasApiConsumer , IAnteojosApiConsumer AnteojosApiConsumer , IForma_de_NarizApiConsumer Forma_de_NarizApiConsumer , INariz_BaseApiConsumer Nariz_BaseApiConsumer , IGrosor_de_LabiosApiConsumer Grosor_de_LabiosApiConsumer , IForma_de_MentonApiConsumer Forma_de_MentonApiConsumer , ISenas_ParticularesApiConsumer Senas_ParticularesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Solicitud_RequeridoApiConsumer = Detalle_de_Solicitud_RequeridoApiConsumer;
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
            this._IOtros_Nombres_Requerido_MASCApiConsumer = Otros_Nombres_Requerido_MASCApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IOtros_Domicilios_Requeridos_MASCApiConsumer = Otros_Domicilios_Requeridos_MASCApiConsumer;

            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ICorporacionApiConsumer = CorporacionApiConsumer;
            this._IEtniaApiConsumer = EtniaApiConsumer;
            this._IReligionApiConsumer = ReligionApiConsumer;
            this._IServicio_MedicoApiConsumer = Servicio_MedicoApiConsumer;
            this._IEspecialidadApiConsumer = EspecialidadApiConsumer;
            this._IEstudios_SuperioresApiConsumer = Estudios_SuperioresApiConsumer;
            this._IIdiomaApiConsumer = IdiomaApiConsumer;
            this._ICalidad_MigratoriaApiConsumer = Calidad_MigratoriaApiConsumer;
            this._IDialectoApiConsumer = DialectoApiConsumer;
            this._IAdicciones_Requerido_MASCApiConsumer = Adicciones_Requerido_MASCApiConsumer;

            this._IAdiccionesApiConsumer = AdiccionesApiConsumer;

            this._ILugares_Frecuentes_Requerido_MASCApiConsumer = Lugares_Frecuentes_Requerido_MASCApiConsumer;

            this._ILugaresApiConsumer = LugaresApiConsumer;

            this._IDatos_Personales_Adicionales_Requerido_MASCApiConsumer = Datos_Personales_Adicionales_Requerido_MASCApiConsumer;

            this._IRedes_SocialesApiConsumer = Redes_SocialesApiConsumer;

            this._IOtras_Identificaciones_Requerido_MASCApiConsumer = Otras_Identificaciones_Requerido_MASCApiConsumer;

            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;

            this._IDiscapacidades_MentalesApiConsumer = Discapacidades_MentalesApiConsumer;
            this._IDiscapacidades_FisicasApiConsumer = Discapacidades_FisicasApiConsumer;
            this._IDiscapacidades_SensorialesApiConsumer = Discapacidades_SensorialesApiConsumer;
            this._IDiscapacidades_PsicosocialesApiConsumer = Discapacidades_PsicosocialesApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._ICejasApiConsumer = CejasApiConsumer;
            this._ITamano_de_CejasApiConsumer = Tamano_de_CejasApiConsumer;
            this._IAnteojosApiConsumer = AnteojosApiConsumer;
            this._IForma_de_NarizApiConsumer = Forma_de_NarizApiConsumer;
            this._INariz_BaseApiConsumer = Nariz_BaseApiConsumer;
            this._IGrosor_de_LabiosApiConsumer = Grosor_de_LabiosApiConsumer;
            this._IForma_de_MentonApiConsumer = Forma_de_MentonApiConsumer;
            this._ISenas_ParticularesApiConsumer = Senas_ParticularesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Solicitud_Requerido
        [ObjectAuth(ObjectId = (ModuleObjectId)45043, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45043, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Solicitud_Requerido/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45043, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45043, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Solicitud_Requerido = new Detalle_de_Solicitud_RequeridoModel();
			varDetalle_de_Solicitud_Requerido.Clave = Id;
			
            ViewBag.ObjectId = "45043";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionOtros_Nombres_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45343, ModuleId);
            ViewBag.PermissionOtros_Nombres_Requerido_MASC = permissionOtros_Nombres_Requerido_MASC;
            var permissionOtros_Domicilios_Requeridos_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45337, ModuleId);
            ViewBag.PermissionOtros_Domicilios_Requeridos_MASC = permissionOtros_Domicilios_Requeridos_MASC;
            var permissionAdicciones_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45342, ModuleId);
            ViewBag.PermissionAdicciones_Requerido_MASC = permissionAdicciones_Requerido_MASC;
            var permissionLugares_Frecuentes_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45333, ModuleId);
            ViewBag.PermissionLugares_Frecuentes_Requerido_MASC = permissionLugares_Frecuentes_Requerido_MASC;
            var permissionDatos_Personales_Adicionales_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45334, ModuleId);
            ViewBag.PermissionDatos_Personales_Adicionales_Requerido_MASC = permissionDatos_Personales_Adicionales_Requerido_MASC;
            var permissionOtras_Identificaciones_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45335, ModuleId);
            ViewBag.PermissionOtras_Identificaciones_Requerido_MASC = permissionOtras_Identificaciones_Requerido_MASC;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Solicitud_RequeridosData = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitud_Requerido.Clave=" + Id, "").Resource.Detalle_de_Solicitud_Requeridos;
				
				if (Detalle_de_Solicitud_RequeridosData != null && Detalle_de_Solicitud_RequeridosData.Count > 0)
                {
					var Detalle_de_Solicitud_RequeridoData = Detalle_de_Solicitud_RequeridosData.First();
					varDetalle_de_Solicitud_Requerido= new Detalle_de_Solicitud_RequeridoModel
					{
						Clave  = Detalle_de_Solicitud_RequeridoData.Clave 
	                    ,idRegistroAT = Detalle_de_Solicitud_RequeridoData.idRegistroAT
                    ,idRegistroUI = Detalle_de_Solicitud_RequeridoData.idRegistroUI
                    ,Solicitud = Detalle_de_Solicitud_RequeridoData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitud_RequeridoData.Solicitud_Solicitud.Numero_de_Folio
                    ,A_Quien_Sea_Responsable = Detalle_de_Solicitud_RequeridoData.A_Quien_Sea_Responsable.GetValueOrDefault()
                    ,Nombre = Detalle_de_Solicitud_RequeridoData.Nombre
                    ,Apellido_Paterno = Detalle_de_Solicitud_RequeridoData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Solicitud_RequeridoData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Solicitud_RequeridoData.Nombre_Completo
                    ,Alias = Detalle_de_Solicitud_RequeridoData.Alias
                    ,Apodo = Detalle_de_Solicitud_RequeridoData.Apodo
                    ,CURP = Detalle_de_Solicitud_RequeridoData.CURP
                    ,RFC = Detalle_de_Solicitud_RequeridoData.RFC
                    ,Fecha_de_Nacimiento = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Solicitud_RequeridoData.Edad
                    ,Sexo = Detalle_de_Solicitud_RequeridoData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Sexo), "Genero") ??  (string)Detalle_de_Solicitud_RequeridoData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Solicitud_RequeridoData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Solicitud_RequeridoData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Solicitud_RequeridoData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Solicitud_RequeridoData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Solicitud_RequeridoData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Solicitud_RequeridoData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Solicitud_RequeridoData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Solicitud_RequeridoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado), "Estado") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Solicitud_RequeridoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = Detalle_de_Solicitud_RequeridoData.Codigo_Postal
                    ,Poblacion = Detalle_de_Solicitud_RequeridoData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Poblacion), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Solicitud_RequeridoData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Colonia), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Solicitud_RequeridoData.Calle
                    ,Numero_Exterior = Detalle_de_Solicitud_RequeridoData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Solicitud_RequeridoData.Numero_Interior
                    ,Entre_Calle = Detalle_de_Solicitud_RequeridoData.Entre_Calle
                    ,Y_Calle = Detalle_de_Solicitud_RequeridoData.Y_Calle
                    ,Referencia_de_Domicilio_Requerido = Detalle_de_Solicitud_RequeridoData.Referencia_de_Domicilio_Requerido
                    ,Latitud = Detalle_de_Solicitud_RequeridoData.Latitud
                    ,Longitud = Detalle_de_Solicitud_RequeridoData.Longitud
                    ,Telefono = Detalle_de_Solicitud_RequeridoData.Telefono
                    ,Extencion = Detalle_de_Solicitud_RequeridoData.Extencion
                    ,Celular = Detalle_de_Solicitud_RequeridoData.Celular
                    ,Correo_Electronico = Detalle_de_Solicitud_RequeridoData.Correo_Electronico
                    ,Pais_de_Origen = Detalle_de_Solicitud_RequeridoData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Pais.Nombre
                    ,Originario_de = Detalle_de_Solicitud_RequeridoData.Originario_de
                    ,Estado_de_Nacimiento = Detalle_de_Solicitud_RequeridoData.Estado_de_Nacimiento
                    ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_de_Nacimiento), "Estado") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_de_Nacimiento_Estado.Nombre
                    ,Municipio_de_Nacimiento = Detalle_de_Solicitud_RequeridoData.Municipio_de_Nacimiento
                    ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio_de_Nacimiento), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_de_Nacimiento_Municipio.Nombre
                    ,Inimputable = Detalle_de_Solicitud_RequeridoData.Inimputable.GetValueOrDefault()
                    ,Tipo_de_Inimputabilidad = Detalle_de_Solicitud_RequeridoData.Tipo_de_Inimputabilidad
                    ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tipo_de_Inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Se_Presenta_con_Detenido = Detalle_de_Solicitud_RequeridoData.Se_Presenta_con_Detenido.GetValueOrDefault()
                    ,Folio_Registro_Nacional_de_Detenciones = Detalle_de_Solicitud_RequeridoData.Folio_Registro_Nacional_de_Detenciones
                    ,Fecha_de_Detencion = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Municipio_de_Detencion = Detalle_de_Solicitud_RequeridoData.Municipio_de_Detencion
                    ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio_de_Detencion), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_de_Detencion_Municipio.Nombre
                    ,Corporacion = Detalle_de_Solicitud_RequeridoData.Corporacion
                    ,CorporacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Corporacion), "Corporacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Corporacion_Corporacion.Descripcion
                    ,Suspension_Condicional = Detalle_de_Solicitud_RequeridoData.Suspension_Condicional.GetValueOrDefault()
                    ,Fecha_de_Suspension_Condicional = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
                    ,Lugar_donde_se_Encuentra_Detenido = Detalle_de_Solicitud_RequeridoData.Lugar_donde_se_Encuentra_Detenido
                    ,Etnia = Detalle_de_Solicitud_RequeridoData.Etnia
                    ,EtniaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Etnia), "Etnia") ??  (string)Detalle_de_Solicitud_RequeridoData.Etnia_Etnia.Descripcion
                    ,No__de_Hijos = Detalle_de_Solicitud_RequeridoData.No__de_Hijos
                    ,Religion = Detalle_de_Solicitud_RequeridoData.Religion
                    ,ReligionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Religion), "Religion") ??  (string)Detalle_de_Solicitud_RequeridoData.Religion_Religion.Descripcion
                    ,Servicio_Medico = Detalle_de_Solicitud_RequeridoData.Servicio_Medico
                    ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Servicio_Medico), "Servicio_Medico") ??  (string)Detalle_de_Solicitud_RequeridoData.Servicio_Medico_Servicio_Medico.Descripcion
                    ,Especialidad = Detalle_de_Solicitud_RequeridoData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Especialidad), "Especialidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Especialidad_Especialidad.Descripcion
                    ,Estudios_Superiores = Detalle_de_Solicitud_RequeridoData.Estudios_Superiores
                    ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estudios_Superiores), "Estudios_Superiores") ??  (string)Detalle_de_Solicitud_RequeridoData.Estudios_Superiores_Estudios_Superiores.Descripcion
                    ,Idioma = Detalle_de_Solicitud_RequeridoData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Idioma), "Idioma") ??  (string)Detalle_de_Solicitud_RequeridoData.Idioma_Idioma.Descripcion
                    ,Calidad_Migratoria = Detalle_de_Solicitud_RequeridoData.Calidad_Migratoria
                    ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Calidad_Migratoria), "Calidad_Migratoria") ??  (string)Detalle_de_Solicitud_RequeridoData.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                    ,Dialecto = Detalle_de_Solicitud_RequeridoData.Dialecto
                    ,DialectoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Dialecto), "Dialecto") ??  (string)Detalle_de_Solicitud_RequeridoData.Dialecto_Dialecto.Descripcion
                    ,Viene_en_Estado_de_Ebriedad = Detalle_de_Solicitud_RequeridoData.Viene_en_Estado_de_Ebriedad.GetValueOrDefault()
                    ,Bajo_el_Efecto_de_una_Droga = Detalle_de_Solicitud_RequeridoData.Bajo_el_Efecto_de_una_Droga.GetValueOrDefault()
                    ,Nombre_de_Droga = Detalle_de_Solicitud_RequeridoData.Nombre_de_Droga
                    ,Discapacidad_Mental = Detalle_de_Solicitud_RequeridoData.Discapacidad_Mental
                    ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Mental), "Discapacidades_Mentales") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                    ,Discapacidad_Fisica = Detalle_de_Solicitud_RequeridoData.Discapacidad_Fisica
                    ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Fisica), "Discapacidades_Fisicas") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                    ,Discapacidad_Sensorial = Detalle_de_Solicitud_RequeridoData.Discapacidad_Sensorial
                    ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Sensorial), "Discapacidades_Sensoriales") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                    ,Discapacidad_Psicosocial = Detalle_de_Solicitud_RequeridoData.Discapacidad_Psicosocial
                    ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Psicosocial), "Discapacidades_Psicosociales") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
                    ,Nombre_de_Tutor = Detalle_de_Solicitud_RequeridoData.Nombre_de_Tutor
                    ,Apellido_Paterno_Tutor = Detalle_de_Solicitud_RequeridoData.Apellido_Paterno_Tutor
                    ,Apellido_Materno_Tutor = Detalle_de_Solicitud_RequeridoData.Apellido_Materno_Tutor
                    ,Nombre_Completo_Tutor = Detalle_de_Solicitud_RequeridoData.Nombre_Completo_Tutor
                    ,Fecha_de_Nacimiento_tutor = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_tutor = Detalle_de_Solicitud_RequeridoData.Edad_tutor
                    ,Sexo_tutor = Detalle_de_Solicitud_RequeridoData.Sexo_tutor
                    ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Sexo_tutor), "Genero") ??  (string)Detalle_de_Solicitud_RequeridoData.Sexo_tutor_Genero.Descripcion
                    ,Estado_Civil_tutor = Detalle_de_Solicitud_RequeridoData.Estado_Civil_tutor
                    ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_Civil_tutor), "Estado_Civil") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_Civil_tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_tutor = Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_tutor
                    ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_tutor = Detalle_de_Solicitud_RequeridoData.Numero_de_Identificacion_tutor
                    ,Nacionalidad_tutor = Detalle_de_Solicitud_RequeridoData.Nacionalidad_tutor
                    ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Nacionalidad_tutor), "Nacionalidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_tutor = Detalle_de_Solicitud_RequeridoData.Escolaridad_tutor
                    ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Escolaridad_tutor), "Escolaridad") ??  (string)Detalle_de_Solicitud_RequeridoData.Escolaridad_tutor_Escolaridad.Descripcion
                    ,Ocupacion_tutor = Detalle_de_Solicitud_RequeridoData.Ocupacion_tutor
                    ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Ocupacion_tutor), "Ocupacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Ocupacion_tutor_Ocupacion.Descripcion
                    ,Pais_tutor = Detalle_de_Solicitud_RequeridoData.Pais_tutor
                    ,Pais_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais_tutor), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_tutor_Pais.Nombre
                    ,Estado_tutor = Detalle_de_Solicitud_RequeridoData.Estado_tutor
                    ,Estado_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_tutor), "Estado") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_tutor_Estado.Nombre
                    ,Municipio_tutor = Detalle_de_Solicitud_RequeridoData.Municipio_tutor
                    ,Municipio_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio_tutor), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_tutor_Municipio.Nombre
                    ,Poblacion_tutor = Detalle_de_Solicitud_RequeridoData.Poblacion_tutor
                    ,Poblacion_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Poblacion_tutor), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Poblacion_tutor_Colonia.Nombre
                    ,Colonia_tutor = Detalle_de_Solicitud_RequeridoData.Colonia_tutor
                    ,Colonia_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Colonia_tutor), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Colonia_tutor_Colonia.Nombre
                    ,Codigo_Postal_tutor = Detalle_de_Solicitud_RequeridoData.Codigo_Postal_tutor
                    ,Calle_tutor = Detalle_de_Solicitud_RequeridoData.Calle_tutor
                    ,Numero_Exterior_tutor = Detalle_de_Solicitud_RequeridoData.Numero_Exterior_tutor
                    ,Numero_Interior_tutor = Detalle_de_Solicitud_RequeridoData.Numero_Interior_tutor
                    ,Referencia = Detalle_de_Solicitud_RequeridoData.Referencia
                    ,Latitud_tutor = Detalle_de_Solicitud_RequeridoData.Latitud_tutor
                    ,Longitud_tutor = Detalle_de_Solicitud_RequeridoData.Longitud_tutor
                    ,Extension_tutor = Detalle_de_Solicitud_RequeridoData.Extension_tutor
                    ,Celular_tutor = Detalle_de_Solicitud_RequeridoData.Celular_tutor
                    ,Correo_Electronico_tutor = Detalle_de_Solicitud_RequeridoData.Correo_Electronico_tutor
                    ,Pais_de_Origen_Tutor = Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Tutor
                    ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Tutor), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Tutor_Pais.Nombre
                    ,Originario_de_Tutor = Detalle_de_Solicitud_RequeridoData.Originario_de_Tutor
                    ,CURP_Tutor = Detalle_de_Solicitud_RequeridoData.CURP_Tutor
                    ,RFC_Tutor = Detalle_de_Solicitud_RequeridoData.RFC_Tutor
                    ,Padecimiento_de_Enfermedad = Detalle_de_Solicitud_RequeridoData.Padecimiento_de_Enfermedad
                    ,Cejas = Detalle_de_Solicitud_RequeridoData.Cejas
                    ,CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Cejas), "Cejas") ??  (string)Detalle_de_Solicitud_RequeridoData.Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Detalle_de_Solicitud_RequeridoData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Detalle_de_Solicitud_RequeridoData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Anteojos = Detalle_de_Solicitud_RequeridoData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Anteojos), "Anteojos") ??  (string)Detalle_de_Solicitud_RequeridoData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Detalle_de_Solicitud_RequeridoData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Detalle_de_Solicitud_RequeridoData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Nariz_base = Detalle_de_Solicitud_RequeridoData.Nariz_base
                    ,Nariz_baseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Nariz_base), "Nariz_Base") ??  (string)Detalle_de_Solicitud_RequeridoData.Nariz_base_Nariz_Base.Descripcion
                    ,Grosor_de_Labios = Detalle_de_Solicitud_RequeridoData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Detalle_de_Solicitud_RequeridoData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Forma_de_Menton = Detalle_de_Solicitud_RequeridoData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Detalle_de_Solicitud_RequeridoData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Senas_Particulares = Detalle_de_Solicitud_RequeridoData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Senas_Particulares), "Senas_Particulares") ??  (string)Detalle_de_Solicitud_RequeridoData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Detalle_de_Solicitud_RequeridoData.Imagen_Tatuaje
                    ,Otras_Senas_Particulares = Detalle_de_Solicitud_RequeridoData.Otras_Senas_Particulares
                    ,Imputado_Recluido = Detalle_de_Solicitud_RequeridoData.Imputado_Recluido

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Solicituds_Solicitud = _ISolicitudApiConsumer.SelAll(true);
            if (Solicituds_Solicitud != null && Solicituds_Solicitud.Resource != null)
                ViewBag.Solicituds_Solicitud = Solicituds_Solicitud.Resource.Where(m => m.Numero_de_Folio != null).OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio") ?? m.Numero_de_Folio.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEtniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Etnias_Etnia = _IEtniaApiConsumer.SelAll(true);
            if (Etnias_Etnia != null && Etnias_Etnia.Resource != null)
                ViewBag.Etnias_Etnia = Etnias_Etnia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Etnia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IReligionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Religions_Religion = _IReligionApiConsumer.SelAll(true);
            if (Religions_Religion != null && Religions_Religion.Resource != null)
                ViewBag.Religions_Religion = Religions_Religion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Religion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_MedicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_Medicos_Servicio_Medico = _IServicio_MedicoApiConsumer.SelAll(true);
            if (Servicio_Medicos_Servicio_Medico != null && Servicio_Medicos_Servicio_Medico.Resource != null)
                ViewBag.Servicio_Medicos_Servicio_Medico = Servicio_Medicos_Servicio_Medico.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_Medico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidads_Especialidad = _IEspecialidadApiConsumer.SelAll(true);
            if (Especialidads_Especialidad != null && Especialidads_Especialidad.Resource != null)
                ViewBag.Especialidads_Especialidad = Especialidads_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstudios_SuperioresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estudios_Superioress_Estudios_Superiores = _IEstudios_SuperioresApiConsumer.SelAll(true);
            if (Estudios_Superioress_Estudios_Superiores != null && Estudios_Superioress_Estudios_Superiores.Resource != null)
                ViewBag.Estudios_Superioress_Estudios_Superiores = Estudios_Superioress_Estudios_Superiores.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estudios_Superiores", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalidad_MigratoriaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calidad_Migratorias_Calidad_Migratoria = _ICalidad_MigratoriaApiConsumer.SelAll(true);
            if (Calidad_Migratorias_Calidad_Migratoria != null && Calidad_Migratorias_Calidad_Migratoria.Resource != null)
                ViewBag.Calidad_Migratorias_Calidad_Migratoria = Calidad_Migratorias_Calidad_Migratoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calidad_Migratoria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Dialecto = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Dialecto != null && Dialectos_Dialecto.Resource != null)
                ViewBag.Dialectos_Dialecto = Dialectos_Dialecto.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_MentalesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Mentaless_Discapacidad_Mental = _IDiscapacidades_MentalesApiConsumer.SelAll(true);
            if (Discapacidades_Mentaless_Discapacidad_Mental != null && Discapacidades_Mentaless_Discapacidad_Mental.Resource != null)
                ViewBag.Discapacidades_Mentaless_Discapacidad_Mental = Discapacidades_Mentaless_Discapacidad_Mental.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Mentales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_FisicasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Fisicass_Discapacidad_Fisica = _IDiscapacidades_FisicasApiConsumer.SelAll(true);
            if (Discapacidades_Fisicass_Discapacidad_Fisica != null && Discapacidades_Fisicass_Discapacidad_Fisica.Resource != null)
                ViewBag.Discapacidades_Fisicass_Discapacidad_Fisica = Discapacidades_Fisicass_Discapacidad_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Fisicas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_SensorialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Sensorialess_Discapacidad_Sensorial = _IDiscapacidades_SensorialesApiConsumer.SelAll(true);
            if (Discapacidades_Sensorialess_Discapacidad_Sensorial != null && Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource != null)
                ViewBag.Discapacidades_Sensorialess_Discapacidad_Sensorial = Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Sensoriales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_PsicosocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Psicosocialess_Discapacidad_Psicosocial = _IDiscapacidades_PsicosocialesApiConsumer.SelAll(true);
            if (Discapacidades_Psicosocialess_Discapacidad_Psicosocial != null && Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource != null)
                ViewBag.Discapacidades_Psicosocialess_Discapacidad_Psicosocial = Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Psicosociales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            var Nariz_Bases_Nariz_base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_base != null && Nariz_Bases_Nariz_base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_base = Nariz_Bases_Nariz_base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Solicitud_Requerido);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Solicitud_Requerido(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45043);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Solicitud_RequeridoModel varDetalle_de_Solicitud_Requerido= new Detalle_de_Solicitud_RequeridoModel();
            var permissionOtros_Nombres_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45343, ModuleId);
            ViewBag.PermissionOtros_Nombres_Requerido_MASC = permissionOtros_Nombres_Requerido_MASC;
            var permissionOtros_Domicilios_Requeridos_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45337, ModuleId);
            ViewBag.PermissionOtros_Domicilios_Requeridos_MASC = permissionOtros_Domicilios_Requeridos_MASC;
            var permissionAdicciones_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45342, ModuleId);
            ViewBag.PermissionAdicciones_Requerido_MASC = permissionAdicciones_Requerido_MASC;
            var permissionLugares_Frecuentes_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45333, ModuleId);
            ViewBag.PermissionLugares_Frecuentes_Requerido_MASC = permissionLugares_Frecuentes_Requerido_MASC;
            var permissionDatos_Personales_Adicionales_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45334, ModuleId);
            ViewBag.PermissionDatos_Personales_Adicionales_Requerido_MASC = permissionDatos_Personales_Adicionales_Requerido_MASC;
            var permissionOtras_Identificaciones_Requerido_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45335, ModuleId);
            ViewBag.PermissionOtras_Identificaciones_Requerido_MASC = permissionOtras_Identificaciones_Requerido_MASC;


            if (id.ToString() != "0")
            {
                var Detalle_de_Solicitud_RequeridosData = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitud_Requerido.Clave=" + id, "").Resource.Detalle_de_Solicitud_Requeridos;
				
				if (Detalle_de_Solicitud_RequeridosData != null && Detalle_de_Solicitud_RequeridosData.Count > 0)
                {
					var Detalle_de_Solicitud_RequeridoData = Detalle_de_Solicitud_RequeridosData.First();
					varDetalle_de_Solicitud_Requerido= new Detalle_de_Solicitud_RequeridoModel
					{
						Clave  = Detalle_de_Solicitud_RequeridoData.Clave 
	                    ,idRegistroAT = Detalle_de_Solicitud_RequeridoData.idRegistroAT
                    ,idRegistroUI = Detalle_de_Solicitud_RequeridoData.idRegistroUI
                    ,Solicitud = Detalle_de_Solicitud_RequeridoData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitud_RequeridoData.Solicitud_Solicitud.Numero_de_Folio
                    ,A_Quien_Sea_Responsable = Detalle_de_Solicitud_RequeridoData.A_Quien_Sea_Responsable.GetValueOrDefault()
                    ,Nombre = Detalle_de_Solicitud_RequeridoData.Nombre
                    ,Apellido_Paterno = Detalle_de_Solicitud_RequeridoData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Solicitud_RequeridoData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Solicitud_RequeridoData.Nombre_Completo
                    ,Alias = Detalle_de_Solicitud_RequeridoData.Alias
                    ,Apodo = Detalle_de_Solicitud_RequeridoData.Apodo
                    ,CURP = Detalle_de_Solicitud_RequeridoData.CURP
                    ,RFC = Detalle_de_Solicitud_RequeridoData.RFC
                    ,Fecha_de_Nacimiento = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Solicitud_RequeridoData.Edad
                    ,Sexo = Detalle_de_Solicitud_RequeridoData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Sexo), "Genero") ??  (string)Detalle_de_Solicitud_RequeridoData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Solicitud_RequeridoData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Solicitud_RequeridoData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Solicitud_RequeridoData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Solicitud_RequeridoData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Solicitud_RequeridoData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Solicitud_RequeridoData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Solicitud_RequeridoData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Solicitud_RequeridoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado), "Estado") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Solicitud_RequeridoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = Detalle_de_Solicitud_RequeridoData.Codigo_Postal
                    ,Poblacion = Detalle_de_Solicitud_RequeridoData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Poblacion), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Solicitud_RequeridoData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Colonia), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Solicitud_RequeridoData.Calle
                    ,Numero_Exterior = Detalle_de_Solicitud_RequeridoData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Solicitud_RequeridoData.Numero_Interior
                    ,Entre_Calle = Detalle_de_Solicitud_RequeridoData.Entre_Calle
                    ,Y_Calle = Detalle_de_Solicitud_RequeridoData.Y_Calle
                    ,Referencia_de_Domicilio_Requerido = Detalle_de_Solicitud_RequeridoData.Referencia_de_Domicilio_Requerido
                    ,Latitud = Detalle_de_Solicitud_RequeridoData.Latitud
                    ,Longitud = Detalle_de_Solicitud_RequeridoData.Longitud
                    ,Telefono = Detalle_de_Solicitud_RequeridoData.Telefono
                    ,Extencion = Detalle_de_Solicitud_RequeridoData.Extencion
                    ,Celular = Detalle_de_Solicitud_RequeridoData.Celular
                    ,Correo_Electronico = Detalle_de_Solicitud_RequeridoData.Correo_Electronico
                    ,Pais_de_Origen = Detalle_de_Solicitud_RequeridoData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Pais.Nombre
                    ,Originario_de = Detalle_de_Solicitud_RequeridoData.Originario_de
                    ,Estado_de_Nacimiento = Detalle_de_Solicitud_RequeridoData.Estado_de_Nacimiento
                    ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_de_Nacimiento), "Estado") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_de_Nacimiento_Estado.Nombre
                    ,Municipio_de_Nacimiento = Detalle_de_Solicitud_RequeridoData.Municipio_de_Nacimiento
                    ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio_de_Nacimiento), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_de_Nacimiento_Municipio.Nombre
                    ,Inimputable = Detalle_de_Solicitud_RequeridoData.Inimputable.GetValueOrDefault()
                    ,Tipo_de_Inimputabilidad = Detalle_de_Solicitud_RequeridoData.Tipo_de_Inimputabilidad
                    ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tipo_de_Inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Se_Presenta_con_Detenido = Detalle_de_Solicitud_RequeridoData.Se_Presenta_con_Detenido.GetValueOrDefault()
                    ,Folio_Registro_Nacional_de_Detenciones = Detalle_de_Solicitud_RequeridoData.Folio_Registro_Nacional_de_Detenciones
                    ,Fecha_de_Detencion = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Municipio_de_Detencion = Detalle_de_Solicitud_RequeridoData.Municipio_de_Detencion
                    ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio_de_Detencion), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_de_Detencion_Municipio.Nombre
                    ,Corporacion = Detalle_de_Solicitud_RequeridoData.Corporacion
                    ,CorporacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Corporacion), "Corporacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Corporacion_Corporacion.Descripcion
                    ,Suspension_Condicional = Detalle_de_Solicitud_RequeridoData.Suspension_Condicional.GetValueOrDefault()
                    ,Fecha_de_Suspension_Condicional = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
                    ,Lugar_donde_se_Encuentra_Detenido = Detalle_de_Solicitud_RequeridoData.Lugar_donde_se_Encuentra_Detenido
                    ,Etnia = Detalle_de_Solicitud_RequeridoData.Etnia
                    ,EtniaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Etnia), "Etnia") ??  (string)Detalle_de_Solicitud_RequeridoData.Etnia_Etnia.Descripcion
                    ,No__de_Hijos = Detalle_de_Solicitud_RequeridoData.No__de_Hijos
                    ,Religion = Detalle_de_Solicitud_RequeridoData.Religion
                    ,ReligionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Religion), "Religion") ??  (string)Detalle_de_Solicitud_RequeridoData.Religion_Religion.Descripcion
                    ,Servicio_Medico = Detalle_de_Solicitud_RequeridoData.Servicio_Medico
                    ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Servicio_Medico), "Servicio_Medico") ??  (string)Detalle_de_Solicitud_RequeridoData.Servicio_Medico_Servicio_Medico.Descripcion
                    ,Especialidad = Detalle_de_Solicitud_RequeridoData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Especialidad), "Especialidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Especialidad_Especialidad.Descripcion
                    ,Estudios_Superiores = Detalle_de_Solicitud_RequeridoData.Estudios_Superiores
                    ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estudios_Superiores), "Estudios_Superiores") ??  (string)Detalle_de_Solicitud_RequeridoData.Estudios_Superiores_Estudios_Superiores.Descripcion
                    ,Idioma = Detalle_de_Solicitud_RequeridoData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Idioma), "Idioma") ??  (string)Detalle_de_Solicitud_RequeridoData.Idioma_Idioma.Descripcion
                    ,Calidad_Migratoria = Detalle_de_Solicitud_RequeridoData.Calidad_Migratoria
                    ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Calidad_Migratoria), "Calidad_Migratoria") ??  (string)Detalle_de_Solicitud_RequeridoData.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                    ,Dialecto = Detalle_de_Solicitud_RequeridoData.Dialecto
                    ,DialectoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Dialecto), "Dialecto") ??  (string)Detalle_de_Solicitud_RequeridoData.Dialecto_Dialecto.Descripcion
                    ,Viene_en_Estado_de_Ebriedad = Detalle_de_Solicitud_RequeridoData.Viene_en_Estado_de_Ebriedad.GetValueOrDefault()
                    ,Bajo_el_Efecto_de_una_Droga = Detalle_de_Solicitud_RequeridoData.Bajo_el_Efecto_de_una_Droga.GetValueOrDefault()
                    ,Nombre_de_Droga = Detalle_de_Solicitud_RequeridoData.Nombre_de_Droga
                    ,Discapacidad_Mental = Detalle_de_Solicitud_RequeridoData.Discapacidad_Mental
                    ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Mental), "Discapacidades_Mentales") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                    ,Discapacidad_Fisica = Detalle_de_Solicitud_RequeridoData.Discapacidad_Fisica
                    ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Fisica), "Discapacidades_Fisicas") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                    ,Discapacidad_Sensorial = Detalle_de_Solicitud_RequeridoData.Discapacidad_Sensorial
                    ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Sensorial), "Discapacidades_Sensoriales") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                    ,Discapacidad_Psicosocial = Detalle_de_Solicitud_RequeridoData.Discapacidad_Psicosocial
                    ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Discapacidad_Psicosocial), "Discapacidades_Psicosociales") ??  (string)Detalle_de_Solicitud_RequeridoData.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
                    ,Nombre_de_Tutor = Detalle_de_Solicitud_RequeridoData.Nombre_de_Tutor
                    ,Apellido_Paterno_Tutor = Detalle_de_Solicitud_RequeridoData.Apellido_Paterno_Tutor
                    ,Apellido_Materno_Tutor = Detalle_de_Solicitud_RequeridoData.Apellido_Materno_Tutor
                    ,Nombre_Completo_Tutor = Detalle_de_Solicitud_RequeridoData.Nombre_Completo_Tutor
                    ,Fecha_de_Nacimiento_tutor = (Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_RequeridoData.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_tutor = Detalle_de_Solicitud_RequeridoData.Edad_tutor
                    ,Sexo_tutor = Detalle_de_Solicitud_RequeridoData.Sexo_tutor
                    ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Sexo_tutor), "Genero") ??  (string)Detalle_de_Solicitud_RequeridoData.Sexo_tutor_Genero.Descripcion
                    ,Estado_Civil_tutor = Detalle_de_Solicitud_RequeridoData.Estado_Civil_tutor
                    ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_Civil_tutor), "Estado_Civil") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_Civil_tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_tutor = Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_tutor
                    ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_tutor = Detalle_de_Solicitud_RequeridoData.Numero_de_Identificacion_tutor
                    ,Nacionalidad_tutor = Detalle_de_Solicitud_RequeridoData.Nacionalidad_tutor
                    ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Nacionalidad_tutor), "Nacionalidad") ??  (string)Detalle_de_Solicitud_RequeridoData.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_tutor = Detalle_de_Solicitud_RequeridoData.Escolaridad_tutor
                    ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Escolaridad_tutor), "Escolaridad") ??  (string)Detalle_de_Solicitud_RequeridoData.Escolaridad_tutor_Escolaridad.Descripcion
                    ,Ocupacion_tutor = Detalle_de_Solicitud_RequeridoData.Ocupacion_tutor
                    ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Ocupacion_tutor), "Ocupacion") ??  (string)Detalle_de_Solicitud_RequeridoData.Ocupacion_tutor_Ocupacion.Descripcion
                    ,Pais_tutor = Detalle_de_Solicitud_RequeridoData.Pais_tutor
                    ,Pais_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais_tutor), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_tutor_Pais.Nombre
                    ,Estado_tutor = Detalle_de_Solicitud_RequeridoData.Estado_tutor
                    ,Estado_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Estado_tutor), "Estado") ??  (string)Detalle_de_Solicitud_RequeridoData.Estado_tutor_Estado.Nombre
                    ,Municipio_tutor = Detalle_de_Solicitud_RequeridoData.Municipio_tutor
                    ,Municipio_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Municipio_tutor), "Municipio") ??  (string)Detalle_de_Solicitud_RequeridoData.Municipio_tutor_Municipio.Nombre
                    ,Poblacion_tutor = Detalle_de_Solicitud_RequeridoData.Poblacion_tutor
                    ,Poblacion_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Poblacion_tutor), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Poblacion_tutor_Colonia.Nombre
                    ,Colonia_tutor = Detalle_de_Solicitud_RequeridoData.Colonia_tutor
                    ,Colonia_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Colonia_tutor), "Colonia") ??  (string)Detalle_de_Solicitud_RequeridoData.Colonia_tutor_Colonia.Nombre
                    ,Codigo_Postal_tutor = Detalle_de_Solicitud_RequeridoData.Codigo_Postal_tutor
                    ,Calle_tutor = Detalle_de_Solicitud_RequeridoData.Calle_tutor
                    ,Numero_Exterior_tutor = Detalle_de_Solicitud_RequeridoData.Numero_Exterior_tutor
                    ,Numero_Interior_tutor = Detalle_de_Solicitud_RequeridoData.Numero_Interior_tutor
                    ,Referencia = Detalle_de_Solicitud_RequeridoData.Referencia
                    ,Latitud_tutor = Detalle_de_Solicitud_RequeridoData.Latitud_tutor
                    ,Longitud_tutor = Detalle_de_Solicitud_RequeridoData.Longitud_tutor
                    ,Extension_tutor = Detalle_de_Solicitud_RequeridoData.Extension_tutor
                    ,Celular_tutor = Detalle_de_Solicitud_RequeridoData.Celular_tutor
                    ,Correo_Electronico_tutor = Detalle_de_Solicitud_RequeridoData.Correo_Electronico_tutor
                    ,Pais_de_Origen_Tutor = Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Tutor
                    ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Tutor), "Pais") ??  (string)Detalle_de_Solicitud_RequeridoData.Pais_de_Origen_Tutor_Pais.Nombre
                    ,Originario_de_Tutor = Detalle_de_Solicitud_RequeridoData.Originario_de_Tutor
                    ,CURP_Tutor = Detalle_de_Solicitud_RequeridoData.CURP_Tutor
                    ,RFC_Tutor = Detalle_de_Solicitud_RequeridoData.RFC_Tutor
                    ,Padecimiento_de_Enfermedad = Detalle_de_Solicitud_RequeridoData.Padecimiento_de_Enfermedad
                    ,Cejas = Detalle_de_Solicitud_RequeridoData.Cejas
                    ,CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Cejas), "Cejas") ??  (string)Detalle_de_Solicitud_RequeridoData.Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Detalle_de_Solicitud_RequeridoData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Detalle_de_Solicitud_RequeridoData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Anteojos = Detalle_de_Solicitud_RequeridoData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Anteojos), "Anteojos") ??  (string)Detalle_de_Solicitud_RequeridoData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Detalle_de_Solicitud_RequeridoData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Detalle_de_Solicitud_RequeridoData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Nariz_base = Detalle_de_Solicitud_RequeridoData.Nariz_base
                    ,Nariz_baseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Nariz_base), "Nariz_Base") ??  (string)Detalle_de_Solicitud_RequeridoData.Nariz_base_Nariz_Base.Descripcion
                    ,Grosor_de_Labios = Detalle_de_Solicitud_RequeridoData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Detalle_de_Solicitud_RequeridoData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Forma_de_Menton = Detalle_de_Solicitud_RequeridoData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Detalle_de_Solicitud_RequeridoData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Senas_Particulares = Detalle_de_Solicitud_RequeridoData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_RequeridoData.Senas_Particulares), "Senas_Particulares") ??  (string)Detalle_de_Solicitud_RequeridoData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Detalle_de_Solicitud_RequeridoData.Imagen_Tatuaje
                    ,Otras_Senas_Particulares = Detalle_de_Solicitud_RequeridoData.Otras_Senas_Particulares
                    ,Imputado_Recluido = Detalle_de_Solicitud_RequeridoData.Imputado_Recluido

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Solicituds_Solicitud = _ISolicitudApiConsumer.SelAll(true);
            if (Solicituds_Solicitud != null && Solicituds_Solicitud.Resource != null)
                ViewBag.Solicituds_Solicitud = Solicituds_Solicitud.Resource.Where(m => m.Numero_de_Folio != null).OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio") ?? m.Numero_de_Folio.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEtniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Etnias_Etnia = _IEtniaApiConsumer.SelAll(true);
            if (Etnias_Etnia != null && Etnias_Etnia.Resource != null)
                ViewBag.Etnias_Etnia = Etnias_Etnia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Etnia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IReligionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Religions_Religion = _IReligionApiConsumer.SelAll(true);
            if (Religions_Religion != null && Religions_Religion.Resource != null)
                ViewBag.Religions_Religion = Religions_Religion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Religion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_MedicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_Medicos_Servicio_Medico = _IServicio_MedicoApiConsumer.SelAll(true);
            if (Servicio_Medicos_Servicio_Medico != null && Servicio_Medicos_Servicio_Medico.Resource != null)
                ViewBag.Servicio_Medicos_Servicio_Medico = Servicio_Medicos_Servicio_Medico.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_Medico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidads_Especialidad = _IEspecialidadApiConsumer.SelAll(true);
            if (Especialidads_Especialidad != null && Especialidads_Especialidad.Resource != null)
                ViewBag.Especialidads_Especialidad = Especialidads_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstudios_SuperioresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estudios_Superioress_Estudios_Superiores = _IEstudios_SuperioresApiConsumer.SelAll(true);
            if (Estudios_Superioress_Estudios_Superiores != null && Estudios_Superioress_Estudios_Superiores.Resource != null)
                ViewBag.Estudios_Superioress_Estudios_Superiores = Estudios_Superioress_Estudios_Superiores.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estudios_Superiores", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalidad_MigratoriaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calidad_Migratorias_Calidad_Migratoria = _ICalidad_MigratoriaApiConsumer.SelAll(true);
            if (Calidad_Migratorias_Calidad_Migratoria != null && Calidad_Migratorias_Calidad_Migratoria.Resource != null)
                ViewBag.Calidad_Migratorias_Calidad_Migratoria = Calidad_Migratorias_Calidad_Migratoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calidad_Migratoria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Dialecto = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Dialecto != null && Dialectos_Dialecto.Resource != null)
                ViewBag.Dialectos_Dialecto = Dialectos_Dialecto.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_MentalesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Mentaless_Discapacidad_Mental = _IDiscapacidades_MentalesApiConsumer.SelAll(true);
            if (Discapacidades_Mentaless_Discapacidad_Mental != null && Discapacidades_Mentaless_Discapacidad_Mental.Resource != null)
                ViewBag.Discapacidades_Mentaless_Discapacidad_Mental = Discapacidades_Mentaless_Discapacidad_Mental.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Mentales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_FisicasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Fisicass_Discapacidad_Fisica = _IDiscapacidades_FisicasApiConsumer.SelAll(true);
            if (Discapacidades_Fisicass_Discapacidad_Fisica != null && Discapacidades_Fisicass_Discapacidad_Fisica.Resource != null)
                ViewBag.Discapacidades_Fisicass_Discapacidad_Fisica = Discapacidades_Fisicass_Discapacidad_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Fisicas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_SensorialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Sensorialess_Discapacidad_Sensorial = _IDiscapacidades_SensorialesApiConsumer.SelAll(true);
            if (Discapacidades_Sensorialess_Discapacidad_Sensorial != null && Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource != null)
                ViewBag.Discapacidades_Sensorialess_Discapacidad_Sensorial = Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Sensoriales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_PsicosocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Psicosocialess_Discapacidad_Psicosocial = _IDiscapacidades_PsicosocialesApiConsumer.SelAll(true);
            if (Discapacidades_Psicosocialess_Discapacidad_Psicosocial != null && Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource != null)
                ViewBag.Discapacidades_Psicosocialess_Discapacidad_Psicosocial = Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Psicosociales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            var Nariz_Bases_Nariz_base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_base != null && Nariz_Bases_Nariz_base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_base = Nariz_Bases_Nariz_base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Solicitud_Requerido", varDetalle_de_Solicitud_Requerido);
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
        public ActionResult GetTipo_de_InimputabilidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InimputabilidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCorporacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICorporacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEtniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEtniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEtniaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Etnia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetReligionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IReligionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IReligionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Religion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetServicio_MedicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicio_MedicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicio_MedicoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_Medico", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEspecialidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecialidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecialidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstudios_SuperioresAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstudios_SuperioresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstudios_SuperioresApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estudios_Superiores", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetCalidad_MigratoriaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalidad_MigratoriaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalidad_MigratoriaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calidad_Migratoria", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetDiscapacidades_MentalesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiscapacidades_MentalesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiscapacidades_MentalesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Mentales", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDiscapacidades_FisicasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiscapacidades_FisicasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiscapacidades_FisicasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Fisicas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDiscapacidades_SensorialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiscapacidades_SensorialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiscapacidades_SensorialesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Sensoriales", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDiscapacidades_PsicosocialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiscapacidades_PsicosocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiscapacidades_PsicosocialesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Psicosociales", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Detalle_de_Solicitud_RequeridoAdvanceSearchModel model, int idFilter = -1)
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

            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Solicituds_Solicitud = _ISolicitudApiConsumer.SelAll(true);
            if (Solicituds_Solicitud != null && Solicituds_Solicitud.Resource != null)
                ViewBag.Solicituds_Solicitud = Solicituds_Solicitud.Resource.Where(m => m.Numero_de_Folio != null).OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio") ?? m.Numero_de_Folio.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEtniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Etnias_Etnia = _IEtniaApiConsumer.SelAll(true);
            if (Etnias_Etnia != null && Etnias_Etnia.Resource != null)
                ViewBag.Etnias_Etnia = Etnias_Etnia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Etnia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IReligionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Religions_Religion = _IReligionApiConsumer.SelAll(true);
            if (Religions_Religion != null && Religions_Religion.Resource != null)
                ViewBag.Religions_Religion = Religions_Religion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Religion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_MedicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_Medicos_Servicio_Medico = _IServicio_MedicoApiConsumer.SelAll(true);
            if (Servicio_Medicos_Servicio_Medico != null && Servicio_Medicos_Servicio_Medico.Resource != null)
                ViewBag.Servicio_Medicos_Servicio_Medico = Servicio_Medicos_Servicio_Medico.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_Medico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidads_Especialidad = _IEspecialidadApiConsumer.SelAll(true);
            if (Especialidads_Especialidad != null && Especialidads_Especialidad.Resource != null)
                ViewBag.Especialidads_Especialidad = Especialidads_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstudios_SuperioresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estudios_Superioress_Estudios_Superiores = _IEstudios_SuperioresApiConsumer.SelAll(true);
            if (Estudios_Superioress_Estudios_Superiores != null && Estudios_Superioress_Estudios_Superiores.Resource != null)
                ViewBag.Estudios_Superioress_Estudios_Superiores = Estudios_Superioress_Estudios_Superiores.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estudios_Superiores", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalidad_MigratoriaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calidad_Migratorias_Calidad_Migratoria = _ICalidad_MigratoriaApiConsumer.SelAll(true);
            if (Calidad_Migratorias_Calidad_Migratoria != null && Calidad_Migratorias_Calidad_Migratoria.Resource != null)
                ViewBag.Calidad_Migratorias_Calidad_Migratoria = Calidad_Migratorias_Calidad_Migratoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calidad_Migratoria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Dialecto = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Dialecto != null && Dialectos_Dialecto.Resource != null)
                ViewBag.Dialectos_Dialecto = Dialectos_Dialecto.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_MentalesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Mentaless_Discapacidad_Mental = _IDiscapacidades_MentalesApiConsumer.SelAll(true);
            if (Discapacidades_Mentaless_Discapacidad_Mental != null && Discapacidades_Mentaless_Discapacidad_Mental.Resource != null)
                ViewBag.Discapacidades_Mentaless_Discapacidad_Mental = Discapacidades_Mentaless_Discapacidad_Mental.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Mentales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_FisicasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Fisicass_Discapacidad_Fisica = _IDiscapacidades_FisicasApiConsumer.SelAll(true);
            if (Discapacidades_Fisicass_Discapacidad_Fisica != null && Discapacidades_Fisicass_Discapacidad_Fisica.Resource != null)
                ViewBag.Discapacidades_Fisicass_Discapacidad_Fisica = Discapacidades_Fisicass_Discapacidad_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Fisicas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_SensorialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Sensorialess_Discapacidad_Sensorial = _IDiscapacidades_SensorialesApiConsumer.SelAll(true);
            if (Discapacidades_Sensorialess_Discapacidad_Sensorial != null && Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource != null)
                ViewBag.Discapacidades_Sensorialess_Discapacidad_Sensorial = Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Sensoriales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_PsicosocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Psicosocialess_Discapacidad_Psicosocial = _IDiscapacidades_PsicosocialesApiConsumer.SelAll(true);
            if (Discapacidades_Psicosocialess_Discapacidad_Psicosocial != null && Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource != null)
                ViewBag.Discapacidades_Psicosocialess_Discapacidad_Psicosocial = Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Psicosociales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            var Nariz_Bases_Nariz_base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_base != null && Nariz_Bases_Nariz_base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_base = Nariz_Bases_Nariz_base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Solicituds_Solicitud = _ISolicitudApiConsumer.SelAll(true);
            if (Solicituds_Solicitud != null && Solicituds_Solicitud.Resource != null)
                ViewBag.Solicituds_Solicitud = Solicituds_Solicitud.Resource.Where(m => m.Numero_de_Folio != null).OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio") ?? m.Numero_de_Folio.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEtniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Etnias_Etnia = _IEtniaApiConsumer.SelAll(true);
            if (Etnias_Etnia != null && Etnias_Etnia.Resource != null)
                ViewBag.Etnias_Etnia = Etnias_Etnia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Etnia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IReligionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Religions_Religion = _IReligionApiConsumer.SelAll(true);
            if (Religions_Religion != null && Religions_Religion.Resource != null)
                ViewBag.Religions_Religion = Religions_Religion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Religion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_MedicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_Medicos_Servicio_Medico = _IServicio_MedicoApiConsumer.SelAll(true);
            if (Servicio_Medicos_Servicio_Medico != null && Servicio_Medicos_Servicio_Medico.Resource != null)
                ViewBag.Servicio_Medicos_Servicio_Medico = Servicio_Medicos_Servicio_Medico.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_Medico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecialidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidads_Especialidad = _IEspecialidadApiConsumer.SelAll(true);
            if (Especialidads_Especialidad != null && Especialidads_Especialidad.Resource != null)
                ViewBag.Especialidads_Especialidad = Especialidads_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstudios_SuperioresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estudios_Superioress_Estudios_Superiores = _IEstudios_SuperioresApiConsumer.SelAll(true);
            if (Estudios_Superioress_Estudios_Superiores != null && Estudios_Superioress_Estudios_Superiores.Resource != null)
                ViewBag.Estudios_Superioress_Estudios_Superiores = Estudios_Superioress_Estudios_Superiores.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estudios_Superiores", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalidad_MigratoriaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calidad_Migratorias_Calidad_Migratoria = _ICalidad_MigratoriaApiConsumer.SelAll(true);
            if (Calidad_Migratorias_Calidad_Migratoria != null && Calidad_Migratorias_Calidad_Migratoria.Resource != null)
                ViewBag.Calidad_Migratorias_Calidad_Migratoria = Calidad_Migratorias_Calidad_Migratoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calidad_Migratoria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Dialecto = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Dialecto != null && Dialectos_Dialecto.Resource != null)
                ViewBag.Dialectos_Dialecto = Dialectos_Dialecto.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_MentalesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Mentaless_Discapacidad_Mental = _IDiscapacidades_MentalesApiConsumer.SelAll(true);
            if (Discapacidades_Mentaless_Discapacidad_Mental != null && Discapacidades_Mentaless_Discapacidad_Mental.Resource != null)
                ViewBag.Discapacidades_Mentaless_Discapacidad_Mental = Discapacidades_Mentaless_Discapacidad_Mental.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Mentales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_FisicasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Fisicass_Discapacidad_Fisica = _IDiscapacidades_FisicasApiConsumer.SelAll(true);
            if (Discapacidades_Fisicass_Discapacidad_Fisica != null && Discapacidades_Fisicass_Discapacidad_Fisica.Resource != null)
                ViewBag.Discapacidades_Fisicass_Discapacidad_Fisica = Discapacidades_Fisicass_Discapacidad_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Fisicas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_SensorialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Sensorialess_Discapacidad_Sensorial = _IDiscapacidades_SensorialesApiConsumer.SelAll(true);
            if (Discapacidades_Sensorialess_Discapacidad_Sensorial != null && Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource != null)
                ViewBag.Discapacidades_Sensorialess_Discapacidad_Sensorial = Discapacidades_Sensorialess_Discapacidad_Sensorial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Sensoriales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDiscapacidades_PsicosocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Discapacidades_Psicosocialess_Discapacidad_Psicosocial = _IDiscapacidades_PsicosocialesApiConsumer.SelAll(true);
            if (Discapacidades_Psicosocialess_Discapacidad_Psicosocial != null && Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource != null)
                ViewBag.Discapacidades_Psicosocialess_Discapacidad_Psicosocial = Discapacidades_Psicosocialess_Discapacidad_Psicosocial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Discapacidades_Psicosociales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            var Nariz_Bases_Nariz_base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_base != null && Nariz_Bases_Nariz_base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_base = Nariz_Bases_Nariz_base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrosor_de_LabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grosor_de_Labioss_Grosor_de_Labios = _IGrosor_de_LabiosApiConsumer.SelAll(true);
            if (Grosor_de_Labioss_Grosor_de_Labios != null && Grosor_de_Labioss_Grosor_de_Labios.Resource != null)
                ViewBag.Grosor_de_Labioss_Grosor_de_Labios = Grosor_de_Labioss_Grosor_de_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grosor_de_Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_MentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Mentons_Forma_de_Menton = _IForma_de_MentonApiConsumer.SelAll(true);
            if (Forma_de_Mentons_Forma_de_Menton != null && Forma_de_Mentons_Forma_de_Menton.Resource != null)
                ViewBag.Forma_de_Mentons_Forma_de_Menton = Forma_de_Mentons_Forma_de_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISenas_ParticularesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Senas_Particularess_Senas_Particulares = _ISenas_ParticularesApiConsumer.SelAll(true);
            if (Senas_Particularess_Senas_Particulares != null && Senas_Particularess_Senas_Particulares.Resource != null)
                ViewBag.Senas_Particularess_Senas_Particulares = Senas_Particularess_Senas_Particulares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Senas_Particulares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Solicitud_RequeridoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Solicitud_RequeridoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Solicitud_RequeridoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Solicitud_RequeridoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Requeridos == null)
                result.Detalle_de_Solicitud_Requeridos = new List<Detalle_de_Solicitud_Requerido>();

            return Json(new
            {
                data = result.Detalle_de_Solicitud_Requeridos.Select(m => new Detalle_de_Solicitud_RequeridoGridModel
                    {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Numero_de_Folio") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,A_Quien_Sea_Responsable = m.A_Quien_Sea_Responsable
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Apodo = m.Apodo
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_de_Domicilio_Requerido = m.Referencia_de_Domicilio_Requerido
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
			,Inimputable = m.Inimputable
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Se_Presenta_con_Detenido = m.Se_Presenta_con_Detenido
			,Folio_Registro_Nacional_de_Detenciones = m.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                        ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(m.Municipio_de_Detencion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Detencion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
			,Suspension_Condicional = m.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
			,Lugar_donde_se_Encuentra_Detenido = m.Lugar_donde_se_Encuentra_Detenido
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No__de_Hijos = m.No__de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
			,Viene_en_Estado_de_Ebriedad = m.Viene_en_Estado_de_Ebriedad
			,Bajo_el_Efecto_de_una_Droga = m.Bajo_el_Efecto_de_una_Droga
			,Nombre_de_Droga = m.Nombre_de_Droga
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_de_Tutor = m.Nombre_de_Tutor
			,Apellido_Paterno_Tutor = m.Apellido_Paterno_Tutor
			,Apellido_Materno_Tutor = m.Apellido_Materno_Tutor
			,Nombre_Completo_Tutor = m.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Poblacion_tutorNombre = CultureHelper.GetTraduction(m.Poblacion_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_tutor_Colonia.Nombre
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Referencia = m.Referencia
			,Latitud_tutor = m.Latitud_tutor
			,Longitud_tutor = m.Longitud_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_Tutor = m.Originario_de_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Nariz_baseDescripcion = CultureHelper.GetTraduction(m.Nariz_base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_base_Nariz_Base.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Solicitud_RequeridoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Requerido", m.),
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
        /// Get List of Detalle_de_Solicitud_Requerido from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Solicitud_Requerido Entity</returns>
        public ActionResult GetDetalle_de_Solicitud_RequeridoList(UrlParametersModel param)
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
            _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Solicitud_RequeridoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Solicitud_RequeridoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Solicitud_RequeridoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Solicitud_RequeridoPropertyMapper oDetalle_de_Solicitud_RequeridoPropertyMapper = new Detalle_de_Solicitud_RequeridoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Solicitud_RequeridoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Requeridos == null)
                result.Detalle_de_Solicitud_Requeridos = new List<Detalle_de_Solicitud_Requerido>();

            return Json(new
            {
                aaData = result.Detalle_de_Solicitud_Requeridos.Select(m => new Detalle_de_Solicitud_RequeridoGridModel
            {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Numero_de_Folio") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,A_Quien_Sea_Responsable = m.A_Quien_Sea_Responsable
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Apodo = m.Apodo
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_de_Domicilio_Requerido = m.Referencia_de_Domicilio_Requerido
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
			,Inimputable = m.Inimputable
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Se_Presenta_con_Detenido = m.Se_Presenta_con_Detenido
			,Folio_Registro_Nacional_de_Detenciones = m.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                        ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(m.Municipio_de_Detencion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Detencion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
			,Suspension_Condicional = m.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
			,Lugar_donde_se_Encuentra_Detenido = m.Lugar_donde_se_Encuentra_Detenido
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No__de_Hijos = m.No__de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
			,Viene_en_Estado_de_Ebriedad = m.Viene_en_Estado_de_Ebriedad
			,Bajo_el_Efecto_de_una_Droga = m.Bajo_el_Efecto_de_una_Droga
			,Nombre_de_Droga = m.Nombre_de_Droga
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_de_Tutor = m.Nombre_de_Tutor
			,Apellido_Paterno_Tutor = m.Apellido_Paterno_Tutor
			,Apellido_Materno_Tutor = m.Apellido_Materno_Tutor
			,Nombre_Completo_Tutor = m.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Poblacion_tutorNombre = CultureHelper.GetTraduction(m.Poblacion_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_tutor_Colonia.Nombre
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Referencia = m.Referencia
			,Latitud_tutor = m.Latitud_tutor
			,Longitud_tutor = m.Longitud_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_Tutor = m.Originario_de_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Nariz_baseDescripcion = CultureHelper.GetTraduction(m.Nariz_base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_base_Nariz_Base.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Requerido_Nacionalidad_Nacionalidad(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Pais_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Colonia_Colonia(string query, string where)
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
        [HttpGet]
        public JsonResult GetOtros_Domicilios_Requeridos_MASC_Estado_Estado(string query, string where)
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
        public JsonResult GetOtros_Domicilios_Requeridos_MASC_Municipio_Municipio(string query, string where)
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
        public JsonResult GetOtros_Domicilios_Requeridos_MASC_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetOtros_Domicilios_Requeridos_MASC_Colonia_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Pais_de_Origen_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Estado_de_Nacimiento_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Municipio_de_Nacimiento_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Municipio_de_Detencion_Municipio(string query, string where)
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
//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Requerido_Pais_tutor_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Estado_tutor_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Municipio_tutor_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Poblacion_tutor_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Colonia_tutor_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Requerido_Pais_de_Origen_Tutor_Pais(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Detalle_de_Solicitud_RequeridoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Solicitud_Requerido.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Solicitud_Requerido.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromidRegistroAT) || !string.IsNullOrEmpty(filter.ToidRegistroAT))
            {
                if (!string.IsNullOrEmpty(filter.FromidRegistroAT))
                    where += " AND Detalle_de_Solicitud_Requerido.idRegistroAT >= " + filter.FromidRegistroAT;
                if (!string.IsNullOrEmpty(filter.ToidRegistroAT))
                    where += " AND Detalle_de_Solicitud_Requerido.idRegistroAT <= " + filter.ToidRegistroAT;
            }

            if (!string.IsNullOrEmpty(filter.FromidRegistroUI) || !string.IsNullOrEmpty(filter.ToidRegistroUI))
            {
                if (!string.IsNullOrEmpty(filter.FromidRegistroUI))
                    where += " AND Detalle_de_Solicitud_Requerido.idRegistroUI >= " + filter.FromidRegistroUI;
                if (!string.IsNullOrEmpty(filter.ToidRegistroUI))
                    where += " AND Detalle_de_Solicitud_Requerido.idRegistroUI <= " + filter.ToidRegistroUI;
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

                where += " AND Detalle_de_Solicitud_Requerido.Solicitud In (" + SolicitudIds + ")";
            }

            if (filter.A_Quien_Sea_Responsable != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.A_Quien_Sea_Responsable = " + Convert.ToInt32(filter.A_Quien_Sea_Responsable);

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Alias))
            {
                switch (filter.AliasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Alias LIKE '" + filter.Alias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Alias LIKE '%" + filter.Alias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Alias = '" + filter.Alias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Alias LIKE '%" + filter.Alias + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apodo))
            {
                switch (filter.ApodoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apodo LIKE '" + filter.Apodo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apodo LIKE '%" + filter.Apodo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Apodo = '" + filter.Apodo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Apodo LIKE '%" + filter.Apodo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CURP))
            {
                switch (filter.CURPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP LIKE '" + filter.CURP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP LIKE '%" + filter.CURP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP = '" + filter.CURP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP LIKE '%" + filter.CURP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC))
            {
                switch (filter.RFCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC LIKE '" + filter.RFC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC LIKE '%" + filter.RFC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC = '" + filter.RFC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC LIKE '%" + filter.RFC + "%'";
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
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Detalle_de_Solicitud_Requerido.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Detalle_de_Solicitud_Requerido.Edad <= " + filter.ToEdad;
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

                where += " AND Detalle_de_Solicitud_Requerido.Sexo In (" + SexoIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
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

                where += " AND Detalle_de_Solicitud_Requerido.Nacionalidad In (" + NacionalidadIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Escolaridad In (" + EscolaridadIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Ocupacion In (" + OcupacionIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Pais In (" + PaisIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Estado In (" + EstadoIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Solicitud_Requerido.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Solicitud_Requerido.Codigo_Postal <= " + filter.ToCodigo_Postal;
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

                where += " AND Detalle_de_Solicitud_Requerido.Poblacion In (" + PoblacionIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_de_Domicilio_Requerido))
            {
                switch (filter.Referencia_de_Domicilio_RequeridoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido LIKE '" + filter.Referencia_de_Domicilio_Requerido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido LIKE '%" + filter.Referencia_de_Domicilio_Requerido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido = '" + filter.Referencia_de_Domicilio_Requerido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido LIKE '%" + filter.Referencia_de_Domicilio_Requerido + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Extencion))
            {
                switch (filter.ExtencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Extencion LIKE '" + filter.Extencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Extencion LIKE '%" + filter.Extencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Extencion = '" + filter.Extencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Extencion LIKE '%" + filter.Extencion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_Origen))
            {
                switch (filter.Pais_de_OrigenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_Origen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_Origen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_OrigenMultiple != null && filter.AdvancePais_de_OrigenMultiple.Count() > 0)
            {
                var Pais_de_OrigenIds = string.Join(",", filter.AdvancePais_de_OrigenMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Pais_de_Origen In (" + Pais_de_OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de))
            {
                switch (filter.Originario_deFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de LIKE '" + filter.Originario_de + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de LIKE '%" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de = '" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de LIKE '%" + filter.Originario_de + "%'";
                        break;
                }
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

                where += " AND Detalle_de_Solicitud_Requerido.Estado_de_Nacimiento In (" + Estado_de_NacimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_de_Nacimiento))
            {
                switch (filter.Municipio_de_NacimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_de_Nacimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_Nacimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_de_Nacimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_Nacimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_de_NacimientoMultiple != null && filter.AdvanceMunicipio_de_NacimientoMultiple.Count() > 0)
            {
                var Municipio_de_NacimientoIds = string.Join(",", filter.AdvanceMunicipio_de_NacimientoMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Municipio_de_Nacimiento In (" + Municipio_de_NacimientoIds + ")";
            }

            if (filter.Inimputable != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.Inimputable = " + Convert.ToInt32(filter.Inimputable);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Inimputabilidad))
            {
                switch (filter.Tipo_de_InimputabilidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion LIKE '" + filter.AdvanceTipo_de_Inimputabilidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion LIKE '%" + filter.AdvanceTipo_de_Inimputabilidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion = '" + filter.AdvanceTipo_de_Inimputabilidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion LIKE '%" + filter.AdvanceTipo_de_Inimputabilidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_InimputabilidadMultiple != null && filter.AdvanceTipo_de_InimputabilidadMultiple.Count() > 0)
            {
                var Tipo_de_InimputabilidadIds = string.Join(",", filter.AdvanceTipo_de_InimputabilidadMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Tipo_de_Inimputabilidad In (" + Tipo_de_InimputabilidadIds + ")";
            }

            if (filter.Se_Presenta_con_Detenido != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.Se_Presenta_con_Detenido = " + Convert.ToInt32(filter.Se_Presenta_con_Detenido);

            if (!string.IsNullOrEmpty(filter.Folio_Registro_Nacional_de_Detenciones))
            {
                switch (filter.Folio_Registro_Nacional_de_DetencionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones LIKE '" + filter.Folio_Registro_Nacional_de_Detenciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones LIKE '%" + filter.Folio_Registro_Nacional_de_Detenciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones = '" + filter.Folio_Registro_Nacional_de_Detenciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones LIKE '%" + filter.Folio_Registro_Nacional_de_Detenciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Detencion) || !string.IsNullOrEmpty(filter.ToFecha_de_Detencion))
            {
                var Fecha_de_DetencionFrom = DateTime.ParseExact(filter.FromFecha_de_Detencion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_DetencionTo = DateTime.ParseExact(filter.ToFecha_de_Detencion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Detencion))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Detencion >= '" + Fecha_de_DetencionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Detencion))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Detencion <= '" + Fecha_de_DetencionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_de_Detencion))
            {
                switch (filter.Municipio_de_DetencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_de_Detencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_Detencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_de_Detencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_Detencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_de_DetencionMultiple != null && filter.AdvanceMunicipio_de_DetencionMultiple.Count() > 0)
            {
                var Municipio_de_DetencionIds = string.Join(",", filter.AdvanceMunicipio_de_DetencionMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Municipio_de_Detencion In (" + Municipio_de_DetencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCorporacion))
            {
                switch (filter.CorporacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Corporacion.Descripcion LIKE '" + filter.AdvanceCorporacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Corporacion.Descripcion LIKE '%" + filter.AdvanceCorporacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Corporacion.Descripcion = '" + filter.AdvanceCorporacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Corporacion.Descripcion LIKE '%" + filter.AdvanceCorporacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCorporacionMultiple != null && filter.AdvanceCorporacionMultiple.Count() > 0)
            {
                var CorporacionIds = string.Join(",", filter.AdvanceCorporacionMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Corporacion In (" + CorporacionIds + ")";
            }

            if (filter.Suspension_Condicional != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.Suspension_Condicional = " + Convert.ToInt32(filter.Suspension_Condicional);

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Suspension_Condicional) || !string.IsNullOrEmpty(filter.ToFecha_de_Suspension_Condicional))
            {
                var Fecha_de_Suspension_CondicionalFrom = DateTime.ParseExact(filter.FromFecha_de_Suspension_Condicional, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Suspension_CondicionalTo = DateTime.ParseExact(filter.ToFecha_de_Suspension_Condicional, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Suspension_Condicional))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional >= '" + Fecha_de_Suspension_CondicionalFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Suspension_Condicional))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional <= '" + Fecha_de_Suspension_CondicionalTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Lugar_donde_se_Encuentra_Detenido))
            {
                switch (filter.Lugar_donde_se_Encuentra_DetenidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido LIKE '" + filter.Lugar_donde_se_Encuentra_Detenido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido LIKE '%" + filter.Lugar_donde_se_Encuentra_Detenido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido = '" + filter.Lugar_donde_se_Encuentra_Detenido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido LIKE '%" + filter.Lugar_donde_se_Encuentra_Detenido + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEtnia))
            {
                switch (filter.EtniaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Etnia.Descripcion LIKE '" + filter.AdvanceEtnia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Etnia.Descripcion LIKE '%" + filter.AdvanceEtnia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Etnia.Descripcion = '" + filter.AdvanceEtnia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Etnia.Descripcion LIKE '%" + filter.AdvanceEtnia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEtniaMultiple != null && filter.AdvanceEtniaMultiple.Count() > 0)
            {
                var EtniaIds = string.Join(",", filter.AdvanceEtniaMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Etnia In (" + EtniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromNo__de_Hijos) || !string.IsNullOrEmpty(filter.ToNo__de_Hijos))
            {
                if (!string.IsNullOrEmpty(filter.FromNo__de_Hijos))
                    where += " AND Detalle_de_Solicitud_Requerido.No__de_Hijos >= " + filter.FromNo__de_Hijos;
                if (!string.IsNullOrEmpty(filter.ToNo__de_Hijos))
                    where += " AND Detalle_de_Solicitud_Requerido.No__de_Hijos <= " + filter.ToNo__de_Hijos;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceReligion))
            {
                switch (filter.ReligionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Religion.Descripcion LIKE '" + filter.AdvanceReligion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Religion.Descripcion LIKE '%" + filter.AdvanceReligion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Religion.Descripcion = '" + filter.AdvanceReligion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Religion.Descripcion LIKE '%" + filter.AdvanceReligion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceReligionMultiple != null && filter.AdvanceReligionMultiple.Count() > 0)
            {
                var ReligionIds = string.Join(",", filter.AdvanceReligionMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Religion In (" + ReligionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceServicio_Medico))
            {
                switch (filter.Servicio_MedicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Servicio_Medico.Descripcion LIKE '" + filter.AdvanceServicio_Medico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Servicio_Medico.Descripcion LIKE '%" + filter.AdvanceServicio_Medico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Servicio_Medico.Descripcion = '" + filter.AdvanceServicio_Medico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Servicio_Medico.Descripcion LIKE '%" + filter.AdvanceServicio_Medico + "%'";
                        break;
                }
            }
            else if (filter.AdvanceServicio_MedicoMultiple != null && filter.AdvanceServicio_MedicoMultiple.Count() > 0)
            {
                var Servicio_MedicoIds = string.Join(",", filter.AdvanceServicio_MedicoMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Servicio_Medico In (" + Servicio_MedicoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecialidad))
            {
                switch (filter.EspecialidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especialidad.Descripcion LIKE '" + filter.AdvanceEspecialidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especialidad.Descripcion LIKE '%" + filter.AdvanceEspecialidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especialidad.Descripcion = '" + filter.AdvanceEspecialidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especialidad.Descripcion LIKE '%" + filter.AdvanceEspecialidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecialidadMultiple != null && filter.AdvanceEspecialidadMultiple.Count() > 0)
            {
                var EspecialidadIds = string.Join(",", filter.AdvanceEspecialidadMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Especialidad In (" + EspecialidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstudios_Superiores))
            {
                switch (filter.Estudios_SuperioresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estudios_Superiores.Descripcion LIKE '" + filter.AdvanceEstudios_Superiores + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estudios_Superiores.Descripcion LIKE '%" + filter.AdvanceEstudios_Superiores + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estudios_Superiores.Descripcion = '" + filter.AdvanceEstudios_Superiores + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estudios_Superiores.Descripcion LIKE '%" + filter.AdvanceEstudios_Superiores + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstudios_SuperioresMultiple != null && filter.AdvanceEstudios_SuperioresMultiple.Count() > 0)
            {
                var Estudios_SuperioresIds = string.Join(",", filter.AdvanceEstudios_SuperioresMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Estudios_Superiores In (" + Estudios_SuperioresIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Idioma In (" + IdiomaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCalidad_Migratoria))
            {
                switch (filter.Calidad_MigratoriaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Calidad_Migratoria.Descripcion LIKE '" + filter.AdvanceCalidad_Migratoria + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Calidad_Migratoria.Descripcion LIKE '%" + filter.AdvanceCalidad_Migratoria + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Calidad_Migratoria.Descripcion = '" + filter.AdvanceCalidad_Migratoria + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Calidad_Migratoria.Descripcion LIKE '%" + filter.AdvanceCalidad_Migratoria + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCalidad_MigratoriaMultiple != null && filter.AdvanceCalidad_MigratoriaMultiple.Count() > 0)
            {
                var Calidad_MigratoriaIds = string.Join(",", filter.AdvanceCalidad_MigratoriaMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Calidad_Migratoria In (" + Calidad_MigratoriaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDialecto))
            {
                switch (filter.DialectoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Dialecto.Descripcion LIKE '" + filter.AdvanceDialecto + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Dialecto.Descripcion LIKE '%" + filter.AdvanceDialecto + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Dialecto.Descripcion = '" + filter.AdvanceDialecto + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Dialecto.Descripcion LIKE '%" + filter.AdvanceDialecto + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDialectoMultiple != null && filter.AdvanceDialectoMultiple.Count() > 0)
            {
                var DialectoIds = string.Join(",", filter.AdvanceDialectoMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Dialecto In (" + DialectoIds + ")";
            }

            if (filter.Viene_en_Estado_de_Ebriedad != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.Viene_en_Estado_de_Ebriedad = " + Convert.ToInt32(filter.Viene_en_Estado_de_Ebriedad);

            if (filter.Bajo_el_Efecto_de_una_Droga != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.Bajo_el_Efecto_de_una_Droga = " + Convert.ToInt32(filter.Bajo_el_Efecto_de_una_Droga);

            if (!string.IsNullOrEmpty(filter.Nombre_de_Droga))
            {
                switch (filter.Nombre_de_DrogaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Droga LIKE '" + filter.Nombre_de_Droga + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Droga LIKE '%" + filter.Nombre_de_Droga + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Droga = '" + filter.Nombre_de_Droga + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Droga LIKE '%" + filter.Nombre_de_Droga + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiscapacidad_Mental))
            {
                switch (filter.Discapacidad_MentalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Discapacidades_Mentales.Descripcion LIKE '" + filter.AdvanceDiscapacidad_Mental + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Discapacidades_Mentales.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Mental + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Discapacidades_Mentales.Descripcion = '" + filter.AdvanceDiscapacidad_Mental + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Discapacidades_Mentales.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Mental + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiscapacidad_MentalMultiple != null && filter.AdvanceDiscapacidad_MentalMultiple.Count() > 0)
            {
                var Discapacidad_MentalIds = string.Join(",", filter.AdvanceDiscapacidad_MentalMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Discapacidad_Mental In (" + Discapacidad_MentalIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiscapacidad_Fisica))
            {
                switch (filter.Discapacidad_FisicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Discapacidades_Fisicas.Descripcion LIKE '" + filter.AdvanceDiscapacidad_Fisica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Discapacidades_Fisicas.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Fisica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Discapacidades_Fisicas.Descripcion = '" + filter.AdvanceDiscapacidad_Fisica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Discapacidades_Fisicas.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Fisica + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiscapacidad_FisicaMultiple != null && filter.AdvanceDiscapacidad_FisicaMultiple.Count() > 0)
            {
                var Discapacidad_FisicaIds = string.Join(",", filter.AdvanceDiscapacidad_FisicaMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Discapacidad_Fisica In (" + Discapacidad_FisicaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiscapacidad_Sensorial))
            {
                switch (filter.Discapacidad_SensorialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Discapacidades_Sensoriales.Descripcion LIKE '" + filter.AdvanceDiscapacidad_Sensorial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Discapacidades_Sensoriales.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Sensorial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Discapacidades_Sensoriales.Descripcion = '" + filter.AdvanceDiscapacidad_Sensorial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Discapacidades_Sensoriales.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Sensorial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiscapacidad_SensorialMultiple != null && filter.AdvanceDiscapacidad_SensorialMultiple.Count() > 0)
            {
                var Discapacidad_SensorialIds = string.Join(",", filter.AdvanceDiscapacidad_SensorialMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Discapacidad_Sensorial In (" + Discapacidad_SensorialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiscapacidad_Psicosocial))
            {
                switch (filter.Discapacidad_PsicosocialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Discapacidades_Psicosociales.Descripcion LIKE '" + filter.AdvanceDiscapacidad_Psicosocial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Discapacidades_Psicosociales.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Psicosocial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Discapacidades_Psicosociales.Descripcion = '" + filter.AdvanceDiscapacidad_Psicosocial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Discapacidades_Psicosociales.Descripcion LIKE '%" + filter.AdvanceDiscapacidad_Psicosocial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiscapacidad_PsicosocialMultiple != null && filter.AdvanceDiscapacidad_PsicosocialMultiple.Count() > 0)
            {
                var Discapacidad_PsicosocialIds = string.Join(",", filter.AdvanceDiscapacidad_PsicosocialMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Discapacidad_Psicosocial In (" + Discapacidad_PsicosocialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_de_Tutor))
            {
                switch (filter.Nombre_de_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Tutor LIKE '" + filter.Nombre_de_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Tutor LIKE '%" + filter.Nombre_de_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Tutor = '" + filter.Nombre_de_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_de_Tutor LIKE '%" + filter.Nombre_de_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_Tutor))
            {
                switch (filter.Apellido_Paterno_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor LIKE '" + filter.Apellido_Paterno_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor LIKE '%" + filter.Apellido_Paterno_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor = '" + filter.Apellido_Paterno_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor LIKE '%" + filter.Apellido_Paterno_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_Tutor))
            {
                switch (filter.Apellido_Materno_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno_Tutor LIKE '" + filter.Apellido_Materno_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno_Tutor LIKE '%" + filter.Apellido_Materno_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno_Tutor = '" + filter.Apellido_Materno_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Apellido_Materno_Tutor LIKE '%" + filter.Apellido_Materno_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo_Tutor))
            {
                switch (filter.Nombre_Completo_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo_Tutor LIKE '" + filter.Nombre_Completo_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo_Tutor LIKE '%" + filter.Nombre_Completo_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo_Tutor = '" + filter.Nombre_Completo_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo_Tutor LIKE '%" + filter.Nombre_Completo_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_tutor) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_tutor))
            {
                var Fecha_de_Nacimiento_tutorFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Nacimiento_tutorTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_tutor))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor >= '" + Fecha_de_Nacimiento_tutorFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_tutor))
                    where += " AND Detalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor <= '" + Fecha_de_Nacimiento_tutorTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad_tutor) || !string.IsNullOrEmpty(filter.ToEdad_tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad_tutor))
                    where += " AND Detalle_de_Solicitud_Requerido.Edad_tutor >= " + filter.FromEdad_tutor;
                if (!string.IsNullOrEmpty(filter.ToEdad_tutor))
                    where += " AND Detalle_de_Solicitud_Requerido.Edad_tutor <= " + filter.ToEdad_tutor;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo_tutor))
            {
                switch (filter.Sexo_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexo_tutorMultiple != null && filter.AdvanceSexo_tutorMultiple.Count() > 0)
            {
                var Sexo_tutorIds = string.Join(",", filter.AdvanceSexo_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Sexo_tutor In (" + Sexo_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Civil_tutor))
            {
                switch (filter.Estado_Civil_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_Civil.Descripcion LIKE '" + filter.AdvanceEstado_Civil_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_Civil.Descripcion = '" + filter.AdvanceEstado_Civil_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_Civil_tutorMultiple != null && filter.AdvanceEstado_Civil_tutorMultiple.Count() > 0)
            {
                var Estado_Civil_tutorIds = string.Join(",", filter.AdvanceEstado_Civil_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Estado_Civil_tutor In (" + Estado_Civil_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion_tutor))
            {
                switch (filter.Tipo_de_Identificacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Identificacion_tutorMultiple != null && filter.AdvanceTipo_de_Identificacion_tutorMultiple.Count() > 0)
            {
                var Tipo_de_Identificacion_tutorIds = string.Join(",", filter.AdvanceTipo_de_Identificacion_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Tipo_de_Identificacion_tutor In (" + Tipo_de_Identificacion_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion_tutor))
            {
                switch (filter.Numero_de_Identificacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor LIKE '" + filter.Numero_de_Identificacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor LIKE '%" + filter.Numero_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor = '" + filter.Numero_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor LIKE '%" + filter.Numero_de_Identificacion_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad_tutor))
            {
                switch (filter.Nacionalidad_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidad_tutorMultiple != null && filter.AdvanceNacionalidad_tutorMultiple.Count() > 0)
            {
                var Nacionalidad_tutorIds = string.Join(",", filter.AdvanceNacionalidad_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Nacionalidad_tutor In (" + Nacionalidad_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad_tutor))
            {
                switch (filter.Escolaridad_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridad_tutorMultiple != null && filter.AdvanceEscolaridad_tutorMultiple.Count() > 0)
            {
                var Escolaridad_tutorIds = string.Join(",", filter.AdvanceEscolaridad_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Escolaridad_tutor In (" + Escolaridad_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOcupacion_tutor))
            {
                switch (filter.Ocupacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ocupacion.Descripcion LIKE '" + filter.AdvanceOcupacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ocupacion.Descripcion = '" + filter.AdvanceOcupacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOcupacion_tutorMultiple != null && filter.AdvanceOcupacion_tutorMultiple.Count() > 0)
            {
                var Ocupacion_tutorIds = string.Join(",", filter.AdvanceOcupacion_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Ocupacion_tutor In (" + Ocupacion_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_tutor))
            {
                switch (filter.Pais_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_tutorMultiple != null && filter.AdvancePais_tutorMultiple.Count() > 0)
            {
                var Pais_tutorIds = string.Join(",", filter.AdvancePais_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Pais_tutor In (" + Pais_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_tutor))
            {
                switch (filter.Estado_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_tutorMultiple != null && filter.AdvanceEstado_tutorMultiple.Count() > 0)
            {
                var Estado_tutorIds = string.Join(",", filter.AdvanceEstado_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Estado_tutor In (" + Estado_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_tutor))
            {
                switch (filter.Municipio_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_tutorMultiple != null && filter.AdvanceMunicipio_tutorMultiple.Count() > 0)
            {
                var Municipio_tutorIds = string.Join(",", filter.AdvanceMunicipio_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Municipio_tutor In (" + Municipio_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion_tutor))
            {
                switch (filter.Poblacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacion_tutorMultiple != null && filter.AdvancePoblacion_tutorMultiple.Count() > 0)
            {
                var Poblacion_tutorIds = string.Join(",", filter.AdvancePoblacion_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Poblacion_tutor In (" + Poblacion_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_tutor))
            {
                switch (filter.Colonia_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_tutorMultiple != null && filter.AdvanceColonia_tutorMultiple.Count() > 0)
            {
                var Colonia_tutorIds = string.Join(",", filter.AdvanceColonia_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Colonia_tutor In (" + Colonia_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_tutor) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_tutor))
                    where += " AND Detalle_de_Solicitud_Requerido.Codigo_Postal_tutor >= " + filter.FromCodigo_Postal_tutor;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_tutor))
                    where += " AND Detalle_de_Solicitud_Requerido.Codigo_Postal_tutor <= " + filter.ToCodigo_Postal_tutor;
            }

            if (!string.IsNullOrEmpty(filter.Calle_tutor))
            {
                switch (filter.Calle_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle_tutor LIKE '" + filter.Calle_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle_tutor LIKE '%" + filter.Calle_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle_tutor = '" + filter.Calle_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Calle_tutor LIKE '%" + filter.Calle_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_tutor))
            {
                switch (filter.Numero_Exterior_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior_tutor LIKE '" + filter.Numero_Exterior_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior_tutor LIKE '%" + filter.Numero_Exterior_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior_tutor = '" + filter.Numero_Exterior_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Exterior_tutor LIKE '%" + filter.Numero_Exterior_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_tutor))
            {
                switch (filter.Numero_Interior_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior_tutor LIKE '" + filter.Numero_Interior_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior_tutor LIKE '%" + filter.Numero_Interior_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior_tutor = '" + filter.Numero_Interior_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Numero_Interior_tutor LIKE '%" + filter.Numero_Interior_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia))
            {
                switch (filter.ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia LIKE '" + filter.Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia LIKE '%" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia = '" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Referencia LIKE '%" + filter.Referencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_tutor))
            {
                switch (filter.Latitud_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud_tutor LIKE '" + filter.Latitud_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud_tutor LIKE '%" + filter.Latitud_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud_tutor = '" + filter.Latitud_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Latitud_tutor LIKE '%" + filter.Latitud_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_tutor))
            {
                switch (filter.Longitud_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud_tutor LIKE '" + filter.Longitud_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud_tutor LIKE '%" + filter.Longitud_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud_tutor = '" + filter.Longitud_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Longitud_tutor LIKE '%" + filter.Longitud_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Extension_tutor))
            {
                switch (filter.Extension_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Extension_tutor LIKE '" + filter.Extension_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Extension_tutor LIKE '%" + filter.Extension_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Extension_tutor = '" + filter.Extension_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Extension_tutor LIKE '%" + filter.Extension_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular_tutor))
            {
                switch (filter.Celular_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular_tutor LIKE '" + filter.Celular_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular_tutor LIKE '%" + filter.Celular_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular_tutor = '" + filter.Celular_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Celular_tutor LIKE '%" + filter.Celular_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico_tutor))
            {
                switch (filter.Correo_Electronico_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico_tutor LIKE '" + filter.Correo_Electronico_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico_tutor LIKE '%" + filter.Correo_Electronico_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico_tutor = '" + filter.Correo_Electronico_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Correo_Electronico_tutor LIKE '%" + filter.Correo_Electronico_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_Origen_Tutor))
            {
                switch (filter.Pais_de_Origen_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_Origen_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_Origen_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_Origen_TutorMultiple != null && filter.AdvancePais_de_Origen_TutorMultiple.Count() > 0)
            {
                var Pais_de_Origen_TutorIds = string.Join(",", filter.AdvancePais_de_Origen_TutorMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Pais_de_Origen_Tutor In (" + Pais_de_Origen_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de_Tutor))
            {
                switch (filter.Originario_de_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de_Tutor LIKE '" + filter.Originario_de_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de_Tutor LIKE '%" + filter.Originario_de_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de_Tutor = '" + filter.Originario_de_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Originario_de_Tutor LIKE '%" + filter.Originario_de_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CURP_Tutor))
            {
                switch (filter.CURP_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP_Tutor LIKE '" + filter.CURP_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP_Tutor LIKE '%" + filter.CURP_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP_Tutor = '" + filter.CURP_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.CURP_Tutor LIKE '%" + filter.CURP_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC_Tutor))
            {
                switch (filter.RFC_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC_Tutor LIKE '" + filter.RFC_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC_Tutor LIKE '%" + filter.RFC_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC_Tutor = '" + filter.RFC_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.RFC_Tutor LIKE '%" + filter.RFC_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Padecimiento_de_Enfermedad))
            {
                switch (filter.Padecimiento_de_EnfermedadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad LIKE '" + filter.Padecimiento_de_Enfermedad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad = '" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "%'";
                        break;
                }
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

                where += " AND Detalle_de_Solicitud_Requerido.Cejas In (" + CejasIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Tamano_de_Cejas In (" + Tamano_de_CejasIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Anteojos In (" + AnteojosIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Forma_de_Nariz In (" + Forma_de_NarizIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNariz_base))
            {
                switch (filter.Nariz_baseFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nariz_Base.Descripcion LIKE '" + filter.AdvanceNariz_base + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nariz_Base.Descripcion LIKE '%" + filter.AdvanceNariz_base + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nariz_Base.Descripcion = '" + filter.AdvanceNariz_base + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nariz_Base.Descripcion LIKE '%" + filter.AdvanceNariz_base + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNariz_baseMultiple != null && filter.AdvanceNariz_baseMultiple.Count() > 0)
            {
                var Nariz_baseIds = string.Join(",", filter.AdvanceNariz_baseMultiple);

                where += " AND Detalle_de_Solicitud_Requerido.Nariz_base In (" + Nariz_baseIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Grosor_de_Labios In (" + Grosor_de_LabiosIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Forma_de_Menton In (" + Forma_de_MentonIds + ")";
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

                where += " AND Detalle_de_Solicitud_Requerido.Senas_Particulares In (" + Senas_ParticularesIds + ")";
            }

            if (filter.Imagen_Tatuaje != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Requerido.Imagen_Tatuaje " + (filter.Imagen_Tatuaje == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Otras_Senas_Particulares))
            {
                switch (filter.Otras_Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Otras_Senas_Particulares LIKE '" + filter.Otras_Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Otras_Senas_Particulares = '" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Imputado_Recluido))
            {
                switch (filter.Imputado_RecluidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Imputado_Recluido LIKE '" + filter.Imputado_Recluido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Imputado_Recluido LIKE '%" + filter.Imputado_Recluido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Imputado_Recluido = '" + filter.Imputado_Recluido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Imputado_Recluido LIKE '%" + filter.Imputado_Recluido + "%'";
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

        public ActionResult GetOtros_Nombres_Requerido_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Otros_Nombres_Requerido_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IOtros_Nombres_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Otros_Nombres_Requerido_MASC.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Otros_Nombres_Requerido_MASC.Requerido='" + RelationId + "'";
            }
            var result = _IOtros_Nombres_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Otros_Nombres_Requerido_MASCs == null)
                result.Otros_Nombres_Requerido_MASCs = new List<Otros_Nombres_Requerido_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Otros_Nombres_Requerido_MASCs.Select(m => new Otros_Nombres_Requerido_MASCGridModel
                {
                    Clave = m.Clave

			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Otros_Nombres_Requerido_MASCGridModel> GetOtros_Nombres_Requerido_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Otros_Nombres_Requerido_MASCGridModel> resultData = new List<Otros_Nombres_Requerido_MASCGridModel>();
            string where = "Otros_Nombres_Requerido_MASC.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Otros_Nombres_Requerido_MASC.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IOtros_Nombres_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IOtros_Nombres_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Otros_Nombres_Requerido_MASCs != null)
            {
                resultData = result.Otros_Nombres_Requerido_MASCs.Select(m => new Otros_Nombres_Requerido_MASCGridModel
                    {
                        Clave = m.Clave

			,Descripcion = m.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetOtros_Domicilios_Requeridos_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Otros_Domicilios_Requeridos_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IOtros_Domicilios_Requeridos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Otros_Domicilios_Requeridos_MASC.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Otros_Domicilios_Requeridos_MASC.Requerido='" + RelationId + "'";
            }
            var result = _IOtros_Domicilios_Requeridos_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Otros_Domicilios_Requeridos_MASCs == null)
                result.Otros_Domicilios_Requeridos_MASCs = new List<Otros_Domicilios_Requeridos_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Otros_Domicilios_Requeridos_MASCs.Select(m => new Otros_Domicilios_Requeridos_MASCGridModel
                {
                    Clave = m.Clave

                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ??(string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Otros_Domicilios_Requeridos_MASCGridModel> GetOtros_Domicilios_Requeridos_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Otros_Domicilios_Requeridos_MASCGridModel> resultData = new List<Otros_Domicilios_Requeridos_MASCGridModel>();
            string where = "Otros_Domicilios_Requeridos_MASC.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Otros_Domicilios_Requeridos_MASC.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IOtros_Domicilios_Requeridos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IOtros_Domicilios_Requeridos_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Otros_Domicilios_Requeridos_MASCs != null)
            {
                resultData = result.Otros_Domicilios_Requeridos_MASCs.Select(m => new Otros_Domicilios_Requeridos_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ??(string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetAdicciones_Requerido_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Adicciones_Requerido_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IAdicciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Adicciones_Requerido_MASC.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Adicciones_Requerido_MASC.Requerido='" + RelationId + "'";
            }
            var result = _IAdicciones_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Adicciones_Requerido_MASCs == null)
                result.Adicciones_Requerido_MASCs = new List<Adicciones_Requerido_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Adicciones_Requerido_MASCs.Select(m => new Adicciones_Requerido_MASCGridModel
                {
                    Clave = m.Clave

                        ,Descripcion = m.Descripcion
                        ,DescripcionDescripcion = CultureHelper.GetTraduction(m.Descripcion_Adicciones.Clave.ToString(), "Descripcion") ??(string)m.Descripcion_Adicciones.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Adicciones_Requerido_MASCGridModel> GetAdicciones_Requerido_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Adicciones_Requerido_MASCGridModel> resultData = new List<Adicciones_Requerido_MASCGridModel>();
            string where = "Adicciones_Requerido_MASC.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Adicciones_Requerido_MASC.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IAdicciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IAdicciones_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Adicciones_Requerido_MASCs != null)
            {
                resultData = result.Adicciones_Requerido_MASCs.Select(m => new Adicciones_Requerido_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Descripcion = m.Descripcion
                        ,DescripcionDescripcion = CultureHelper.GetTraduction(m.Descripcion_Adicciones.Clave.ToString(), "Descripcion") ??(string)m.Descripcion_Adicciones.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetLugares_Frecuentes_Requerido_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Lugares_Frecuentes_Requerido_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ILugares_Frecuentes_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Lugares_Frecuentes_Requerido_MASC.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Lugares_Frecuentes_Requerido_MASC.Requerido='" + RelationId + "'";
            }
            var result = _ILugares_Frecuentes_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Lugares_Frecuentes_Requerido_MASCs == null)
                result.Lugares_Frecuentes_Requerido_MASCs = new List<Lugares_Frecuentes_Requerido_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Lugares_Frecuentes_Requerido_MASCs.Select(m => new Lugares_Frecuentes_Requerido_MASCGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Lugar = m.Tipo_de_Lugar
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Lugares.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_Lugares.Descripcion
			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Lugares_Frecuentes_Requerido_MASCGridModel> GetLugares_Frecuentes_Requerido_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Lugares_Frecuentes_Requerido_MASCGridModel> resultData = new List<Lugares_Frecuentes_Requerido_MASCGridModel>();
            string where = "Lugares_Frecuentes_Requerido_MASC.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Lugares_Frecuentes_Requerido_MASC.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ILugares_Frecuentes_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ILugares_Frecuentes_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Lugares_Frecuentes_Requerido_MASCs != null)
            {
                resultData = result.Lugares_Frecuentes_Requerido_MASCs.Select(m => new Lugares_Frecuentes_Requerido_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Lugar = m.Tipo_de_Lugar
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Lugares.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_Lugares.Descripcion
			,Descripcion = m.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDatos_Personales_Adicionales_Requerido_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Datos_Personales_Adicionales_Requerido_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Datos_Personales_Adicionales_Requerido_MASC.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Datos_Personales_Adicionales_Requerido_MASC.Requerido='" + RelationId + "'";
            }
            var result = _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Datos_Personales_Adicionales_Requerido_MASCs == null)
                result.Datos_Personales_Adicionales_Requerido_MASCs = new List<Datos_Personales_Adicionales_Requerido_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Datos_Personales_Adicionales_Requerido_MASCs.Select(m => new Datos_Personales_Adicionales_Requerido_MASCGridModel
                {
                    Clave = m.Clave

			,Correo_Electronico = m.Correo_Electronico
			,Numero_Telefonico = m.Numero_Telefonico
                        ,Redes_Sociales = m.Redes_Sociales
                        ,Redes_SocialesDescripcion = CultureHelper.GetTraduction(m.Redes_Sociales_Redes_Sociales.Clave.ToString(), "Descripcion") ??(string)m.Redes_Sociales_Redes_Sociales.Descripcion
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Datos_Personales_Adicionales_Requerido_MASCGridModel> GetDatos_Personales_Adicionales_Requerido_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Datos_Personales_Adicionales_Requerido_MASCGridModel> resultData = new List<Datos_Personales_Adicionales_Requerido_MASCGridModel>();
            string where = "Datos_Personales_Adicionales_Requerido_MASC.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Datos_Personales_Adicionales_Requerido_MASC.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Datos_Personales_Adicionales_Requerido_MASCs != null)
            {
                resultData = result.Datos_Personales_Adicionales_Requerido_MASCs.Select(m => new Datos_Personales_Adicionales_Requerido_MASCGridModel
                    {
                        Clave = m.Clave

			,Correo_Electronico = m.Correo_Electronico
			,Numero_Telefonico = m.Numero_Telefonico
                        ,Redes_Sociales = m.Redes_Sociales
                        ,Redes_SocialesDescripcion = CultureHelper.GetTraduction(m.Redes_Sociales_Redes_Sociales.Clave.ToString(), "Descripcion") ??(string)m.Redes_Sociales_Redes_Sociales.Descripcion
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetOtras_Identificaciones_Requerido_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Otras_Identificaciones_Requerido_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IOtras_Identificaciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Otras_Identificaciones_Requerido_MASC.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Otras_Identificaciones_Requerido_MASC.Requerido='" + RelationId + "'";
            }
            var result = _IOtras_Identificaciones_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Otras_Identificaciones_Requerido_MASCs == null)
                result.Otras_Identificaciones_Requerido_MASCs = new List<Otras_Identificaciones_Requerido_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Otras_Identificaciones_Requerido_MASCs.Select(m => new Otras_Identificaciones_Requerido_MASCGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Otras_Identificaciones_Requerido_MASCGridModel> GetOtras_Identificaciones_Requerido_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Otras_Identificaciones_Requerido_MASCGridModel> resultData = new List<Otras_Identificaciones_Requerido_MASCGridModel>();
            string where = "Otras_Identificaciones_Requerido_MASC.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Otras_Identificaciones_Requerido_MASC.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IOtras_Identificaciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IOtras_Identificaciones_Requerido_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Otras_Identificaciones_Requerido_MASCs != null)
            {
                resultData = result.Otras_Identificaciones_Requerido_MASCs.Select(m => new Otras_Identificaciones_Requerido_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Descripcion = m.Descripcion


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
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Solicitud_Requerido varDetalle_de_Solicitud_Requerido = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IOtros_Nombres_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Otros_Nombres_Requerido_MASC.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Otros_Nombres_Requerido_MASC.Requerido='" + id + "'";
                    }
                    var Otros_Nombres_Requerido_MASCInfo =
                        _IOtros_Nombres_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Otros_Nombres_Requerido_MASCInfo.Otros_Nombres_Requerido_MASCs.Count > 0)
                    {
                        var resultOtros_Nombres_Requerido_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Otros_Nombres_Requerido_MASCItem in Otros_Nombres_Requerido_MASCInfo.Otros_Nombres_Requerido_MASCs)
                            resultOtros_Nombres_Requerido_MASC = resultOtros_Nombres_Requerido_MASC
                                              && _IOtros_Nombres_Requerido_MASCApiConsumer.Delete(Otros_Nombres_Requerido_MASCItem.Clave, null,null).Resource;

                        if (!resultOtros_Nombres_Requerido_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IOtros_Domicilios_Requeridos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Otros_Domicilios_Requeridos_MASC.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Otros_Domicilios_Requeridos_MASC.Requerido='" + id + "'";
                    }
                    var Otros_Domicilios_Requeridos_MASCInfo =
                        _IOtros_Domicilios_Requeridos_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Otros_Domicilios_Requeridos_MASCInfo.Otros_Domicilios_Requeridos_MASCs.Count > 0)
                    {
                        var resultOtros_Domicilios_Requeridos_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Otros_Domicilios_Requeridos_MASCItem in Otros_Domicilios_Requeridos_MASCInfo.Otros_Domicilios_Requeridos_MASCs)
                            resultOtros_Domicilios_Requeridos_MASC = resultOtros_Domicilios_Requeridos_MASC
                                              && _IOtros_Domicilios_Requeridos_MASCApiConsumer.Delete(Otros_Domicilios_Requeridos_MASCItem.Clave, null,null).Resource;

                        if (!resultOtros_Domicilios_Requeridos_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IAdicciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Adicciones_Requerido_MASC.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Adicciones_Requerido_MASC.Requerido='" + id + "'";
                    }
                    var Adicciones_Requerido_MASCInfo =
                        _IAdicciones_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Adicciones_Requerido_MASCInfo.Adicciones_Requerido_MASCs.Count > 0)
                    {
                        var resultAdicciones_Requerido_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Adicciones_Requerido_MASCItem in Adicciones_Requerido_MASCInfo.Adicciones_Requerido_MASCs)
                            resultAdicciones_Requerido_MASC = resultAdicciones_Requerido_MASC
                                              && _IAdicciones_Requerido_MASCApiConsumer.Delete(Adicciones_Requerido_MASCItem.Clave, null,null).Resource;

                        if (!resultAdicciones_Requerido_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ILugares_Frecuentes_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Lugares_Frecuentes_Requerido_MASC.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Lugares_Frecuentes_Requerido_MASC.Requerido='" + id + "'";
                    }
                    var Lugares_Frecuentes_Requerido_MASCInfo =
                        _ILugares_Frecuentes_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Lugares_Frecuentes_Requerido_MASCInfo.Lugares_Frecuentes_Requerido_MASCs.Count > 0)
                    {
                        var resultLugares_Frecuentes_Requerido_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Lugares_Frecuentes_Requerido_MASCItem in Lugares_Frecuentes_Requerido_MASCInfo.Lugares_Frecuentes_Requerido_MASCs)
                            resultLugares_Frecuentes_Requerido_MASC = resultLugares_Frecuentes_Requerido_MASC
                                              && _ILugares_Frecuentes_Requerido_MASCApiConsumer.Delete(Lugares_Frecuentes_Requerido_MASCItem.Clave, null,null).Resource;

                        if (!resultLugares_Frecuentes_Requerido_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Datos_Personales_Adicionales_Requerido_MASC.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Datos_Personales_Adicionales_Requerido_MASC.Requerido='" + id + "'";
                    }
                    var Datos_Personales_Adicionales_Requerido_MASCInfo =
                        _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Datos_Personales_Adicionales_Requerido_MASCInfo.Datos_Personales_Adicionales_Requerido_MASCs.Count > 0)
                    {
                        var resultDatos_Personales_Adicionales_Requerido_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Datos_Personales_Adicionales_Requerido_MASCItem in Datos_Personales_Adicionales_Requerido_MASCInfo.Datos_Personales_Adicionales_Requerido_MASCs)
                            resultDatos_Personales_Adicionales_Requerido_MASC = resultDatos_Personales_Adicionales_Requerido_MASC
                                              && _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.Delete(Datos_Personales_Adicionales_Requerido_MASCItem.Clave, null,null).Resource;

                        if (!resultDatos_Personales_Adicionales_Requerido_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IOtras_Identificaciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Otras_Identificaciones_Requerido_MASC.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Otras_Identificaciones_Requerido_MASC.Requerido='" + id + "'";
                    }
                    var Otras_Identificaciones_Requerido_MASCInfo =
                        _IOtras_Identificaciones_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Otras_Identificaciones_Requerido_MASCInfo.Otras_Identificaciones_Requerido_MASCs.Count > 0)
                    {
                        var resultOtras_Identificaciones_Requerido_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Otras_Identificaciones_Requerido_MASCItem in Otras_Identificaciones_Requerido_MASCInfo.Otras_Identificaciones_Requerido_MASCs)
                            resultOtras_Identificaciones_Requerido_MASC = resultOtras_Identificaciones_Requerido_MASC
                                              && _IOtras_Identificaciones_Requerido_MASCApiConsumer.Delete(Otras_Identificaciones_Requerido_MASCItem.Clave, null,null).Resource;

                        if (!resultOtras_Identificaciones_Requerido_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Solicitud_RequeridoModel varDetalle_de_Solicitud_Requerido)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Solicitud_Requerido.Imagen_TatuajeRemoveAttachment != 0 && varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile == null)
                    {
                        varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje = 0;
                    }

                    if (varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Solicitud_RequeridoInfo = new Detalle_de_Solicitud_Requerido
                    {
                        Clave = varDetalle_de_Solicitud_Requerido.Clave
                        ,idRegistroAT = varDetalle_de_Solicitud_Requerido.idRegistroAT
                        ,idRegistroUI = varDetalle_de_Solicitud_Requerido.idRegistroUI
                        ,Solicitud = varDetalle_de_Solicitud_Requerido.Solicitud
                        ,A_Quien_Sea_Responsable = varDetalle_de_Solicitud_Requerido.A_Quien_Sea_Responsable
                        ,Nombre = varDetalle_de_Solicitud_Requerido.Nombre
                        ,Apellido_Paterno = varDetalle_de_Solicitud_Requerido.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Solicitud_Requerido.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Solicitud_Requerido.Nombre_Completo
                        ,Alias = varDetalle_de_Solicitud_Requerido.Alias
                        ,Apodo = varDetalle_de_Solicitud_Requerido.Apodo
                        ,CURP = varDetalle_de_Solicitud_Requerido.CURP
                        ,RFC = varDetalle_de_Solicitud_Requerido.RFC
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Solicitud_Requerido.Edad
                        ,Sexo = varDetalle_de_Solicitud_Requerido.Sexo
                        ,Estado_Civil = varDetalle_de_Solicitud_Requerido.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Solicitud_Requerido.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Solicitud_Requerido.Numero_de_Identificacion
                        ,Nacionalidad = varDetalle_de_Solicitud_Requerido.Nacionalidad
                        ,Escolaridad = varDetalle_de_Solicitud_Requerido.Escolaridad
                        ,Ocupacion = varDetalle_de_Solicitud_Requerido.Ocupacion
                        ,Pais = varDetalle_de_Solicitud_Requerido.Pais
                        ,Estado = varDetalle_de_Solicitud_Requerido.Estado
                        ,Municipio = varDetalle_de_Solicitud_Requerido.Municipio
                        ,Codigo_Postal = varDetalle_de_Solicitud_Requerido.Codigo_Postal
                        ,Poblacion = varDetalle_de_Solicitud_Requerido.Poblacion
                        ,Colonia = varDetalle_de_Solicitud_Requerido.Colonia
                        ,Calle = varDetalle_de_Solicitud_Requerido.Calle
                        ,Numero_Exterior = varDetalle_de_Solicitud_Requerido.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Solicitud_Requerido.Numero_Interior
                        ,Entre_Calle = varDetalle_de_Solicitud_Requerido.Entre_Calle
                        ,Y_Calle = varDetalle_de_Solicitud_Requerido.Y_Calle
                        ,Referencia_de_Domicilio_Requerido = varDetalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido
                        ,Latitud = varDetalle_de_Solicitud_Requerido.Latitud
                        ,Longitud = varDetalle_de_Solicitud_Requerido.Longitud
                        ,Telefono = varDetalle_de_Solicitud_Requerido.Telefono
                        ,Extencion = varDetalle_de_Solicitud_Requerido.Extencion
                        ,Celular = varDetalle_de_Solicitud_Requerido.Celular
                        ,Correo_Electronico = varDetalle_de_Solicitud_Requerido.Correo_Electronico
                        ,Pais_de_Origen = varDetalle_de_Solicitud_Requerido.Pais_de_Origen
                        ,Originario_de = varDetalle_de_Solicitud_Requerido.Originario_de
                        ,Estado_de_Nacimiento = varDetalle_de_Solicitud_Requerido.Estado_de_Nacimiento
                        ,Municipio_de_Nacimiento = varDetalle_de_Solicitud_Requerido.Municipio_de_Nacimiento
                        ,Inimputable = varDetalle_de_Solicitud_Requerido.Inimputable
                        ,Tipo_de_Inimputabilidad = varDetalle_de_Solicitud_Requerido.Tipo_de_Inimputabilidad
                        ,Se_Presenta_con_Detenido = varDetalle_de_Solicitud_Requerido.Se_Presenta_con_Detenido
                        ,Folio_Registro_Nacional_de_Detenciones = varDetalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Detencion)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Municipio_de_Detencion = varDetalle_de_Solicitud_Requerido.Municipio_de_Detencion
                        ,Corporacion = varDetalle_de_Solicitud_Requerido.Corporacion
                        ,Suspension_Condicional = varDetalle_de_Solicitud_Requerido.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Lugar_donde_se_Encuentra_Detenido = varDetalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido
                        ,Etnia = varDetalle_de_Solicitud_Requerido.Etnia
                        ,No__de_Hijos = varDetalle_de_Solicitud_Requerido.No__de_Hijos
                        ,Religion = varDetalle_de_Solicitud_Requerido.Religion
                        ,Servicio_Medico = varDetalle_de_Solicitud_Requerido.Servicio_Medico
                        ,Especialidad = varDetalle_de_Solicitud_Requerido.Especialidad
                        ,Estudios_Superiores = varDetalle_de_Solicitud_Requerido.Estudios_Superiores
                        ,Idioma = varDetalle_de_Solicitud_Requerido.Idioma
                        ,Calidad_Migratoria = varDetalle_de_Solicitud_Requerido.Calidad_Migratoria
                        ,Dialecto = varDetalle_de_Solicitud_Requerido.Dialecto
                        ,Viene_en_Estado_de_Ebriedad = varDetalle_de_Solicitud_Requerido.Viene_en_Estado_de_Ebriedad
                        ,Bajo_el_Efecto_de_una_Droga = varDetalle_de_Solicitud_Requerido.Bajo_el_Efecto_de_una_Droga
                        ,Nombre_de_Droga = varDetalle_de_Solicitud_Requerido.Nombre_de_Droga
                        ,Discapacidad_Mental = varDetalle_de_Solicitud_Requerido.Discapacidad_Mental
                        ,Discapacidad_Fisica = varDetalle_de_Solicitud_Requerido.Discapacidad_Fisica
                        ,Discapacidad_Sensorial = varDetalle_de_Solicitud_Requerido.Discapacidad_Sensorial
                        ,Discapacidad_Psicosocial = varDetalle_de_Solicitud_Requerido.Discapacidad_Psicosocial
                        ,Nombre_de_Tutor = varDetalle_de_Solicitud_Requerido.Nombre_de_Tutor
                        ,Apellido_Paterno_Tutor = varDetalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor
                        ,Apellido_Materno_Tutor = varDetalle_de_Solicitud_Requerido.Apellido_Materno_Tutor
                        ,Nombre_Completo_Tutor = varDetalle_de_Solicitud_Requerido.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_tutor = varDetalle_de_Solicitud_Requerido.Edad_tutor
                        ,Sexo_tutor = varDetalle_de_Solicitud_Requerido.Sexo_tutor
                        ,Estado_Civil_tutor = varDetalle_de_Solicitud_Requerido.Estado_Civil_tutor
                        ,Tipo_de_Identificacion_tutor = varDetalle_de_Solicitud_Requerido.Tipo_de_Identificacion_tutor
                        ,Numero_de_Identificacion_tutor = varDetalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutor = varDetalle_de_Solicitud_Requerido.Nacionalidad_tutor
                        ,Escolaridad_tutor = varDetalle_de_Solicitud_Requerido.Escolaridad_tutor
                        ,Ocupacion_tutor = varDetalle_de_Solicitud_Requerido.Ocupacion_tutor
                        ,Pais_tutor = varDetalle_de_Solicitud_Requerido.Pais_tutor
                        ,Estado_tutor = varDetalle_de_Solicitud_Requerido.Estado_tutor
                        ,Municipio_tutor = varDetalle_de_Solicitud_Requerido.Municipio_tutor
                        ,Poblacion_tutor = varDetalle_de_Solicitud_Requerido.Poblacion_tutor
                        ,Colonia_tutor = varDetalle_de_Solicitud_Requerido.Colonia_tutor
                        ,Codigo_Postal_tutor = varDetalle_de_Solicitud_Requerido.Codigo_Postal_tutor
                        ,Calle_tutor = varDetalle_de_Solicitud_Requerido.Calle_tutor
                        ,Numero_Exterior_tutor = varDetalle_de_Solicitud_Requerido.Numero_Exterior_tutor
                        ,Numero_Interior_tutor = varDetalle_de_Solicitud_Requerido.Numero_Interior_tutor
                        ,Referencia = varDetalle_de_Solicitud_Requerido.Referencia
                        ,Latitud_tutor = varDetalle_de_Solicitud_Requerido.Latitud_tutor
                        ,Longitud_tutor = varDetalle_de_Solicitud_Requerido.Longitud_tutor
                        ,Extension_tutor = varDetalle_de_Solicitud_Requerido.Extension_tutor
                        ,Celular_tutor = varDetalle_de_Solicitud_Requerido.Celular_tutor
                        ,Correo_Electronico_tutor = varDetalle_de_Solicitud_Requerido.Correo_Electronico_tutor
                        ,Pais_de_Origen_Tutor = varDetalle_de_Solicitud_Requerido.Pais_de_Origen_Tutor
                        ,Originario_de_Tutor = varDetalle_de_Solicitud_Requerido.Originario_de_Tutor
                        ,CURP_Tutor = varDetalle_de_Solicitud_Requerido.CURP_Tutor
                        ,RFC_Tutor = varDetalle_de_Solicitud_Requerido.RFC_Tutor
                        ,Padecimiento_de_Enfermedad = varDetalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad
                        ,Cejas = varDetalle_de_Solicitud_Requerido.Cejas
                        ,Tamano_de_Cejas = varDetalle_de_Solicitud_Requerido.Tamano_de_Cejas
                        ,Anteojos = varDetalle_de_Solicitud_Requerido.Anteojos
                        ,Forma_de_Nariz = varDetalle_de_Solicitud_Requerido.Forma_de_Nariz
                        ,Nariz_base = varDetalle_de_Solicitud_Requerido.Nariz_base
                        ,Grosor_de_Labios = varDetalle_de_Solicitud_Requerido.Grosor_de_Labios
                        ,Forma_de_Menton = varDetalle_de_Solicitud_Requerido.Forma_de_Menton
                        ,Senas_Particulares = varDetalle_de_Solicitud_Requerido.Senas_Particulares
                        ,Imagen_Tatuaje = (varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje.HasValue && varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje.Value)) : null

                        ,Otras_Senas_Particulares = varDetalle_de_Solicitud_Requerido.Otras_Senas_Particulares
                        ,Imputado_Recluido = varDetalle_de_Solicitud_Requerido.Imputado_Recluido

                    };

                    result = !IsNew ?
                        _IDetalle_de_Solicitud_RequeridoApiConsumer.Update(Detalle_de_Solicitud_RequeridoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Solicitud_RequeridoApiConsumer.Insert(Detalle_de_Solicitud_RequeridoInfo, null, null).Resource.ToString();
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
        public bool CopyOtros_Nombres_Requerido_MASC(int MasterId, int referenceId, List<Otros_Nombres_Requerido_MASCGridModelPost> Otros_Nombres_Requerido_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IOtros_Nombres_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Otros_Nombres_Requerido_MASCData = _IOtros_Nombres_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Otros_Nombres_Requerido_MASC.Requerido=" + referenceId,"").Resource;
                if (Otros_Nombres_Requerido_MASCData == null || Otros_Nombres_Requerido_MASCData.Otros_Nombres_Requerido_MASCs.Count == 0)
                    return true;

                var result = true;

                Otros_Nombres_Requerido_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varOtros_Nombres_Requerido_MASC in Otros_Nombres_Requerido_MASCData.Otros_Nombres_Requerido_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Otros_Nombres_Requerido_MASC Otros_Nombres_Requerido_MASC1 = varOtros_Nombres_Requerido_MASC;

                    if (Otros_Nombres_Requerido_MASCItems != null && Otros_Nombres_Requerido_MASCItems.Any(m => m.Clave == Otros_Nombres_Requerido_MASC1.Clave))
                    {
                        modelDataToChange = Otros_Nombres_Requerido_MASCItems.FirstOrDefault(m => m.Clave == Otros_Nombres_Requerido_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varOtros_Nombres_Requerido_MASC.Requerido = MasterId;
                    var insertId = _IOtros_Nombres_Requerido_MASCApiConsumer.Insert(varOtros_Nombres_Requerido_MASC,null,null).Resource;
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
        public ActionResult PostOtros_Nombres_Requerido_MASC(List<Otros_Nombres_Requerido_MASCGridModelPost> Otros_Nombres_Requerido_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyOtros_Nombres_Requerido_MASC(MasterId, referenceId, Otros_Nombres_Requerido_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Otros_Nombres_Requerido_MASCItems != null && Otros_Nombres_Requerido_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IOtros_Nombres_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Otros_Nombres_Requerido_MASCItem in Otros_Nombres_Requerido_MASCItems)
                    {



                        //Removal Request
                        if (Otros_Nombres_Requerido_MASCItem.Removed)
                        {
                            result = result && _IOtros_Nombres_Requerido_MASCApiConsumer.Delete(Otros_Nombres_Requerido_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Otros_Nombres_Requerido_MASCItem.Clave = 0;

                        var Otros_Nombres_Requerido_MASCData = new Otros_Nombres_Requerido_MASC
                        {
                            Requerido = MasterId
                            ,Clave = Otros_Nombres_Requerido_MASCItem.Clave
                            ,Descripcion = Otros_Nombres_Requerido_MASCItem.Descripcion

                        };

                        var resultId = Otros_Nombres_Requerido_MASCItem.Clave > 0
                           ? _IOtros_Nombres_Requerido_MASCApiConsumer.Update(Otros_Nombres_Requerido_MASCData,null,null).Resource
                           : _IOtros_Nombres_Requerido_MASCApiConsumer.Insert(Otros_Nombres_Requerido_MASCData,null,null).Resource;

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
        public bool CopyOtros_Domicilios_Requeridos_MASC(int MasterId, int referenceId, List<Otros_Domicilios_Requeridos_MASCGridModelPost> Otros_Domicilios_Requeridos_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IOtros_Domicilios_Requeridos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Otros_Domicilios_Requeridos_MASCData = _IOtros_Domicilios_Requeridos_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Otros_Domicilios_Requeridos_MASC.Requerido=" + referenceId,"").Resource;
                if (Otros_Domicilios_Requeridos_MASCData == null || Otros_Domicilios_Requeridos_MASCData.Otros_Domicilios_Requeridos_MASCs.Count == 0)
                    return true;

                var result = true;

                Otros_Domicilios_Requeridos_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varOtros_Domicilios_Requeridos_MASC in Otros_Domicilios_Requeridos_MASCData.Otros_Domicilios_Requeridos_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Otros_Domicilios_Requeridos_MASC Otros_Domicilios_Requeridos_MASC1 = varOtros_Domicilios_Requeridos_MASC;

                    if (Otros_Domicilios_Requeridos_MASCItems != null && Otros_Domicilios_Requeridos_MASCItems.Any(m => m.Clave == Otros_Domicilios_Requeridos_MASC1.Clave))
                    {
                        modelDataToChange = Otros_Domicilios_Requeridos_MASCItems.FirstOrDefault(m => m.Clave == Otros_Domicilios_Requeridos_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varOtros_Domicilios_Requeridos_MASC.Requerido = MasterId;
                    var insertId = _IOtros_Domicilios_Requeridos_MASCApiConsumer.Insert(varOtros_Domicilios_Requeridos_MASC,null,null).Resource;
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
        public ActionResult PostOtros_Domicilios_Requeridos_MASC(List<Otros_Domicilios_Requeridos_MASCGridModelPost> Otros_Domicilios_Requeridos_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyOtros_Domicilios_Requeridos_MASC(MasterId, referenceId, Otros_Domicilios_Requeridos_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Otros_Domicilios_Requeridos_MASCItems != null && Otros_Domicilios_Requeridos_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IOtros_Domicilios_Requeridos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Otros_Domicilios_Requeridos_MASCItem in Otros_Domicilios_Requeridos_MASCItems)
                    {











                        //Removal Request
                        if (Otros_Domicilios_Requeridos_MASCItem.Removed)
                        {
                            result = result && _IOtros_Domicilios_Requeridos_MASCApiConsumer.Delete(Otros_Domicilios_Requeridos_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Otros_Domicilios_Requeridos_MASCItem.Clave = 0;

                        var Otros_Domicilios_Requeridos_MASCData = new Otros_Domicilios_Requeridos_MASC
                        {
                            Requerido = MasterId
                            ,Clave = Otros_Domicilios_Requeridos_MASCItem.Clave
                            ,Estado = (Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Estado))
                            ,Municipio = (Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Municipio))
                            ,Poblacion = (Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Poblacion) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Poblacion))
                            ,Colonia = (Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_Requeridos_MASCItem.Colonia))
                            ,Codigo_Postal = Otros_Domicilios_Requeridos_MASCItem.Codigo_Postal
                            ,Calle = Otros_Domicilios_Requeridos_MASCItem.Calle
                            ,Entre_Calle = Otros_Domicilios_Requeridos_MASCItem.Entre_Calle
                            ,Y_Calle = Otros_Domicilios_Requeridos_MASCItem.Y_Calle
                            ,Numero_Exterior = Otros_Domicilios_Requeridos_MASCItem.Numero_Exterior

                        };

                        var resultId = Otros_Domicilios_Requeridos_MASCItem.Clave > 0
                           ? _IOtros_Domicilios_Requeridos_MASCApiConsumer.Update(Otros_Domicilios_Requeridos_MASCData,null,null).Resource
                           : _IOtros_Domicilios_Requeridos_MASCApiConsumer.Insert(Otros_Domicilios_Requeridos_MASCData,null,null).Resource;

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
        public ActionResult GetOtros_Domicilios_Requeridos_MASC_EstadoAll()
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
        public ActionResult GetOtros_Domicilios_Requeridos_MASC_MunicipioAll()
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
        public ActionResult GetOtros_Domicilios_Requeridos_MASC_ColoniaAll()
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
        public bool CopyAdicciones_Requerido_MASC(int MasterId, int referenceId, List<Adicciones_Requerido_MASCGridModelPost> Adicciones_Requerido_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IAdicciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Adicciones_Requerido_MASCData = _IAdicciones_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Adicciones_Requerido_MASC.Requerido=" + referenceId,"").Resource;
                if (Adicciones_Requerido_MASCData == null || Adicciones_Requerido_MASCData.Adicciones_Requerido_MASCs.Count == 0)
                    return true;

                var result = true;

                Adicciones_Requerido_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varAdicciones_Requerido_MASC in Adicciones_Requerido_MASCData.Adicciones_Requerido_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Adicciones_Requerido_MASC Adicciones_Requerido_MASC1 = varAdicciones_Requerido_MASC;

                    if (Adicciones_Requerido_MASCItems != null && Adicciones_Requerido_MASCItems.Any(m => m.Clave == Adicciones_Requerido_MASC1.Clave))
                    {
                        modelDataToChange = Adicciones_Requerido_MASCItems.FirstOrDefault(m => m.Clave == Adicciones_Requerido_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varAdicciones_Requerido_MASC.Requerido = MasterId;
                    var insertId = _IAdicciones_Requerido_MASCApiConsumer.Insert(varAdicciones_Requerido_MASC,null,null).Resource;
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
        public ActionResult PostAdicciones_Requerido_MASC(List<Adicciones_Requerido_MASCGridModelPost> Adicciones_Requerido_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyAdicciones_Requerido_MASC(MasterId, referenceId, Adicciones_Requerido_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Adicciones_Requerido_MASCItems != null && Adicciones_Requerido_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IAdicciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Adicciones_Requerido_MASCItem in Adicciones_Requerido_MASCItems)
                    {



                        //Removal Request
                        if (Adicciones_Requerido_MASCItem.Removed)
                        {
                            result = result && _IAdicciones_Requerido_MASCApiConsumer.Delete(Adicciones_Requerido_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Adicciones_Requerido_MASCItem.Clave = 0;

                        var Adicciones_Requerido_MASCData = new Adicciones_Requerido_MASC
                        {
                            Requerido = MasterId
                            ,Clave = Adicciones_Requerido_MASCItem.Clave
                            ,Descripcion = (Convert.ToInt32(Adicciones_Requerido_MASCItem.Descripcion) == 0 ? (Int32?)null : Convert.ToInt32(Adicciones_Requerido_MASCItem.Descripcion))

                        };

                        var resultId = Adicciones_Requerido_MASCItem.Clave > 0
                           ? _IAdicciones_Requerido_MASCApiConsumer.Update(Adicciones_Requerido_MASCData,null,null).Resource
                           : _IAdicciones_Requerido_MASCApiConsumer.Insert(Adicciones_Requerido_MASCData,null,null).Resource;

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
        public ActionResult GetAdicciones_Requerido_MASC_AdiccionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAdiccionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAdiccionesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Adicciones", "Descripcion");
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
        public bool CopyLugares_Frecuentes_Requerido_MASC(int MasterId, int referenceId, List<Lugares_Frecuentes_Requerido_MASCGridModelPost> Lugares_Frecuentes_Requerido_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ILugares_Frecuentes_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Lugares_Frecuentes_Requerido_MASCData = _ILugares_Frecuentes_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Lugares_Frecuentes_Requerido_MASC.Requerido=" + referenceId,"").Resource;
                if (Lugares_Frecuentes_Requerido_MASCData == null || Lugares_Frecuentes_Requerido_MASCData.Lugares_Frecuentes_Requerido_MASCs.Count == 0)
                    return true;

                var result = true;

                Lugares_Frecuentes_Requerido_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varLugares_Frecuentes_Requerido_MASC in Lugares_Frecuentes_Requerido_MASCData.Lugares_Frecuentes_Requerido_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Lugares_Frecuentes_Requerido_MASC Lugares_Frecuentes_Requerido_MASC1 = varLugares_Frecuentes_Requerido_MASC;

                    if (Lugares_Frecuentes_Requerido_MASCItems != null && Lugares_Frecuentes_Requerido_MASCItems.Any(m => m.Clave == Lugares_Frecuentes_Requerido_MASC1.Clave))
                    {
                        modelDataToChange = Lugares_Frecuentes_Requerido_MASCItems.FirstOrDefault(m => m.Clave == Lugares_Frecuentes_Requerido_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varLugares_Frecuentes_Requerido_MASC.Requerido = MasterId;
                    var insertId = _ILugares_Frecuentes_Requerido_MASCApiConsumer.Insert(varLugares_Frecuentes_Requerido_MASC,null,null).Resource;
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
        public ActionResult PostLugares_Frecuentes_Requerido_MASC(List<Lugares_Frecuentes_Requerido_MASCGridModelPost> Lugares_Frecuentes_Requerido_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyLugares_Frecuentes_Requerido_MASC(MasterId, referenceId, Lugares_Frecuentes_Requerido_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Lugares_Frecuentes_Requerido_MASCItems != null && Lugares_Frecuentes_Requerido_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ILugares_Frecuentes_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Lugares_Frecuentes_Requerido_MASCItem in Lugares_Frecuentes_Requerido_MASCItems)
                    {




                        //Removal Request
                        if (Lugares_Frecuentes_Requerido_MASCItem.Removed)
                        {
                            result = result && _ILugares_Frecuentes_Requerido_MASCApiConsumer.Delete(Lugares_Frecuentes_Requerido_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Lugares_Frecuentes_Requerido_MASCItem.Clave = 0;

                        var Lugares_Frecuentes_Requerido_MASCData = new Lugares_Frecuentes_Requerido_MASC
                        {
                            Requerido = MasterId
                            ,Clave = Lugares_Frecuentes_Requerido_MASCItem.Clave
                            ,Tipo_de_Lugar = (Convert.ToInt32(Lugares_Frecuentes_Requerido_MASCItem.Tipo_de_Lugar) == 0 ? (Int32?)null : Convert.ToInt32(Lugares_Frecuentes_Requerido_MASCItem.Tipo_de_Lugar))
                            ,Descripcion = Lugares_Frecuentes_Requerido_MASCItem.Descripcion

                        };

                        var resultId = Lugares_Frecuentes_Requerido_MASCItem.Clave > 0
                           ? _ILugares_Frecuentes_Requerido_MASCApiConsumer.Update(Lugares_Frecuentes_Requerido_MASCData,null,null).Resource
                           : _ILugares_Frecuentes_Requerido_MASCApiConsumer.Insert(Lugares_Frecuentes_Requerido_MASCData,null,null).Resource;

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
        public ActionResult GetLugares_Frecuentes_Requerido_MASC_LugaresAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugaresApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Lugares", "Descripcion");
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
        public bool CopyDatos_Personales_Adicionales_Requerido_MASC(int MasterId, int referenceId, List<Datos_Personales_Adicionales_Requerido_MASCGridModelPost> Datos_Personales_Adicionales_Requerido_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Datos_Personales_Adicionales_Requerido_MASCData = _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Datos_Personales_Adicionales_Requerido_MASC.Requerido=" + referenceId,"").Resource;
                if (Datos_Personales_Adicionales_Requerido_MASCData == null || Datos_Personales_Adicionales_Requerido_MASCData.Datos_Personales_Adicionales_Requerido_MASCs.Count == 0)
                    return true;

                var result = true;

                Datos_Personales_Adicionales_Requerido_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDatos_Personales_Adicionales_Requerido_MASC in Datos_Personales_Adicionales_Requerido_MASCData.Datos_Personales_Adicionales_Requerido_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Datos_Personales_Adicionales_Requerido_MASC Datos_Personales_Adicionales_Requerido_MASC1 = varDatos_Personales_Adicionales_Requerido_MASC;

                    if (Datos_Personales_Adicionales_Requerido_MASCItems != null && Datos_Personales_Adicionales_Requerido_MASCItems.Any(m => m.Clave == Datos_Personales_Adicionales_Requerido_MASC1.Clave))
                    {
                        modelDataToChange = Datos_Personales_Adicionales_Requerido_MASCItems.FirstOrDefault(m => m.Clave == Datos_Personales_Adicionales_Requerido_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varDatos_Personales_Adicionales_Requerido_MASC.Requerido = MasterId;
                    var insertId = _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.Insert(varDatos_Personales_Adicionales_Requerido_MASC,null,null).Resource;
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
        public ActionResult PostDatos_Personales_Adicionales_Requerido_MASC(List<Datos_Personales_Adicionales_Requerido_MASCGridModelPost> Datos_Personales_Adicionales_Requerido_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDatos_Personales_Adicionales_Requerido_MASC(MasterId, referenceId, Datos_Personales_Adicionales_Requerido_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Datos_Personales_Adicionales_Requerido_MASCItems != null && Datos_Personales_Adicionales_Requerido_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Datos_Personales_Adicionales_Requerido_MASCItem in Datos_Personales_Adicionales_Requerido_MASCItems)
                    {






                        //Removal Request
                        if (Datos_Personales_Adicionales_Requerido_MASCItem.Removed)
                        {
                            result = result && _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.Delete(Datos_Personales_Adicionales_Requerido_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Datos_Personales_Adicionales_Requerido_MASCItem.Clave = 0;

                        var Datos_Personales_Adicionales_Requerido_MASCData = new Datos_Personales_Adicionales_Requerido_MASC
                        {
                            Requerido = MasterId
                            ,Clave = Datos_Personales_Adicionales_Requerido_MASCItem.Clave
                            ,Correo_Electronico = Datos_Personales_Adicionales_Requerido_MASCItem.Correo_Electronico
                            ,Numero_Telefonico = Datos_Personales_Adicionales_Requerido_MASCItem.Numero_Telefonico
                            ,Redes_Sociales = (Convert.ToInt32(Datos_Personales_Adicionales_Requerido_MASCItem.Redes_Sociales) == 0 ? (Int32?)null : Convert.ToInt32(Datos_Personales_Adicionales_Requerido_MASCItem.Redes_Sociales))
                            ,Observaciones = Datos_Personales_Adicionales_Requerido_MASCItem.Observaciones

                        };

                        var resultId = Datos_Personales_Adicionales_Requerido_MASCItem.Clave > 0
                           ? _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.Update(Datos_Personales_Adicionales_Requerido_MASCData,null,null).Resource
                           : _IDatos_Personales_Adicionales_Requerido_MASCApiConsumer.Insert(Datos_Personales_Adicionales_Requerido_MASCData,null,null).Resource;

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
        public ActionResult GetDatos_Personales_Adicionales_Requerido_MASC_Redes_SocialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRedes_SocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRedes_SocialesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Redes_Sociales", "Descripcion");
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
        public bool CopyOtras_Identificaciones_Requerido_MASC(int MasterId, int referenceId, List<Otras_Identificaciones_Requerido_MASCGridModelPost> Otras_Identificaciones_Requerido_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IOtras_Identificaciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Otras_Identificaciones_Requerido_MASCData = _IOtras_Identificaciones_Requerido_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Otras_Identificaciones_Requerido_MASC.Requerido=" + referenceId,"").Resource;
                if (Otras_Identificaciones_Requerido_MASCData == null || Otras_Identificaciones_Requerido_MASCData.Otras_Identificaciones_Requerido_MASCs.Count == 0)
                    return true;

                var result = true;

                Otras_Identificaciones_Requerido_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varOtras_Identificaciones_Requerido_MASC in Otras_Identificaciones_Requerido_MASCData.Otras_Identificaciones_Requerido_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Otras_Identificaciones_Requerido_MASC Otras_Identificaciones_Requerido_MASC1 = varOtras_Identificaciones_Requerido_MASC;

                    if (Otras_Identificaciones_Requerido_MASCItems != null && Otras_Identificaciones_Requerido_MASCItems.Any(m => m.Clave == Otras_Identificaciones_Requerido_MASC1.Clave))
                    {
                        modelDataToChange = Otras_Identificaciones_Requerido_MASCItems.FirstOrDefault(m => m.Clave == Otras_Identificaciones_Requerido_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varOtras_Identificaciones_Requerido_MASC.Requerido = MasterId;
                    var insertId = _IOtras_Identificaciones_Requerido_MASCApiConsumer.Insert(varOtras_Identificaciones_Requerido_MASC,null,null).Resource;
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
        public ActionResult PostOtras_Identificaciones_Requerido_MASC(List<Otras_Identificaciones_Requerido_MASCGridModelPost> Otras_Identificaciones_Requerido_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyOtras_Identificaciones_Requerido_MASC(MasterId, referenceId, Otras_Identificaciones_Requerido_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Otras_Identificaciones_Requerido_MASCItems != null && Otras_Identificaciones_Requerido_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IOtras_Identificaciones_Requerido_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Otras_Identificaciones_Requerido_MASCItem in Otras_Identificaciones_Requerido_MASCItems)
                    {




                        //Removal Request
                        if (Otras_Identificaciones_Requerido_MASCItem.Removed)
                        {
                            result = result && _IOtras_Identificaciones_Requerido_MASCApiConsumer.Delete(Otras_Identificaciones_Requerido_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Otras_Identificaciones_Requerido_MASCItem.Clave = 0;

                        var Otras_Identificaciones_Requerido_MASCData = new Otras_Identificaciones_Requerido_MASC
                        {
                            Requerido = MasterId
                            ,Clave = Otras_Identificaciones_Requerido_MASCItem.Clave
                            ,Tipo_de_Identificacion = (Convert.ToInt32(Otras_Identificaciones_Requerido_MASCItem.Tipo_de_Identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Otras_Identificaciones_Requerido_MASCItem.Tipo_de_Identificacion))
                            ,Descripcion = Otras_Identificaciones_Requerido_MASCItem.Descripcion

                        };

                        var resultId = Otras_Identificaciones_Requerido_MASCItem.Clave > 0
                           ? _IOtras_Identificaciones_Requerido_MASCApiConsumer.Update(Otras_Identificaciones_Requerido_MASCData,null,null).Resource
                           : _IOtras_Identificaciones_Requerido_MASCApiConsumer.Insert(Otras_Identificaciones_Requerido_MASCData,null,null).Resource;

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
        public ActionResult GetOtras_Identificaciones_Requerido_MASC_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        /// <summary>
        /// Write Element Array of Detalle_de_Solicitud_Requerido script
        /// </summary>
        /// <param name="oDetalle_de_Solicitud_RequeridoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Solicitud_RequeridoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Solicitud_RequeridoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Solicitud_RequeridoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Solicitud_RequeridoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Solicitud_RequeridoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Solicitud_RequeridoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Solicitud_RequeridoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Requerido.js")))
            {
                strDetalle_de_Solicitud_RequeridoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Solicitud_Requerido element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Solicitud_RequeridoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Solicitud_RequeridoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Solicitud_RequeridoScript.Substring(indexOfArray, strDetalle_de_Solicitud_RequeridoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Solicitud_RequeridoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Solicitud_RequeridoScript.Substring(indexOfArrayHistory, strDetalle_de_Solicitud_RequeridoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Solicitud_RequeridoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Solicitud_RequeridoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Solicitud_RequeridoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Solicitud_RequeridoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Requerido.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Requerido.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Requerido.js")))
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
        public ActionResult Detalle_de_Solicitud_RequeridoPropertyBag()
        {
            return PartialView("Detalle_de_Solicitud_RequeridoPropertyBag", "Detalle_de_Solicitud_Requerido");
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
        public ActionResult AddOtros_Nombres_Requerido_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Otros_Nombres_Requerido_MASC/AddOtros_Nombres_Requerido_MASC");
        }

        [HttpGet]
        public ActionResult AddOtros_Domicilios_Requeridos_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Otros_Domicilios_Requeridos_MASC/AddOtros_Domicilios_Requeridos_MASC");
        }

        [HttpGet]
        public ActionResult AddAdicciones_Requerido_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Adicciones_Requerido_MASC/AddAdicciones_Requerido_MASC");
        }

        [HttpGet]
        public ActionResult AddLugares_Frecuentes_Requerido_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Lugares_Frecuentes_Requerido_MASC/AddLugares_Frecuentes_Requerido_MASC");
        }

        [HttpGet]
        public ActionResult AddDatos_Personales_Adicionales_Requerido_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Datos_Personales_Adicionales_Requerido_MASC/AddDatos_Personales_Adicionales_Requerido_MASC");
        }

        [HttpGet]
        public ActionResult AddOtras_Identificaciones_Requerido_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Otras_Identificaciones_Requerido_MASC/AddOtras_Identificaciones_Requerido_MASC");
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
                var whereClauseFormat = "Object = 45043 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Solicitud_Requerido.Clave= " + RecordId;
                            var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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
										  
			string[] arrayColumnsVisible = null;

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitud_RequeridoPropertyMapper());
			
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
                    (Detalle_de_Solicitud_RequeridoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Solicitud_RequeridoPropertyMapper oDetalle_de_Solicitud_RequeridoPropertyMapper = new Detalle_de_Solicitud_RequeridoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitud_RequeridoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Requeridos == null)
                result.Detalle_de_Solicitud_Requeridos = new List<Detalle_de_Solicitud_Requerido>();

            var data = result.Detalle_de_Solicitud_Requeridos.Select(m => new Detalle_de_Solicitud_RequeridoGridModel
            {
                Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Numero_de_Folio") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,A_Quien_Sea_Responsable = m.A_Quien_Sea_Responsable
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Apodo = m.Apodo
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_de_Domicilio_Requerido = m.Referencia_de_Domicilio_Requerido
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
			,Inimputable = m.Inimputable
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Se_Presenta_con_Detenido = m.Se_Presenta_con_Detenido
			,Folio_Registro_Nacional_de_Detenciones = m.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                        ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(m.Municipio_de_Detencion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Detencion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
			,Suspension_Condicional = m.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
			,Lugar_donde_se_Encuentra_Detenido = m.Lugar_donde_se_Encuentra_Detenido
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No__de_Hijos = m.No__de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
			,Viene_en_Estado_de_Ebriedad = m.Viene_en_Estado_de_Ebriedad
			,Bajo_el_Efecto_de_una_Droga = m.Bajo_el_Efecto_de_una_Droga
			,Nombre_de_Droga = m.Nombre_de_Droga
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_de_Tutor = m.Nombre_de_Tutor
			,Apellido_Paterno_Tutor = m.Apellido_Paterno_Tutor
			,Apellido_Materno_Tutor = m.Apellido_Materno_Tutor
			,Nombre_Completo_Tutor = m.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Poblacion_tutorNombre = CultureHelper.GetTraduction(m.Poblacion_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_tutor_Colonia.Nombre
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Referencia = m.Referencia
			,Latitud_tutor = m.Latitud_tutor
			,Longitud_tutor = m.Longitud_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_Tutor = m.Originario_de_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Nariz_baseDescripcion = CultureHelper.GetTraduction(m.Nariz_base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_base_Nariz_Base.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45043, arrayColumnsVisible), "Detalle_de_Solicitud_RequeridoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45043, arrayColumnsVisible), "Detalle_de_Solicitud_RequeridoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45043, arrayColumnsVisible), "Detalle_de_Solicitud_RequeridoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitud_RequeridoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Solicitud_RequeridoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Solicitud_RequeridoPropertyMapper oDetalle_de_Solicitud_RequeridoPropertyMapper = new Detalle_de_Solicitud_RequeridoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitud_RequeridoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Requeridos == null)
                result.Detalle_de_Solicitud_Requeridos = new List<Detalle_de_Solicitud_Requerido>();

            var data = result.Detalle_de_Solicitud_Requeridos.Select(m => new Detalle_de_Solicitud_RequeridoGridModel
            {
                Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Numero_de_Folio") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,A_Quien_Sea_Responsable = m.A_Quien_Sea_Responsable
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Apodo = m.Apodo
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_de_Domicilio_Requerido = m.Referencia_de_Domicilio_Requerido
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
			,Inimputable = m.Inimputable
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Se_Presenta_con_Detenido = m.Se_Presenta_con_Detenido
			,Folio_Registro_Nacional_de_Detenciones = m.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                        ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(m.Municipio_de_Detencion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Detencion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
			,Suspension_Condicional = m.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
			,Lugar_donde_se_Encuentra_Detenido = m.Lugar_donde_se_Encuentra_Detenido
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No__de_Hijos = m.No__de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
			,Viene_en_Estado_de_Ebriedad = m.Viene_en_Estado_de_Ebriedad
			,Bajo_el_Efecto_de_una_Droga = m.Bajo_el_Efecto_de_una_Droga
			,Nombre_de_Droga = m.Nombre_de_Droga
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_de_Tutor = m.Nombre_de_Tutor
			,Apellido_Paterno_Tutor = m.Apellido_Paterno_Tutor
			,Apellido_Materno_Tutor = m.Apellido_Materno_Tutor
			,Nombre_Completo_Tutor = m.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Poblacion_tutorNombre = CultureHelper.GetTraduction(m.Poblacion_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_tutor_Colonia.Nombre
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Referencia = m.Referencia
			,Latitud_tutor = m.Latitud_tutor
			,Longitud_tutor = m.Longitud_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_Tutor = m.Originario_de_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Nariz_baseDescripcion = CultureHelper.GetTraduction(m.Nariz_base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_base_Nariz_Base.Descripcion
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
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
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Solicitud_Requerido_Datos_GeneralesModel varDetalle_de_Solicitud_Requerido)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Solicitud_Requerido_Datos_GeneralesInfo = new Detalle_de_Solicitud_Requerido_Datos_Generales
                {
                    Clave = varDetalle_de_Solicitud_Requerido.Clave
                                            ,idRegistroAT = varDetalle_de_Solicitud_Requerido.idRegistroAT
                        ,idRegistroUI = varDetalle_de_Solicitud_Requerido.idRegistroUI
                        ,Solicitud = varDetalle_de_Solicitud_Requerido.Solicitud
                        ,A_Quien_Sea_Responsable = varDetalle_de_Solicitud_Requerido.A_Quien_Sea_Responsable
                        ,Nombre = varDetalle_de_Solicitud_Requerido.Nombre
                        ,Apellido_Paterno = varDetalle_de_Solicitud_Requerido.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Solicitud_Requerido.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Solicitud_Requerido.Nombre_Completo
                        ,Alias = varDetalle_de_Solicitud_Requerido.Alias
                        ,Apodo = varDetalle_de_Solicitud_Requerido.Apodo
                        ,CURP = varDetalle_de_Solicitud_Requerido.CURP
                        ,RFC = varDetalle_de_Solicitud_Requerido.RFC
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Solicitud_Requerido.Edad
                        ,Sexo = varDetalle_de_Solicitud_Requerido.Sexo
                        ,Estado_Civil = varDetalle_de_Solicitud_Requerido.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Solicitud_Requerido.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Solicitud_Requerido.Numero_de_Identificacion
                        ,Nacionalidad = varDetalle_de_Solicitud_Requerido.Nacionalidad
                        ,Escolaridad = varDetalle_de_Solicitud_Requerido.Escolaridad
                        ,Ocupacion = varDetalle_de_Solicitud_Requerido.Ocupacion
                        ,Pais = varDetalle_de_Solicitud_Requerido.Pais
                        ,Estado = varDetalle_de_Solicitud_Requerido.Estado
                        ,Municipio = varDetalle_de_Solicitud_Requerido.Municipio
                        ,Codigo_Postal = varDetalle_de_Solicitud_Requerido.Codigo_Postal
                        ,Poblacion = varDetalle_de_Solicitud_Requerido.Poblacion
                        ,Colonia = varDetalle_de_Solicitud_Requerido.Colonia
                        ,Calle = varDetalle_de_Solicitud_Requerido.Calle
                        ,Numero_Exterior = varDetalle_de_Solicitud_Requerido.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Solicitud_Requerido.Numero_Interior
                        ,Entre_Calle = varDetalle_de_Solicitud_Requerido.Entre_Calle
                        ,Y_Calle = varDetalle_de_Solicitud_Requerido.Y_Calle
                        ,Referencia_de_Domicilio_Requerido = varDetalle_de_Solicitud_Requerido.Referencia_de_Domicilio_Requerido
                        ,Latitud = varDetalle_de_Solicitud_Requerido.Latitud
                        ,Longitud = varDetalle_de_Solicitud_Requerido.Longitud
                        ,Telefono = varDetalle_de_Solicitud_Requerido.Telefono
                        ,Extencion = varDetalle_de_Solicitud_Requerido.Extencion
                        ,Celular = varDetalle_de_Solicitud_Requerido.Celular
                        ,Correo_Electronico = varDetalle_de_Solicitud_Requerido.Correo_Electronico
                        ,Pais_de_Origen = varDetalle_de_Solicitud_Requerido.Pais_de_Origen
                        ,Originario_de = varDetalle_de_Solicitud_Requerido.Originario_de
                        ,Estado_de_Nacimiento = varDetalle_de_Solicitud_Requerido.Estado_de_Nacimiento
                        ,Municipio_de_Nacimiento = varDetalle_de_Solicitud_Requerido.Municipio_de_Nacimiento
                        ,Inimputable = varDetalle_de_Solicitud_Requerido.Inimputable
                        ,Tipo_de_Inimputabilidad = varDetalle_de_Solicitud_Requerido.Tipo_de_Inimputabilidad
                        ,Se_Presenta_con_Detenido = varDetalle_de_Solicitud_Requerido.Se_Presenta_con_Detenido
                        ,Folio_Registro_Nacional_de_Detenciones = varDetalle_de_Solicitud_Requerido.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Detencion)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Municipio_de_Detencion = varDetalle_de_Solicitud_Requerido.Municipio_de_Detencion
                        ,Corporacion = varDetalle_de_Solicitud_Requerido.Corporacion
                        ,Suspension_Condicional = varDetalle_de_Solicitud_Requerido.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Suspension_Condicional, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Lugar_donde_se_Encuentra_Detenido = varDetalle_de_Solicitud_Requerido.Lugar_donde_se_Encuentra_Detenido
                        ,Etnia = varDetalle_de_Solicitud_Requerido.Etnia
                        ,No__de_Hijos = varDetalle_de_Solicitud_Requerido.No__de_Hijos
                        ,Religion = varDetalle_de_Solicitud_Requerido.Religion
                        ,Servicio_Medico = varDetalle_de_Solicitud_Requerido.Servicio_Medico
                        ,Especialidad = varDetalle_de_Solicitud_Requerido.Especialidad
                        ,Estudios_Superiores = varDetalle_de_Solicitud_Requerido.Estudios_Superiores
                        ,Idioma = varDetalle_de_Solicitud_Requerido.Idioma
                        ,Calidad_Migratoria = varDetalle_de_Solicitud_Requerido.Calidad_Migratoria
                        ,Dialecto = varDetalle_de_Solicitud_Requerido.Dialecto
                        ,Viene_en_Estado_de_Ebriedad = varDetalle_de_Solicitud_Requerido.Viene_en_Estado_de_Ebriedad
                        ,Bajo_el_Efecto_de_una_Droga = varDetalle_de_Solicitud_Requerido.Bajo_el_Efecto_de_una_Droga
                        ,Nombre_de_Droga = varDetalle_de_Solicitud_Requerido.Nombre_de_Droga
                        ,Discapacidad_Mental = varDetalle_de_Solicitud_Requerido.Discapacidad_Mental
                        ,Discapacidad_Fisica = varDetalle_de_Solicitud_Requerido.Discapacidad_Fisica
                        ,Discapacidad_Sensorial = varDetalle_de_Solicitud_Requerido.Discapacidad_Sensorial
                        ,Discapacidad_Psicosocial = varDetalle_de_Solicitud_Requerido.Discapacidad_Psicosocial
                    
                };

                result = _IDetalle_de_Solicitud_RequeridoApiConsumer.Update_Datos_Generales(Detalle_de_Solicitud_Requerido_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_RequeridoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Otros_Nombres_Requerido_MASC;
                var Otros_Nombres_Requerido_MASCData = GetOtros_Nombres_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Nombres_Requerido_MASC);
                int RowCount_Otros_Domicilios_Requeridos_MASC;
                var Otros_Domicilios_Requeridos_MASCData = GetOtros_Domicilios_Requeridos_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Requeridos_MASC);
                int RowCount_Adicciones_Requerido_MASC;
                var Adicciones_Requerido_MASCData = GetAdicciones_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_Requerido_MASC);
                int RowCount_Lugares_Frecuentes_Requerido_MASC;
                var Lugares_Frecuentes_Requerido_MASCData = GetLugares_Frecuentes_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Requerido_MASC);
                int RowCount_Datos_Personales_Adicionales_Requerido_MASC;
                var Datos_Personales_Adicionales_Requerido_MASCData = GetDatos_Personales_Adicionales_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Requerido_MASC);
                int RowCount_Otras_Identificaciones_Requerido_MASC;
                var Otras_Identificaciones_Requerido_MASCData = GetOtras_Identificaciones_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Requerido_MASC);

                var result = new Detalle_de_Solicitud_Requerido_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,Solicitud = m.Solicitud
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Numero_de_Folio") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,A_Quien_Sea_Responsable = m.A_Quien_Sea_Responsable
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Apodo = m.Apodo
			,CURP = m.CURP
			,RFC = m.RFC
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
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
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_de_Domicilio_Requerido = m.Referencia_de_Domicilio_Requerido
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Estado_de_Nacimiento = m.Estado_de_Nacimiento
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_Nacimiento = m.Municipio_de_Nacimiento
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
			,Inimputable = m.Inimputable
                        ,Tipo_de_Inimputabilidad = m.Tipo_de_Inimputabilidad
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Se_Presenta_con_Detenido = m.Se_Presenta_con_Detenido
			,Folio_Registro_Nacional_de_Detenciones = m.Folio_Registro_Nacional_de_Detenciones
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                        ,Municipio_de_Detencion = m.Municipio_de_Detencion
                        ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(m.Municipio_de_Detencion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Detencion_Municipio.Nombre
                        ,Corporacion = m.Corporacion
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
			,Suspension_Condicional = m.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))
			,Lugar_donde_se_Encuentra_Detenido = m.Lugar_donde_se_Encuentra_Detenido
                        ,Etnia = m.Etnia
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No__de_Hijos = m.No__de_Hijos
                        ,Religion = m.Religion
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_Medico = m.Servicio_Medico
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,Especialidad = m.Especialidad
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_Superiores = m.Estudios_Superiores
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
                        ,Idioma = m.Idioma
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_Migratoria = m.Calidad_Migratoria
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,Dialecto = m.Dialecto
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
			,Viene_en_Estado_de_Ebriedad = m.Viene_en_Estado_de_Ebriedad
			,Bajo_el_Efecto_de_una_Droga = m.Bajo_el_Efecto_de_una_Droga
			,Nombre_de_Droga = m.Nombre_de_Droga
                        ,Discapacidad_Mental = m.Discapacidad_Mental
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_Fisica = m.Discapacidad_Fisica
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_Sensorial = m.Discapacidad_Sensorial
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_Psicosocial = m.Discapacidad_Psicosocial
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Otros_Nombres = Otros_Nombres_Requerido_MASCData
                    ,Otros_Domicilios = Otros_Domicilios_Requeridos_MASCData
                    ,Adicciones_Probable_Responsable = Adicciones_Requerido_MASCData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_Requerido_MASCData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_Requerido_MASCData
                    ,Otras_Identificaciones = Otras_Identificaciones_Requerido_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Tutor(Detalle_de_Solicitud_Requerido_Datos_del_TutorModel varDetalle_de_Solicitud_Requerido)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Solicitud_Requerido_Datos_del_TutorInfo = new Detalle_de_Solicitud_Requerido_Datos_del_Tutor
                {
                    Clave = varDetalle_de_Solicitud_Requerido.Clave
                                            ,Nombre_de_Tutor = varDetalle_de_Solicitud_Requerido.Nombre_de_Tutor
                        ,Apellido_Paterno_Tutor = varDetalle_de_Solicitud_Requerido.Apellido_Paterno_Tutor
                        ,Apellido_Materno_Tutor = varDetalle_de_Solicitud_Requerido.Apellido_Materno_Tutor
                        ,Nombre_Completo_Tutor = varDetalle_de_Solicitud_Requerido.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Requerido.Fecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_tutor = varDetalle_de_Solicitud_Requerido.Edad_tutor
                        ,Sexo_tutor = varDetalle_de_Solicitud_Requerido.Sexo_tutor
                        ,Estado_Civil_tutor = varDetalle_de_Solicitud_Requerido.Estado_Civil_tutor
                        ,Tipo_de_Identificacion_tutor = varDetalle_de_Solicitud_Requerido.Tipo_de_Identificacion_tutor
                        ,Numero_de_Identificacion_tutor = varDetalle_de_Solicitud_Requerido.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutor = varDetalle_de_Solicitud_Requerido.Nacionalidad_tutor
                        ,Escolaridad_tutor = varDetalle_de_Solicitud_Requerido.Escolaridad_tutor
                        ,Ocupacion_tutor = varDetalle_de_Solicitud_Requerido.Ocupacion_tutor
                        ,Pais_tutor = varDetalle_de_Solicitud_Requerido.Pais_tutor
                        ,Estado_tutor = varDetalle_de_Solicitud_Requerido.Estado_tutor
                        ,Municipio_tutor = varDetalle_de_Solicitud_Requerido.Municipio_tutor
                        ,Poblacion_tutor = varDetalle_de_Solicitud_Requerido.Poblacion_tutor
                        ,Colonia_tutor = varDetalle_de_Solicitud_Requerido.Colonia_tutor
                        ,Codigo_Postal_tutor = varDetalle_de_Solicitud_Requerido.Codigo_Postal_tutor
                        ,Calle_tutor = varDetalle_de_Solicitud_Requerido.Calle_tutor
                        ,Numero_Exterior_tutor = varDetalle_de_Solicitud_Requerido.Numero_Exterior_tutor
                        ,Numero_Interior_tutor = varDetalle_de_Solicitud_Requerido.Numero_Interior_tutor
                        ,Referencia = varDetalle_de_Solicitud_Requerido.Referencia
                        ,Latitud_tutor = varDetalle_de_Solicitud_Requerido.Latitud_tutor
                        ,Longitud_tutor = varDetalle_de_Solicitud_Requerido.Longitud_tutor
                        ,Extension_tutor = varDetalle_de_Solicitud_Requerido.Extension_tutor
                        ,Celular_tutor = varDetalle_de_Solicitud_Requerido.Celular_tutor
                        ,Correo_Electronico_tutor = varDetalle_de_Solicitud_Requerido.Correo_Electronico_tutor
                        ,Pais_de_Origen_Tutor = varDetalle_de_Solicitud_Requerido.Pais_de_Origen_Tutor
                        ,Originario_de_Tutor = varDetalle_de_Solicitud_Requerido.Originario_de_Tutor
                        ,CURP_Tutor = varDetalle_de_Solicitud_Requerido.CURP_Tutor
                        ,RFC_Tutor = varDetalle_de_Solicitud_Requerido.RFC_Tutor
                    
                };

                result = _IDetalle_de_Solicitud_RequeridoApiConsumer.Update_Datos_del_Tutor(Detalle_de_Solicitud_Requerido_Datos_del_TutorInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Tutor(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_RequeridoApiConsumer.Get_Datos_del_Tutor(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Otros_Nombres_Requerido_MASC;
                var Otros_Nombres_Requerido_MASCData = GetOtros_Nombres_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Nombres_Requerido_MASC);
                int RowCount_Otros_Domicilios_Requeridos_MASC;
                var Otros_Domicilios_Requeridos_MASCData = GetOtros_Domicilios_Requeridos_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Requeridos_MASC);
                int RowCount_Adicciones_Requerido_MASC;
                var Adicciones_Requerido_MASCData = GetAdicciones_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_Requerido_MASC);
                int RowCount_Lugares_Frecuentes_Requerido_MASC;
                var Lugares_Frecuentes_Requerido_MASCData = GetLugares_Frecuentes_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Requerido_MASC);
                int RowCount_Datos_Personales_Adicionales_Requerido_MASC;
                var Datos_Personales_Adicionales_Requerido_MASCData = GetDatos_Personales_Adicionales_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Requerido_MASC);
                int RowCount_Otras_Identificaciones_Requerido_MASC;
                var Otras_Identificaciones_Requerido_MASCData = GetOtras_Identificaciones_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Requerido_MASC);

                var result = new Detalle_de_Solicitud_Requerido_Datos_del_TutorModel
                {
                    Clave = m.Clave
			,Nombre_de_Tutor = m.Nombre_de_Tutor
			,Apellido_Paterno_Tutor = m.Apellido_Paterno_Tutor
			,Apellido_Materno_Tutor = m.Apellido_Materno_Tutor
			,Nombre_Completo_Tutor = m.Nombre_Completo_Tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutor = m.Sexo_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutor = m.Estado_Civil_tutor
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutor = m.Tipo_de_Identificacion_tutor
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutor = m.Nacionalidad_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutor = m.Escolaridad_tutor
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutor = m.Ocupacion_tutor
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutor = m.Pais_tutor
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutor = m.Estado_tutor
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutor = m.Municipio_tutor
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Poblacion_tutor = m.Poblacion_tutor
                        ,Poblacion_tutorNombre = CultureHelper.GetTraduction(m.Poblacion_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_tutor_Colonia.Nombre
                        ,Colonia_tutor = m.Colonia_tutor
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Referencia = m.Referencia
			,Latitud_tutor = m.Latitud_tutor
			,Longitud_tutor = m.Longitud_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_Tutor = m.Pais_de_Origen_Tutor
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_Tutor = m.Originario_de_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor

                    
                };
				var resultData = new
                {
                    data = result
                    ,Otros_Nombres = Otros_Nombres_Requerido_MASCData
                    ,Otros_Domicilios = Otros_Domicilios_Requeridos_MASCData
                    ,Adicciones_Probable_Responsable = Adicciones_Requerido_MASCData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_Requerido_MASCData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_Requerido_MASCData
                    ,Otras_Identificaciones = Otras_Identificaciones_Requerido_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_Media_Filiacion(Detalle_de_Solicitud_Requerido_Datos_de_Media_FiliacionModel varDetalle_de_Solicitud_Requerido)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Solicitud_Requerido.Imagen_TatuajeRemoveAttachment != 0 && varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile == null)
                    {
                        varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje = 0;
                    }

                    if (varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Solicitud_Requerido.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Solicitud_Requerido_Datos_de_Media_FiliacionInfo = new Detalle_de_Solicitud_Requerido_Datos_de_Media_Filiacion
                {
                    Clave = varDetalle_de_Solicitud_Requerido.Clave
                                            ,Padecimiento_de_Enfermedad = varDetalle_de_Solicitud_Requerido.Padecimiento_de_Enfermedad
                        ,Cejas = varDetalle_de_Solicitud_Requerido.Cejas
                        ,Tamano_de_Cejas = varDetalle_de_Solicitud_Requerido.Tamano_de_Cejas
                        ,Anteojos = varDetalle_de_Solicitud_Requerido.Anteojos
                        ,Forma_de_Nariz = varDetalle_de_Solicitud_Requerido.Forma_de_Nariz
                        ,Nariz_base = varDetalle_de_Solicitud_Requerido.Nariz_base
                        ,Grosor_de_Labios = varDetalle_de_Solicitud_Requerido.Grosor_de_Labios
                        ,Forma_de_Menton = varDetalle_de_Solicitud_Requerido.Forma_de_Menton
                        ,Senas_Particulares = varDetalle_de_Solicitud_Requerido.Senas_Particulares
                        ,Imagen_Tatuaje = (varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje.HasValue && varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Solicitud_Requerido.Imagen_Tatuaje.Value)) : null

                        ,Otras_Senas_Particulares = varDetalle_de_Solicitud_Requerido.Otras_Senas_Particulares
                        ,Imputado_Recluido = varDetalle_de_Solicitud_Requerido.Imputado_Recluido
                    
                };

                result = _IDetalle_de_Solicitud_RequeridoApiConsumer.Update_Datos_de_Media_Filiacion(Detalle_de_Solicitud_Requerido_Datos_de_Media_FiliacionInfo).Resource.ToString();
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
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_RequeridoApiConsumer.Get_Datos_de_Media_Filiacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Otros_Nombres_Requerido_MASC;
                var Otros_Nombres_Requerido_MASCData = GetOtros_Nombres_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Nombres_Requerido_MASC);
                int RowCount_Otros_Domicilios_Requeridos_MASC;
                var Otros_Domicilios_Requeridos_MASCData = GetOtros_Domicilios_Requeridos_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Requeridos_MASC);
                int RowCount_Adicciones_Requerido_MASC;
                var Adicciones_Requerido_MASCData = GetAdicciones_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_Requerido_MASC);
                int RowCount_Lugares_Frecuentes_Requerido_MASC;
                var Lugares_Frecuentes_Requerido_MASCData = GetLugares_Frecuentes_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Requerido_MASC);
                int RowCount_Datos_Personales_Adicionales_Requerido_MASC;
                var Datos_Personales_Adicionales_Requerido_MASCData = GetDatos_Personales_Adicionales_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Requerido_MASC);
                int RowCount_Otras_Identificaciones_Requerido_MASC;
                var Otras_Identificaciones_Requerido_MASCData = GetOtras_Identificaciones_Requerido_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Requerido_MASC);

                var result = new Detalle_de_Solicitud_Requerido_Datos_de_Media_FiliacionModel
                {
                    Clave = m.Clave
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Cejas = m.Cejas
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Tamano_de_Cejas = m.Tamano_de_Cejas
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Anteojos = m.Anteojos
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_Nariz = m.Forma_de_Nariz
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Nariz_base = m.Nariz_base
                        ,Nariz_baseDescripcion = CultureHelper.GetTraduction(m.Nariz_base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_base_Nariz_Base.Descripcion
                        ,Grosor_de_Labios = m.Grosor_de_Labios
                        ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(m.Grosor_de_Labios_Grosor_de_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                        ,Forma_de_Menton = m.Forma_de_Menton
                        ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(m.Forma_de_Menton_Forma_de_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Menton_Forma_de_Menton.Descripcion
                        ,Senas_Particulares = m.Senas_Particulares
                        ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(m.Senas_Particulares_Senas_Particulares.Clave.ToString(), "Descripcion") ?? (string)m.Senas_Particulares_Senas_Particulares.Descripcion
			,Imagen_Tatuaje = m.Imagen_Tatuaje
			,Otras_Senas_Particulares = m.Otras_Senas_Particulares
			,Imputado_Recluido = m.Imputado_Recluido

                    
                };
				var resultData = new
                {
                    data = result
                    ,Otros_Nombres = Otros_Nombres_Requerido_MASCData
                    ,Otros_Domicilios = Otros_Domicilios_Requeridos_MASCData
                    ,Adicciones_Probable_Responsable = Adicciones_Requerido_MASCData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_Requerido_MASCData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_Requerido_MASCData
                    ,Otras_Identificaciones = Otras_Identificaciones_Requerido_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

