using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Delito;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Formato_de_Denuncia;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Agravantes_del_Delito;

using Spartane.Core.Domain.Agravantes;

using Spartane.Core.Domain.Circunstancias_del_Delito;

using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;

using Spartane.Core.Domain.Circunstancia_del_Delito;
using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using Spartane.Core.Domain.Concurso;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Motivo_de_No_Canalizacion;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Elemento_Robado;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Especifica_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;
using Spartane.Core.Domain.Zona_de_Robo;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Procedencia_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Robo;
using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;
using Spartane.Core.Domain.Tipo_de_Carretera;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Core.Domain.Circunstancia_Defuncion;
using Spartane.Core.Domain.Consecuencia_Defuncion;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Detalle_de_Persona_Moral;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Delito;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Formato_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Delitos_Violencia_Genero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Delito;
using Spartane.Web.Areas.WebApiConsumer.Titulo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Agravantes_del_Delito;

using Spartane.Web.Areas.WebApiConsumer.Agravantes;

using Spartane.Web.Areas.WebApiConsumer.Circunstancias_del_Delito;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Lugar_del_Robo;

using Spartane.Web.Areas.WebApiConsumer.Circunstancia_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;
using Spartane.Web.Areas.WebApiConsumer.Elementos_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Clasificacion_en_Orden_de_Resultado;
using Spartane.Web.Areas.WebApiConsumer.Concurso;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_No_Canalizacion;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Elemento_Robado;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Especifica_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Lugar_del_Robo;
using Spartane.Web.Areas.WebApiConsumer.Zona_de_Robo;
using Spartane.Web.Areas.WebApiConsumer.Aseguradora_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Robo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Lugar_del_Robo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Carretera;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;

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
    public class Detalle_de_DelitoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_DelitoService service = null;
        private IDetalle_de_DelitoApiConsumer _IDetalle_de_DelitoApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IFormato_de_DenunciaApiConsumer _IFormato_de_DenunciaApiConsumer;
        private IDelitos_Violencia_GeneroApiConsumer _IDelitos_Violencia_GeneroApiConsumer;
        private ITipo_DelitoApiConsumer _ITipo_DelitoApiConsumer;
        private ITitulo_del_DelitoApiConsumer _ITitulo_del_DelitoApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private IAgravantes_del_DelitoApiConsumer _IAgravantes_del_DelitoApiConsumer;

        private IAgravantesApiConsumer _IAgravantesApiConsumer;

        private ICircunstancias_del_DelitoApiConsumer _ICircunstancias_del_DelitoApiConsumer;

        private ITipo_de_Lugar_del_RoboApiConsumer _ITipo_de_Lugar_del_RoboApiConsumer;

        private ICircunstancia_del_DelitoApiConsumer _ICircunstancia_del_DelitoApiConsumer;
        private IForma_Comision_DelitoApiConsumer _IForma_Comision_DelitoApiConsumer;
        private IForma_Accion_DelitoApiConsumer _IForma_Accion_DelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;
        private IElementos_Comision_DelitoApiConsumer _IElementos_Comision_DelitoApiConsumer;
        private IClasificacion_en_Orden_de_ResultadoApiConsumer _IClasificacion_en_Orden_de_ResultadoApiConsumer;
        private IConcursoApiConsumer _IConcursoApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private IMotivo_de_No_CanalizacionApiConsumer _IMotivo_de_No_CanalizacionApiConsumer;
        private IRegistro_de_Mandamiento_JudicialApiConsumer _IRegistro_de_Mandamiento_JudicialApiConsumer;
        private IElemento_RobadoApiConsumer _IElemento_RobadoApiConsumer;
        private ICircunstancia_VehiculoApiConsumer _ICircunstancia_VehiculoApiConsumer;
        private IEspecifica_VehiculoApiConsumer _IEspecifica_VehiculoApiConsumer;
        private IMarca_del_VehiculoApiConsumer _IMarca_del_VehiculoApiConsumer;
        private ISub_Marca_del_VehiculoApiConsumer _ISub_Marca_del_VehiculoApiConsumer;
        private ITipo_de_VehiculoApiConsumer _ITipo_de_VehiculoApiConsumer;
        private IColor_VehiculoApiConsumer _IColor_VehiculoApiConsumer;
        private IZona_de_RoboApiConsumer _IZona_de_RoboApiConsumer;
        private IAseguradora_de_VehiculoApiConsumer _IAseguradora_de_VehiculoApiConsumer;
        private IServicio_del_VehiculoApiConsumer _IServicio_del_VehiculoApiConsumer;
        private IProcedencia_del_VehiculoApiConsumer _IProcedencia_del_VehiculoApiConsumer;
        private ITipo_de_RoboApiConsumer _ITipo_de_RoboApiConsumer;
        private ITipo_de_CarreteraApiConsumer _ITipo_de_CarreteraApiConsumer;
        private IModalidad_de_Robo_de_VehiculoApiConsumer _IModalidad_de_Robo_de_VehiculoApiConsumer;
        private ICircunstancia_DefuncionApiConsumer _ICircunstancia_DefuncionApiConsumer;
        private IConsecuencia_DefuncionApiConsumer _IConsecuencia_DefuncionApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IDetalle_de_Persona_MoralApiConsumer _IDetalle_de_Persona_MoralApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;

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

        
        public Detalle_de_DelitoController(IDetalle_de_DelitoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_DelitoApiConsumer Detalle_de_DelitoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IFormato_de_DenunciaApiConsumer Formato_de_DenunciaApiConsumer , IDelitos_Violencia_GeneroApiConsumer Delitos_Violencia_GeneroApiConsumer , ITipo_DelitoApiConsumer Tipo_DelitoApiConsumer , ITitulo_del_DelitoApiConsumer Titulo_del_DelitoApiConsumer , IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer , IDelitoApiConsumer DelitoApiConsumer , IAgravantes_del_DelitoApiConsumer Agravantes_del_DelitoApiConsumer , IAgravantesApiConsumer AgravantesApiConsumer  , ICircunstancias_del_DelitoApiConsumer Circunstancias_del_DelitoApiConsumer , ITipo_de_Lugar_del_RoboApiConsumer Tipo_de_Lugar_del_RoboApiConsumer  , ICircunstancia_del_DelitoApiConsumer Circunstancia_del_DelitoApiConsumer , IForma_Comision_DelitoApiConsumer Forma_Comision_DelitoApiConsumer , IForma_Accion_DelitoApiConsumer Forma_Accion_DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer , IElementos_Comision_DelitoApiConsumer Elementos_Comision_DelitoApiConsumer , IClasificacion_en_Orden_de_ResultadoApiConsumer Clasificacion_en_Orden_de_ResultadoApiConsumer , IConcursoApiConsumer ConcursoApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , IMotivo_de_No_CanalizacionApiConsumer Motivo_de_No_CanalizacionApiConsumer , IRegistro_de_Mandamiento_JudicialApiConsumer Registro_de_Mandamiento_JudicialApiConsumer , IElemento_RobadoApiConsumer Elemento_RobadoApiConsumer , ICircunstancia_VehiculoApiConsumer Circunstancia_VehiculoApiConsumer , IEspecifica_VehiculoApiConsumer Especifica_VehiculoApiConsumer , IMarca_del_VehiculoApiConsumer Marca_del_VehiculoApiConsumer , ISub_Marca_del_VehiculoApiConsumer Sub_Marca_del_VehiculoApiConsumer , ITipo_de_VehiculoApiConsumer Tipo_de_VehiculoApiConsumer , IColor_VehiculoApiConsumer Color_VehiculoApiConsumer , IZona_de_RoboApiConsumer Zona_de_RoboApiConsumer , IAseguradora_de_VehiculoApiConsumer Aseguradora_de_VehiculoApiConsumer , IServicio_del_VehiculoApiConsumer Servicio_del_VehiculoApiConsumer , IProcedencia_del_VehiculoApiConsumer Procedencia_del_VehiculoApiConsumer , ITipo_de_RoboApiConsumer Tipo_de_RoboApiConsumer , ITipo_de_CarreteraApiConsumer Tipo_de_CarreteraApiConsumer , IModalidad_de_Robo_de_VehiculoApiConsumer Modalidad_de_Robo_de_VehiculoApiConsumer , ICircunstancia_DefuncionApiConsumer Circunstancia_DefuncionApiConsumer , IConsecuencia_DefuncionApiConsumer Consecuencia_DefuncionApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IPaisApiConsumer PaisApiConsumer , IDetalle_de_Persona_MoralApiConsumer Detalle_de_Persona_MoralApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_DelitoApiConsumer = Detalle_de_DelitoApiConsumer;
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
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._IFormato_de_DenunciaApiConsumer = Formato_de_DenunciaApiConsumer;
            this._IDelitos_Violencia_GeneroApiConsumer = Delitos_Violencia_GeneroApiConsumer;
            this._ITipo_DelitoApiConsumer = Tipo_DelitoApiConsumer;
            this._ITitulo_del_DelitoApiConsumer = Titulo_del_DelitoApiConsumer;
            this._IGrupo_del_DelitoApiConsumer = Grupo_del_DelitoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._IAgravantes_del_DelitoApiConsumer = Agravantes_del_DelitoApiConsumer;

            this._IAgravantesApiConsumer = AgravantesApiConsumer;

            this._ICircunstancias_del_DelitoApiConsumer = Circunstancias_del_DelitoApiConsumer;

            this._ITipo_de_Lugar_del_RoboApiConsumer = Tipo_de_Lugar_del_RoboApiConsumer;

            this._ICircunstancia_del_DelitoApiConsumer = Circunstancia_del_DelitoApiConsumer;
            this._IForma_Comision_DelitoApiConsumer = Forma_Comision_DelitoApiConsumer;
            this._IForma_Accion_DelitoApiConsumer = Forma_Accion_DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;
            this._IElementos_Comision_DelitoApiConsumer = Elementos_Comision_DelitoApiConsumer;
            this._IClasificacion_en_Orden_de_ResultadoApiConsumer = Clasificacion_en_Orden_de_ResultadoApiConsumer;
            this._IConcursoApiConsumer = ConcursoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IMotivo_de_No_CanalizacionApiConsumer = Motivo_de_No_CanalizacionApiConsumer;
            this._IRegistro_de_Mandamiento_JudicialApiConsumer = Registro_de_Mandamiento_JudicialApiConsumer;
            this._IElemento_RobadoApiConsumer = Elemento_RobadoApiConsumer;
            this._ICircunstancia_VehiculoApiConsumer = Circunstancia_VehiculoApiConsumer;
            this._IEspecifica_VehiculoApiConsumer = Especifica_VehiculoApiConsumer;
            this._IMarca_del_VehiculoApiConsumer = Marca_del_VehiculoApiConsumer;
            this._ISub_Marca_del_VehiculoApiConsumer = Sub_Marca_del_VehiculoApiConsumer;
            this._ITipo_de_VehiculoApiConsumer = Tipo_de_VehiculoApiConsumer;
            this._IColor_VehiculoApiConsumer = Color_VehiculoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ITipo_de_Lugar_del_RoboApiConsumer = Tipo_de_Lugar_del_RoboApiConsumer;
            this._IZona_de_RoboApiConsumer = Zona_de_RoboApiConsumer;
            this._IAseguradora_de_VehiculoApiConsumer = Aseguradora_de_VehiculoApiConsumer;
            this._IServicio_del_VehiculoApiConsumer = Servicio_del_VehiculoApiConsumer;
            this._IProcedencia_del_VehiculoApiConsumer = Procedencia_del_VehiculoApiConsumer;
            this._ITipo_de_RoboApiConsumer = Tipo_de_RoboApiConsumer;
            this._ITipo_de_Lugar_del_RoboApiConsumer = Tipo_de_Lugar_del_RoboApiConsumer;
            this._ITipo_de_CarreteraApiConsumer = Tipo_de_CarreteraApiConsumer;
            this._IModalidad_de_Robo_de_VehiculoApiConsumer = Modalidad_de_Robo_de_VehiculoApiConsumer;
            this._ICircunstancia_DefuncionApiConsumer = Circunstancia_DefuncionApiConsumer;
            this._IConsecuencia_DefuncionApiConsumer = Consecuencia_DefuncionApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IDetalle_de_Persona_MoralApiConsumer = Detalle_de_Persona_MoralApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Delito
        [ObjectAuth(ObjectId = (ModuleObjectId)45078, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45078, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Delito/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45078, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45078, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Delito = new Detalle_de_DelitoModel();
			varDetalle_de_Delito.Clave = Id;
			
            ViewBag.ObjectId = "45078";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionAgravantes_del_Delito = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45301, ModuleId);
            ViewBag.PermissionAgravantes_del_Delito = permissionAgravantes_del_Delito;
            var permissionCircunstancias_del_Delito = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45302, ModuleId);
            ViewBag.PermissionCircunstancias_del_Delito = permissionCircunstancias_del_Delito;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_DelitosData = _IDetalle_de_DelitoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Delito.Clave=" + Id, "").Resource.Detalle_de_Delitos;
				
				if (Detalle_de_DelitosData != null && Detalle_de_DelitosData.Count > 0)
                {
					var Detalle_de_DelitoData = Detalle_de_DelitosData.First();
					varDetalle_de_Delito= new Detalle_de_DelitoModel
					{
						Clave  = Detalle_de_DelitoData.Clave 
	                    ,Descripcion_corta = Detalle_de_DelitoData.Descripcion_corta
                    ,Robo_de_Vehiculo = Detalle_de_DelitoData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Expediente_Inicial = Detalle_de_DelitoData.Expediente_Inicial
                    ,Expediente_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Expediente_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_DelitoData.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MP = Detalle_de_DelitoData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_DelitoData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Expediente_MASC = Detalle_de_DelitoData.Expediente_MASC
                    ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Expediente_MASC), "Solicitud") ??  (string)Detalle_de_DelitoData.Expediente_MASC_Solicitud.Numero_de_Folio
                    ,Tipo_de_Denuncia = Detalle_de_DelitoData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Denuncia), "Formato_de_Denuncia") ??  (string)Detalle_de_DelitoData.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                    ,Fecha_del_Delito = (Detalle_de_DelitoData.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(Detalle_de_DelitoData.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Delito = Detalle_de_DelitoData.Hora_del_Delito
                    ,Violencia_de_Genero = Detalle_de_DelitoData.Violencia_de_Genero.GetValueOrDefault()
                    ,Delito_Violencia_Genero = Detalle_de_DelitoData.Delito_Violencia_Genero
                    ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Delito_Violencia_Genero), "Delitos_Violencia_Genero") ??  (string)Detalle_de_DelitoData.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                    ,Tipo_de_Delito = Detalle_de_DelitoData.Tipo_de_Delito
                    ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Delito), "Tipo_Delito") ??  (string)Detalle_de_DelitoData.Tipo_de_Delito_Tipo_Delito.Descripcion
                    ,Titulo_del_Delito = Detalle_de_DelitoData.Titulo_del_Delito
                    ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Titulo_del_Delito), "Titulo_del_Delito") ??  (string)Detalle_de_DelitoData.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_Delito = Detalle_de_DelitoData.Grupo_Delito
                    ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Grupo_Delito), "Grupo_del_Delito") ??  (string)Detalle_de_DelitoData.Grupo_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Detalle_de_DelitoData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Delito), "Delito") ??  (string)Detalle_de_DelitoData.Delito_Delito.Descripcion
                    ,Agravante = Detalle_de_DelitoData.Agravante.GetValueOrDefault()
                    ,Circunstancia_Delito = Detalle_de_DelitoData.Circunstancia_Delito
                    ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Circunstancia_Delito), "Circunstancia_del_Delito") ??  (string)Detalle_de_DelitoData.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
                    ,Articulado_de_Delito = Detalle_de_DelitoData.Articulado_de_Delito
                    ,Delito_Principal = Detalle_de_DelitoData.Delito_Principal.GetValueOrDefault()
                    ,Forma_Comision_Delito = Detalle_de_DelitoData.Forma_Comision_Delito
                    ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Forma_Comision_Delito), "Forma_Comision_Delito") ??  (string)Detalle_de_DelitoData.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_Accion_Delito = Detalle_de_DelitoData.Forma_Accion_Delito
                    ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Forma_Accion_Delito), "Forma_Accion_Delito") ??  (string)Detalle_de_DelitoData.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_Delito = Detalle_de_DelitoData.Modalidad_Delito
                    ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Modalidad_Delito), "Modalidad_Delito") ??  (string)Detalle_de_DelitoData.Modalidad_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_Comision_Delito = Detalle_de_DelitoData.Elementos_Comision_Delito
                    ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Elementos_Comision_Delito), "Elementos_Comision_Delito") ??  (string)Detalle_de_DelitoData.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                    ,Clasificacion_con_Orden_de_Resultado = Detalle_de_DelitoData.Clasificacion_con_Orden_de_Resultado
                    ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Clasificacion_con_Orden_de_Resultado), "Clasificacion_en_Orden_de_Resultado") ??  (string)Detalle_de_DelitoData.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                    ,Concurso = Detalle_de_DelitoData.Concurso
                    ,ConcursoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Concurso), "Concurso") ??  (string)Detalle_de_DelitoData.Concurso_Concurso.Descripcion
                    ,Monto = Detalle_de_DelitoData.Monto
                    ,Estado_del_Delito = Detalle_de_DelitoData.Estado_del_Delito
                    ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado_del_Delito), "Estado") ??  (string)Detalle_de_DelitoData.Estado_del_Delito_Estado.Nombre
                    ,Municipio_del_Delito = Detalle_de_DelitoData.Municipio_del_Delito
                    ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Municipio_del_Delito), "Municipio") ??  (string)Detalle_de_DelitoData.Municipio_del_Delito_Municipio.Nombre
                    ,Colonia_del_Delito = Detalle_de_DelitoData.Colonia_del_Delito
                    ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Colonia_del_Delito), "Colonia") ??  (string)Detalle_de_DelitoData.Colonia_del_Delito_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_DelitoData.Codigo_Postal
                    ,Calle = Detalle_de_DelitoData.Calle
                    ,Entre_Calle = Detalle_de_DelitoData.Entre_Calle
                    ,y_Calle = Detalle_de_DelitoData.y_Calle
                    ,Numero_Exterior_del_Delito = Detalle_de_DelitoData.Numero_Exterior_del_Delito
                    ,Numero_Interior_del_Delito = Detalle_de_DelitoData.Numero_Interior_del_Delito
                    ,Referencia = Detalle_de_DelitoData.Referencia
                    ,Latitud = Detalle_de_DelitoData.Latitud
                    ,Longitud = Detalle_de_DelitoData.Longitud
                    ,Puede_Ser_Canalizado_a_JA = Detalle_de_DelitoData.Puede_Ser_Canalizado_a_JA
                    ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Puede_Ser_Canalizado_a_JA), "A_Tiempo") ??  (string)Detalle_de_DelitoData.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                    ,Motivo_de_no_canalizacion = Detalle_de_DelitoData.Motivo_de_no_canalizacion
                    ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Motivo_de_no_canalizacion), "Motivo_de_No_Canalizacion") ??  (string)Detalle_de_DelitoData.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
                    ,Se_Informaron_sus_Derechos = Detalle_de_DelitoData.Se_Informaron_sus_Derechos.GetValueOrDefault()
                    ,Se_Informo_el_Procedimiento = Detalle_de_DelitoData.Se_Informo_el_Procedimiento.GetValueOrDefault()
                    ,Levantamiento_de_Cadaver = Detalle_de_DelitoData.Levantamiento_de_Cadaver.GetValueOrDefault()
                    ,Mandamiento_Judicial = Detalle_de_DelitoData.Mandamiento_Judicial
                    ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Mandamiento_Judicial), "Registro_de_Mandamiento_Judicial") ??  (string)Detalle_de_DelitoData.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                    ,Fecha_del_Robo = (Detalle_de_DelitoData.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(Detalle_de_DelitoData.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Robo = Detalle_de_DelitoData.Hora_del_Robo
                    ,Robo_de = Detalle_de_DelitoData.Robo_de
                    ,Robo_deDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Robo_de), "Elemento_Robado") ??  (string)Detalle_de_DelitoData.Robo_de_Elemento_Robado.Descripcion
                    ,Registro_Federal_Vehicular = Detalle_de_DelitoData.Registro_Federal_Vehicular
                    ,Numero_de_Registro_Publico_Vehicular = Detalle_de_DelitoData.Numero_de_Registro_Publico_Vehicular
                    ,Circunstancia_de_Vehiculo = Detalle_de_DelitoData.Circunstancia_de_Vehiculo
                    ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Circunstancia_de_Vehiculo), "Circunstancia_Vehiculo") ??  (string)Detalle_de_DelitoData.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                    ,Clase = Detalle_de_DelitoData.Clase
                    ,ClaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Clase), "Especifica_Vehiculo") ??  (string)Detalle_de_DelitoData.Clase_Especifica_Vehiculo.Descripcion
                    ,Vehiculo_Robado = Detalle_de_DelitoData.Vehiculo_Robado.GetValueOrDefault()
                    ,Marca = Detalle_de_DelitoData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Marca), "Marca_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Detalle_de_DelitoData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = Detalle_de_DelitoData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)Detalle_de_DelitoData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Detalle_de_DelitoData.Modelo
                    ,Color = Detalle_de_DelitoData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Color), "Color_Vehiculo") ??  (string)Detalle_de_DelitoData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Detalle_de_DelitoData.Placas
                    ,Estado_de_Origen_de_las_Placas = Detalle_de_DelitoData.Estado_de_Origen_de_las_Placas
                    ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado_de_Origen_de_las_Placas), "Estado") ??  (string)Detalle_de_DelitoData.Estado_de_Origen_de_las_Placas_Estado.Nombre
                    ,Numero_de_Motor = Detalle_de_DelitoData.Numero_de_Motor
                    ,Numero_de_Serie = Detalle_de_DelitoData.Numero_de_Serie
                    ,Estado_del_Robo = Detalle_de_DelitoData.Estado_del_Robo
                    ,Estado_del_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado_del_Robo), "Estado") ??  (string)Detalle_de_DelitoData.Estado_del_Robo_Estado.Nombre
                    ,Municipio_del_Robo = Detalle_de_DelitoData.Municipio_del_Robo
                    ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Municipio_del_Robo), "Municipio") ??  (string)Detalle_de_DelitoData.Municipio_del_Robo_Municipio.Nombre
                    ,Colonia_del_Robo = Detalle_de_DelitoData.Colonia_del_Robo
                    ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Colonia_del_Robo), "Colonia") ??  (string)Detalle_de_DelitoData.Colonia_del_Robo_Colonia.Nombre
                    ,Codigo_Postal_Robo = Detalle_de_DelitoData.Codigo_Postal_Robo
                    ,Calle_Robo = Detalle_de_DelitoData.Calle_Robo
                    ,Entre_Calle_Robo = Detalle_de_DelitoData.Entre_Calle_Robo
                    ,y_Calle_Robo = Detalle_de_DelitoData.y_Calle_Robo
                    ,Numero_Exterior_del_Delito_Robo = Detalle_de_DelitoData.Numero_Exterior_del_Delito_Robo
                    ,Numero_Interior_del_Delito_Robo = Detalle_de_DelitoData.Numero_Interior_del_Delito_Robo
                    ,Referencia_Robo = Detalle_de_DelitoData.Referencia_Robo
                    ,Latitud_Robo = Detalle_de_DelitoData.Latitud_Robo
                    ,Longitud_Robo = Detalle_de_DelitoData.Longitud_Robo
                    ,Lugar_del_Robo = Detalle_de_DelitoData.Lugar_del_Robo
                    ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Lugar_del_Robo), "Tipo_de_Lugar_del_Robo") ??  (string)Detalle_de_DelitoData.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                    ,Zona_de_Robo = Detalle_de_DelitoData.Zona_de_Robo
                    ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Zona_de_Robo), "Zona_de_Robo") ??  (string)Detalle_de_DelitoData.Zona_de_Robo_Zona_de_Robo.Descripcion
                    ,El_Vehiculo_esta_Asegurado = Detalle_de_DelitoData.El_Vehiculo_esta_Asegurado.GetValueOrDefault()
                    ,Nombre_de_la_Aseguradora = Detalle_de_DelitoData.Nombre_de_la_Aseguradora
                    ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_de_la_Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)Detalle_de_DelitoData.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Motor = Detalle_de_DelitoData.Motor
                    ,Serie = Detalle_de_DelitoData.Serie
                    ,Tipo_de_Servicio = Detalle_de_DelitoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = Detalle_de_DelitoData.Ruta_del_Servicio_Publico
                    ,Procedencia = Detalle_de_DelitoData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Procedencia), "Procedencia_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Procedencia_Procedencia_del_Vehiculo.Descripcion
                    ,Mercancia = Detalle_de_DelitoData.Mercancia.GetValueOrDefault()
                    ,Descripcion_de_lo_que_Transportaba = Detalle_de_DelitoData.Descripcion_de_lo_que_Transportaba
                    ,Monto_de_la_Carga = Detalle_de_DelitoData.Monto_de_la_Carga
                    ,Senas_Particulares = Detalle_de_DelitoData.Senas_Particulares
                    ,Cuenta_con_GPS = Detalle_de_DelitoData.Cuenta_con_GPS.GetValueOrDefault()
                    ,Tipo_de_Robo = Detalle_de_DelitoData.Tipo_de_Robo
                    ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Robo), "Tipo_de_Robo") ??  (string)Detalle_de_DelitoData.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                    ,Tipo_de_Lugar_del_Robo = Detalle_de_DelitoData.Tipo_de_Lugar_del_Robo
                    ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Lugar_del_Robo), "Tipo_de_Lugar_del_Robo") ??  (string)Detalle_de_DelitoData.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                    ,Tipo_de_Carretera = Detalle_de_DelitoData.Tipo_de_Carretera
                    ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Carretera), "Tipo_de_Carretera") ??  (string)Detalle_de_DelitoData.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                    ,Modalidad_del_Robo = Detalle_de_DelitoData.Modalidad_del_Robo
                    ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Modalidad_del_Robo), "Modalidad_de_Robo_de_Vehiculo") ??  (string)Detalle_de_DelitoData.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                    ,Causa_de_Muerte = Detalle_de_DelitoData.Causa_de_Muerte
                    ,Circunstancia_Defuncion = Detalle_de_DelitoData.Circunstancia_Defuncion
                    ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Circunstancia_Defuncion), "Circunstancia_Defuncion") ??  (string)Detalle_de_DelitoData.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                    ,Consecuencia_Defuncion = Detalle_de_DelitoData.Consecuencia_Defuncion
                    ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Consecuencia_Defuncion), "Consecuencia_Defuncion") ??  (string)Detalle_de_DelitoData.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                    ,Fecha_Levantamiento = (Detalle_de_DelitoData.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_DelitoData.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Levantamiento = Detalle_de_DelitoData.Hora_Levantamiento
                    ,Tipo_de_Lugar_del_Hecho = Detalle_de_DelitoData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_DelitoData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Pais = Detalle_de_DelitoData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Pais), "Pais") ??  (string)Detalle_de_DelitoData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_DelitoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado), "Estado") ??  (string)Detalle_de_DelitoData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_DelitoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Municipio), "Municipio") ??  (string)Detalle_de_DelitoData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_DelitoData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Colonia), "Colonia") ??  (string)Detalle_de_DelitoData.Colonia_Colonia.Nombre
                    ,Colonia_no_Catalogada = Detalle_de_DelitoData.Colonia_no_Catalogada
                    ,Numero_Exterior = Detalle_de_DelitoData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_DelitoData.Numero_Interior
                    ,Necropsia = Detalle_de_DelitoData.Necropsia
                    ,Cronotanatodiagnostico = Detalle_de_DelitoData.Cronotanatodiagnostico
                    ,Ruta = Detalle_de_DelitoData.Ruta
                    ,Estado_del_Conductor = Detalle_de_DelitoData.Estado_del_Conductor.GetValueOrDefault()
                    ,Persona_Moral_Dueno = Detalle_de_DelitoData.Persona_Moral_Dueno.GetValueOrDefault()
                    ,Nombre_Completo = Detalle_de_DelitoData.Nombre_Completo
                    ,Nombre_CompletoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_Completo), "Detalle_de_Persona_Moral") ??  (string)Detalle_de_DelitoData.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
                    ,Persona_Fisica_Dueno = Detalle_de_DelitoData.Persona_Fisica_Dueno.GetValueOrDefault()
                    ,Nombre_Completo_Involucrado = Detalle_de_DelitoData.Nombre_Completo_Involucrado
                    ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_Completo_Involucrado), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_DelitoData.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
                    ,Denunciante_dueno = Detalle_de_DelitoData.Denunciante_dueno.GetValueOrDefault()
                    ,Nombre_Completo_Dueno = Detalle_de_DelitoData.Nombre_Completo_Dueno
                    ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_Completo_Dueno), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_DelitoData.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFormato_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formato_de_Denuncias_Tipo_de_Denuncia = _IFormato_de_DenunciaApiConsumer.SelAll(true);
            if (Formato_de_Denuncias_Tipo_de_Denuncia != null && Formato_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Formato_de_Denuncias_Tipo_de_Denuncia = Formato_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formato_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitos_Violencia_GeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Violencia_Generos_Delito_Violencia_Genero = _IDelitos_Violencia_GeneroApiConsumer.SelAll(true);
            if (Delitos_Violencia_Generos_Delito_Violencia_Genero != null && Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource != null)
                ViewBag.Delitos_Violencia_Generos_Delito_Violencia_Genero = Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delitos_Violencia_Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_de_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_de_Delito != null && Tipo_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_de_Delito = Tipo_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia_Delito = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia_Delito != null && Circunstancia_del_Delitos_Circunstancia_Delito.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia_Delito = Circunstancia_del_Delitos_Circunstancia_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Puede_Ser_Canalizado_a_JA = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Puede_Ser_Canalizado_a_JA != null && A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource != null)
                ViewBag.A_Tiempos_Puede_Ser_Canalizado_a_JA = A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_No_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = _IMotivo_de_No_CanalizacionApiConsumer.SelAll(true);
            if (Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion != null && Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource != null)
                ViewBag.Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_No_Canalizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase != null && Especifica_Vehiculos_Clase.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase = Especifica_Vehiculos_Clase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZona_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zona_de_Robos_Zona_de_Robo = _IZona_de_RoboApiConsumer.SelAll(true);
            if (Zona_de_Robos_Zona_de_Robo != null && Zona_de_Robos_Zona_de_Robo.Resource != null)
                ViewBag.Zona_de_Robos_Zona_de_Robo = Zona_de_Robos_Zona_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora != null && Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Morals_Nombre_Completo = _IDetalle_de_Persona_MoralApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Morals_Nombre_Completo != null && Detalle_de_Persona_Morals_Nombre_Completo.Resource != null)
                ViewBag.Detalle_de_Persona_Morals_Nombre_Completo = Detalle_de_Persona_Morals_Nombre_Completo.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado != null && Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Dueno != null && Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Delito);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Delito(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45078);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_DelitoModel varDetalle_de_Delito= new Detalle_de_DelitoModel();
            var permissionAgravantes_del_Delito = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45301, ModuleId);
            ViewBag.PermissionAgravantes_del_Delito = permissionAgravantes_del_Delito;
            var permissionCircunstancias_del_Delito = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45302, ModuleId);
            ViewBag.PermissionCircunstancias_del_Delito = permissionCircunstancias_del_Delito;


            if (id.ToString() != "0")
            {
                var Detalle_de_DelitosData = _IDetalle_de_DelitoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Delito.Clave=" + id, "").Resource.Detalle_de_Delitos;
				
				if (Detalle_de_DelitosData != null && Detalle_de_DelitosData.Count > 0)
                {
					var Detalle_de_DelitoData = Detalle_de_DelitosData.First();
					varDetalle_de_Delito= new Detalle_de_DelitoModel
					{
						Clave  = Detalle_de_DelitoData.Clave 
	                    ,Descripcion_corta = Detalle_de_DelitoData.Descripcion_corta
                    ,Robo_de_Vehiculo = Detalle_de_DelitoData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Expediente_Inicial = Detalle_de_DelitoData.Expediente_Inicial
                    ,Expediente_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Expediente_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_DelitoData.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MP = Detalle_de_DelitoData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_DelitoData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Expediente_MASC = Detalle_de_DelitoData.Expediente_MASC
                    ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Expediente_MASC), "Solicitud") ??  (string)Detalle_de_DelitoData.Expediente_MASC_Solicitud.Numero_de_Folio
                    ,Tipo_de_Denuncia = Detalle_de_DelitoData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Denuncia), "Formato_de_Denuncia") ??  (string)Detalle_de_DelitoData.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                    ,Fecha_del_Delito = (Detalle_de_DelitoData.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(Detalle_de_DelitoData.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Delito = Detalle_de_DelitoData.Hora_del_Delito
                    ,Violencia_de_Genero = Detalle_de_DelitoData.Violencia_de_Genero.GetValueOrDefault()
                    ,Delito_Violencia_Genero = Detalle_de_DelitoData.Delito_Violencia_Genero
                    ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Delito_Violencia_Genero), "Delitos_Violencia_Genero") ??  (string)Detalle_de_DelitoData.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                    ,Tipo_de_Delito = Detalle_de_DelitoData.Tipo_de_Delito
                    ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Delito), "Tipo_Delito") ??  (string)Detalle_de_DelitoData.Tipo_de_Delito_Tipo_Delito.Descripcion
                    ,Titulo_del_Delito = Detalle_de_DelitoData.Titulo_del_Delito
                    ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Titulo_del_Delito), "Titulo_del_Delito") ??  (string)Detalle_de_DelitoData.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_Delito = Detalle_de_DelitoData.Grupo_Delito
                    ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Grupo_Delito), "Grupo_del_Delito") ??  (string)Detalle_de_DelitoData.Grupo_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Detalle_de_DelitoData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Delito), "Delito") ??  (string)Detalle_de_DelitoData.Delito_Delito.Descripcion
                    ,Agravante = Detalle_de_DelitoData.Agravante.GetValueOrDefault()
                    ,Circunstancia_Delito = Detalle_de_DelitoData.Circunstancia_Delito
                    ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Circunstancia_Delito), "Circunstancia_del_Delito") ??  (string)Detalle_de_DelitoData.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
                    ,Articulado_de_Delito = Detalle_de_DelitoData.Articulado_de_Delito
                    ,Delito_Principal = Detalle_de_DelitoData.Delito_Principal.GetValueOrDefault()
                    ,Forma_Comision_Delito = Detalle_de_DelitoData.Forma_Comision_Delito
                    ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Forma_Comision_Delito), "Forma_Comision_Delito") ??  (string)Detalle_de_DelitoData.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_Accion_Delito = Detalle_de_DelitoData.Forma_Accion_Delito
                    ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Forma_Accion_Delito), "Forma_Accion_Delito") ??  (string)Detalle_de_DelitoData.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_Delito = Detalle_de_DelitoData.Modalidad_Delito
                    ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Modalidad_Delito), "Modalidad_Delito") ??  (string)Detalle_de_DelitoData.Modalidad_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_Comision_Delito = Detalle_de_DelitoData.Elementos_Comision_Delito
                    ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Elementos_Comision_Delito), "Elementos_Comision_Delito") ??  (string)Detalle_de_DelitoData.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                    ,Clasificacion_con_Orden_de_Resultado = Detalle_de_DelitoData.Clasificacion_con_Orden_de_Resultado
                    ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Clasificacion_con_Orden_de_Resultado), "Clasificacion_en_Orden_de_Resultado") ??  (string)Detalle_de_DelitoData.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                    ,Concurso = Detalle_de_DelitoData.Concurso
                    ,ConcursoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Concurso), "Concurso") ??  (string)Detalle_de_DelitoData.Concurso_Concurso.Descripcion
                    ,Monto = Detalle_de_DelitoData.Monto
                    ,Estado_del_Delito = Detalle_de_DelitoData.Estado_del_Delito
                    ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado_del_Delito), "Estado") ??  (string)Detalle_de_DelitoData.Estado_del_Delito_Estado.Nombre
                    ,Municipio_del_Delito = Detalle_de_DelitoData.Municipio_del_Delito
                    ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Municipio_del_Delito), "Municipio") ??  (string)Detalle_de_DelitoData.Municipio_del_Delito_Municipio.Nombre
                    ,Colonia_del_Delito = Detalle_de_DelitoData.Colonia_del_Delito
                    ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Colonia_del_Delito), "Colonia") ??  (string)Detalle_de_DelitoData.Colonia_del_Delito_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_DelitoData.Codigo_Postal
                    ,Calle = Detalle_de_DelitoData.Calle
                    ,Entre_Calle = Detalle_de_DelitoData.Entre_Calle
                    ,y_Calle = Detalle_de_DelitoData.y_Calle
                    ,Numero_Exterior_del_Delito = Detalle_de_DelitoData.Numero_Exterior_del_Delito
                    ,Numero_Interior_del_Delito = Detalle_de_DelitoData.Numero_Interior_del_Delito
                    ,Referencia = Detalle_de_DelitoData.Referencia
                    ,Latitud = Detalle_de_DelitoData.Latitud
                    ,Longitud = Detalle_de_DelitoData.Longitud
                    ,Puede_Ser_Canalizado_a_JA = Detalle_de_DelitoData.Puede_Ser_Canalizado_a_JA
                    ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Puede_Ser_Canalizado_a_JA), "A_Tiempo") ??  (string)Detalle_de_DelitoData.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                    ,Motivo_de_no_canalizacion = Detalle_de_DelitoData.Motivo_de_no_canalizacion
                    ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Motivo_de_no_canalizacion), "Motivo_de_No_Canalizacion") ??  (string)Detalle_de_DelitoData.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
                    ,Se_Informaron_sus_Derechos = Detalle_de_DelitoData.Se_Informaron_sus_Derechos.GetValueOrDefault()
                    ,Se_Informo_el_Procedimiento = Detalle_de_DelitoData.Se_Informo_el_Procedimiento.GetValueOrDefault()
                    ,Levantamiento_de_Cadaver = Detalle_de_DelitoData.Levantamiento_de_Cadaver.GetValueOrDefault()
                    ,Mandamiento_Judicial = Detalle_de_DelitoData.Mandamiento_Judicial
                    ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Mandamiento_Judicial), "Registro_de_Mandamiento_Judicial") ??  (string)Detalle_de_DelitoData.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                    ,Fecha_del_Robo = (Detalle_de_DelitoData.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(Detalle_de_DelitoData.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Robo = Detalle_de_DelitoData.Hora_del_Robo
                    ,Robo_de = Detalle_de_DelitoData.Robo_de
                    ,Robo_deDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Robo_de), "Elemento_Robado") ??  (string)Detalle_de_DelitoData.Robo_de_Elemento_Robado.Descripcion
                    ,Registro_Federal_Vehicular = Detalle_de_DelitoData.Registro_Federal_Vehicular
                    ,Numero_de_Registro_Publico_Vehicular = Detalle_de_DelitoData.Numero_de_Registro_Publico_Vehicular
                    ,Circunstancia_de_Vehiculo = Detalle_de_DelitoData.Circunstancia_de_Vehiculo
                    ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Circunstancia_de_Vehiculo), "Circunstancia_Vehiculo") ??  (string)Detalle_de_DelitoData.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                    ,Clase = Detalle_de_DelitoData.Clase
                    ,ClaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Clase), "Especifica_Vehiculo") ??  (string)Detalle_de_DelitoData.Clase_Especifica_Vehiculo.Descripcion
                    ,Vehiculo_Robado = Detalle_de_DelitoData.Vehiculo_Robado.GetValueOrDefault()
                    ,Marca = Detalle_de_DelitoData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Marca), "Marca_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Detalle_de_DelitoData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = Detalle_de_DelitoData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)Detalle_de_DelitoData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Detalle_de_DelitoData.Modelo
                    ,Color = Detalle_de_DelitoData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Color), "Color_Vehiculo") ??  (string)Detalle_de_DelitoData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Detalle_de_DelitoData.Placas
                    ,Estado_de_Origen_de_las_Placas = Detalle_de_DelitoData.Estado_de_Origen_de_las_Placas
                    ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado_de_Origen_de_las_Placas), "Estado") ??  (string)Detalle_de_DelitoData.Estado_de_Origen_de_las_Placas_Estado.Nombre
                    ,Numero_de_Motor = Detalle_de_DelitoData.Numero_de_Motor
                    ,Numero_de_Serie = Detalle_de_DelitoData.Numero_de_Serie
                    ,Estado_del_Robo = Detalle_de_DelitoData.Estado_del_Robo
                    ,Estado_del_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado_del_Robo), "Estado") ??  (string)Detalle_de_DelitoData.Estado_del_Robo_Estado.Nombre
                    ,Municipio_del_Robo = Detalle_de_DelitoData.Municipio_del_Robo
                    ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Municipio_del_Robo), "Municipio") ??  (string)Detalle_de_DelitoData.Municipio_del_Robo_Municipio.Nombre
                    ,Colonia_del_Robo = Detalle_de_DelitoData.Colonia_del_Robo
                    ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Colonia_del_Robo), "Colonia") ??  (string)Detalle_de_DelitoData.Colonia_del_Robo_Colonia.Nombre
                    ,Codigo_Postal_Robo = Detalle_de_DelitoData.Codigo_Postal_Robo
                    ,Calle_Robo = Detalle_de_DelitoData.Calle_Robo
                    ,Entre_Calle_Robo = Detalle_de_DelitoData.Entre_Calle_Robo
                    ,y_Calle_Robo = Detalle_de_DelitoData.y_Calle_Robo
                    ,Numero_Exterior_del_Delito_Robo = Detalle_de_DelitoData.Numero_Exterior_del_Delito_Robo
                    ,Numero_Interior_del_Delito_Robo = Detalle_de_DelitoData.Numero_Interior_del_Delito_Robo
                    ,Referencia_Robo = Detalle_de_DelitoData.Referencia_Robo
                    ,Latitud_Robo = Detalle_de_DelitoData.Latitud_Robo
                    ,Longitud_Robo = Detalle_de_DelitoData.Longitud_Robo
                    ,Lugar_del_Robo = Detalle_de_DelitoData.Lugar_del_Robo
                    ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Lugar_del_Robo), "Tipo_de_Lugar_del_Robo") ??  (string)Detalle_de_DelitoData.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                    ,Zona_de_Robo = Detalle_de_DelitoData.Zona_de_Robo
                    ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Zona_de_Robo), "Zona_de_Robo") ??  (string)Detalle_de_DelitoData.Zona_de_Robo_Zona_de_Robo.Descripcion
                    ,El_Vehiculo_esta_Asegurado = Detalle_de_DelitoData.El_Vehiculo_esta_Asegurado.GetValueOrDefault()
                    ,Nombre_de_la_Aseguradora = Detalle_de_DelitoData.Nombre_de_la_Aseguradora
                    ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_de_la_Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)Detalle_de_DelitoData.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Motor = Detalle_de_DelitoData.Motor
                    ,Serie = Detalle_de_DelitoData.Serie
                    ,Tipo_de_Servicio = Detalle_de_DelitoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = Detalle_de_DelitoData.Ruta_del_Servicio_Publico
                    ,Procedencia = Detalle_de_DelitoData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Procedencia), "Procedencia_del_Vehiculo") ??  (string)Detalle_de_DelitoData.Procedencia_Procedencia_del_Vehiculo.Descripcion
                    ,Mercancia = Detalle_de_DelitoData.Mercancia.GetValueOrDefault()
                    ,Descripcion_de_lo_que_Transportaba = Detalle_de_DelitoData.Descripcion_de_lo_que_Transportaba
                    ,Monto_de_la_Carga = Detalle_de_DelitoData.Monto_de_la_Carga
                    ,Senas_Particulares = Detalle_de_DelitoData.Senas_Particulares
                    ,Cuenta_con_GPS = Detalle_de_DelitoData.Cuenta_con_GPS.GetValueOrDefault()
                    ,Tipo_de_Robo = Detalle_de_DelitoData.Tipo_de_Robo
                    ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Robo), "Tipo_de_Robo") ??  (string)Detalle_de_DelitoData.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                    ,Tipo_de_Lugar_del_Robo = Detalle_de_DelitoData.Tipo_de_Lugar_del_Robo
                    ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Lugar_del_Robo), "Tipo_de_Lugar_del_Robo") ??  (string)Detalle_de_DelitoData.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                    ,Tipo_de_Carretera = Detalle_de_DelitoData.Tipo_de_Carretera
                    ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Carretera), "Tipo_de_Carretera") ??  (string)Detalle_de_DelitoData.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                    ,Modalidad_del_Robo = Detalle_de_DelitoData.Modalidad_del_Robo
                    ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Modalidad_del_Robo), "Modalidad_de_Robo_de_Vehiculo") ??  (string)Detalle_de_DelitoData.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                    ,Causa_de_Muerte = Detalle_de_DelitoData.Causa_de_Muerte
                    ,Circunstancia_Defuncion = Detalle_de_DelitoData.Circunstancia_Defuncion
                    ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Circunstancia_Defuncion), "Circunstancia_Defuncion") ??  (string)Detalle_de_DelitoData.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                    ,Consecuencia_Defuncion = Detalle_de_DelitoData.Consecuencia_Defuncion
                    ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Consecuencia_Defuncion), "Consecuencia_Defuncion") ??  (string)Detalle_de_DelitoData.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                    ,Fecha_Levantamiento = (Detalle_de_DelitoData.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_DelitoData.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Levantamiento = Detalle_de_DelitoData.Hora_Levantamiento
                    ,Tipo_de_Lugar_del_Hecho = Detalle_de_DelitoData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_DelitoData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Pais = Detalle_de_DelitoData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Pais), "Pais") ??  (string)Detalle_de_DelitoData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_DelitoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Estado), "Estado") ??  (string)Detalle_de_DelitoData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_DelitoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Municipio), "Municipio") ??  (string)Detalle_de_DelitoData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_DelitoData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Colonia), "Colonia") ??  (string)Detalle_de_DelitoData.Colonia_Colonia.Nombre
                    ,Colonia_no_Catalogada = Detalle_de_DelitoData.Colonia_no_Catalogada
                    ,Numero_Exterior = Detalle_de_DelitoData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_DelitoData.Numero_Interior
                    ,Necropsia = Detalle_de_DelitoData.Necropsia
                    ,Cronotanatodiagnostico = Detalle_de_DelitoData.Cronotanatodiagnostico
                    ,Ruta = Detalle_de_DelitoData.Ruta
                    ,Estado_del_Conductor = Detalle_de_DelitoData.Estado_del_Conductor.GetValueOrDefault()
                    ,Persona_Moral_Dueno = Detalle_de_DelitoData.Persona_Moral_Dueno.GetValueOrDefault()
                    ,Nombre_Completo = Detalle_de_DelitoData.Nombre_Completo
                    ,Nombre_CompletoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_Completo), "Detalle_de_Persona_Moral") ??  (string)Detalle_de_DelitoData.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
                    ,Persona_Fisica_Dueno = Detalle_de_DelitoData.Persona_Fisica_Dueno.GetValueOrDefault()
                    ,Nombre_Completo_Involucrado = Detalle_de_DelitoData.Nombre_Completo_Involucrado
                    ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_Completo_Involucrado), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_DelitoData.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
                    ,Denunciante_dueno = Detalle_de_DelitoData.Denunciante_dueno.GetValueOrDefault()
                    ,Nombre_Completo_Dueno = Detalle_de_DelitoData.Nombre_Completo_Dueno
                    ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DelitoData.Nombre_Completo_Dueno), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_DelitoData.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFormato_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formato_de_Denuncias_Tipo_de_Denuncia = _IFormato_de_DenunciaApiConsumer.SelAll(true);
            if (Formato_de_Denuncias_Tipo_de_Denuncia != null && Formato_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Formato_de_Denuncias_Tipo_de_Denuncia = Formato_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formato_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitos_Violencia_GeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Violencia_Generos_Delito_Violencia_Genero = _IDelitos_Violencia_GeneroApiConsumer.SelAll(true);
            if (Delitos_Violencia_Generos_Delito_Violencia_Genero != null && Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource != null)
                ViewBag.Delitos_Violencia_Generos_Delito_Violencia_Genero = Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delitos_Violencia_Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_de_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_de_Delito != null && Tipo_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_de_Delito = Tipo_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia_Delito = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia_Delito != null && Circunstancia_del_Delitos_Circunstancia_Delito.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia_Delito = Circunstancia_del_Delitos_Circunstancia_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Puede_Ser_Canalizado_a_JA = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Puede_Ser_Canalizado_a_JA != null && A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource != null)
                ViewBag.A_Tiempos_Puede_Ser_Canalizado_a_JA = A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_No_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = _IMotivo_de_No_CanalizacionApiConsumer.SelAll(true);
            if (Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion != null && Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource != null)
                ViewBag.Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_No_Canalizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase != null && Especifica_Vehiculos_Clase.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase = Especifica_Vehiculos_Clase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZona_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zona_de_Robos_Zona_de_Robo = _IZona_de_RoboApiConsumer.SelAll(true);
            if (Zona_de_Robos_Zona_de_Robo != null && Zona_de_Robos_Zona_de_Robo.Resource != null)
                ViewBag.Zona_de_Robos_Zona_de_Robo = Zona_de_Robos_Zona_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora != null && Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Morals_Nombre_Completo = _IDetalle_de_Persona_MoralApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Morals_Nombre_Completo != null && Detalle_de_Persona_Morals_Nombre_Completo.Resource != null)
                ViewBag.Detalle_de_Persona_Morals_Nombre_Completo = Detalle_de_Persona_Morals_Nombre_Completo.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado != null && Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Dueno != null && Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Delito", varDetalle_de_Delito);
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
        public ActionResult GetFormato_de_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFormato_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFormato_de_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formato_de_Denuncia", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetTipo_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetCircunstancia_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetA_TiempoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IA_TiempoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMotivo_de_No_CanalizacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_de_No_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_de_No_CanalizacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_No_Canalizacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetRegistro_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Mandamiento).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Registro_de_Mandamiento_Judicial", "Numero_de_Mandamiento")?? m.Numero_de_Mandamiento,
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
        public ActionResult GetEspecifica_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecifica_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetZona_de_RoboAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IZona_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IZona_de_RoboApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona_de_Robo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetProcedencia_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProcedencia_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetModalidad_de_Robo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetConsecuencia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsecuencia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetDetalle_de_Persona_MoralAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Persona_MoralApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor")?? m.Nombre_del_Tutor,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_DelitoAdvanceSearchModel model, int idFilter = -1)
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

            _IFormato_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formato_de_Denuncias_Tipo_de_Denuncia = _IFormato_de_DenunciaApiConsumer.SelAll(true);
            if (Formato_de_Denuncias_Tipo_de_Denuncia != null && Formato_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Formato_de_Denuncias_Tipo_de_Denuncia = Formato_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formato_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitos_Violencia_GeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Violencia_Generos_Delito_Violencia_Genero = _IDelitos_Violencia_GeneroApiConsumer.SelAll(true);
            if (Delitos_Violencia_Generos_Delito_Violencia_Genero != null && Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource != null)
                ViewBag.Delitos_Violencia_Generos_Delito_Violencia_Genero = Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delitos_Violencia_Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_de_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_de_Delito != null && Tipo_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_de_Delito = Tipo_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia_Delito = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia_Delito != null && Circunstancia_del_Delitos_Circunstancia_Delito.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia_Delito = Circunstancia_del_Delitos_Circunstancia_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Puede_Ser_Canalizado_a_JA = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Puede_Ser_Canalizado_a_JA != null && A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource != null)
                ViewBag.A_Tiempos_Puede_Ser_Canalizado_a_JA = A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_No_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = _IMotivo_de_No_CanalizacionApiConsumer.SelAll(true);
            if (Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion != null && Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource != null)
                ViewBag.Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_No_Canalizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase != null && Especifica_Vehiculos_Clase.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase = Especifica_Vehiculos_Clase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZona_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zona_de_Robos_Zona_de_Robo = _IZona_de_RoboApiConsumer.SelAll(true);
            if (Zona_de_Robos_Zona_de_Robo != null && Zona_de_Robos_Zona_de_Robo.Resource != null)
                ViewBag.Zona_de_Robos_Zona_de_Robo = Zona_de_Robos_Zona_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora != null && Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Morals_Nombre_Completo = _IDetalle_de_Persona_MoralApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Morals_Nombre_Completo != null && Detalle_de_Persona_Morals_Nombre_Completo.Resource != null)
                ViewBag.Detalle_de_Persona_Morals_Nombre_Completo = Detalle_de_Persona_Morals_Nombre_Completo.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado != null && Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Dueno != null && Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFormato_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formato_de_Denuncias_Tipo_de_Denuncia = _IFormato_de_DenunciaApiConsumer.SelAll(true);
            if (Formato_de_Denuncias_Tipo_de_Denuncia != null && Formato_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Formato_de_Denuncias_Tipo_de_Denuncia = Formato_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formato_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitos_Violencia_GeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Violencia_Generos_Delito_Violencia_Genero = _IDelitos_Violencia_GeneroApiConsumer.SelAll(true);
            if (Delitos_Violencia_Generos_Delito_Violencia_Genero != null && Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource != null)
                ViewBag.Delitos_Violencia_Generos_Delito_Violencia_Genero = Delitos_Violencia_Generos_Delito_Violencia_Genero.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delitos_Violencia_Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_de_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_de_Delito != null && Tipo_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_de_Delito = Tipo_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia_Delito = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia_Delito != null && Circunstancia_del_Delitos_Circunstancia_Delito.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia_Delito = Circunstancia_del_Delitos_Circunstancia_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Puede_Ser_Canalizado_a_JA = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Puede_Ser_Canalizado_a_JA != null && A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource != null)
                ViewBag.A_Tiempos_Puede_Ser_Canalizado_a_JA = A_Tiempos_Puede_Ser_Canalizado_a_JA.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_No_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = _IMotivo_de_No_CanalizacionApiConsumer.SelAll(true);
            if (Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion != null && Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource != null)
                ViewBag.Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion = Motivo_de_No_Canalizacions_Motivo_de_no_canalizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_No_Canalizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase != null && Especifica_Vehiculos_Clase.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase = Especifica_Vehiculos_Clase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZona_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zona_de_Robos_Zona_de_Robo = _IZona_de_RoboApiConsumer.SelAll(true);
            if (Zona_de_Robos_Zona_de_Robo != null && Zona_de_Robos_Zona_de_Robo.Resource != null)
                ViewBag.Zona_de_Robos_Zona_de_Robo = Zona_de_Robos_Zona_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora != null && Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Morals_Nombre_Completo = _IDetalle_de_Persona_MoralApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Morals_Nombre_Completo != null && Detalle_de_Persona_Morals_Nombre_Completo.Resource != null)
                ViewBag.Detalle_de_Persona_Morals_Nombre_Completo = Detalle_de_Persona_Morals_Nombre_Completo.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado != null && Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado = Detalle_de_Datos_Generaless_Nombre_Completo_Involucrado.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(true);
            if (Detalle_de_Datos_Generaless_Nombre_Completo_Dueno != null && Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource != null)
                ViewBag.Detalle_de_Datos_Generaless_Nombre_Completo_Dueno = Detalle_de_Datos_Generaless_Nombre_Completo_Dueno.Resource.Where(m => m.Nombre_del_Tutor != null).OrderBy(m => m.Nombre_del_Tutor).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_del_Tutor") ?? m.Nombre_del_Tutor.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_DelitoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_DelitoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_DelitoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_DelitoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delitos == null)
                result.Detalle_de_Delitos = new List<Detalle_de_Delito>();

            return Json(new
            {
                data = result.Detalle_de_Delitos.Select(m => new Detalle_de_DelitoGridModel
                    {
                    Clave = m.Clave
			,Descripcion_corta = m.Descripcion_corta
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Expediente_InicialNUAT = CultureHelper.GetTraduction(m.Expediente_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Formato_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                        ,Fecha_del_Delito = (m.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Delito = m.Hora_del_Delito
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Titulo_del_Delito") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Grupo_del_Delito") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
			,Agravante = m.Agravante
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Articulado_de_Delito = m.Articulado_de_Delito
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto = m.Monto
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                        ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
			,Se_Informaron_sus_Derechos = m.Se_Informaron_sus_Derechos
			,Se_Informo_el_Procedimiento = m.Se_Informo_el_Procedimiento
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Numero_de_Motor = m.Numero_de_Motor
			,Numero_de_Serie = m.Numero_de_Serie
                        ,Estado_del_RoboNombre = CultureHelper.GetTraduction(m.Estado_del_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Robo_Estado.Nombre
                        ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(m.Municipio_del_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Robo_Municipio.Nombre
                        ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(m.Colonia_del_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Robo_Colonia.Nombre
			,Codigo_Postal_Robo = m.Codigo_Postal_Robo
			,Calle_Robo = m.Calle_Robo
			,Entre_Calle_Robo = m.Entre_Calle_Robo
			,y_Calle_Robo = m.y_Calle_Robo
			,Numero_Exterior_del_Delito_Robo = m.Numero_Exterior_del_Delito_Robo
			,Numero_Interior_del_Delito_Robo = m.Numero_Interior_del_Delito_Robo
			,Referencia_Robo = m.Referencia_Robo
			,Latitud_Robo = m.Latitud_Robo
			,Longitud_Robo = m.Longitud_Robo
                        ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(m.Zona_de_Robo_Zona_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_Robo_Zona_de_Robo.Descripcion
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
			,Cuenta_con_GPS = m.Cuenta_con_GPS
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Persona_Moral_Dueno = m.Persona_Moral_Dueno
                        ,Nombre_CompletoNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Persona_Moral.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
			,Persona_Fisica_Dueno = m.Persona_Fisica_Dueno
                        ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
			,Denunciante_dueno = m.Denunciante_dueno
                        ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Delito", m.),
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
        /// Get List of Detalle_de_Delito from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Delito Entity</returns>
        public ActionResult GetDetalle_de_DelitoList(UrlParametersModel param)
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
            _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_DelitoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_DelitoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_DelitoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_DelitoPropertyMapper oDetalle_de_DelitoPropertyMapper = new Detalle_de_DelitoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_DelitoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delitos == null)
                result.Detalle_de_Delitos = new List<Detalle_de_Delito>();

            return Json(new
            {
                aaData = result.Detalle_de_Delitos.Select(m => new Detalle_de_DelitoGridModel
            {
                    Clave = m.Clave
			,Descripcion_corta = m.Descripcion_corta
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Expediente_InicialNUAT = CultureHelper.GetTraduction(m.Expediente_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Formato_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                        ,Fecha_del_Delito = (m.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Delito = m.Hora_del_Delito
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Titulo_del_Delito") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Grupo_del_Delito") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
			,Agravante = m.Agravante
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Articulado_de_Delito = m.Articulado_de_Delito
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto = m.Monto
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                        ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
			,Se_Informaron_sus_Derechos = m.Se_Informaron_sus_Derechos
			,Se_Informo_el_Procedimiento = m.Se_Informo_el_Procedimiento
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Numero_de_Motor = m.Numero_de_Motor
			,Numero_de_Serie = m.Numero_de_Serie
                        ,Estado_del_RoboNombre = CultureHelper.GetTraduction(m.Estado_del_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Robo_Estado.Nombre
                        ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(m.Municipio_del_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Robo_Municipio.Nombre
                        ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(m.Colonia_del_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Robo_Colonia.Nombre
			,Codigo_Postal_Robo = m.Codigo_Postal_Robo
			,Calle_Robo = m.Calle_Robo
			,Entre_Calle_Robo = m.Entre_Calle_Robo
			,y_Calle_Robo = m.y_Calle_Robo
			,Numero_Exterior_del_Delito_Robo = m.Numero_Exterior_del_Delito_Robo
			,Numero_Interior_del_Delito_Robo = m.Numero_Interior_del_Delito_Robo
			,Referencia_Robo = m.Referencia_Robo
			,Latitud_Robo = m.Latitud_Robo
			,Longitud_Robo = m.Longitud_Robo
                        ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(m.Zona_de_Robo_Zona_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_Robo_Zona_de_Robo.Descripcion
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
			,Cuenta_con_GPS = m.Cuenta_con_GPS
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Persona_Moral_Dueno = m.Persona_Moral_Dueno
                        ,Nombre_CompletoNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Persona_Moral.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
			,Persona_Fisica_Dueno = m.Persona_Fisica_Dueno
                        ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
			,Denunciante_dueno = m.Denunciante_dueno
                        ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Expediente_Inicial_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Expediente_MASC_Solicitud(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Titulo_del_Delito_Titulo_del_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Titulo_del_Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Titulo_del_Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ITitulo_del_DelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Titulo_del_Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Titulo_del_Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Titulo_del_Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Titulo_del_Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Grupo_Delito_Grupo_del_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Grupo_del_Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Grupo_del_Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IGrupo_del_DelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Grupo_del_Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Grupo_del_Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Grupo_del_Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Grupo_del_Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Delito_Delito(string query, string where)
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

//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Estado_del_Delito_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Municipio_del_Delito_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Colonia_del_Delito_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Mandamiento_Judicial_Registro_de_Mandamiento_Judicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Registro_de_Mandamiento_Judicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll(1, 20,elWhere , " Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento ASC ").Resource;
               
                foreach (var item in result.Registro_de_Mandamiento_Judicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Registro_de_Mandamiento_Judicial", "Numero_de_Mandamiento");
                    item.Numero_de_Mandamiento =trans ??item.Numero_de_Mandamiento;
                }
                return Json(result.Registro_de_Mandamiento_Judicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Estado_de_Origen_de_las_Placas_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Estado_del_Robo_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Municipio_del_Robo_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Colonia_del_Robo_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Pais_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_Colonia_Colonia(string query, string where)
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
        public string GetAdvanceFilter(Detalle_de_DelitoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Delito.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Delito.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion_corta))
            {
                switch (filter.Descripcion_cortaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Descripcion_corta LIKE '" + filter.Descripcion_corta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Descripcion_corta LIKE '%" + filter.Descripcion_corta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Descripcion_corta = '" + filter.Descripcion_corta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Descripcion_corta LIKE '%" + filter.Descripcion_corta + "%'";
                        break;
                }
            }

            if (filter.Robo_de_Vehiculo != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Robo_de_Vehiculo = " + Convert.ToInt32(filter.Robo_de_Vehiculo);

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_Inicial))
            {
                switch (filter.Expediente_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceExpediente_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceExpediente_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceExpediente_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceExpediente_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_InicialMultiple != null && filter.AdvanceExpediente_InicialMultiple.Count() > 0)
            {
                var Expediente_InicialIds = string.Join(",", filter.AdvanceExpediente_InicialMultiple);

                where += " AND Detalle_de_Delito.Expediente_Inicial In (" + Expediente_InicialIds + ")";
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

                where += " AND Detalle_de_Delito.Expediente_MP In (" + Expediente_MPIds + ")";
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

                where += " AND Detalle_de_Delito.Expediente_MASC In (" + Expediente_MASCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Denuncia))
            {
                switch (filter.Tipo_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Formato_de_Denuncia.Descripcion LIKE '" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Formato_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Formato_de_Denuncia.Descripcion = '" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Formato_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DenunciaMultiple != null && filter.AdvanceTipo_de_DenunciaMultiple.Count() > 0)
            {
                var Tipo_de_DenunciaIds = string.Join(",", filter.AdvanceTipo_de_DenunciaMultiple);

                where += " AND Detalle_de_Delito.Tipo_de_Denuncia In (" + Tipo_de_DenunciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Delito) || !string.IsNullOrEmpty(filter.ToFecha_del_Delito))
            {
                var Fecha_del_DelitoFrom = DateTime.ParseExact(filter.FromFecha_del_Delito, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_DelitoTo = DateTime.ParseExact(filter.ToFecha_del_Delito, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Delito))
                    where += " AND Detalle_de_Delito.Fecha_del_Delito >= '" + Fecha_del_DelitoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Delito))
                    where += " AND Detalle_de_Delito.Fecha_del_Delito <= '" + Fecha_del_DelitoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Delito) || !string.IsNullOrEmpty(filter.ToHora_del_Delito))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Delito))
                    where += " AND Convert(TIME,Detalle_de_Delito.Hora_del_Delito) >='" + filter.FromHora_del_Delito + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Delito))
                    where += " AND Convert(TIME,Detalle_de_Delito.Hora_del_Delito) <='" + filter.ToHora_del_Delito + "'";
            }

            if (filter.Violencia_de_Genero != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Violencia_de_Genero = " + Convert.ToInt32(filter.Violencia_de_Genero);

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

                where += " AND Detalle_de_Delito.Delito_Violencia_Genero In (" + Delito_Violencia_GeneroIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Delito))
            {
                switch (filter.Tipo_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_Delito.Descripcion LIKE '" + filter.AdvanceTipo_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_Delito.Descripcion LIKE '%" + filter.AdvanceTipo_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_Delito.Descripcion = '" + filter.AdvanceTipo_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_Delito.Descripcion LIKE '%" + filter.AdvanceTipo_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DelitoMultiple != null && filter.AdvanceTipo_de_DelitoMultiple.Count() > 0)
            {
                var Tipo_de_DelitoIds = string.Join(",", filter.AdvanceTipo_de_DelitoMultiple);

                where += " AND Detalle_de_Delito.Tipo_de_Delito In (" + Tipo_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTitulo_del_Delito))
            {
                switch (filter.Titulo_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '" + filter.AdvanceTitulo_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '%" + filter.AdvanceTitulo_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Titulo_del_Delito.Descripcion = '" + filter.AdvanceTitulo_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '%" + filter.AdvanceTitulo_del_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTitulo_del_DelitoMultiple != null && filter.AdvanceTitulo_del_DelitoMultiple.Count() > 0)
            {
                var Titulo_del_DelitoIds = string.Join(",", filter.AdvanceTitulo_del_DelitoMultiple);

                where += " AND Detalle_de_Delito.Titulo_del_Delito In (" + Titulo_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceGrupo_Delito))
            {
                switch (filter.Grupo_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '" + filter.AdvanceGrupo_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Grupo_del_Delito.Descripcion = '" + filter.AdvanceGrupo_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGrupo_DelitoMultiple != null && filter.AdvanceGrupo_DelitoMultiple.Count() > 0)
            {
                var Grupo_DelitoIds = string.Join(",", filter.AdvanceGrupo_DelitoMultiple);

                where += " AND Detalle_de_Delito.Grupo_Delito In (" + Grupo_DelitoIds + ")";
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

                where += " AND Detalle_de_Delito.Delito In (" + DelitoIds + ")";
            }

            if (filter.Agravante != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Agravante = " + Convert.ToInt32(filter.Agravante);

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstancia_Delito))
            {
                switch (filter.Circunstancia_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '" + filter.AdvanceCircunstancia_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '%" + filter.AdvanceCircunstancia_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_del_Delito.Descripcion = '" + filter.AdvanceCircunstancia_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '%" + filter.AdvanceCircunstancia_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstancia_DelitoMultiple != null && filter.AdvanceCircunstancia_DelitoMultiple.Count() > 0)
            {
                var Circunstancia_DelitoIds = string.Join(",", filter.AdvanceCircunstancia_DelitoMultiple);

                where += " AND Detalle_de_Delito.Circunstancia_Delito In (" + Circunstancia_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Articulado_de_Delito))
            {
                switch (filter.Articulado_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Articulado_de_Delito LIKE '" + filter.Articulado_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Articulado_de_Delito LIKE '%" + filter.Articulado_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Articulado_de_Delito = '" + filter.Articulado_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Articulado_de_Delito LIKE '%" + filter.Articulado_de_Delito + "%'";
                        break;
                }
            }

            if (filter.Delito_Principal != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Delito_Principal = " + Convert.ToInt32(filter.Delito_Principal);

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Comision_Delito))
            {
                switch (filter.Forma_Comision_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '" + filter.AdvanceForma_Comision_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Comision_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Comision_Delito.Descripcion = '" + filter.AdvanceForma_Comision_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Comision_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_Comision_DelitoMultiple != null && filter.AdvanceForma_Comision_DelitoMultiple.Count() > 0)
            {
                var Forma_Comision_DelitoIds = string.Join(",", filter.AdvanceForma_Comision_DelitoMultiple);

                where += " AND Detalle_de_Delito.Forma_Comision_Delito In (" + Forma_Comision_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Accion_Delito))
            {
                switch (filter.Forma_Accion_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '" + filter.AdvanceForma_Accion_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Accion_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Accion_Delito.Descripcion = '" + filter.AdvanceForma_Accion_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Accion_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_Accion_DelitoMultiple != null && filter.AdvanceForma_Accion_DelitoMultiple.Count() > 0)
            {
                var Forma_Accion_DelitoIds = string.Join(",", filter.AdvanceForma_Accion_DelitoMultiple);

                where += " AND Detalle_de_Delito.Forma_Accion_Delito In (" + Forma_Accion_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModalidad_Delito))
            {
                switch (filter.Modalidad_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modalidad_Delito.Descripcion LIKE '" + filter.AdvanceModalidad_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modalidad_Delito.Descripcion LIKE '%" + filter.AdvanceModalidad_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modalidad_Delito.Descripcion = '" + filter.AdvanceModalidad_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modalidad_Delito.Descripcion LIKE '%" + filter.AdvanceModalidad_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModalidad_DelitoMultiple != null && filter.AdvanceModalidad_DelitoMultiple.Count() > 0)
            {
                var Modalidad_DelitoIds = string.Join(",", filter.AdvanceModalidad_DelitoMultiple);

                where += " AND Detalle_de_Delito.Modalidad_Delito In (" + Modalidad_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceElementos_Comision_Delito))
            {
                switch (filter.Elementos_Comision_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '" + filter.AdvanceElementos_Comision_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceElementos_Comision_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Elementos_Comision_Delito.Descripcion = '" + filter.AdvanceElementos_Comision_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceElementos_Comision_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceElementos_Comision_DelitoMultiple != null && filter.AdvanceElementos_Comision_DelitoMultiple.Count() > 0)
            {
                var Elementos_Comision_DelitoIds = string.Join(",", filter.AdvanceElementos_Comision_DelitoMultiple);

                where += " AND Detalle_de_Delito.Elementos_Comision_Delito In (" + Elementos_Comision_DelitoIds + ")";
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

                where += " AND Detalle_de_Delito.Clasificacion_con_Orden_de_Resultado In (" + Clasificacion_con_Orden_de_ResultadoIds + ")";
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

                where += " AND Detalle_de_Delito.Concurso In (" + ConcursoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromMonto) || !string.IsNullOrEmpty(filter.ToMonto))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto))
                    where += " AND Detalle_de_Delito.Monto >= " + filter.FromMonto;
                if (!string.IsNullOrEmpty(filter.ToMonto))
                    where += " AND Detalle_de_Delito.Monto <= " + filter.ToMonto;
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

                where += " AND Detalle_de_Delito.Estado_del_Delito In (" + Estado_del_DelitoIds + ")";
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

                where += " AND Detalle_de_Delito.Municipio_del_Delito In (" + Municipio_del_DelitoIds + ")";
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

                where += " AND Detalle_de_Delito.Colonia_del_Delito In (" + Colonia_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Delito.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Delito.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.y_Calle))
            {
                switch (filter.y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.y_Calle LIKE '" + filter.y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.y_Calle LIKE '%" + filter.y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.y_Calle = '" + filter.y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.y_Calle LIKE '%" + filter.y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_del_Delito))
            {
                switch (filter.Numero_Exterior_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito LIKE '" + filter.Numero_Exterior_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito LIKE '%" + filter.Numero_Exterior_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito = '" + filter.Numero_Exterior_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito LIKE '%" + filter.Numero_Exterior_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_del_Delito))
            {
                switch (filter.Numero_Interior_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito LIKE '" + filter.Numero_Interior_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito LIKE '%" + filter.Numero_Interior_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito = '" + filter.Numero_Interior_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito LIKE '%" + filter.Numero_Interior_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia))
            {
                switch (filter.ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Referencia LIKE '" + filter.Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Referencia LIKE '%" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Referencia = '" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Referencia LIKE '%" + filter.Referencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePuede_Ser_Canalizado_a_JA))
            {
                switch (filter.Puede_Ser_Canalizado_a_JAFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvancePuede_Ser_Canalizado_a_JA + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvancePuede_Ser_Canalizado_a_JA + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvancePuede_Ser_Canalizado_a_JA + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvancePuede_Ser_Canalizado_a_JA + "%'";
                        break;
                }
            }
            else if (filter.AdvancePuede_Ser_Canalizado_a_JAMultiple != null && filter.AdvancePuede_Ser_Canalizado_a_JAMultiple.Count() > 0)
            {
                var Puede_Ser_Canalizado_a_JAIds = string.Join(",", filter.AdvancePuede_Ser_Canalizado_a_JAMultiple);

                where += " AND Detalle_de_Delito.Puede_Ser_Canalizado_a_JA In (" + Puede_Ser_Canalizado_a_JAIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMotivo_de_no_canalizacion))
            {
                switch (filter.Motivo_de_no_canalizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Motivo_de_No_Canalizacion.Descripcion LIKE '" + filter.AdvanceMotivo_de_no_canalizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Motivo_de_No_Canalizacion.Descripcion LIKE '%" + filter.AdvanceMotivo_de_no_canalizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Motivo_de_No_Canalizacion.Descripcion = '" + filter.AdvanceMotivo_de_no_canalizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Motivo_de_No_Canalizacion.Descripcion LIKE '%" + filter.AdvanceMotivo_de_no_canalizacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMotivo_de_no_canalizacionMultiple != null && filter.AdvanceMotivo_de_no_canalizacionMultiple.Count() > 0)
            {
                var Motivo_de_no_canalizacionIds = string.Join(",", filter.AdvanceMotivo_de_no_canalizacionMultiple);

                where += " AND Detalle_de_Delito.Motivo_de_no_canalizacion In (" + Motivo_de_no_canalizacionIds + ")";
            }

            if (filter.Se_Informaron_sus_Derechos != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Se_Informaron_sus_Derechos = " + Convert.ToInt32(filter.Se_Informaron_sus_Derechos);

            if (filter.Se_Informo_el_Procedimiento != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Se_Informo_el_Procedimiento = " + Convert.ToInt32(filter.Se_Informo_el_Procedimiento);

            if (filter.Levantamiento_de_Cadaver != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Levantamiento_de_Cadaver = " + Convert.ToInt32(filter.Levantamiento_de_Cadaver);

            if (!string.IsNullOrEmpty(filter.AdvanceMandamiento_Judicial))
            {
                switch (filter.Mandamiento_JudicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '" + filter.AdvanceMandamiento_Judicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.AdvanceMandamiento_Judicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento = '" + filter.AdvanceMandamiento_Judicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.AdvanceMandamiento_Judicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMandamiento_JudicialMultiple != null && filter.AdvanceMandamiento_JudicialMultiple.Count() > 0)
            {
                var Mandamiento_JudicialIds = string.Join(",", filter.AdvanceMandamiento_JudicialMultiple);

                where += " AND Detalle_de_Delito.Mandamiento_Judicial In (" + Mandamiento_JudicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Robo) || !string.IsNullOrEmpty(filter.ToFecha_del_Robo))
            {
                var Fecha_del_RoboFrom = DateTime.ParseExact(filter.FromFecha_del_Robo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_RoboTo = DateTime.ParseExact(filter.ToFecha_del_Robo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Robo))
                    where += " AND Detalle_de_Delito.Fecha_del_Robo >= '" + Fecha_del_RoboFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Robo))
                    where += " AND Detalle_de_Delito.Fecha_del_Robo <= '" + Fecha_del_RoboTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Robo) || !string.IsNullOrEmpty(filter.ToHora_del_Robo))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Robo))
                    where += " AND Convert(TIME,Detalle_de_Delito.Hora_del_Robo) >='" + filter.FromHora_del_Robo + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Robo))
                    where += " AND Convert(TIME,Detalle_de_Delito.Hora_del_Robo) <='" + filter.ToHora_del_Robo + "'";
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

                where += " AND Detalle_de_Delito.Robo_de In (" + Robo_deIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Registro_Federal_Vehicular))
            {
                switch (filter.Registro_Federal_VehicularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Registro_Federal_Vehicular LIKE '" + filter.Registro_Federal_Vehicular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Registro_Federal_Vehicular LIKE '%" + filter.Registro_Federal_Vehicular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Registro_Federal_Vehicular = '" + filter.Registro_Federal_Vehicular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Registro_Federal_Vehicular LIKE '%" + filter.Registro_Federal_Vehicular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Registro_Publico_Vehicular))
            {
                switch (filter.Numero_de_Registro_Publico_VehicularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_de_Registro_Publico_Vehicular LIKE '" + filter.Numero_de_Registro_Publico_Vehicular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_de_Registro_Publico_Vehicular LIKE '%" + filter.Numero_de_Registro_Publico_Vehicular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_de_Registro_Publico_Vehicular = '" + filter.Numero_de_Registro_Publico_Vehicular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_de_Registro_Publico_Vehicular LIKE '%" + filter.Numero_de_Registro_Publico_Vehicular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstancia_de_Vehiculo))
            {
                switch (filter.Circunstancia_de_VehiculoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '" + filter.AdvanceCircunstancia_de_Vehiculo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '%" + filter.AdvanceCircunstancia_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_Vehiculo.Descripcion = '" + filter.AdvanceCircunstancia_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '%" + filter.AdvanceCircunstancia_de_Vehiculo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstancia_de_VehiculoMultiple != null && filter.AdvanceCircunstancia_de_VehiculoMultiple.Count() > 0)
            {
                var Circunstancia_de_VehiculoIds = string.Join(",", filter.AdvanceCircunstancia_de_VehiculoMultiple);

                where += " AND Detalle_de_Delito.Circunstancia_de_Vehiculo In (" + Circunstancia_de_VehiculoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceClase))
            {
                switch (filter.ClaseFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especifica_Vehiculo.Descripcion LIKE '" + filter.AdvanceClase + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especifica_Vehiculo.Descripcion LIKE '%" + filter.AdvanceClase + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especifica_Vehiculo.Descripcion = '" + filter.AdvanceClase + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especifica_Vehiculo.Descripcion LIKE '%" + filter.AdvanceClase + "%'";
                        break;
                }
            }
            else if (filter.AdvanceClaseMultiple != null && filter.AdvanceClaseMultiple.Count() > 0)
            {
                var ClaseIds = string.Join(",", filter.AdvanceClaseMultiple);

                where += " AND Detalle_de_Delito.Clase In (" + ClaseIds + ")";
            }

            if (filter.Vehiculo_Robado != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Vehiculo_Robado = " + Convert.ToInt32(filter.Vehiculo_Robado);

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

                where += " AND Detalle_de_Delito.Marca In (" + MarcaIds + ")";
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

                where += " AND Detalle_de_Delito.Sub_Marca In (" + Sub_MarcaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Vehiculo))
            {
                switch (filter.Tipo_de_VehiculoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceTipo_de_Vehiculo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Vehiculo.Descripcion = '" + filter.AdvanceTipo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Vehiculo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_VehiculoMultiple != null && filter.AdvanceTipo_de_VehiculoMultiple.Count() > 0)
            {
                var Tipo_de_VehiculoIds = string.Join(",", filter.AdvanceTipo_de_VehiculoMultiple);

                where += " AND Detalle_de_Delito.Tipo_de_Vehiculo In (" + Tipo_de_VehiculoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromModelo) || !string.IsNullOrEmpty(filter.ToModelo))
            {
                if (!string.IsNullOrEmpty(filter.FromModelo))
                    where += " AND Detalle_de_Delito.Modelo >= " + filter.FromModelo;
                if (!string.IsNullOrEmpty(filter.ToModelo))
                    where += " AND Detalle_de_Delito.Modelo <= " + filter.ToModelo;
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

                where += " AND Detalle_de_Delito.Color In (" + ColorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Placas))
            {
                switch (filter.PlacasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Placas LIKE '" + filter.Placas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Placas LIKE '%" + filter.Placas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Placas = '" + filter.Placas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Placas LIKE '%" + filter.Placas + "%'";
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

                where += " AND Detalle_de_Delito.Estado_de_Origen_de_las_Placas In (" + Estado_de_Origen_de_las_PlacasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Motor))
            {
                switch (filter.Numero_de_MotorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_de_Motor LIKE '" + filter.Numero_de_Motor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_de_Motor LIKE '%" + filter.Numero_de_Motor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_de_Motor = '" + filter.Numero_de_Motor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_de_Motor LIKE '%" + filter.Numero_de_Motor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Serie))
            {
                switch (filter.Numero_de_SerieFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_de_Serie LIKE '" + filter.Numero_de_Serie + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_de_Serie LIKE '%" + filter.Numero_de_Serie + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_de_Serie = '" + filter.Numero_de_Serie + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_de_Serie LIKE '%" + filter.Numero_de_Serie + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_del_Robo))
            {
                switch (filter.Estado_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_del_RoboMultiple != null && filter.AdvanceEstado_del_RoboMultiple.Count() > 0)
            {
                var Estado_del_RoboIds = string.Join(",", filter.AdvanceEstado_del_RoboMultiple);

                where += " AND Detalle_de_Delito.Estado_del_Robo In (" + Estado_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_del_Robo))
            {
                switch (filter.Municipio_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_del_RoboMultiple != null && filter.AdvanceMunicipio_del_RoboMultiple.Count() > 0)
            {
                var Municipio_del_RoboIds = string.Join(",", filter.AdvanceMunicipio_del_RoboMultiple);

                where += " AND Detalle_de_Delito.Municipio_del_Robo In (" + Municipio_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_del_Robo))
            {
                switch (filter.Colonia_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_del_RoboMultiple != null && filter.AdvanceColonia_del_RoboMultiple.Count() > 0)
            {
                var Colonia_del_RoboIds = string.Join(",", filter.AdvanceColonia_del_RoboMultiple);

                where += " AND Detalle_de_Delito.Colonia_del_Robo In (" + Colonia_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_Robo) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_Robo))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_Robo))
                    where += " AND Detalle_de_Delito.Codigo_Postal_Robo >= " + filter.FromCodigo_Postal_Robo;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_Robo))
                    where += " AND Detalle_de_Delito.Codigo_Postal_Robo <= " + filter.ToCodigo_Postal_Robo;
            }

            if (!string.IsNullOrEmpty(filter.Calle_Robo))
            {
                switch (filter.Calle_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Calle_Robo LIKE '" + filter.Calle_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Calle_Robo LIKE '%" + filter.Calle_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Calle_Robo = '" + filter.Calle_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Calle_Robo LIKE '%" + filter.Calle_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_Robo))
            {
                switch (filter.Entre_Calle_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Entre_Calle_Robo LIKE '" + filter.Entre_Calle_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Entre_Calle_Robo LIKE '%" + filter.Entre_Calle_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Entre_Calle_Robo = '" + filter.Entre_Calle_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Entre_Calle_Robo LIKE '%" + filter.Entre_Calle_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.y_Calle_Robo))
            {
                switch (filter.y_Calle_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.y_Calle_Robo LIKE '" + filter.y_Calle_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.y_Calle_Robo LIKE '%" + filter.y_Calle_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.y_Calle_Robo = '" + filter.y_Calle_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.y_Calle_Robo LIKE '%" + filter.y_Calle_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_del_Delito_Robo))
            {
                switch (filter.Numero_Exterior_del_Delito_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito_Robo LIKE '" + filter.Numero_Exterior_del_Delito_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito_Robo LIKE '%" + filter.Numero_Exterior_del_Delito_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito_Robo = '" + filter.Numero_Exterior_del_Delito_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_Exterior_del_Delito_Robo LIKE '%" + filter.Numero_Exterior_del_Delito_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_del_Delito_Robo))
            {
                switch (filter.Numero_Interior_del_Delito_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito_Robo LIKE '" + filter.Numero_Interior_del_Delito_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito_Robo LIKE '%" + filter.Numero_Interior_del_Delito_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito_Robo = '" + filter.Numero_Interior_del_Delito_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_Interior_del_Delito_Robo LIKE '%" + filter.Numero_Interior_del_Delito_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_Robo))
            {
                switch (filter.Referencia_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Referencia_Robo LIKE '" + filter.Referencia_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Referencia_Robo LIKE '%" + filter.Referencia_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Referencia_Robo = '" + filter.Referencia_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Referencia_Robo LIKE '%" + filter.Referencia_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_Robo))
            {
                switch (filter.Latitud_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Latitud_Robo LIKE '" + filter.Latitud_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Latitud_Robo LIKE '%" + filter.Latitud_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Latitud_Robo = '" + filter.Latitud_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Latitud_Robo LIKE '%" + filter.Latitud_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_Robo))
            {
                switch (filter.Longitud_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Longitud_Robo LIKE '" + filter.Longitud_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Longitud_Robo LIKE '%" + filter.Longitud_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Longitud_Robo = '" + filter.Longitud_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Longitud_Robo LIKE '%" + filter.Longitud_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLugar_del_Robo))
            {
                switch (filter.Lugar_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion LIKE '" + filter.AdvanceLugar_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion LIKE '%" + filter.AdvanceLugar_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion = '" + filter.AdvanceLugar_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion LIKE '%" + filter.AdvanceLugar_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLugar_del_RoboMultiple != null && filter.AdvanceLugar_del_RoboMultiple.Count() > 0)
            {
                var Lugar_del_RoboIds = string.Join(",", filter.AdvanceLugar_del_RoboMultiple);

                where += " AND Detalle_de_Delito.Lugar_del_Robo In (" + Lugar_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceZona_de_Robo))
            {
                switch (filter.Zona_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Zona_de_Robo.Descripcion LIKE '" + filter.AdvanceZona_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Zona_de_Robo.Descripcion LIKE '%" + filter.AdvanceZona_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Zona_de_Robo.Descripcion = '" + filter.AdvanceZona_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Zona_de_Robo.Descripcion LIKE '%" + filter.AdvanceZona_de_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceZona_de_RoboMultiple != null && filter.AdvanceZona_de_RoboMultiple.Count() > 0)
            {
                var Zona_de_RoboIds = string.Join(",", filter.AdvanceZona_de_RoboMultiple);

                where += " AND Detalle_de_Delito.Zona_de_Robo In (" + Zona_de_RoboIds + ")";
            }

            if (filter.El_Vehiculo_esta_Asegurado != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.El_Vehiculo_esta_Asegurado = " + Convert.ToInt32(filter.El_Vehiculo_esta_Asegurado);

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

                where += " AND Detalle_de_Delito.Nombre_de_la_Aseguradora In (" + Nombre_de_la_AseguradoraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motor))
            {
                switch (filter.MotorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Motor LIKE '" + filter.Motor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Motor LIKE '%" + filter.Motor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Motor = '" + filter.Motor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Motor LIKE '%" + filter.Motor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Serie))
            {
                switch (filter.SerieFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Serie LIKE '" + filter.Serie + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Serie LIKE '%" + filter.Serie + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Serie = '" + filter.Serie + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Serie LIKE '%" + filter.Serie + "%'";
                        break;
                }
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

                where += " AND Detalle_de_Delito.Tipo_de_Servicio In (" + Tipo_de_ServicioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Ruta_del_Servicio_Publico))
            {
                switch (filter.Ruta_del_Servicio_PublicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Ruta_del_Servicio_Publico LIKE '" + filter.Ruta_del_Servicio_Publico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Ruta_del_Servicio_Publico LIKE '%" + filter.Ruta_del_Servicio_Publico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Ruta_del_Servicio_Publico = '" + filter.Ruta_del_Servicio_Publico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Ruta_del_Servicio_Publico LIKE '%" + filter.Ruta_del_Servicio_Publico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProcedencia))
            {
                switch (filter.ProcedenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Procedencia_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceProcedencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Procedencia_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceProcedencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Procedencia_del_Vehiculo.Descripcion = '" + filter.AdvanceProcedencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Procedencia_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceProcedencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProcedenciaMultiple != null && filter.AdvanceProcedenciaMultiple.Count() > 0)
            {
                var ProcedenciaIds = string.Join(",", filter.AdvanceProcedenciaMultiple);

                where += " AND Detalle_de_Delito.Procedencia In (" + ProcedenciaIds + ")";
            }

            if (filter.Mercancia != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Mercancia = " + Convert.ToInt32(filter.Mercancia);

            if (!string.IsNullOrEmpty(filter.Descripcion_de_lo_que_Transportaba))
            {
                switch (filter.Descripcion_de_lo_que_TransportabaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Descripcion_de_lo_que_Transportaba LIKE '" + filter.Descripcion_de_lo_que_Transportaba + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Descripcion_de_lo_que_Transportaba LIKE '%" + filter.Descripcion_de_lo_que_Transportaba + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Descripcion_de_lo_que_Transportaba = '" + filter.Descripcion_de_lo_que_Transportaba + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Descripcion_de_lo_que_Transportaba LIKE '%" + filter.Descripcion_de_lo_que_Transportaba + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Carga) || !string.IsNullOrEmpty(filter.ToMonto_de_la_Carga))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Carga))
                    where += " AND Detalle_de_Delito.Monto_de_la_Carga >= " + filter.FromMonto_de_la_Carga;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_la_Carga))
                    where += " AND Detalle_de_Delito.Monto_de_la_Carga <= " + filter.ToMonto_de_la_Carga;
            }

            if (!string.IsNullOrEmpty(filter.Senas_Particulares))
            {
                switch (filter.Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Senas_Particulares LIKE '" + filter.Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Senas_Particulares LIKE '%" + filter.Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Senas_Particulares = '" + filter.Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Senas_Particulares LIKE '%" + filter.Senas_Particulares + "%'";
                        break;
                }
            }

            if (filter.Cuenta_con_GPS != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Cuenta_con_GPS = " + Convert.ToInt32(filter.Cuenta_con_GPS);

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

                where += " AND Detalle_de_Delito.Tipo_de_Robo In (" + Tipo_de_RoboIds + ")";
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

                where += " AND Detalle_de_Delito.Tipo_de_Lugar_del_Robo In (" + Tipo_de_Lugar_del_RoboIds + ")";
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

                where += " AND Detalle_de_Delito.Tipo_de_Carretera In (" + Tipo_de_CarreteraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModalidad_del_Robo))
            {
                switch (filter.Modalidad_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceModalidad_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceModalidad_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion = '" + filter.AdvanceModalidad_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceModalidad_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModalidad_del_RoboMultiple != null && filter.AdvanceModalidad_del_RoboMultiple.Count() > 0)
            {
                var Modalidad_del_RoboIds = string.Join(",", filter.AdvanceModalidad_del_RoboMultiple);

                where += " AND Detalle_de_Delito.Modalidad_del_Robo In (" + Modalidad_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Causa_de_Muerte))
            {
                switch (filter.Causa_de_MuerteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Causa_de_Muerte LIKE '" + filter.Causa_de_Muerte + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Causa_de_Muerte LIKE '%" + filter.Causa_de_Muerte + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Causa_de_Muerte = '" + filter.Causa_de_Muerte + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Causa_de_Muerte LIKE '%" + filter.Causa_de_Muerte + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstancia_Defuncion))
            {
                switch (filter.Circunstancia_DefuncionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_Defuncion.Descripcion LIKE '" + filter.AdvanceCircunstancia_Defuncion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_Defuncion.Descripcion LIKE '%" + filter.AdvanceCircunstancia_Defuncion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_Defuncion.Descripcion = '" + filter.AdvanceCircunstancia_Defuncion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_Defuncion.Descripcion LIKE '%" + filter.AdvanceCircunstancia_Defuncion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstancia_DefuncionMultiple != null && filter.AdvanceCircunstancia_DefuncionMultiple.Count() > 0)
            {
                var Circunstancia_DefuncionIds = string.Join(",", filter.AdvanceCircunstancia_DefuncionMultiple);

                where += " AND Detalle_de_Delito.Circunstancia_Defuncion In (" + Circunstancia_DefuncionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceConsecuencia_Defuncion))
            {
                switch (filter.Consecuencia_DefuncionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '" + filter.AdvanceConsecuencia_Defuncion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '%" + filter.AdvanceConsecuencia_Defuncion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Consecuencia_Defuncion.Descripcion = '" + filter.AdvanceConsecuencia_Defuncion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '%" + filter.AdvanceConsecuencia_Defuncion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceConsecuencia_DefuncionMultiple != null && filter.AdvanceConsecuencia_DefuncionMultiple.Count() > 0)
            {
                var Consecuencia_DefuncionIds = string.Join(",", filter.AdvanceConsecuencia_DefuncionMultiple);

                where += " AND Detalle_de_Delito.Consecuencia_Defuncion In (" + Consecuencia_DefuncionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Levantamiento) || !string.IsNullOrEmpty(filter.ToFecha_Levantamiento))
            {
                var Fecha_LevantamientoFrom = DateTime.ParseExact(filter.FromFecha_Levantamiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_LevantamientoTo = DateTime.ParseExact(filter.ToFecha_Levantamiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Levantamiento))
                    where += " AND Detalle_de_Delito.Fecha_Levantamiento >= '" + Fecha_LevantamientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Levantamiento))
                    where += " AND Detalle_de_Delito.Fecha_Levantamiento <= '" + Fecha_LevantamientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Levantamiento) || !string.IsNullOrEmpty(filter.ToHora_Levantamiento))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Levantamiento))
                    where += " AND Convert(TIME,Detalle_de_Delito.Hora_Levantamiento) >='" + filter.FromHora_Levantamiento + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Levantamiento))
                    where += " AND Convert(TIME,Detalle_de_Delito.Hora_Levantamiento) <='" + filter.ToHora_Levantamiento + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Lugar_del_Hecho))
            {
                switch (filter.Tipo_de_Lugar_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceTipo_de_Lugar_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceTipo_de_Lugar_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Lugar_del_HechoMultiple != null && filter.AdvanceTipo_de_Lugar_del_HechoMultiple.Count() > 0)
            {
                var Tipo_de_Lugar_del_HechoIds = string.Join(",", filter.AdvanceTipo_de_Lugar_del_HechoMultiple);

                where += " AND Detalle_de_Delito.Tipo_de_Lugar_del_Hecho In (" + Tipo_de_Lugar_del_HechoIds + ")";
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

                where += " AND Detalle_de_Delito.Pais In (" + PaisIds + ")";
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

                where += " AND Detalle_de_Delito.Estado In (" + EstadoIds + ")";
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

                where += " AND Detalle_de_Delito.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Detalle_de_Delito.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Colonia_no_Catalogada))
            {
                switch (filter.Colonia_no_CatalogadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Colonia_no_Catalogada LIKE '" + filter.Colonia_no_Catalogada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Colonia_no_Catalogada LIKE '%" + filter.Colonia_no_Catalogada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Colonia_no_Catalogada = '" + filter.Colonia_no_Catalogada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Colonia_no_Catalogada LIKE '%" + filter.Colonia_no_Catalogada + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior) || !string.IsNullOrEmpty(filter.ToNumero_Exterior))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior))
                    where += " AND Detalle_de_Delito.Numero_Exterior >= " + filter.FromNumero_Exterior;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior))
                    where += " AND Detalle_de_Delito.Numero_Exterior <= " + filter.ToNumero_Exterior;
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Necropsia))
            {
                switch (filter.NecropsiaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Necropsia LIKE '" + filter.Necropsia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Necropsia LIKE '%" + filter.Necropsia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Necropsia = '" + filter.Necropsia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Necropsia LIKE '%" + filter.Necropsia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Cronotanatodiagnostico))
            {
                switch (filter.CronotanatodiagnosticoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Cronotanatodiagnostico LIKE '" + filter.Cronotanatodiagnostico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Cronotanatodiagnostico LIKE '%" + filter.Cronotanatodiagnostico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Cronotanatodiagnostico = '" + filter.Cronotanatodiagnostico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Cronotanatodiagnostico LIKE '%" + filter.Cronotanatodiagnostico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Ruta))
            {
                switch (filter.RutaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito.Ruta LIKE '" + filter.Ruta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito.Ruta LIKE '%" + filter.Ruta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito.Ruta = '" + filter.Ruta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito.Ruta LIKE '%" + filter.Ruta + "%'";
                        break;
                }
            }

            if (filter.Estado_del_Conductor != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Estado_del_Conductor = " + Convert.ToInt32(filter.Estado_del_Conductor);

            if (filter.Persona_Moral_Dueno != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Persona_Moral_Dueno = " + Convert.ToInt32(filter.Persona_Moral_Dueno);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre LIKE '" + filter.AdvanceNombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre LIKE '%" + filter.AdvanceNombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Nombre = '" + filter.AdvanceNombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Nombre LIKE '%" + filter.AdvanceNombre_Completo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_CompletoMultiple != null && filter.AdvanceNombre_CompletoMultiple.Count() > 0)
            {
                var Nombre_CompletoIds = string.Join(",", filter.AdvanceNombre_CompletoMultiple);

                where += " AND Detalle_de_Delito.Nombre_Completo In (" + Nombre_CompletoIds + ")";
            }

            if (filter.Persona_Fisica_Dueno != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Persona_Fisica_Dueno = " + Convert.ToInt32(filter.Persona_Fisica_Dueno);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo_Involucrado))
            {
                switch (filter.Nombre_Completo_InvolucradoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '" + filter.AdvanceNombre_Completo_Involucrado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '%" + filter.AdvanceNombre_Completo_Involucrado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor = '" + filter.AdvanceNombre_Completo_Involucrado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '%" + filter.AdvanceNombre_Completo_Involucrado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_Completo_InvolucradoMultiple != null && filter.AdvanceNombre_Completo_InvolucradoMultiple.Count() > 0)
            {
                var Nombre_Completo_InvolucradoIds = string.Join(",", filter.AdvanceNombre_Completo_InvolucradoMultiple);

                where += " AND Detalle_de_Delito.Nombre_Completo_Involucrado In (" + Nombre_Completo_InvolucradoIds + ")";
            }

            if (filter.Denunciante_dueno != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito.Denunciante_dueno = " + Convert.ToInt32(filter.Denunciante_dueno);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo_Dueno))
            {
                switch (filter.Nombre_Completo_DuenoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '" + filter.AdvanceNombre_Completo_Dueno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '%" + filter.AdvanceNombre_Completo_Dueno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor = '" + filter.AdvanceNombre_Completo_Dueno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '%" + filter.AdvanceNombre_Completo_Dueno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_Completo_DuenoMultiple != null && filter.AdvanceNombre_Completo_DuenoMultiple.Count() > 0)
            {
                var Nombre_Completo_DuenoIds = string.Join(",", filter.AdvanceNombre_Completo_DuenoMultiple);

                where += " AND Detalle_de_Delito.Nombre_Completo_Dueno In (" + Nombre_Completo_DuenoIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetAgravantes_del_Delito(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Agravantes_del_DelitoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IAgravantes_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Agravantes_del_Delito.Folio_Agravante=" + RelationId;
            if("int" == "string")
            {
	           where = "Agravantes_del_Delito.Folio_Agravante='" + RelationId + "'";
            }
            var result = _IAgravantes_del_DelitoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Agravantes_del_Delitos == null)
                result.Agravantes_del_Delitos = new List<Agravantes_del_Delito>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Agravantes_del_Delitos.Select(m => new Agravantes_del_DelitoGridModel
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
        public List<Agravantes_del_DelitoGridModel> GetAgravantes_del_DelitoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Agravantes_del_DelitoGridModel> resultData = new List<Agravantes_del_DelitoGridModel>();
            string where = "Agravantes_del_Delito.Folio_Agravante=" + Id;
            if("int" == "string")
            {
                where = "Agravantes_del_Delito.Folio_Agravante='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IAgravantes_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IAgravantes_del_DelitoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Agravantes_del_Delitos != null)
            {
                resultData = result.Agravantes_del_Delitos.Select(m => new Agravantes_del_DelitoGridModel
                    {
                        Clave = m.Clave

                        ,Agravante = m.Agravante
                        ,AgravanteDescripcion = CultureHelper.GetTraduction(m.Agravante_Agravantes.Clave.ToString(), "Descripcion") ??(string)m.Agravante_Agravantes.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetCircunstancias_del_Delito(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Circunstancias_del_DelitoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ICircunstancias_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Circunstancias_del_Delito.Folio_Circunstacias=" + RelationId;
            if("int" == "string")
            {
	           where = "Circunstancias_del_Delito.Folio_Circunstacias='" + RelationId + "'";
            }
            var result = _ICircunstancias_del_DelitoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Circunstancias_del_Delitos == null)
                result.Circunstancias_del_Delitos = new List<Circunstancias_del_Delito>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Circunstancias_del_Delitos.Select(m => new Circunstancias_del_DelitoGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Lugar = m.Tipo_de_Lugar
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_Tipo_de_Lugar_del_Robo.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Circunstancias_del_DelitoGridModel> GetCircunstancias_del_DelitoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Circunstancias_del_DelitoGridModel> resultData = new List<Circunstancias_del_DelitoGridModel>();
            string where = "Circunstancias_del_Delito.Folio_Circunstacias=" + Id;
            if("int" == "string")
            {
                where = "Circunstancias_del_Delito.Folio_Circunstacias='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ICircunstancias_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ICircunstancias_del_DelitoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Circunstancias_del_Delitos != null)
            {
                resultData = result.Circunstancias_del_Delitos.Select(m => new Circunstancias_del_DelitoGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Lugar = m.Tipo_de_Lugar
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_Tipo_de_Lugar_del_Robo.Descripcion


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
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Delito varDetalle_de_Delito = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IAgravantes_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Agravantes_del_Delito.Folio_Agravante=" + id;
                    if("int" == "string")
                    {
	                where = "Agravantes_del_Delito.Folio_Agravante='" + id + "'";
                    }
                    var Agravantes_del_DelitoInfo =
                        _IAgravantes_del_DelitoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Agravantes_del_DelitoInfo.Agravantes_del_Delitos.Count > 0)
                    {
                        var resultAgravantes_del_Delito = true;
                        //Removing associated job history with attachment
                        foreach (var Agravantes_del_DelitoItem in Agravantes_del_DelitoInfo.Agravantes_del_Delitos)
                            resultAgravantes_del_Delito = resultAgravantes_del_Delito
                                              && _IAgravantes_del_DelitoApiConsumer.Delete(Agravantes_del_DelitoItem.Clave, null,null).Resource;

                        if (!resultAgravantes_del_Delito)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ICircunstancias_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Circunstancias_del_Delito.Folio_Circunstacias=" + id;
                    if("int" == "string")
                    {
	                where = "Circunstancias_del_Delito.Folio_Circunstacias='" + id + "'";
                    }
                    var Circunstancias_del_DelitoInfo =
                        _ICircunstancias_del_DelitoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Circunstancias_del_DelitoInfo.Circunstancias_del_Delitos.Count > 0)
                    {
                        var resultCircunstancias_del_Delito = true;
                        //Removing associated job history with attachment
                        foreach (var Circunstancias_del_DelitoItem in Circunstancias_del_DelitoInfo.Circunstancias_del_Delitos)
                            resultCircunstancias_del_Delito = resultCircunstancias_del_Delito
                                              && _ICircunstancias_del_DelitoApiConsumer.Delete(Circunstancias_del_DelitoItem.Clave, null,null).Resource;

                        if (!resultCircunstancias_del_Delito)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_DelitoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_DelitoModel varDetalle_de_Delito)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_DelitoInfo = new Detalle_de_Delito
                    {
                        Clave = varDetalle_de_Delito.Clave
                        ,Descripcion_corta = varDetalle_de_Delito.Descripcion_corta
                        ,Robo_de_Vehiculo = varDetalle_de_Delito.Robo_de_Vehiculo
                        ,Expediente_Inicial = varDetalle_de_Delito.Expediente_Inicial
                        ,Expediente_MP = varDetalle_de_Delito.Expediente_MP
                        ,Expediente_MASC = varDetalle_de_Delito.Expediente_MASC
                        ,Tipo_de_Denuncia = varDetalle_de_Delito.Tipo_de_Denuncia
                        ,Fecha_del_Delito = (!String.IsNullOrEmpty(varDetalle_de_Delito.Fecha_del_Delito)) ? DateTime.ParseExact(varDetalle_de_Delito.Fecha_del_Delito, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Delito = varDetalle_de_Delito.Hora_del_Delito
                        ,Violencia_de_Genero = varDetalle_de_Delito.Violencia_de_Genero
                        ,Delito_Violencia_Genero = varDetalle_de_Delito.Delito_Violencia_Genero
                        ,Tipo_de_Delito = varDetalle_de_Delito.Tipo_de_Delito
                        ,Titulo_del_Delito = varDetalle_de_Delito.Titulo_del_Delito
                        ,Grupo_Delito = varDetalle_de_Delito.Grupo_Delito
                        ,Delito = varDetalle_de_Delito.Delito
                        ,Agravante = varDetalle_de_Delito.Agravante
                        ,Circunstancia_Delito = varDetalle_de_Delito.Circunstancia_Delito
                        ,Articulado_de_Delito = varDetalle_de_Delito.Articulado_de_Delito
                        ,Delito_Principal = varDetalle_de_Delito.Delito_Principal
                        ,Forma_Comision_Delito = varDetalle_de_Delito.Forma_Comision_Delito
                        ,Forma_Accion_Delito = varDetalle_de_Delito.Forma_Accion_Delito
                        ,Modalidad_Delito = varDetalle_de_Delito.Modalidad_Delito
                        ,Elementos_Comision_Delito = varDetalle_de_Delito.Elementos_Comision_Delito
                        ,Clasificacion_con_Orden_de_Resultado = varDetalle_de_Delito.Clasificacion_con_Orden_de_Resultado
                        ,Concurso = varDetalle_de_Delito.Concurso
                        ,Monto = varDetalle_de_Delito.Monto
                        ,Estado_del_Delito = varDetalle_de_Delito.Estado_del_Delito
                        ,Municipio_del_Delito = varDetalle_de_Delito.Municipio_del_Delito
                        ,Colonia_del_Delito = varDetalle_de_Delito.Colonia_del_Delito
                        ,Codigo_Postal = varDetalle_de_Delito.Codigo_Postal
                        ,Calle = varDetalle_de_Delito.Calle
                        ,Entre_Calle = varDetalle_de_Delito.Entre_Calle
                        ,y_Calle = varDetalle_de_Delito.y_Calle
                        ,Numero_Exterior_del_Delito = varDetalle_de_Delito.Numero_Exterior_del_Delito
                        ,Numero_Interior_del_Delito = varDetalle_de_Delito.Numero_Interior_del_Delito
                        ,Referencia = varDetalle_de_Delito.Referencia
                        ,Latitud = varDetalle_de_Delito.Latitud
                        ,Longitud = varDetalle_de_Delito.Longitud
                        ,Puede_Ser_Canalizado_a_JA = varDetalle_de_Delito.Puede_Ser_Canalizado_a_JA
                        ,Motivo_de_no_canalizacion = varDetalle_de_Delito.Motivo_de_no_canalizacion
                        ,Se_Informaron_sus_Derechos = varDetalle_de_Delito.Se_Informaron_sus_Derechos
                        ,Se_Informo_el_Procedimiento = varDetalle_de_Delito.Se_Informo_el_Procedimiento
                        ,Levantamiento_de_Cadaver = varDetalle_de_Delito.Levantamiento_de_Cadaver
                        ,Mandamiento_Judicial = varDetalle_de_Delito.Mandamiento_Judicial
                        ,Fecha_del_Robo = (!String.IsNullOrEmpty(varDetalle_de_Delito.Fecha_del_Robo)) ? DateTime.ParseExact(varDetalle_de_Delito.Fecha_del_Robo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Robo = varDetalle_de_Delito.Hora_del_Robo
                        ,Robo_de = varDetalle_de_Delito.Robo_de
                        ,Registro_Federal_Vehicular = varDetalle_de_Delito.Registro_Federal_Vehicular
                        ,Numero_de_Registro_Publico_Vehicular = varDetalle_de_Delito.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Vehiculo = varDetalle_de_Delito.Circunstancia_de_Vehiculo
                        ,Clase = varDetalle_de_Delito.Clase
                        ,Vehiculo_Robado = varDetalle_de_Delito.Vehiculo_Robado
                        ,Marca = varDetalle_de_Delito.Marca
                        ,Sub_Marca = varDetalle_de_Delito.Sub_Marca
                        ,Tipo_de_Vehiculo = varDetalle_de_Delito.Tipo_de_Vehiculo
                        ,Modelo = varDetalle_de_Delito.Modelo
                        ,Color = varDetalle_de_Delito.Color
                        ,Placas = varDetalle_de_Delito.Placas
                        ,Estado_de_Origen_de_las_Placas = varDetalle_de_Delito.Estado_de_Origen_de_las_Placas
                        ,Numero_de_Motor = varDetalle_de_Delito.Numero_de_Motor
                        ,Numero_de_Serie = varDetalle_de_Delito.Numero_de_Serie
                        ,Estado_del_Robo = varDetalle_de_Delito.Estado_del_Robo
                        ,Municipio_del_Robo = varDetalle_de_Delito.Municipio_del_Robo
                        ,Colonia_del_Robo = varDetalle_de_Delito.Colonia_del_Robo
                        ,Codigo_Postal_Robo = varDetalle_de_Delito.Codigo_Postal_Robo
                        ,Calle_Robo = varDetalle_de_Delito.Calle_Robo
                        ,Entre_Calle_Robo = varDetalle_de_Delito.Entre_Calle_Robo
                        ,y_Calle_Robo = varDetalle_de_Delito.y_Calle_Robo
                        ,Numero_Exterior_del_Delito_Robo = varDetalle_de_Delito.Numero_Exterior_del_Delito_Robo
                        ,Numero_Interior_del_Delito_Robo = varDetalle_de_Delito.Numero_Interior_del_Delito_Robo
                        ,Referencia_Robo = varDetalle_de_Delito.Referencia_Robo
                        ,Latitud_Robo = varDetalle_de_Delito.Latitud_Robo
                        ,Longitud_Robo = varDetalle_de_Delito.Longitud_Robo
                        ,Lugar_del_Robo = varDetalle_de_Delito.Lugar_del_Robo
                        ,Zona_de_Robo = varDetalle_de_Delito.Zona_de_Robo
                        ,El_Vehiculo_esta_Asegurado = varDetalle_de_Delito.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_Aseguradora = varDetalle_de_Delito.Nombre_de_la_Aseguradora
                        ,Motor = varDetalle_de_Delito.Motor
                        ,Serie = varDetalle_de_Delito.Serie
                        ,Tipo_de_Servicio = varDetalle_de_Delito.Tipo_de_Servicio
                        ,Ruta_del_Servicio_Publico = varDetalle_de_Delito.Ruta_del_Servicio_Publico
                        ,Procedencia = varDetalle_de_Delito.Procedencia
                        ,Mercancia = varDetalle_de_Delito.Mercancia
                        ,Descripcion_de_lo_que_Transportaba = varDetalle_de_Delito.Descripcion_de_lo_que_Transportaba
                        ,Monto_de_la_Carga = varDetalle_de_Delito.Monto_de_la_Carga
                        ,Senas_Particulares = varDetalle_de_Delito.Senas_Particulares
                        ,Cuenta_con_GPS = varDetalle_de_Delito.Cuenta_con_GPS
                        ,Tipo_de_Robo = varDetalle_de_Delito.Tipo_de_Robo
                        ,Tipo_de_Lugar_del_Robo = varDetalle_de_Delito.Tipo_de_Lugar_del_Robo
                        ,Tipo_de_Carretera = varDetalle_de_Delito.Tipo_de_Carretera
                        ,Modalidad_del_Robo = varDetalle_de_Delito.Modalidad_del_Robo
                        ,Causa_de_Muerte = varDetalle_de_Delito.Causa_de_Muerte
                        ,Circunstancia_Defuncion = varDetalle_de_Delito.Circunstancia_Defuncion
                        ,Consecuencia_Defuncion = varDetalle_de_Delito.Consecuencia_Defuncion
                        ,Fecha_Levantamiento = (!String.IsNullOrEmpty(varDetalle_de_Delito.Fecha_Levantamiento)) ? DateTime.ParseExact(varDetalle_de_Delito.Fecha_Levantamiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Levantamiento = varDetalle_de_Delito.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_Hecho = varDetalle_de_Delito.Tipo_de_Lugar_del_Hecho
                        ,Pais = varDetalle_de_Delito.Pais
                        ,Estado = varDetalle_de_Delito.Estado
                        ,Municipio = varDetalle_de_Delito.Municipio
                        ,Colonia = varDetalle_de_Delito.Colonia
                        ,Colonia_no_Catalogada = varDetalle_de_Delito.Colonia_no_Catalogada
                        ,Numero_Exterior = varDetalle_de_Delito.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Delito.Numero_Interior
                        ,Necropsia = varDetalle_de_Delito.Necropsia
                        ,Cronotanatodiagnostico = varDetalle_de_Delito.Cronotanatodiagnostico
                        ,Ruta = varDetalle_de_Delito.Ruta
                        ,Estado_del_Conductor = varDetalle_de_Delito.Estado_del_Conductor
                        ,Persona_Moral_Dueno = varDetalle_de_Delito.Persona_Moral_Dueno
                        ,Nombre_Completo = varDetalle_de_Delito.Nombre_Completo
                        ,Persona_Fisica_Dueno = varDetalle_de_Delito.Persona_Fisica_Dueno
                        ,Nombre_Completo_Involucrado = varDetalle_de_Delito.Nombre_Completo_Involucrado
                        ,Denunciante_dueno = varDetalle_de_Delito.Denunciante_dueno
                        ,Nombre_Completo_Dueno = varDetalle_de_Delito.Nombre_Completo_Dueno

                    };

                    result = !IsNew ?
                        _IDetalle_de_DelitoApiConsumer.Update(Detalle_de_DelitoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_DelitoApiConsumer.Insert(Detalle_de_DelitoInfo, null, null).Resource.ToString();
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
        public bool CopyAgravantes_del_Delito(int MasterId, int referenceId, List<Agravantes_del_DelitoGridModelPost> Agravantes_del_DelitoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IAgravantes_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Agravantes_del_DelitoData = _IAgravantes_del_DelitoApiConsumer.ListaSelAll(1, int.MaxValue, "Agravantes_del_Delito.Folio_Agravante=" + referenceId,"").Resource;
                if (Agravantes_del_DelitoData == null || Agravantes_del_DelitoData.Agravantes_del_Delitos.Count == 0)
                    return true;

                var result = true;

                Agravantes_del_DelitoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varAgravantes_del_Delito in Agravantes_del_DelitoData.Agravantes_del_Delitos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Agravantes_del_Delito Agravantes_del_Delito1 = varAgravantes_del_Delito;

                    if (Agravantes_del_DelitoItems != null && Agravantes_del_DelitoItems.Any(m => m.Clave == Agravantes_del_Delito1.Clave))
                    {
                        modelDataToChange = Agravantes_del_DelitoItems.FirstOrDefault(m => m.Clave == Agravantes_del_Delito1.Clave);
                    }
                    //Chaning Id Value
                    varAgravantes_del_Delito.Folio_Agravante = MasterId;
                    var insertId = _IAgravantes_del_DelitoApiConsumer.Insert(varAgravantes_del_Delito,null,null).Resource;
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
        public ActionResult PostAgravantes_del_Delito(List<Agravantes_del_DelitoGridModelPost> Agravantes_del_DelitoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyAgravantes_del_Delito(MasterId, referenceId, Agravantes_del_DelitoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Agravantes_del_DelitoItems != null && Agravantes_del_DelitoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IAgravantes_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Agravantes_del_DelitoItem in Agravantes_del_DelitoItems)
                    {



                        //Removal Request
                        if (Agravantes_del_DelitoItem.Removed)
                        {
                            result = result && _IAgravantes_del_DelitoApiConsumer.Delete(Agravantes_del_DelitoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Agravantes_del_DelitoItem.Clave = 0;

                        var Agravantes_del_DelitoData = new Agravantes_del_Delito
                        {
                            Folio_Agravante = MasterId
                            ,Clave = Agravantes_del_DelitoItem.Clave
                            ,Agravante = (Convert.ToInt32(Agravantes_del_DelitoItem.Agravante) == 0 ? (Int32?)null : Convert.ToInt32(Agravantes_del_DelitoItem.Agravante))

                        };

                        var resultId = Agravantes_del_DelitoItem.Clave > 0
                           ? _IAgravantes_del_DelitoApiConsumer.Update(Agravantes_del_DelitoData,null,null).Resource
                           : _IAgravantes_del_DelitoApiConsumer.Insert(Agravantes_del_DelitoData,null,null).Resource;

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
        public ActionResult GetAgravantes_del_Delito_AgravantesAll()
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
        public bool CopyCircunstancias_del_Delito(int MasterId, int referenceId, List<Circunstancias_del_DelitoGridModelPost> Circunstancias_del_DelitoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ICircunstancias_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Circunstancias_del_DelitoData = _ICircunstancias_del_DelitoApiConsumer.ListaSelAll(1, int.MaxValue, "Circunstancias_del_Delito.Folio_Circunstacias=" + referenceId,"").Resource;
                if (Circunstancias_del_DelitoData == null || Circunstancias_del_DelitoData.Circunstancias_del_Delitos.Count == 0)
                    return true;

                var result = true;

                Circunstancias_del_DelitoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varCircunstancias_del_Delito in Circunstancias_del_DelitoData.Circunstancias_del_Delitos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Circunstancias_del_Delito Circunstancias_del_Delito1 = varCircunstancias_del_Delito;

                    if (Circunstancias_del_DelitoItems != null && Circunstancias_del_DelitoItems.Any(m => m.Clave == Circunstancias_del_Delito1.Clave))
                    {
                        modelDataToChange = Circunstancias_del_DelitoItems.FirstOrDefault(m => m.Clave == Circunstancias_del_Delito1.Clave);
                    }
                    //Chaning Id Value
                    varCircunstancias_del_Delito.Folio_Circunstacias = MasterId;
                    var insertId = _ICircunstancias_del_DelitoApiConsumer.Insert(varCircunstancias_del_Delito,null,null).Resource;
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
        public ActionResult PostCircunstancias_del_Delito(List<Circunstancias_del_DelitoGridModelPost> Circunstancias_del_DelitoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyCircunstancias_del_Delito(MasterId, referenceId, Circunstancias_del_DelitoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Circunstancias_del_DelitoItems != null && Circunstancias_del_DelitoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ICircunstancias_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Circunstancias_del_DelitoItem in Circunstancias_del_DelitoItems)
                    {



                        //Removal Request
                        if (Circunstancias_del_DelitoItem.Removed)
                        {
                            result = result && _ICircunstancias_del_DelitoApiConsumer.Delete(Circunstancias_del_DelitoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Circunstancias_del_DelitoItem.Clave = 0;

                        var Circunstancias_del_DelitoData = new Circunstancias_del_Delito
                        {
                            Folio_Circunstacias = MasterId
                            ,Clave = Circunstancias_del_DelitoItem.Clave
                            ,Tipo_de_Lugar = (Convert.ToInt32(Circunstancias_del_DelitoItem.Tipo_de_Lugar) == 0 ? (Int32?)null : Convert.ToInt32(Circunstancias_del_DelitoItem.Tipo_de_Lugar))

                        };

                        var resultId = Circunstancias_del_DelitoItem.Clave > 0
                           ? _ICircunstancias_del_DelitoApiConsumer.Update(Circunstancias_del_DelitoData,null,null).Resource
                           : _ICircunstancias_del_DelitoApiConsumer.Insert(Circunstancias_del_DelitoData,null,null).Resource;

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
        public ActionResult GetCircunstancias_del_Delito_Tipo_de_Lugar_del_RoboAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion");
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
        /// Write Element Array of Detalle_de_Delito script
        /// </summary>
        /// <param name="oDetalle_de_DelitoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_DelitoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_DelitoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_DelitoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_DelitoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_DelitoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_DelitoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_DelitoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito.js")))
            {
                strDetalle_de_DelitoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Delito element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_DelitoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_DelitoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_DelitoScript.Substring(indexOfArray, strDetalle_de_DelitoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_DelitoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_DelitoScript.Substring(indexOfArrayHistory, strDetalle_de_DelitoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_DelitoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_DelitoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_DelitoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_DelitoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito.js")))
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
        public ActionResult Detalle_de_DelitoPropertyBag()
        {
            return PartialView("Detalle_de_DelitoPropertyBag", "Detalle_de_Delito");
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
        public ActionResult AddAgravantes_del_Delito(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Agravantes_del_Delito/AddAgravantes_del_Delito");
        }

        [HttpGet]
        public ActionResult AddCircunstancias_del_Delito(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Circunstancias_del_Delito/AddCircunstancias_del_Delito");
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
                var whereClauseFormat = "Object = 45078 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Delito.Clave= " + RecordId;
                            var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_DelitoPropertyMapper());
			
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
                    (Detalle_de_DelitoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_DelitoPropertyMapper oDetalle_de_DelitoPropertyMapper = new Detalle_de_DelitoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_DelitoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delitos == null)
                result.Detalle_de_Delitos = new List<Detalle_de_Delito>();

            var data = result.Detalle_de_Delitos.Select(m => new Detalle_de_DelitoGridModel
            {
                Clave = m.Clave
			,Descripcion_corta = m.Descripcion_corta
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Expediente_InicialNUAT = CultureHelper.GetTraduction(m.Expediente_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Formato_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                        ,Fecha_del_Delito = (m.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Delito = m.Hora_del_Delito
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Titulo_del_Delito") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Grupo_del_Delito") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
			,Agravante = m.Agravante
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Articulado_de_Delito = m.Articulado_de_Delito
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto = m.Monto
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                        ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
			,Se_Informaron_sus_Derechos = m.Se_Informaron_sus_Derechos
			,Se_Informo_el_Procedimiento = m.Se_Informo_el_Procedimiento
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Numero_de_Motor = m.Numero_de_Motor
			,Numero_de_Serie = m.Numero_de_Serie
                        ,Estado_del_RoboNombre = CultureHelper.GetTraduction(m.Estado_del_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Robo_Estado.Nombre
                        ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(m.Municipio_del_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Robo_Municipio.Nombre
                        ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(m.Colonia_del_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Robo_Colonia.Nombre
			,Codigo_Postal_Robo = m.Codigo_Postal_Robo
			,Calle_Robo = m.Calle_Robo
			,Entre_Calle_Robo = m.Entre_Calle_Robo
			,y_Calle_Robo = m.y_Calle_Robo
			,Numero_Exterior_del_Delito_Robo = m.Numero_Exterior_del_Delito_Robo
			,Numero_Interior_del_Delito_Robo = m.Numero_Interior_del_Delito_Robo
			,Referencia_Robo = m.Referencia_Robo
			,Latitud_Robo = m.Latitud_Robo
			,Longitud_Robo = m.Longitud_Robo
                        ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(m.Zona_de_Robo_Zona_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_Robo_Zona_de_Robo.Descripcion
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
			,Cuenta_con_GPS = m.Cuenta_con_GPS
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Persona_Moral_Dueno = m.Persona_Moral_Dueno
                        ,Nombre_CompletoNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Persona_Moral.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
			,Persona_Fisica_Dueno = m.Persona_Fisica_Dueno
                        ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
			,Denunciante_dueno = m.Denunciante_dueno
                        ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45078, arrayColumnsVisible), "Detalle_de_DelitoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45078, arrayColumnsVisible), "Detalle_de_DelitoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45078, arrayColumnsVisible), "Detalle_de_DelitoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_DelitoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_DelitoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_DelitoPropertyMapper oDetalle_de_DelitoPropertyMapper = new Detalle_de_DelitoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_DelitoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delitos == null)
                result.Detalle_de_Delitos = new List<Detalle_de_Delito>();

            var data = result.Detalle_de_Delitos.Select(m => new Detalle_de_DelitoGridModel
            {
                Clave = m.Clave
			,Descripcion_corta = m.Descripcion_corta
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Expediente_InicialNUAT = CultureHelper.GetTraduction(m.Expediente_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Formato_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                        ,Fecha_del_Delito = (m.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Delito = m.Hora_del_Delito
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Titulo_del_Delito") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Grupo_del_Delito") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
			,Agravante = m.Agravante
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Articulado_de_Delito = m.Articulado_de_Delito
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto = m.Monto
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                        ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
			,Se_Informaron_sus_Derechos = m.Se_Informaron_sus_Derechos
			,Se_Informo_el_Procedimiento = m.Se_Informo_el_Procedimiento
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Numero_de_Motor = m.Numero_de_Motor
			,Numero_de_Serie = m.Numero_de_Serie
                        ,Estado_del_RoboNombre = CultureHelper.GetTraduction(m.Estado_del_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Robo_Estado.Nombre
                        ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(m.Municipio_del_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Robo_Municipio.Nombre
                        ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(m.Colonia_del_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Robo_Colonia.Nombre
			,Codigo_Postal_Robo = m.Codigo_Postal_Robo
			,Calle_Robo = m.Calle_Robo
			,Entre_Calle_Robo = m.Entre_Calle_Robo
			,y_Calle_Robo = m.y_Calle_Robo
			,Numero_Exterior_del_Delito_Robo = m.Numero_Exterior_del_Delito_Robo
			,Numero_Interior_del_Delito_Robo = m.Numero_Interior_del_Delito_Robo
			,Referencia_Robo = m.Referencia_Robo
			,Latitud_Robo = m.Latitud_Robo
			,Longitud_Robo = m.Longitud_Robo
                        ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(m.Zona_de_Robo_Zona_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_Robo_Zona_de_Robo.Descripcion
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
			,Cuenta_con_GPS = m.Cuenta_con_GPS
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Persona_Moral_Dueno = m.Persona_Moral_Dueno
                        ,Nombre_CompletoNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Persona_Moral.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
			,Persona_Fisica_Dueno = m.Persona_Fisica_Dueno
                        ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
			,Denunciante_dueno = m.Denunciante_dueno
                        ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

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
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_DelitoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Delito_Datos_GeneralesModel varDetalle_de_Delito)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_Datos_GeneralesInfo = new Detalle_de_Delito_Datos_Generales
                {
                    Clave = varDetalle_de_Delito.Clave
                                            ,Descripcion_corta = varDetalle_de_Delito.Descripcion_corta
                        ,Robo_de_Vehiculo = varDetalle_de_Delito.Robo_de_Vehiculo
                        ,Expediente_Inicial = varDetalle_de_Delito.Expediente_Inicial
                        ,Expediente_MP = varDetalle_de_Delito.Expediente_MP
                        ,Expediente_MASC = varDetalle_de_Delito.Expediente_MASC
                        ,Tipo_de_Denuncia = varDetalle_de_Delito.Tipo_de_Denuncia
                        ,Fecha_del_Delito = (!String.IsNullOrEmpty(varDetalle_de_Delito.Fecha_del_Delito)) ? DateTime.ParseExact(varDetalle_de_Delito.Fecha_del_Delito, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Delito = varDetalle_de_Delito.Hora_del_Delito
                        ,Violencia_de_Genero = varDetalle_de_Delito.Violencia_de_Genero
                        ,Delito_Violencia_Genero = varDetalle_de_Delito.Delito_Violencia_Genero
                        ,Tipo_de_Delito = varDetalle_de_Delito.Tipo_de_Delito
                        ,Titulo_del_Delito = varDetalle_de_Delito.Titulo_del_Delito
                        ,Grupo_Delito = varDetalle_de_Delito.Grupo_Delito
                        ,Delito = varDetalle_de_Delito.Delito
                        ,Agravante = varDetalle_de_Delito.Agravante
                        ,Circunstancia_Delito = varDetalle_de_Delito.Circunstancia_Delito
                        ,Articulado_de_Delito = varDetalle_de_Delito.Articulado_de_Delito
                        ,Delito_Principal = varDetalle_de_Delito.Delito_Principal
                        ,Forma_Comision_Delito = varDetalle_de_Delito.Forma_Comision_Delito
                        ,Forma_Accion_Delito = varDetalle_de_Delito.Forma_Accion_Delito
                        ,Modalidad_Delito = varDetalle_de_Delito.Modalidad_Delito
                        ,Elementos_Comision_Delito = varDetalle_de_Delito.Elementos_Comision_Delito
                        ,Clasificacion_con_Orden_de_Resultado = varDetalle_de_Delito.Clasificacion_con_Orden_de_Resultado
                        ,Concurso = varDetalle_de_Delito.Concurso
                        ,Monto = varDetalle_de_Delito.Monto
                        ,Estado_del_Delito = varDetalle_de_Delito.Estado_del_Delito
                        ,Municipio_del_Delito = varDetalle_de_Delito.Municipio_del_Delito
                        ,Colonia_del_Delito = varDetalle_de_Delito.Colonia_del_Delito
                        ,Codigo_Postal = varDetalle_de_Delito.Codigo_Postal
                        ,Calle = varDetalle_de_Delito.Calle
                        ,Entre_Calle = varDetalle_de_Delito.Entre_Calle
                        ,y_Calle = varDetalle_de_Delito.y_Calle
                        ,Numero_Exterior_del_Delito = varDetalle_de_Delito.Numero_Exterior_del_Delito
                        ,Numero_Interior_del_Delito = varDetalle_de_Delito.Numero_Interior_del_Delito
                        ,Referencia = varDetalle_de_Delito.Referencia
                        ,Latitud = varDetalle_de_Delito.Latitud
                        ,Longitud = varDetalle_de_Delito.Longitud
                        ,Puede_Ser_Canalizado_a_JA = varDetalle_de_Delito.Puede_Ser_Canalizado_a_JA
                        ,Motivo_de_no_canalizacion = varDetalle_de_Delito.Motivo_de_no_canalizacion
                        ,Se_Informaron_sus_Derechos = varDetalle_de_Delito.Se_Informaron_sus_Derechos
                        ,Se_Informo_el_Procedimiento = varDetalle_de_Delito.Se_Informo_el_Procedimiento
                        ,Levantamiento_de_Cadaver = varDetalle_de_Delito.Levantamiento_de_Cadaver
                        ,Mandamiento_Judicial = varDetalle_de_Delito.Mandamiento_Judicial
                    
                };

                result = _IDetalle_de_DelitoApiConsumer.Update_Datos_Generales(Detalle_de_Delito_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_DelitoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito;
                var Agravantes_del_DelitoData = GetAgravantes_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito);
                int RowCount_Circunstancias_del_Delito;
                var Circunstancias_del_DelitoData = GetCircunstancias_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito);

                var result = new Detalle_de_Delito_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Descripcion_corta = m.Descripcion_corta
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Expediente_Inicial = m.Expediente_Inicial
                        ,Expediente_InicialNUAT = CultureHelper.GetTraduction(m.Expediente_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASC = m.Expediente_MASC
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Tipo_de_Denuncia = m.Tipo_de_Denuncia
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Formato_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Formato_de_Denuncia.Descripcion
                        ,Fecha_del_Delito = (m.Fecha_del_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Delito).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Delito = m.Hora_del_Delito
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_Genero = m.Delito_Violencia_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                        ,Tipo_de_Delito = m.Tipo_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Titulo_del_Delito = m.Titulo_del_Delito
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Titulo_del_Delito") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_Delito = m.Grupo_Delito
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Grupo_del_Delito") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
			,Agravante = m.Agravante
                        ,Circunstancia_Delito = m.Circunstancia_Delito
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Articulado_de_Delito = m.Articulado_de_Delito
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_Delito = m.Forma_Comision_Delito
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_Delito = m.Forma_Accion_Delito
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_Delito = m.Modalidad_Delito
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_Delito = m.Elementos_Comision_Delito
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_Resultado = m.Clasificacion_con_Orden_de_Resultado
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,Concurso = m.Concurso
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto = m.Monto
                        ,Estado_del_Delito = m.Estado_del_Delito
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_Delito = m.Municipio_del_Delito
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_Delito = m.Colonia_del_Delito
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Puede_Ser_Canalizado_a_JA = m.Puede_Ser_Canalizado_a_JA
                        ,Puede_Ser_Canalizado_a_JADescripcion = CultureHelper.GetTraduction(m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Puede_Ser_Canalizado_a_JA_A_Tiempo.Descripcion
                        ,Motivo_de_no_canalizacion = m.Motivo_de_no_canalizacion
                        ,Motivo_de_no_canalizacionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_no_canalizacion_Motivo_de_No_Canalizacion.Descripcion
			,Se_Informaron_sus_Derechos = m.Se_Informaron_sus_Derechos
			,Se_Informo_el_Procedimiento = m.Se_Informo_el_Procedimiento
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Mandamiento_Judicial = m.Mandamiento_Judicial
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificactivas = Agravantes_del_DelitoData
                    ,Circunstancias_Delito = Circunstancias_del_DelitoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_Robo_de_Vehiculo(Detalle_de_Delito_Datos_de_Robo_de_VehiculoModel varDetalle_de_Delito)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_Datos_de_Robo_de_VehiculoInfo = new Detalle_de_Delito_Datos_de_Robo_de_Vehiculo
                {
                    Clave = varDetalle_de_Delito.Clave
                                            ,Fecha_del_Robo = (!String.IsNullOrEmpty(varDetalle_de_Delito.Fecha_del_Robo)) ? DateTime.ParseExact(varDetalle_de_Delito.Fecha_del_Robo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Robo = varDetalle_de_Delito.Hora_del_Robo
                        ,Robo_de = varDetalle_de_Delito.Robo_de
                        ,Registro_Federal_Vehicular = varDetalle_de_Delito.Registro_Federal_Vehicular
                        ,Numero_de_Registro_Publico_Vehicular = varDetalle_de_Delito.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Vehiculo = varDetalle_de_Delito.Circunstancia_de_Vehiculo
                        ,Clase = varDetalle_de_Delito.Clase
                        ,Vehiculo_Robado = varDetalle_de_Delito.Vehiculo_Robado
                        ,Marca = varDetalle_de_Delito.Marca
                        ,Sub_Marca = varDetalle_de_Delito.Sub_Marca
                        ,Tipo_de_Vehiculo = varDetalle_de_Delito.Tipo_de_Vehiculo
                        ,Modelo = varDetalle_de_Delito.Modelo
                        ,Color = varDetalle_de_Delito.Color
                        ,Placas = varDetalle_de_Delito.Placas
                        ,Estado_de_Origen_de_las_Placas = varDetalle_de_Delito.Estado_de_Origen_de_las_Placas
                        ,Numero_de_Motor = varDetalle_de_Delito.Numero_de_Motor
                        ,Numero_de_Serie = varDetalle_de_Delito.Numero_de_Serie
                        ,Estado_del_Robo = varDetalle_de_Delito.Estado_del_Robo
                        ,Municipio_del_Robo = varDetalle_de_Delito.Municipio_del_Robo
                        ,Colonia_del_Robo = varDetalle_de_Delito.Colonia_del_Robo
                        ,Codigo_Postal_Robo = varDetalle_de_Delito.Codigo_Postal_Robo
                        ,Calle_Robo = varDetalle_de_Delito.Calle_Robo
                        ,Entre_Calle_Robo = varDetalle_de_Delito.Entre_Calle_Robo
                        ,y_Calle_Robo = varDetalle_de_Delito.y_Calle_Robo
                        ,Numero_Exterior_del_Delito_Robo = varDetalle_de_Delito.Numero_Exterior_del_Delito_Robo
                        ,Numero_Interior_del_Delito_Robo = varDetalle_de_Delito.Numero_Interior_del_Delito_Robo
                        ,Referencia_Robo = varDetalle_de_Delito.Referencia_Robo
                        ,Latitud_Robo = varDetalle_de_Delito.Latitud_Robo
                        ,Longitud_Robo = varDetalle_de_Delito.Longitud_Robo
                        ,Lugar_del_Robo = varDetalle_de_Delito.Lugar_del_Robo
                        ,Zona_de_Robo = varDetalle_de_Delito.Zona_de_Robo
                        ,El_Vehiculo_esta_Asegurado = varDetalle_de_Delito.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_Aseguradora = varDetalle_de_Delito.Nombre_de_la_Aseguradora
                        ,Motor = varDetalle_de_Delito.Motor
                        ,Serie = varDetalle_de_Delito.Serie
                        ,Tipo_de_Servicio = varDetalle_de_Delito.Tipo_de_Servicio
                        ,Ruta_del_Servicio_Publico = varDetalle_de_Delito.Ruta_del_Servicio_Publico
                        ,Procedencia = varDetalle_de_Delito.Procedencia
                        ,Mercancia = varDetalle_de_Delito.Mercancia
                        ,Descripcion_de_lo_que_Transportaba = varDetalle_de_Delito.Descripcion_de_lo_que_Transportaba
                        ,Monto_de_la_Carga = varDetalle_de_Delito.Monto_de_la_Carga
                        ,Senas_Particulares = varDetalle_de_Delito.Senas_Particulares
                        ,Cuenta_con_GPS = varDetalle_de_Delito.Cuenta_con_GPS
                        ,Tipo_de_Robo = varDetalle_de_Delito.Tipo_de_Robo
                        ,Tipo_de_Lugar_del_Robo = varDetalle_de_Delito.Tipo_de_Lugar_del_Robo
                        ,Tipo_de_Carretera = varDetalle_de_Delito.Tipo_de_Carretera
                        ,Modalidad_del_Robo = varDetalle_de_Delito.Modalidad_del_Robo
                    
                };

                result = _IDetalle_de_DelitoApiConsumer.Update_Datos_de_Robo_de_Vehiculo(Detalle_de_Delito_Datos_de_Robo_de_VehiculoInfo).Resource.ToString();
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
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_DelitoApiConsumer.Get_Datos_de_Robo_de_Vehiculo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito;
                var Agravantes_del_DelitoData = GetAgravantes_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito);
                int RowCount_Circunstancias_del_Delito;
                var Circunstancias_del_DelitoData = GetCircunstancias_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito);

                var result = new Detalle_de_Delito_Datos_de_Robo_de_VehiculoModel
                {
                    Clave = m.Clave
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_de = m.Robo_de
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Vehiculo = m.Circunstancia_de_Vehiculo
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,Clase = m.Clase
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_Marca = m.Sub_Marca
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_Vehiculo = m.Tipo_de_Vehiculo
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_Placas = m.Estado_de_Origen_de_las_Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Numero_de_Motor = m.Numero_de_Motor
			,Numero_de_Serie = m.Numero_de_Serie
                        ,Estado_del_Robo = m.Estado_del_Robo
                        ,Estado_del_RoboNombre = CultureHelper.GetTraduction(m.Estado_del_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Robo_Estado.Nombre
                        ,Municipio_del_Robo = m.Municipio_del_Robo
                        ,Municipio_del_RoboNombre = CultureHelper.GetTraduction(m.Municipio_del_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Robo_Municipio.Nombre
                        ,Colonia_del_Robo = m.Colonia_del_Robo
                        ,Colonia_del_RoboNombre = CultureHelper.GetTraduction(m.Colonia_del_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Robo_Colonia.Nombre
			,Codigo_Postal_Robo = m.Codigo_Postal_Robo
			,Calle_Robo = m.Calle_Robo
			,Entre_Calle_Robo = m.Entre_Calle_Robo
			,y_Calle_Robo = m.y_Calle_Robo
			,Numero_Exterior_del_Delito_Robo = m.Numero_Exterior_del_Delito_Robo
			,Numero_Interior_del_Delito_Robo = m.Numero_Interior_del_Delito_Robo
			,Referencia_Robo = m.Referencia_Robo
			,Latitud_Robo = m.Latitud_Robo
			,Longitud_Robo = m.Longitud_Robo
                        ,Lugar_del_Robo = m.Lugar_del_Robo
                        ,Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Zona_de_Robo = m.Zona_de_Robo
                        ,Zona_de_RoboDescripcion = CultureHelper.GetTraduction(m.Zona_de_Robo_Zona_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_Robo_Zona_de_Robo.Descripcion
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_Aseguradora = m.Nombre_de_la_Aseguradora
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,Procedencia = m.Procedencia
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
			,Cuenta_con_GPS = m.Cuenta_con_GPS
                        ,Tipo_de_Robo = m.Tipo_de_Robo
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_Robo = m.Tipo_de_Lugar_del_Robo
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_Carretera = m.Tipo_de_Carretera
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Modalidad_del_Robo = m.Modalidad_del_Robo
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificactivas = Agravantes_del_DelitoData
                    ,Circunstancias_Delito = Circunstancias_del_DelitoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Levantamiento_del_Cadaver(Detalle_de_Delito_Datos_del_Levantamiento_del_CadaverModel varDetalle_de_Delito)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_Datos_del_Levantamiento_del_CadaverInfo = new Detalle_de_Delito_Datos_del_Levantamiento_del_Cadaver
                {
                    Clave = varDetalle_de_Delito.Clave
                                            ,Causa_de_Muerte = varDetalle_de_Delito.Causa_de_Muerte
                        ,Circunstancia_Defuncion = varDetalle_de_Delito.Circunstancia_Defuncion
                        ,Consecuencia_Defuncion = varDetalle_de_Delito.Consecuencia_Defuncion
                        ,Fecha_Levantamiento = (!String.IsNullOrEmpty(varDetalle_de_Delito.Fecha_Levantamiento)) ? DateTime.ParseExact(varDetalle_de_Delito.Fecha_Levantamiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Levantamiento = varDetalle_de_Delito.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_Hecho = varDetalle_de_Delito.Tipo_de_Lugar_del_Hecho
                        ,Pais = varDetalle_de_Delito.Pais
                        ,Estado = varDetalle_de_Delito.Estado
                        ,Municipio = varDetalle_de_Delito.Municipio
                        ,Colonia = varDetalle_de_Delito.Colonia
                        ,Colonia_no_Catalogada = varDetalle_de_Delito.Colonia_no_Catalogada
                        ,Numero_Exterior = varDetalle_de_Delito.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Delito.Numero_Interior
                        ,Necropsia = varDetalle_de_Delito.Necropsia
                        ,Cronotanatodiagnostico = varDetalle_de_Delito.Cronotanatodiagnostico
                        ,Ruta = varDetalle_de_Delito.Ruta
                        ,Estado_del_Conductor = varDetalle_de_Delito.Estado_del_Conductor
                    
                };

                result = _IDetalle_de_DelitoApiConsumer.Update_Datos_del_Levantamiento_del_Cadaver(Detalle_de_Delito_Datos_del_Levantamiento_del_CadaverInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Levantamiento_del_Cadaver(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_DelitoApiConsumer.Get_Datos_del_Levantamiento_del_Cadaver(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito;
                var Agravantes_del_DelitoData = GetAgravantes_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito);
                int RowCount_Circunstancias_del_Delito;
                var Circunstancias_del_DelitoData = GetCircunstancias_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito);

                var result = new Detalle_de_Delito_Datos_del_Levantamiento_del_CadaverModel
                {
                    Clave = m.Clave
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_Defuncion = m.Circunstancia_Defuncion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_Defuncion = m.Consecuencia_Defuncion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificactivas = Agravantes_del_DelitoData
                    ,Circunstancias_Delito = Circunstancias_del_DelitoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Asignar_Dueno(Detalle_de_Delito_Asignar_DuenoModel varDetalle_de_Delito)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_Asignar_DuenoInfo = new Detalle_de_Delito_Asignar_Dueno
                {
                    Clave = varDetalle_de_Delito.Clave
                                            ,Persona_Moral_Dueno = varDetalle_de_Delito.Persona_Moral_Dueno
                        ,Nombre_Completo = varDetalle_de_Delito.Nombre_Completo
                        ,Persona_Fisica_Dueno = varDetalle_de_Delito.Persona_Fisica_Dueno
                        ,Nombre_Completo_Involucrado = varDetalle_de_Delito.Nombre_Completo_Involucrado
                        ,Denunciante_dueno = varDetalle_de_Delito.Denunciante_dueno
                        ,Nombre_Completo_Dueno = varDetalle_de_Delito.Nombre_Completo_Dueno
                    
                };

                result = _IDetalle_de_DelitoApiConsumer.Update_Asignar_Dueno(Detalle_de_Delito_Asignar_DuenoInfo).Resource.ToString();
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
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_DelitoApiConsumer.Get_Asignar_Dueno(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito;
                var Agravantes_del_DelitoData = GetAgravantes_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito);
                int RowCount_Circunstancias_del_Delito;
                var Circunstancias_del_DelitoData = GetCircunstancias_del_DelitoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito);

                var result = new Detalle_de_Delito_Asignar_DuenoModel
                {
                    Clave = m.Clave
			,Persona_Moral_Dueno = m.Persona_Moral_Dueno
                        ,Nombre_Completo = m.Nombre_Completo
                        ,Nombre_CompletoNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Persona_Moral.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Detalle_de_Persona_Moral.Nombre
			,Persona_Fisica_Dueno = m.Persona_Fisica_Dueno
                        ,Nombre_Completo_Involucrado = m.Nombre_Completo_Involucrado
                        ,Nombre_Completo_InvolucradoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Involucrado_Detalle_de_Datos_Generales.Nombre_del_Tutor
			,Denunciante_dueno = m.Denunciante_dueno
                        ,Nombre_Completo_Dueno = m.Nombre_Completo_Dueno
                        ,Nombre_Completo_DuenoNombre_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_del_Tutor") ?? (string)m.Nombre_Completo_Dueno_Detalle_de_Datos_Generales.Nombre_del_Tutor

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificactivas = Agravantes_del_DelitoData
                    ,Circunstancias_Delito = Circunstancias_del_DelitoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

