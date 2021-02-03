using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Corporacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Grupo_al_que_Pertenece;
using Spartane.Core.Domain.Preferencia_Sexual;
using Spartane.Core.Domain.Etnia;
using Spartane.Core.Domain.Religion;
using Spartane.Core.Domain.Servicio_Medico;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Especialidad;
using Spartane.Core.Domain.Estudios_Superiores;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Calidad_Migratoria;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Estado_de_Involucrado;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
using Spartane.Core.Domain.Adicciones_de_Involucrado;

using Spartane.Core.Domain.Adicciones;

using Spartane.Core.Domain.Lugares_Frecuentes_Involucrado;

using Spartane.Core.Domain.Lugares;


using Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado;



using Spartane.Core.Domain.Redes_Sociales;


using Spartane.Core.Domain.Otras_Identificaciones_Involucrado;

using Spartane.Core.Domain.Tipo_de_Identificacion;


using Spartane.Core.Domain.Discapacidades_Mentales;
using Spartane.Core.Domain.Discapacidades_Fisicas;
using Spartane.Core.Domain.Discapacidades_Sensoriales;
using Spartane.Core.Domain.Discapacidades_Psicosociales;
using Spartane.Core.Domain.Otros_Domicilios_Involucrado;

using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;










using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Documento_Extraviado;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Largo_de_Cabello;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Color_de_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Froma_Ojos;
using Spartane.Core.Domain.Anteojos;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Core.Domain.Tamano_de_Nariz;
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
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using Spartane.Core.Domain.A_Tiempo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Corporacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Grupo_al_que_Pertenece;
using Spartane.Web.Areas.WebApiConsumer.Preferencia_Sexual;
using Spartane.Web.Areas.WebApiConsumer.Etnia;
using Spartane.Web.Areas.WebApiConsumer.Religion;
using Spartane.Web.Areas.WebApiConsumer.Servicio_Medico;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Especialidad;
using Spartane.Web.Areas.WebApiConsumer.Estudios_Superiores;
using Spartane.Web.Areas.WebApiConsumer.Idioma;
using Spartane.Web.Areas.WebApiConsumer.Calidad_Migratoria;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Dialecto;
using Spartane.Web.Areas.WebApiConsumer.Estado_de_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_de_Involucrado;

using Spartane.Web.Areas.WebApiConsumer.Adicciones;

using Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Involucrado;

using Spartane.Web.Areas.WebApiConsumer.Lugares;

using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Involucrado;

using Spartane.Web.Areas.WebApiConsumer.Redes_Sociales;

using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Involucrado;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;

using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Mentales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Fisicas;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Sensoriales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Psicosociales;
using Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Involucrado;

using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Documento_Extraviado;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cara;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_de_Cejas;
using Spartane.Web.Areas.WebApiConsumer.Cantidad_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Implantacion_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Complexion;
using Spartane.Web.Areas.WebApiConsumer.Color_Piel;
using Spartane.Web.Areas.WebApiConsumer.Frente;
using Spartane.Web.Areas.WebApiConsumer.Largo_de_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Color_de_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Calvicie;
using Spartane.Web.Areas.WebApiConsumer.Color_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Ojos;
using Spartane.Web.Areas.WebApiConsumer.Froma_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Anteojos;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Nariz;
using Spartane.Web.Areas.WebApiConsumer.Tamano_de_Nariz;
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
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Causas_de_Interrupcion;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;

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
    public class Detalle_de_Datos_GeneralesController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Datos_GeneralesService service = null;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private ICorporacionApiConsumer _ICorporacionApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IGrupo_al_que_PerteneceApiConsumer _IGrupo_al_que_PerteneceApiConsumer;
        private IPreferencia_SexualApiConsumer _IPreferencia_SexualApiConsumer;
        private IEtniaApiConsumer _IEtniaApiConsumer;
        private IReligionApiConsumer _IReligionApiConsumer;
        private IServicio_MedicoApiConsumer _IServicio_MedicoApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IEspecialidadApiConsumer _IEspecialidadApiConsumer;
        private IEstudios_SuperioresApiConsumer _IEstudios_SuperioresApiConsumer;
        private IIdiomaApiConsumer _IIdiomaApiConsumer;
        private ICalidad_MigratoriaApiConsumer _ICalidad_MigratoriaApiConsumer;
        private IDialectoApiConsumer _IDialectoApiConsumer;
        private IEstado_de_InvolucradoApiConsumer _IEstado_de_InvolucradoApiConsumer;
        private ITipo_de_InimputabilidadApiConsumer _ITipo_de_InimputabilidadApiConsumer;
        private IAdicciones_de_InvolucradoApiConsumer _IAdicciones_de_InvolucradoApiConsumer;

        private IAdiccionesApiConsumer _IAdiccionesApiConsumer;

        private ILugares_Frecuentes_InvolucradoApiConsumer _ILugares_Frecuentes_InvolucradoApiConsumer;

        private ILugaresApiConsumer _ILugaresApiConsumer;

        private IDatos_Personales_Adicionales_InvolucradoApiConsumer _IDatos_Personales_Adicionales_InvolucradoApiConsumer;

        private IRedes_SocialesApiConsumer _IRedes_SocialesApiConsumer;

        private IOtras_Identificaciones_InvolucradoApiConsumer _IOtras_Identificaciones_InvolucradoApiConsumer;


        private IDiscapacidades_MentalesApiConsumer _IDiscapacidades_MentalesApiConsumer;
        private IDiscapacidades_FisicasApiConsumer _IDiscapacidades_FisicasApiConsumer;
        private IDiscapacidades_SensorialesApiConsumer _IDiscapacidades_SensorialesApiConsumer;
        private IDiscapacidades_PsicosocialesApiConsumer _IDiscapacidades_PsicosocialesApiConsumer;
        private IOtros_Domicilios_InvolucradoApiConsumer _IOtros_Domicilios_InvolucradoApiConsumer;


        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private IPrioridad_del_HechoApiConsumer _IPrioridad_del_HechoApiConsumer;
        private IDocumento_ExtraviadoApiConsumer _IDocumento_ExtraviadoApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IForma_CaraApiConsumer _IForma_CaraApiConsumer;
        private ICejasApiConsumer _ICejasApiConsumer;
        private ITamano_de_CejasApiConsumer _ITamano_de_CejasApiConsumer;
        private ICantidad_CabelloApiConsumer _ICantidad_CabelloApiConsumer;
        private IImplantacion_CabelloApiConsumer _IImplantacion_CabelloApiConsumer;
        private IComplexionApiConsumer _IComplexionApiConsumer;
        private IColor_PielApiConsumer _IColor_PielApiConsumer;
        private IFrenteApiConsumer _IFrenteApiConsumer;
        private ILargo_de_CabelloApiConsumer _ILargo_de_CabelloApiConsumer;
        private IForma_CabelloApiConsumer _IForma_CabelloApiConsumer;
        private IColor_de_CabelloApiConsumer _IColor_de_CabelloApiConsumer;
        private ICalvicieApiConsumer _ICalvicieApiConsumer;
        private IColor_OjosApiConsumer _IColor_OjosApiConsumer;
        private IOjosApiConsumer _IOjosApiConsumer;
        private IFroma_OjosApiConsumer _IFroma_OjosApiConsumer;
        private IAnteojosApiConsumer _IAnteojosApiConsumer;
        private IForma_de_NarizApiConsumer _IForma_de_NarizApiConsumer;
        private ITamano_de_NarizApiConsumer _ITamano_de_NarizApiConsumer;
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
        private ICausas_de_InterrupcionApiConsumer _ICausas_de_InterrupcionApiConsumer;

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

        
        public Detalle_de_Datos_GeneralesController(IDetalle_de_Datos_GeneralesService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , ICorporacionApiConsumer CorporacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IGrupo_al_que_PerteneceApiConsumer Grupo_al_que_PerteneceApiConsumer , IPreferencia_SexualApiConsumer Preferencia_SexualApiConsumer , IEtniaApiConsumer EtniaApiConsumer , IReligionApiConsumer ReligionApiConsumer , IServicio_MedicoApiConsumer Servicio_MedicoApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IEspecialidadApiConsumer EspecialidadApiConsumer , IEstudios_SuperioresApiConsumer Estudios_SuperioresApiConsumer , IIdiomaApiConsumer IdiomaApiConsumer , ICalidad_MigratoriaApiConsumer Calidad_MigratoriaApiConsumer , IDialectoApiConsumer DialectoApiConsumer , IEstado_de_InvolucradoApiConsumer Estado_de_InvolucradoApiConsumer , ITipo_de_InimputabilidadApiConsumer Tipo_de_InimputabilidadApiConsumer , IAdicciones_de_InvolucradoApiConsumer Adicciones_de_InvolucradoApiConsumer , IAdiccionesApiConsumer AdiccionesApiConsumer  , ILugares_Frecuentes_InvolucradoApiConsumer Lugares_Frecuentes_InvolucradoApiConsumer , ILugaresApiConsumer LugaresApiConsumer  , IDatos_Personales_Adicionales_InvolucradoApiConsumer Datos_Personales_Adicionales_InvolucradoApiConsumer , IRedes_SocialesApiConsumer Redes_SocialesApiConsumer  , IOtras_Identificaciones_InvolucradoApiConsumer Otras_Identificaciones_InvolucradoApiConsumer  , IDiscapacidades_MentalesApiConsumer Discapacidades_MentalesApiConsumer , IDiscapacidades_FisicasApiConsumer Discapacidades_FisicasApiConsumer , IDiscapacidades_SensorialesApiConsumer Discapacidades_SensorialesApiConsumer , IDiscapacidades_PsicosocialesApiConsumer Discapacidades_PsicosocialesApiConsumer , IOtros_Domicilios_InvolucradoApiConsumer Otros_Domicilios_InvolucradoApiConsumer  , ILocalidadApiConsumer LocalidadApiConsumer , IPrioridad_del_HechoApiConsumer Prioridad_del_HechoApiConsumer , IDocumento_ExtraviadoApiConsumer Documento_ExtraviadoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IForma_CaraApiConsumer Forma_CaraApiConsumer , ICejasApiConsumer CejasApiConsumer , ITamano_de_CejasApiConsumer Tamano_de_CejasApiConsumer , ICantidad_CabelloApiConsumer Cantidad_CabelloApiConsumer , IImplantacion_CabelloApiConsumer Implantacion_CabelloApiConsumer , IComplexionApiConsumer ComplexionApiConsumer , IColor_PielApiConsumer Color_PielApiConsumer , IFrenteApiConsumer FrenteApiConsumer , ILargo_de_CabelloApiConsumer Largo_de_CabelloApiConsumer , IForma_CabelloApiConsumer Forma_CabelloApiConsumer , IColor_de_CabelloApiConsumer Color_de_CabelloApiConsumer , ICalvicieApiConsumer CalvicieApiConsumer , IColor_OjosApiConsumer Color_OjosApiConsumer , IOjosApiConsumer OjosApiConsumer , IFroma_OjosApiConsumer Froma_OjosApiConsumer , IAnteojosApiConsumer AnteojosApiConsumer , IForma_de_NarizApiConsumer Forma_de_NarizApiConsumer , ITamano_de_NarizApiConsumer Tamano_de_NarizApiConsumer , ILabiosApiConsumer LabiosApiConsumer , IBocaApiConsumer BocaApiConsumer , IGrosor_de_LabiosApiConsumer Grosor_de_LabiosApiConsumer , IMentonApiConsumer MentonApiConsumer , IForma_de_MentonApiConsumer Forma_de_MentonApiConsumer , IBarbaApiConsumer BarbaApiConsumer , IForma_OrejasApiConsumer Forma_OrejasApiConsumer , ITamano_OrejasApiConsumer Tamano_OrejasApiConsumer , ITipo_LobuloApiConsumer Tipo_LobuloApiConsumer , IBigoteApiConsumer BigoteApiConsumer , ISenas_ParticularesApiConsumer Senas_ParticularesApiConsumer , ISituacion_FisicaApiConsumer Situacion_FisicaApiConsumer , ICausas_de_InterrupcionApiConsumer Causas_de_InterrupcionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;
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
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ICorporacionApiConsumer = CorporacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IGrupo_al_que_PerteneceApiConsumer = Grupo_al_que_PerteneceApiConsumer;
            this._IPreferencia_SexualApiConsumer = Preferencia_SexualApiConsumer;
            this._IEtniaApiConsumer = EtniaApiConsumer;
            this._IReligionApiConsumer = ReligionApiConsumer;
            this._IServicio_MedicoApiConsumer = Servicio_MedicoApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IEspecialidadApiConsumer = EspecialidadApiConsumer;
            this._IEstudios_SuperioresApiConsumer = Estudios_SuperioresApiConsumer;
            this._IIdiomaApiConsumer = IdiomaApiConsumer;
            this._ICalidad_MigratoriaApiConsumer = Calidad_MigratoriaApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IDialectoApiConsumer = DialectoApiConsumer;
            this._IEstado_de_InvolucradoApiConsumer = Estado_de_InvolucradoApiConsumer;
            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;
            this._IAdicciones_de_InvolucradoApiConsumer = Adicciones_de_InvolucradoApiConsumer;

            this._IAdiccionesApiConsumer = AdiccionesApiConsumer;

            this._ILugares_Frecuentes_InvolucradoApiConsumer = Lugares_Frecuentes_InvolucradoApiConsumer;

            this._ILugaresApiConsumer = LugaresApiConsumer;

            this._IDatos_Personales_Adicionales_InvolucradoApiConsumer = Datos_Personales_Adicionales_InvolucradoApiConsumer;

            this._IRedes_SocialesApiConsumer = Redes_SocialesApiConsumer;

            this._IOtras_Identificaciones_InvolucradoApiConsumer = Otras_Identificaciones_InvolucradoApiConsumer;

            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;

            this._IDiscapacidades_MentalesApiConsumer = Discapacidades_MentalesApiConsumer;
            this._IDiscapacidades_FisicasApiConsumer = Discapacidades_FisicasApiConsumer;
            this._IDiscapacidades_SensorialesApiConsumer = Discapacidades_SensorialesApiConsumer;
            this._IDiscapacidades_PsicosocialesApiConsumer = Discapacidades_PsicosocialesApiConsumer;
            this._IOtros_Domicilios_InvolucradoApiConsumer = Otros_Domicilios_InvolucradoApiConsumer;

            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IDocumento_ExtraviadoApiConsumer = Documento_ExtraviadoApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IForma_CaraApiConsumer = Forma_CaraApiConsumer;
            this._ICejasApiConsumer = CejasApiConsumer;
            this._ITamano_de_CejasApiConsumer = Tamano_de_CejasApiConsumer;
            this._ICantidad_CabelloApiConsumer = Cantidad_CabelloApiConsumer;
            this._IImplantacion_CabelloApiConsumer = Implantacion_CabelloApiConsumer;
            this._IComplexionApiConsumer = ComplexionApiConsumer;
            this._IColor_PielApiConsumer = Color_PielApiConsumer;
            this._IFrenteApiConsumer = FrenteApiConsumer;
            this._ILargo_de_CabelloApiConsumer = Largo_de_CabelloApiConsumer;
            this._IForma_CabelloApiConsumer = Forma_CabelloApiConsumer;
            this._IColor_de_CabelloApiConsumer = Color_de_CabelloApiConsumer;
            this._ICalvicieApiConsumer = CalvicieApiConsumer;
            this._IColor_OjosApiConsumer = Color_OjosApiConsumer;
            this._IOjosApiConsumer = OjosApiConsumer;
            this._IFroma_OjosApiConsumer = Froma_OjosApiConsumer;
            this._IAnteojosApiConsumer = AnteojosApiConsumer;
            this._IForma_de_NarizApiConsumer = Forma_de_NarizApiConsumer;
            this._ITamano_de_NarizApiConsumer = Tamano_de_NarizApiConsumer;
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
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._ICausas_de_InterrupcionApiConsumer = Causas_de_InterrupcionApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Datos_Generales
        [ObjectAuth(ObjectId = (ModuleObjectId)45106, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45106, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Datos_Generales/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45106, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45106, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Datos_Generales = new Detalle_de_Datos_GeneralesModel();
			varDetalle_de_Datos_Generales.Clave = Id;
			
            ViewBag.ObjectId = "45106";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionAdicciones_de_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45312, ModuleId);
            ViewBag.PermissionAdicciones_de_Involucrado = permissionAdicciones_de_Involucrado;
            var permissionLugares_Frecuentes_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45311, ModuleId);
            ViewBag.PermissionLugares_Frecuentes_Involucrado = permissionLugares_Frecuentes_Involucrado;
            var permissionDatos_Personales_Adicionales_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45310, ModuleId);
            ViewBag.PermissionDatos_Personales_Adicionales_Involucrado = permissionDatos_Personales_Adicionales_Involucrado;
            var permissionOtras_Identificaciones_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45309, ModuleId);
            ViewBag.PermissionOtras_Identificaciones_Involucrado = permissionOtras_Identificaciones_Involucrado;
            var permissionOtros_Domicilios_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45299, ModuleId);
            ViewBag.PermissionOtros_Domicilios_Involucrado = permissionOtros_Domicilios_Involucrado;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Datos_GeneralessData = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Datos_Generales.Clave=" + Id, "").Resource.Detalle_de_Datos_Generaless;
				
				if (Detalle_de_Datos_GeneralessData != null && Detalle_de_Datos_GeneralessData.Count > 0)
                {
					var Detalle_de_Datos_GeneralesData = Detalle_de_Datos_GeneralessData.First();
					varDetalle_de_Datos_Generales= new Detalle_de_Datos_GeneralesModel
					{
						Clave  = Detalle_de_Datos_GeneralesData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_Datos_GeneralesData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Datos_GeneralesData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MP = Detalle_de_Datos_GeneralesData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_Datos_GeneralesData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Expediente_MASC = Detalle_de_Datos_GeneralesData.Expediente_MASC
                    ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Expediente_MASC), "Solicitud") ??  (string)Detalle_de_Datos_GeneralesData.Expediente_MASC_Solicitud.Numero_de_Folio
                    ,Datos_Confidenciales = Detalle_de_Datos_GeneralesData.Datos_Confidenciales.GetValueOrDefault()
                    ,Se_Informo_sobre_el_Procedimiento = Detalle_de_Datos_GeneralesData.Se_Informo_sobre_el_Procedimiento.GetValueOrDefault()
                    ,Tipo_de_Compareciente = Detalle_de_Datos_GeneralesData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Persona_Desaparecida = Detalle_de_Datos_GeneralesData.Persona_Desaparecida.GetValueOrDefault()
                    ,Persona_Aparecio = Detalle_de_Datos_GeneralesData.Persona_Aparecio.GetValueOrDefault()
                    ,Fecha_de_Aparicion = (Detalle_de_Datos_GeneralesData.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                    ,Con_Vida = Detalle_de_Datos_GeneralesData.Con_Vida
                    ,Con_VidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Con_Vida), "A_Tiempo") ??  (string)Detalle_de_Datos_GeneralesData.Con_Vida_A_Tiempo.Descripcion
                    ,Persona_Moral = Detalle_de_Datos_GeneralesData.Persona_Moral.GetValueOrDefault()
                    ,Q_Q_R_O_ = Detalle_de_Datos_GeneralesData.Q_Q_R_O_.GetValueOrDefault()
                    ,Es_victima = Detalle_de_Datos_GeneralesData.Es_victima.GetValueOrDefault()
                    ,Nombre = Detalle_de_Datos_GeneralesData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_GeneralesData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_GeneralesData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Datos_GeneralesData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_GeneralesData.Edad
                    ,Sexo = Detalle_de_Datos_GeneralesData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Sexo), "Genero") ??  (string)Detalle_de_Datos_GeneralesData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_GeneralesData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_GeneralesData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_GeneralesData.Numero_de_Identificacion
                    ,CURP = Detalle_de_Datos_GeneralesData.CURP
                    ,RFC = Detalle_de_Datos_GeneralesData.RFC
                    ,Calidad_Juridica = Detalle_de_Datos_GeneralesData.Calidad_Juridica
                    ,Razon_Social = Detalle_de_Datos_GeneralesData.Razon_Social
                    ,Nacionalidad = Detalle_de_Datos_GeneralesData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_GeneralesData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Ocupacion = Detalle_de_Datos_GeneralesData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_GeneralesData.Ocupacion_Ocupacion.Descripcion
                    ,Municipio_Corporacion = Detalle_de_Datos_GeneralesData.Municipio_Corporacion
                    ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_Corporacion), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_Corporacion_Municipio.Nombre
                    ,Corporacion = Detalle_de_Datos_GeneralesData.Corporacion
                    ,CorporacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Corporacion), "Corporacion") ??  (string)Detalle_de_Datos_GeneralesData.Corporacion_Corporacion.Descripcion
                    ,Pais_de_Origen = Detalle_de_Datos_GeneralesData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_de_Origen_Pais.Nombre
                    ,Originario_de = Detalle_de_Datos_GeneralesData.Originario_de
                    ,Pais = Detalle_de_Datos_GeneralesData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Datos_GeneralesData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_GeneralesData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Datos_GeneralesData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Poblacion), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Datos_GeneralesData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_GeneralesData.Codigo_Postal
                    ,Calle = Detalle_de_Datos_GeneralesData.Calle
                    ,Entre_Calle = Detalle_de_Datos_GeneralesData.Entre_Calle
                    ,Y_Calle = Detalle_de_Datos_GeneralesData.Y_Calle
                    ,Numero_Exterior = Detalle_de_Datos_GeneralesData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_GeneralesData.Numero_Interior
                    ,Referencia_de_Domicilio = Detalle_de_Datos_GeneralesData.Referencia_de_Domicilio
                    ,Latitud = Detalle_de_Datos_GeneralesData.Latitud
                    ,Longitud = Detalle_de_Datos_GeneralesData.Longitud
                    ,Telefono = Detalle_de_Datos_GeneralesData.Telefono
                    ,Extension = Detalle_de_Datos_GeneralesData.Extension
                    ,Celular = Detalle_de_Datos_GeneralesData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_GeneralesData.Correo_Electronico
                    ,Situacion_de_Vulnerabilidad = Detalle_de_Datos_GeneralesData.Situacion_de_Vulnerabilidad.GetValueOrDefault()
                    ,Grupo_al_que_pertenece = Detalle_de_Datos_GeneralesData.Grupo_al_que_pertenece
                    ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Grupo_al_que_pertenece), "Grupo_al_que_Pertenece") ??  (string)Detalle_de_Datos_GeneralesData.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                    ,Preferencia_Sexual = Detalle_de_Datos_GeneralesData.Preferencia_Sexual
                    ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Preferencia_Sexual), "Preferencia_Sexual") ??  (string)Detalle_de_Datos_GeneralesData.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                    ,Etnia = Detalle_de_Datos_GeneralesData.Etnia
                    ,EtniaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Etnia), "Etnia") ??  (string)Detalle_de_Datos_GeneralesData.Etnia_Etnia.Descripcion
                    ,No_de_Hijos = Detalle_de_Datos_GeneralesData.No_de_Hijos
                    ,Religion = Detalle_de_Datos_GeneralesData.Religion
                    ,ReligionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Religion), "Religion") ??  (string)Detalle_de_Datos_GeneralesData.Religion_Religion.Descripcion
                    ,Servicio_Medico = Detalle_de_Datos_GeneralesData.Servicio_Medico
                    ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Servicio_Medico), "Servicio_Medico") ??  (string)Detalle_de_Datos_GeneralesData.Servicio_Medico_Servicio_Medico.Descripcion
                    ,Escolaridad = Detalle_de_Datos_GeneralesData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad_Escolaridad.Descripcion
                    ,Escolaridad_ = Detalle_de_Datos_GeneralesData.Escolaridad_
                    ,Escolaridad_Descripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad_), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad__Escolaridad.Descripcion
                    ,Especialidad = Detalle_de_Datos_GeneralesData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Especialidad), "Especialidad") ??  (string)Detalle_de_Datos_GeneralesData.Especialidad_Especialidad.Descripcion
                    ,Estudios_Superiores = Detalle_de_Datos_GeneralesData.Estudios_Superiores
                    ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estudios_Superiores), "Estudios_Superiores") ??  (string)Detalle_de_Datos_GeneralesData.Estudios_Superiores_Estudios_Superiores.Descripcion
                    ,Incompleto = Detalle_de_Datos_GeneralesData.Incompleto.GetValueOrDefault()
                    ,Idioma = Detalle_de_Datos_GeneralesData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Idioma), "Idioma") ??  (string)Detalle_de_Datos_GeneralesData.Idioma_Idioma.Descripcion
                    ,Calidad_Migratoria = Detalle_de_Datos_GeneralesData.Calidad_Migratoria
                    ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Calidad_Migratoria), "Calidad_Migratoria") ??  (string)Detalle_de_Datos_GeneralesData.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                    ,Estado_de_Nacimiento = Detalle_de_Datos_GeneralesData.Estado_de_Nacimiento
                    ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_de_Nacimiento), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_de_Nacimiento_Estado.Nombre
                    ,Municipio_de_Nacimiento = Detalle_de_Datos_GeneralesData.Municipio_de_Nacimiento
                    ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_de_Nacimiento), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_de_Nacimiento_Municipio.Nombre
                    ,Dialecto = Detalle_de_Datos_GeneralesData.Dialecto
                    ,DialectoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Dialecto), "Dialecto") ??  (string)Detalle_de_Datos_GeneralesData.Dialecto_Dialecto.Descripcion
                    ,Estado_de_Involucrado = Detalle_de_Datos_GeneralesData.Estado_de_Involucrado
                    ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_de_Involucrado), "Estado_de_Involucrado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
                    ,Incapaz = Detalle_de_Datos_GeneralesData.Incapaz.GetValueOrDefault()
                    ,Tipo_de_Inimputabilidad = Detalle_de_Datos_GeneralesData.Tipo_de_Inimputabilidad
                    ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Especifique = Detalle_de_Datos_GeneralesData.Especifique
                    ,Se_Informaron_sobre_sus_Derechos = Detalle_de_Datos_GeneralesData.Se_Informaron_sobre_sus_Derechos.GetValueOrDefault()
                    ,Gravidez = Detalle_de_Datos_GeneralesData.Gravidez.GetValueOrDefault()
                    ,Discapacidad_Mental = Detalle_de_Datos_GeneralesData.Discapacidad_Mental
                    ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Mental), "Discapacidades_Mentales") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                    ,Discapacidad_Fisica = Detalle_de_Datos_GeneralesData.Discapacidad_Fisica
                    ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Fisica), "Discapacidades_Fisicas") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                    ,Discapacidad_Sensorial = Detalle_de_Datos_GeneralesData.Discapacidad_Sensorial
                    ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Sensorial), "Discapacidades_Sensoriales") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                    ,Discapacidad_Psicosocial = Detalle_de_Datos_GeneralesData.Discapacidad_Psicosocial
                    ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Psicosocial), "Discapacidades_Psicosociales") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
                    ,Nombre_del_Tutor = Detalle_de_Datos_GeneralesData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_GeneralesData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_GeneralesData.Apellido_Materno_del_Tutor
                    ,Nombre_Completo_del_Tutor = Detalle_de_Datos_GeneralesData.Nombre_Completo_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_GeneralesData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_GeneralesData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_GeneralesData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_GeneralesData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_GeneralesData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_GeneralesData.Numero_de_Identificacion_del_Tutor
                    ,CURP_Tutor = Detalle_de_Datos_GeneralesData.CURP_Tutor
                    ,RFC_Tutor = Detalle_de_Datos_GeneralesData.RFC_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_GeneralesData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_GeneralesData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_GeneralesData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_GeneralesData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_GeneralesData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_de_Origen_Tutor = Detalle_de_Datos_GeneralesData.Pais_de_Origen_Tutor
                    ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_de_Origen_Tutor), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_de_Origen_Tutor_Pais.Nombre
                    ,Originario_de_T = Detalle_de_Datos_GeneralesData.Originario_de_T
                    ,Pais_del_Tutor = Detalle_de_Datos_GeneralesData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_GeneralesData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_GeneralesData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_del_Tutor_Municipio.Nombre
                    ,Poblacion_Tutor = Detalle_de_Datos_GeneralesData.Poblacion_Tutor
                    ,Poblacion_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Poblacion_Tutor), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Poblacion_Tutor_Colonia.Nombre
                    ,Localidad_del_Tutor = Detalle_de_Datos_GeneralesData.Localidad_del_Tutor
                    ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Localidad_del_Tutor), "Localidad") ??  (string)Detalle_de_Datos_GeneralesData.Localidad_del_Tutor_Localidad.Descripcion
                    ,Colonia_del_Tutor = Detalle_de_Datos_GeneralesData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_GeneralesData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_GeneralesData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_GeneralesData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_GeneralesData.Numero_Interior_del_Tutor
                    ,Referencia_de_Domicilio_Tutor = Detalle_de_Datos_GeneralesData.Referencia_de_Domicilio_Tutor
                    ,Latitud_Tutor = Detalle_de_Datos_GeneralesData.Latitud_Tutor
                    ,Longitud_Tutor = Detalle_de_Datos_GeneralesData.Longitud_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_GeneralesData.Telefono_del_Tutor
                    ,Extension_del_Tutor = Detalle_de_Datos_GeneralesData.Extension_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_GeneralesData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_GeneralesData.Correo_Electronico_del_Tutor
                    ,Nombres2 = Detalle_de_Datos_GeneralesData.Nombres2
                    ,Apellido_Paterno2 = Detalle_de_Datos_GeneralesData.Apellido_Paterno2
                    ,Apellido_Materno2 = Detalle_de_Datos_GeneralesData.Apellido_Materno2
                    ,Nombre_Completo2 = Detalle_de_Datos_GeneralesData.Nombre_Completo2
                    ,Sexo2 = Detalle_de_Datos_GeneralesData.Sexo2
                    ,Sexo2Descripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Sexo2), "Genero") ??  (string)Detalle_de_Datos_GeneralesData.Sexo2_Genero.Descripcion
                    ,Nacionalidad2 = Detalle_de_Datos_GeneralesData.Nacionalidad2
                    ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Nacionalidad2), "Nacionalidad") ??  (string)Detalle_de_Datos_GeneralesData.Nacionalidad2_Nacionalidad.NacionalidadC
                    ,Escolaridad2 = Detalle_de_Datos_GeneralesData.Escolaridad2
                    ,Escolaridad2Descripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad2), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad2_Escolaridad.Descripcion
                    ,ID_Estado_Institucion = Detalle_de_Datos_GeneralesData.ID_Estado_Institucion
                    ,Titulo_del_Hecho = Detalle_de_Datos_GeneralesData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Detalle_de_Datos_GeneralesData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Detalle_de_Datos_GeneralesData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_GeneralesData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_GeneralesData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_GeneralesData.Hora_Aproximada_del_Hecho
                    ,Pais_del_hecho = Detalle_de_Datos_GeneralesData.Pais_del_hecho
                    ,Pais_del_hechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_del_hecho), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_del_hecho_Pais.Nombre
                    ,Estado_del_Hecho = Detalle_de_Datos_GeneralesData.Estado_del_Hecho
                    ,Estado_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_del_Hecho), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_del_Hecho_Estado.Nombre
                    ,Municipio_de_los_Hechos = Detalle_de_Datos_GeneralesData.Municipio_de_los_Hechos
                    ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_de_los_Hechos), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_de_los_Hechos_Municipio.Nombre
                    ,Poblacion_Hechos = Detalle_de_Datos_GeneralesData.Poblacion_Hechos
                    ,Poblacion_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Poblacion_Hechos), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Poblacion_Hechos_Colonia.Nombre
                    ,Colonia_de_los_Hechos = Detalle_de_Datos_GeneralesData.Colonia_de_los_Hechos
                    ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Colonia_de_los_Hechos), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Colonia_de_los_Hechos_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos = Detalle_de_Datos_GeneralesData.Codigo_Postal_de_los_Hechos
                    ,Calle_de_los_Hechos = Detalle_de_Datos_GeneralesData.Calle_de_los_Hechos
                    ,Entre_Calle_de_los_Hechos = Detalle_de_Datos_GeneralesData.Entre_Calle_de_los_Hechos
                    ,Y_calle_de_los_hechos = Detalle_de_Datos_GeneralesData.Y_calle_de_los_hechos
                    ,Numero_Exterior_de_los_Hechos = Detalle_de_Datos_GeneralesData.Numero_Exterior_de_los_Hechos
                    ,Numero_Interior_de_los_Hechos = Detalle_de_Datos_GeneralesData.Numero_Interior_de_los_Hechos
                    ,Referencia_Hechos = Detalle_de_Datos_GeneralesData.Referencia_Hechos
                    ,Latitud_de_los_Hechos = Detalle_de_Datos_GeneralesData.Latitud_de_los_Hechos
                    ,Longitud_de_los_Hechos = Detalle_de_Datos_GeneralesData.Longitud_de_los_Hechos
                    ,Documento_Extraviado = Detalle_de_Datos_GeneralesData.Documento_Extraviado.GetValueOrDefault()
                    ,Tipo_de_Documento_Extraviado = Detalle_de_Datos_GeneralesData.Tipo_de_Documento_Extraviado
                    ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Documento_Extraviado), "Documento_Extraviado") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                    ,Tipo_de_lugar_del_hecho = Detalle_de_Datos_GeneralesData.Tipo_de_lugar_del_hecho
                    ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_lugar_del_hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion
                    ,Peso = Detalle_de_Datos_GeneralesData.Peso
                    ,Estatura = Detalle_de_Datos_GeneralesData.Estatura
                    ,Padecimiento_de_Enfermedad = Detalle_de_Datos_GeneralesData.Padecimiento_de_Enfermedad
                    ,Forma_Cara = Detalle_de_Datos_GeneralesData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_Cara), "Forma_Cara") ??  (string)Detalle_de_Datos_GeneralesData.Forma_Cara_Forma_Cara.Descripcion
                    ,Tipo_de_Cejas = Detalle_de_Datos_GeneralesData.Tipo_de_Cejas
                    ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Cejas), "Cejas") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Detalle_de_Datos_GeneralesData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Cantidad_Cabello = Detalle_de_Datos_GeneralesData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Detalle_de_Datos_GeneralesData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Detalle_de_Datos_GeneralesData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Complexion), "Complexion") ??  (string)Detalle_de_Datos_GeneralesData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Detalle_de_Datos_GeneralesData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Color_Piel), "Color_Piel") ??  (string)Detalle_de_Datos_GeneralesData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Detalle_de_Datos_GeneralesData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Frente), "Frente") ??  (string)Detalle_de_Datos_GeneralesData.Frente_Frente.Descripcion
                    ,Largo_de_Cabello = Detalle_de_Datos_GeneralesData.Largo_de_Cabello
                    ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Largo_de_Cabello), "Largo_de_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                    ,Forma_de_Cabello = Detalle_de_Datos_GeneralesData.Forma_de_Cabello
                    ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_de_Cabello), "Forma_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Forma_de_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Detalle_de_Datos_GeneralesData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Color_Cabello), "Color_de_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Detalle_de_Datos_GeneralesData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Calvicie), "Calvicie") ??  (string)Detalle_de_Datos_GeneralesData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Detalle_de_Datos_GeneralesData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Color_Ojos), "Color_Ojos") ??  (string)Detalle_de_Datos_GeneralesData.Color_Ojos_Color_Ojos.Descripcion
                    ,Tamano_de_Ojos = Detalle_de_Datos_GeneralesData.Tamano_de_Ojos
                    ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_de_Ojos), "Ojos") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_de_Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Detalle_de_Datos_GeneralesData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_Ojos), "Froma_Ojos") ??  (string)Detalle_de_Datos_GeneralesData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Anteojos = Detalle_de_Datos_GeneralesData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Anteojos), "Anteojos") ??  (string)Detalle_de_Datos_GeneralesData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Detalle_de_Datos_GeneralesData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Detalle_de_Datos_GeneralesData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Tamano_Nariz = Detalle_de_Datos_GeneralesData.Tamano_Nariz
                    ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_Nariz), "Tamano_de_Nariz") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_Nariz_Tamano_de_Nariz.Descripcion
                    ,Labios = Detalle_de_Datos_GeneralesData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Labios), "Labios") ??  (string)Detalle_de_Datos_GeneralesData.Labios_Labios.Descripcion
                    ,Boca = Detalle_de_Datos_GeneralesData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Boca), "Boca") ??  (string)Detalle_de_Datos_GeneralesData.Boca_Boca.Descripcion
                    ,Grosor_de_Labios = Detalle_de_Datos_GeneralesData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Detalle_de_Datos_GeneralesData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Menton = Detalle_de_Datos_GeneralesData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Menton), "Menton") ??  (string)Detalle_de_Datos_GeneralesData.Menton_Menton.Descripcion
                    ,Forma_de_Menton = Detalle_de_Datos_GeneralesData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Detalle_de_Datos_GeneralesData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Barba = Detalle_de_Datos_GeneralesData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Barba), "Barba") ??  (string)Detalle_de_Datos_GeneralesData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Detalle_de_Datos_GeneralesData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_Orejas), "Forma_Orejas") ??  (string)Detalle_de_Datos_GeneralesData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Detalle_de_Datos_GeneralesData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Detalle_de_Datos_GeneralesData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Detalle_de_Datos_GeneralesData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Bigote), "Bigote") ??  (string)Detalle_de_Datos_GeneralesData.Bigote_Bigote.Descripcion
                    ,Senas_Particulares = Detalle_de_Datos_GeneralesData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Senas_Particulares), "Senas_Particulares") ??  (string)Detalle_de_Datos_GeneralesData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Detalle_de_Datos_GeneralesData.Imagen_Tatuaje
                    ,Situacion_Fisica = Detalle_de_Datos_GeneralesData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Detalle_de_Datos_GeneralesData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Otras_Senas_Particulares = Detalle_de_Datos_GeneralesData.Otras_Senas_Particulares
                    ,Causal = Detalle_de_Datos_GeneralesData.Causal
                    ,CausalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Causal), "A_Tiempo") ??  (string)Detalle_de_Datos_GeneralesData.Causal_A_Tiempo.Descripcion
                    ,Causa_de_Interrupcion = Detalle_de_Datos_GeneralesData.Causa_de_Interrupcion
                    ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Causa_de_Interrupcion), "Causas_de_Interrupcion") ??  (string)Detalle_de_Datos_GeneralesData.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                    ,Datos_Insuficientes = Detalle_de_Datos_GeneralesData.Datos_Insuficientes
                    ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Datos_Insuficientes), "A_Tiempo") ??  (string)Detalle_de_Datos_GeneralesData.Datos_Insuficientes_A_Tiempo.Descripcion
                    ,Actualizacion_de_Sobreseimiento = Detalle_de_Datos_GeneralesData.Actualizacion_de_Sobreseimiento

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Datos_Generales.Imagen_Tatuaje).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Vida = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Vida != null && A_Tiempos_Con_Vida.Resource != null)
                ViewBag.A_Tiempos_Con_Vida = A_Tiempos_Con_Vida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Corporacion = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Corporacion != null && Municipios_Municipio_Corporacion.Resource != null)
                ViewBag.Municipios_Municipio_Corporacion = Municipios_Municipio_Corporacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_al_que_PerteneceApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_al_que_Perteneces_Grupo_al_que_pertenece = _IGrupo_al_que_PerteneceApiConsumer.SelAll(true);
            if (Grupo_al_que_Perteneces_Grupo_al_que_pertenece != null && Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource != null)
                ViewBag.Grupo_al_que_Perteneces_Grupo_al_que_pertenece = Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_al_que_Pertenece", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPreferencia_SexualApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Preferencia_Sexuals_Preferencia_Sexual = _IPreferencia_SexualApiConsumer.SelAll(true);
            if (Preferencia_Sexuals_Preferencia_Sexual != null && Preferencia_Sexuals_Preferencia_Sexual.Resource != null)
                ViewBag.Preferencia_Sexuals_Preferencia_Sexual = Preferencia_Sexuals_Preferencia_Sexual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Preferencia_Sexual", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_ = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_ != null && Escolaridads_Escolaridad_.Resource != null)
                ViewBag.Escolaridads_Escolaridad_ = Escolaridads_Escolaridad_.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstado_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_de_Involucrados_Estado_de_Involucrado = _IEstado_de_InvolucradoApiConsumer.SelAll(true);
            if (Estado_de_Involucrados_Estado_de_Involucrado != null && Estado_de_Involucrados_Estado_de_Involucrado.Resource != null)
                ViewBag.Estado_de_Involucrados_Estado_de_Involucrado = Estado_de_Involucrados_Estado_de_Involucrado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_de_Involucrado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo2 = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo2 != null && Generos_Sexo2.Resource != null)
                ViewBag.Generos_Sexo2 = Generos_Sexo2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad2 = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad2 != null && Nacionalidads_Nacionalidad2.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad2 = Nacionalidads_Nacionalidad2.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad2 = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad2 != null && Escolaridads_Escolaridad2.Resource != null)
                ViewBag.Escolaridads_Escolaridad2 = Escolaridads_Escolaridad2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_lugar_del_hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_lugar_del_hecho != null && Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_lugar_del_hecho = Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_de_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_de_Cabello != null && Forma_Cabellos_Forma_de_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_de_Cabello = Forma_Cabellos_Forma_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITamano_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Narizs_Tamano_Nariz = _ITamano_de_NarizApiConsumer.SelAll(true);
            if (Tamano_de_Narizs_Tamano_Nariz != null && Tamano_de_Narizs_Tamano_Nariz.Resource != null)
                ViewBag.Tamano_de_Narizs_Tamano_Nariz = Tamano_de_Narizs_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal != null && A_Tiempos_Causal.Resource != null)
                ViewBag.A_Tiempos_Causal = A_Tiempos_Causal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Datos_Generales);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Datos_Generales(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45106);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Datos_GeneralesModel varDetalle_de_Datos_Generales= new Detalle_de_Datos_GeneralesModel();
            var permissionAdicciones_de_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45312, ModuleId);
            ViewBag.PermissionAdicciones_de_Involucrado = permissionAdicciones_de_Involucrado;
            var permissionLugares_Frecuentes_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45311, ModuleId);
            ViewBag.PermissionLugares_Frecuentes_Involucrado = permissionLugares_Frecuentes_Involucrado;
            var permissionDatos_Personales_Adicionales_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45310, ModuleId);
            ViewBag.PermissionDatos_Personales_Adicionales_Involucrado = permissionDatos_Personales_Adicionales_Involucrado;
            var permissionOtras_Identificaciones_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45309, ModuleId);
            ViewBag.PermissionOtras_Identificaciones_Involucrado = permissionOtras_Identificaciones_Involucrado;
            var permissionOtros_Domicilios_Involucrado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45299, ModuleId);
            ViewBag.PermissionOtros_Domicilios_Involucrado = permissionOtros_Domicilios_Involucrado;


            if (id.ToString() != "0")
            {
                var Detalle_de_Datos_GeneralessData = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Datos_Generales.Clave=" + id, "").Resource.Detalle_de_Datos_Generaless;
				
				if (Detalle_de_Datos_GeneralessData != null && Detalle_de_Datos_GeneralessData.Count > 0)
                {
					var Detalle_de_Datos_GeneralesData = Detalle_de_Datos_GeneralessData.First();
					varDetalle_de_Datos_Generales= new Detalle_de_Datos_GeneralesModel
					{
						Clave  = Detalle_de_Datos_GeneralesData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_Datos_GeneralesData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Datos_GeneralesData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MP = Detalle_de_Datos_GeneralesData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_Datos_GeneralesData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Expediente_MASC = Detalle_de_Datos_GeneralesData.Expediente_MASC
                    ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Expediente_MASC), "Solicitud") ??  (string)Detalle_de_Datos_GeneralesData.Expediente_MASC_Solicitud.Numero_de_Folio
                    ,Datos_Confidenciales = Detalle_de_Datos_GeneralesData.Datos_Confidenciales.GetValueOrDefault()
                    ,Se_Informo_sobre_el_Procedimiento = Detalle_de_Datos_GeneralesData.Se_Informo_sobre_el_Procedimiento.GetValueOrDefault()
                    ,Tipo_de_Compareciente = Detalle_de_Datos_GeneralesData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Persona_Desaparecida = Detalle_de_Datos_GeneralesData.Persona_Desaparecida.GetValueOrDefault()
                    ,Persona_Aparecio = Detalle_de_Datos_GeneralesData.Persona_Aparecio.GetValueOrDefault()
                    ,Fecha_de_Aparicion = (Detalle_de_Datos_GeneralesData.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                    ,Con_Vida = Detalle_de_Datos_GeneralesData.Con_Vida
                    ,Con_VidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Con_Vida), "A_Tiempo") ??  (string)Detalle_de_Datos_GeneralesData.Con_Vida_A_Tiempo.Descripcion
                    ,Persona_Moral = Detalle_de_Datos_GeneralesData.Persona_Moral.GetValueOrDefault()
                    ,Q_Q_R_O_ = Detalle_de_Datos_GeneralesData.Q_Q_R_O_.GetValueOrDefault()
                    ,Es_victima = Detalle_de_Datos_GeneralesData.Es_victima.GetValueOrDefault()
                    ,Nombre = Detalle_de_Datos_GeneralesData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_GeneralesData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_GeneralesData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Datos_GeneralesData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_GeneralesData.Edad
                    ,Sexo = Detalle_de_Datos_GeneralesData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Sexo), "Genero") ??  (string)Detalle_de_Datos_GeneralesData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_GeneralesData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_GeneralesData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_GeneralesData.Numero_de_Identificacion
                    ,CURP = Detalle_de_Datos_GeneralesData.CURP
                    ,RFC = Detalle_de_Datos_GeneralesData.RFC
                    ,Calidad_Juridica = Detalle_de_Datos_GeneralesData.Calidad_Juridica
                    ,Razon_Social = Detalle_de_Datos_GeneralesData.Razon_Social
                    ,Nacionalidad = Detalle_de_Datos_GeneralesData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_GeneralesData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Ocupacion = Detalle_de_Datos_GeneralesData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_GeneralesData.Ocupacion_Ocupacion.Descripcion
                    ,Municipio_Corporacion = Detalle_de_Datos_GeneralesData.Municipio_Corporacion
                    ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_Corporacion), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_Corporacion_Municipio.Nombre
                    ,Corporacion = Detalle_de_Datos_GeneralesData.Corporacion
                    ,CorporacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Corporacion), "Corporacion") ??  (string)Detalle_de_Datos_GeneralesData.Corporacion_Corporacion.Descripcion
                    ,Pais_de_Origen = Detalle_de_Datos_GeneralesData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_de_Origen_Pais.Nombre
                    ,Originario_de = Detalle_de_Datos_GeneralesData.Originario_de
                    ,Pais = Detalle_de_Datos_GeneralesData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Datos_GeneralesData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_GeneralesData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Datos_GeneralesData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Poblacion), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Datos_GeneralesData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_GeneralesData.Codigo_Postal
                    ,Calle = Detalle_de_Datos_GeneralesData.Calle
                    ,Entre_Calle = Detalle_de_Datos_GeneralesData.Entre_Calle
                    ,Y_Calle = Detalle_de_Datos_GeneralesData.Y_Calle
                    ,Numero_Exterior = Detalle_de_Datos_GeneralesData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_GeneralesData.Numero_Interior
                    ,Referencia_de_Domicilio = Detalle_de_Datos_GeneralesData.Referencia_de_Domicilio
                    ,Latitud = Detalle_de_Datos_GeneralesData.Latitud
                    ,Longitud = Detalle_de_Datos_GeneralesData.Longitud
                    ,Telefono = Detalle_de_Datos_GeneralesData.Telefono
                    ,Extension = Detalle_de_Datos_GeneralesData.Extension
                    ,Celular = Detalle_de_Datos_GeneralesData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_GeneralesData.Correo_Electronico
                    ,Situacion_de_Vulnerabilidad = Detalle_de_Datos_GeneralesData.Situacion_de_Vulnerabilidad.GetValueOrDefault()
                    ,Grupo_al_que_pertenece = Detalle_de_Datos_GeneralesData.Grupo_al_que_pertenece
                    ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Grupo_al_que_pertenece), "Grupo_al_que_Pertenece") ??  (string)Detalle_de_Datos_GeneralesData.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                    ,Preferencia_Sexual = Detalle_de_Datos_GeneralesData.Preferencia_Sexual
                    ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Preferencia_Sexual), "Preferencia_Sexual") ??  (string)Detalle_de_Datos_GeneralesData.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                    ,Etnia = Detalle_de_Datos_GeneralesData.Etnia
                    ,EtniaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Etnia), "Etnia") ??  (string)Detalle_de_Datos_GeneralesData.Etnia_Etnia.Descripcion
                    ,No_de_Hijos = Detalle_de_Datos_GeneralesData.No_de_Hijos
                    ,Religion = Detalle_de_Datos_GeneralesData.Religion
                    ,ReligionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Religion), "Religion") ??  (string)Detalle_de_Datos_GeneralesData.Religion_Religion.Descripcion
                    ,Servicio_Medico = Detalle_de_Datos_GeneralesData.Servicio_Medico
                    ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Servicio_Medico), "Servicio_Medico") ??  (string)Detalle_de_Datos_GeneralesData.Servicio_Medico_Servicio_Medico.Descripcion
                    ,Escolaridad = Detalle_de_Datos_GeneralesData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad_Escolaridad.Descripcion
                    ,Escolaridad_ = Detalle_de_Datos_GeneralesData.Escolaridad_
                    ,Escolaridad_Descripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad_), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad__Escolaridad.Descripcion
                    ,Especialidad = Detalle_de_Datos_GeneralesData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Especialidad), "Especialidad") ??  (string)Detalle_de_Datos_GeneralesData.Especialidad_Especialidad.Descripcion
                    ,Estudios_Superiores = Detalle_de_Datos_GeneralesData.Estudios_Superiores
                    ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estudios_Superiores), "Estudios_Superiores") ??  (string)Detalle_de_Datos_GeneralesData.Estudios_Superiores_Estudios_Superiores.Descripcion
                    ,Incompleto = Detalle_de_Datos_GeneralesData.Incompleto.GetValueOrDefault()
                    ,Idioma = Detalle_de_Datos_GeneralesData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Idioma), "Idioma") ??  (string)Detalle_de_Datos_GeneralesData.Idioma_Idioma.Descripcion
                    ,Calidad_Migratoria = Detalle_de_Datos_GeneralesData.Calidad_Migratoria
                    ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Calidad_Migratoria), "Calidad_Migratoria") ??  (string)Detalle_de_Datos_GeneralesData.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                    ,Estado_de_Nacimiento = Detalle_de_Datos_GeneralesData.Estado_de_Nacimiento
                    ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_de_Nacimiento), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_de_Nacimiento_Estado.Nombre
                    ,Municipio_de_Nacimiento = Detalle_de_Datos_GeneralesData.Municipio_de_Nacimiento
                    ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_de_Nacimiento), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_de_Nacimiento_Municipio.Nombre
                    ,Dialecto = Detalle_de_Datos_GeneralesData.Dialecto
                    ,DialectoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Dialecto), "Dialecto") ??  (string)Detalle_de_Datos_GeneralesData.Dialecto_Dialecto.Descripcion
                    ,Estado_de_Involucrado = Detalle_de_Datos_GeneralesData.Estado_de_Involucrado
                    ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_de_Involucrado), "Estado_de_Involucrado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
                    ,Incapaz = Detalle_de_Datos_GeneralesData.Incapaz.GetValueOrDefault()
                    ,Tipo_de_Inimputabilidad = Detalle_de_Datos_GeneralesData.Tipo_de_Inimputabilidad
                    ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Especifique = Detalle_de_Datos_GeneralesData.Especifique
                    ,Se_Informaron_sobre_sus_Derechos = Detalle_de_Datos_GeneralesData.Se_Informaron_sobre_sus_Derechos.GetValueOrDefault()
                    ,Gravidez = Detalle_de_Datos_GeneralesData.Gravidez.GetValueOrDefault()
                    ,Discapacidad_Mental = Detalle_de_Datos_GeneralesData.Discapacidad_Mental
                    ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Mental), "Discapacidades_Mentales") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                    ,Discapacidad_Fisica = Detalle_de_Datos_GeneralesData.Discapacidad_Fisica
                    ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Fisica), "Discapacidades_Fisicas") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                    ,Discapacidad_Sensorial = Detalle_de_Datos_GeneralesData.Discapacidad_Sensorial
                    ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Sensorial), "Discapacidades_Sensoriales") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                    ,Discapacidad_Psicosocial = Detalle_de_Datos_GeneralesData.Discapacidad_Psicosocial
                    ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Discapacidad_Psicosocial), "Discapacidades_Psicosociales") ??  (string)Detalle_de_Datos_GeneralesData.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
                    ,Nombre_del_Tutor = Detalle_de_Datos_GeneralesData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_GeneralesData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_GeneralesData.Apellido_Materno_del_Tutor
                    ,Nombre_Completo_del_Tutor = Detalle_de_Datos_GeneralesData.Nombre_Completo_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_GeneralesData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_GeneralesData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_GeneralesData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_GeneralesData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_GeneralesData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_GeneralesData.Numero_de_Identificacion_del_Tutor
                    ,CURP_Tutor = Detalle_de_Datos_GeneralesData.CURP_Tutor
                    ,RFC_Tutor = Detalle_de_Datos_GeneralesData.RFC_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_GeneralesData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_GeneralesData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_GeneralesData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_GeneralesData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_GeneralesData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_de_Origen_Tutor = Detalle_de_Datos_GeneralesData.Pais_de_Origen_Tutor
                    ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_de_Origen_Tutor), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_de_Origen_Tutor_Pais.Nombre
                    ,Originario_de_T = Detalle_de_Datos_GeneralesData.Originario_de_T
                    ,Pais_del_Tutor = Detalle_de_Datos_GeneralesData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_GeneralesData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_GeneralesData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_del_Tutor_Municipio.Nombre
                    ,Poblacion_Tutor = Detalle_de_Datos_GeneralesData.Poblacion_Tutor
                    ,Poblacion_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Poblacion_Tutor), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Poblacion_Tutor_Colonia.Nombre
                    ,Localidad_del_Tutor = Detalle_de_Datos_GeneralesData.Localidad_del_Tutor
                    ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Localidad_del_Tutor), "Localidad") ??  (string)Detalle_de_Datos_GeneralesData.Localidad_del_Tutor_Localidad.Descripcion
                    ,Colonia_del_Tutor = Detalle_de_Datos_GeneralesData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_GeneralesData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_GeneralesData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_GeneralesData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_GeneralesData.Numero_Interior_del_Tutor
                    ,Referencia_de_Domicilio_Tutor = Detalle_de_Datos_GeneralesData.Referencia_de_Domicilio_Tutor
                    ,Latitud_Tutor = Detalle_de_Datos_GeneralesData.Latitud_Tutor
                    ,Longitud_Tutor = Detalle_de_Datos_GeneralesData.Longitud_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_GeneralesData.Telefono_del_Tutor
                    ,Extension_del_Tutor = Detalle_de_Datos_GeneralesData.Extension_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_GeneralesData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_GeneralesData.Correo_Electronico_del_Tutor
                    ,Nombres2 = Detalle_de_Datos_GeneralesData.Nombres2
                    ,Apellido_Paterno2 = Detalle_de_Datos_GeneralesData.Apellido_Paterno2
                    ,Apellido_Materno2 = Detalle_de_Datos_GeneralesData.Apellido_Materno2
                    ,Nombre_Completo2 = Detalle_de_Datos_GeneralesData.Nombre_Completo2
                    ,Sexo2 = Detalle_de_Datos_GeneralesData.Sexo2
                    ,Sexo2Descripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Sexo2), "Genero") ??  (string)Detalle_de_Datos_GeneralesData.Sexo2_Genero.Descripcion
                    ,Nacionalidad2 = Detalle_de_Datos_GeneralesData.Nacionalidad2
                    ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Nacionalidad2), "Nacionalidad") ??  (string)Detalle_de_Datos_GeneralesData.Nacionalidad2_Nacionalidad.NacionalidadC
                    ,Escolaridad2 = Detalle_de_Datos_GeneralesData.Escolaridad2
                    ,Escolaridad2Descripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Escolaridad2), "Escolaridad") ??  (string)Detalle_de_Datos_GeneralesData.Escolaridad2_Escolaridad.Descripcion
                    ,ID_Estado_Institucion = Detalle_de_Datos_GeneralesData.ID_Estado_Institucion
                    ,Titulo_del_Hecho = Detalle_de_Datos_GeneralesData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Detalle_de_Datos_GeneralesData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Detalle_de_Datos_GeneralesData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_GeneralesData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_GeneralesData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_GeneralesData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_GeneralesData.Hora_Aproximada_del_Hecho
                    ,Pais_del_hecho = Detalle_de_Datos_GeneralesData.Pais_del_hecho
                    ,Pais_del_hechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Pais_del_hecho), "Pais") ??  (string)Detalle_de_Datos_GeneralesData.Pais_del_hecho_Pais.Nombre
                    ,Estado_del_Hecho = Detalle_de_Datos_GeneralesData.Estado_del_Hecho
                    ,Estado_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Estado_del_Hecho), "Estado") ??  (string)Detalle_de_Datos_GeneralesData.Estado_del_Hecho_Estado.Nombre
                    ,Municipio_de_los_Hechos = Detalle_de_Datos_GeneralesData.Municipio_de_los_Hechos
                    ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Municipio_de_los_Hechos), "Municipio") ??  (string)Detalle_de_Datos_GeneralesData.Municipio_de_los_Hechos_Municipio.Nombre
                    ,Poblacion_Hechos = Detalle_de_Datos_GeneralesData.Poblacion_Hechos
                    ,Poblacion_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Poblacion_Hechos), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Poblacion_Hechos_Colonia.Nombre
                    ,Colonia_de_los_Hechos = Detalle_de_Datos_GeneralesData.Colonia_de_los_Hechos
                    ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Colonia_de_los_Hechos), "Colonia") ??  (string)Detalle_de_Datos_GeneralesData.Colonia_de_los_Hechos_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos = Detalle_de_Datos_GeneralesData.Codigo_Postal_de_los_Hechos
                    ,Calle_de_los_Hechos = Detalle_de_Datos_GeneralesData.Calle_de_los_Hechos
                    ,Entre_Calle_de_los_Hechos = Detalle_de_Datos_GeneralesData.Entre_Calle_de_los_Hechos
                    ,Y_calle_de_los_hechos = Detalle_de_Datos_GeneralesData.Y_calle_de_los_hechos
                    ,Numero_Exterior_de_los_Hechos = Detalle_de_Datos_GeneralesData.Numero_Exterior_de_los_Hechos
                    ,Numero_Interior_de_los_Hechos = Detalle_de_Datos_GeneralesData.Numero_Interior_de_los_Hechos
                    ,Referencia_Hechos = Detalle_de_Datos_GeneralesData.Referencia_Hechos
                    ,Latitud_de_los_Hechos = Detalle_de_Datos_GeneralesData.Latitud_de_los_Hechos
                    ,Longitud_de_los_Hechos = Detalle_de_Datos_GeneralesData.Longitud_de_los_Hechos
                    ,Documento_Extraviado = Detalle_de_Datos_GeneralesData.Documento_Extraviado.GetValueOrDefault()
                    ,Tipo_de_Documento_Extraviado = Detalle_de_Datos_GeneralesData.Tipo_de_Documento_Extraviado
                    ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Documento_Extraviado), "Documento_Extraviado") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                    ,Tipo_de_lugar_del_hecho = Detalle_de_Datos_GeneralesData.Tipo_de_lugar_del_hecho
                    ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_lugar_del_hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion
                    ,Peso = Detalle_de_Datos_GeneralesData.Peso
                    ,Estatura = Detalle_de_Datos_GeneralesData.Estatura
                    ,Padecimiento_de_Enfermedad = Detalle_de_Datos_GeneralesData.Padecimiento_de_Enfermedad
                    ,Forma_Cara = Detalle_de_Datos_GeneralesData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_Cara), "Forma_Cara") ??  (string)Detalle_de_Datos_GeneralesData.Forma_Cara_Forma_Cara.Descripcion
                    ,Tipo_de_Cejas = Detalle_de_Datos_GeneralesData.Tipo_de_Cejas
                    ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_de_Cejas), "Cejas") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_de_Cejas_Cejas.Descripcion
                    ,Tamano_de_Cejas = Detalle_de_Datos_GeneralesData.Tamano_de_Cejas
                    ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_de_Cejas), "Tamano_de_Cejas") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                    ,Cantidad_Cabello = Detalle_de_Datos_GeneralesData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Detalle_de_Datos_GeneralesData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Detalle_de_Datos_GeneralesData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Complexion), "Complexion") ??  (string)Detalle_de_Datos_GeneralesData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Detalle_de_Datos_GeneralesData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Color_Piel), "Color_Piel") ??  (string)Detalle_de_Datos_GeneralesData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Detalle_de_Datos_GeneralesData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Frente), "Frente") ??  (string)Detalle_de_Datos_GeneralesData.Frente_Frente.Descripcion
                    ,Largo_de_Cabello = Detalle_de_Datos_GeneralesData.Largo_de_Cabello
                    ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Largo_de_Cabello), "Largo_de_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                    ,Forma_de_Cabello = Detalle_de_Datos_GeneralesData.Forma_de_Cabello
                    ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_de_Cabello), "Forma_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Forma_de_Cabello_Forma_Cabello.Descripcion
                    ,Color_Cabello = Detalle_de_Datos_GeneralesData.Color_Cabello
                    ,Color_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Color_Cabello), "Color_de_Cabello") ??  (string)Detalle_de_Datos_GeneralesData.Color_Cabello_Color_de_Cabello.Descripcion
                    ,Calvicie = Detalle_de_Datos_GeneralesData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Calvicie), "Calvicie") ??  (string)Detalle_de_Datos_GeneralesData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Detalle_de_Datos_GeneralesData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Color_Ojos), "Color_Ojos") ??  (string)Detalle_de_Datos_GeneralesData.Color_Ojos_Color_Ojos.Descripcion
                    ,Tamano_de_Ojos = Detalle_de_Datos_GeneralesData.Tamano_de_Ojos
                    ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_de_Ojos), "Ojos") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_de_Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Detalle_de_Datos_GeneralesData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_Ojos), "Froma_Ojos") ??  (string)Detalle_de_Datos_GeneralesData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Anteojos = Detalle_de_Datos_GeneralesData.Anteojos
                    ,AnteojosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Anteojos), "Anteojos") ??  (string)Detalle_de_Datos_GeneralesData.Anteojos_Anteojos.Descripcion
                    ,Forma_de_Nariz = Detalle_de_Datos_GeneralesData.Forma_de_Nariz
                    ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_de_Nariz), "Forma_de_Nariz") ??  (string)Detalle_de_Datos_GeneralesData.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                    ,Tamano_Nariz = Detalle_de_Datos_GeneralesData.Tamano_Nariz
                    ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_Nariz), "Tamano_de_Nariz") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_Nariz_Tamano_de_Nariz.Descripcion
                    ,Labios = Detalle_de_Datos_GeneralesData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Labios), "Labios") ??  (string)Detalle_de_Datos_GeneralesData.Labios_Labios.Descripcion
                    ,Boca = Detalle_de_Datos_GeneralesData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Boca), "Boca") ??  (string)Detalle_de_Datos_GeneralesData.Boca_Boca.Descripcion
                    ,Grosor_de_Labios = Detalle_de_Datos_GeneralesData.Grosor_de_Labios
                    ,Grosor_de_LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Grosor_de_Labios), "Grosor_de_Labios") ??  (string)Detalle_de_Datos_GeneralesData.Grosor_de_Labios_Grosor_de_Labios.Descripcion
                    ,Menton = Detalle_de_Datos_GeneralesData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Menton), "Menton") ??  (string)Detalle_de_Datos_GeneralesData.Menton_Menton.Descripcion
                    ,Forma_de_Menton = Detalle_de_Datos_GeneralesData.Forma_de_Menton
                    ,Forma_de_MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_de_Menton), "Forma_de_Menton") ??  (string)Detalle_de_Datos_GeneralesData.Forma_de_Menton_Forma_de_Menton.Descripcion
                    ,Barba = Detalle_de_Datos_GeneralesData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Barba), "Barba") ??  (string)Detalle_de_Datos_GeneralesData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Detalle_de_Datos_GeneralesData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Forma_Orejas), "Forma_Orejas") ??  (string)Detalle_de_Datos_GeneralesData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Detalle_de_Datos_GeneralesData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tamano_Orejas), "Tamano_Orejas") ??  (string)Detalle_de_Datos_GeneralesData.Tamano_Orejas_Tamano_Orejas.Descripcion
                    ,Tipo_Lobulo = Detalle_de_Datos_GeneralesData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Detalle_de_Datos_GeneralesData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Detalle_de_Datos_GeneralesData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Bigote), "Bigote") ??  (string)Detalle_de_Datos_GeneralesData.Bigote_Bigote.Descripcion
                    ,Senas_Particulares = Detalle_de_Datos_GeneralesData.Senas_Particulares
                    ,Senas_ParticularesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Senas_Particulares), "Senas_Particulares") ??  (string)Detalle_de_Datos_GeneralesData.Senas_Particulares_Senas_Particulares.Descripcion
                    ,Imagen_Tatuaje = Detalle_de_Datos_GeneralesData.Imagen_Tatuaje
                    ,Situacion_Fisica = Detalle_de_Datos_GeneralesData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Detalle_de_Datos_GeneralesData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Otras_Senas_Particulares = Detalle_de_Datos_GeneralesData.Otras_Senas_Particulares
                    ,Causal = Detalle_de_Datos_GeneralesData.Causal
                    ,CausalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Causal), "A_Tiempo") ??  (string)Detalle_de_Datos_GeneralesData.Causal_A_Tiempo.Descripcion
                    ,Causa_de_Interrupcion = Detalle_de_Datos_GeneralesData.Causa_de_Interrupcion
                    ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Causa_de_Interrupcion), "Causas_de_Interrupcion") ??  (string)Detalle_de_Datos_GeneralesData.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                    ,Datos_Insuficientes = Detalle_de_Datos_GeneralesData.Datos_Insuficientes
                    ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_GeneralesData.Datos_Insuficientes), "A_Tiempo") ??  (string)Detalle_de_Datos_GeneralesData.Datos_Insuficientes_A_Tiempo.Descripcion
                    ,Actualizacion_de_Sobreseimiento = Detalle_de_Datos_GeneralesData.Actualizacion_de_Sobreseimiento

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Imagen_TatuajeSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Datos_Generales.Imagen_Tatuaje).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Vida = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Vida != null && A_Tiempos_Con_Vida.Resource != null)
                ViewBag.A_Tiempos_Con_Vida = A_Tiempos_Con_Vida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Corporacion = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Corporacion != null && Municipios_Municipio_Corporacion.Resource != null)
                ViewBag.Municipios_Municipio_Corporacion = Municipios_Municipio_Corporacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_al_que_PerteneceApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_al_que_Perteneces_Grupo_al_que_pertenece = _IGrupo_al_que_PerteneceApiConsumer.SelAll(true);
            if (Grupo_al_que_Perteneces_Grupo_al_que_pertenece != null && Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource != null)
                ViewBag.Grupo_al_que_Perteneces_Grupo_al_que_pertenece = Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_al_que_Pertenece", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPreferencia_SexualApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Preferencia_Sexuals_Preferencia_Sexual = _IPreferencia_SexualApiConsumer.SelAll(true);
            if (Preferencia_Sexuals_Preferencia_Sexual != null && Preferencia_Sexuals_Preferencia_Sexual.Resource != null)
                ViewBag.Preferencia_Sexuals_Preferencia_Sexual = Preferencia_Sexuals_Preferencia_Sexual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Preferencia_Sexual", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_ = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_ != null && Escolaridads_Escolaridad_.Resource != null)
                ViewBag.Escolaridads_Escolaridad_ = Escolaridads_Escolaridad_.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstado_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_de_Involucrados_Estado_de_Involucrado = _IEstado_de_InvolucradoApiConsumer.SelAll(true);
            if (Estado_de_Involucrados_Estado_de_Involucrado != null && Estado_de_Involucrados_Estado_de_Involucrado.Resource != null)
                ViewBag.Estado_de_Involucrados_Estado_de_Involucrado = Estado_de_Involucrados_Estado_de_Involucrado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_de_Involucrado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo2 = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo2 != null && Generos_Sexo2.Resource != null)
                ViewBag.Generos_Sexo2 = Generos_Sexo2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad2 = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad2 != null && Nacionalidads_Nacionalidad2.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad2 = Nacionalidads_Nacionalidad2.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad2 = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad2 != null && Escolaridads_Escolaridad2.Resource != null)
                ViewBag.Escolaridads_Escolaridad2 = Escolaridads_Escolaridad2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_lugar_del_hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_lugar_del_hecho != null && Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_lugar_del_hecho = Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_de_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_de_Cabello != null && Forma_Cabellos_Forma_de_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_de_Cabello = Forma_Cabellos_Forma_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITamano_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Narizs_Tamano_Nariz = _ITamano_de_NarizApiConsumer.SelAll(true);
            if (Tamano_de_Narizs_Tamano_Nariz != null && Tamano_de_Narizs_Tamano_Nariz.Resource != null)
                ViewBag.Tamano_de_Narizs_Tamano_Nariz = Tamano_de_Narizs_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal != null && A_Tiempos_Causal.Resource != null)
                ViewBag.A_Tiempos_Causal = A_Tiempos_Causal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Datos_Generales", varDetalle_de_Datos_Generales);
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
        public ActionResult GetTipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetGrupo_al_que_PerteneceAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_al_que_PerteneceApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrupo_al_que_PerteneceApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_al_que_Pertenece", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPreferencia_SexualAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPreferencia_SexualApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPreferencia_SexualApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Preferencia_Sexual", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetEstado_de_InvolucradoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_de_InvolucradoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_de_Involucrado", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetLocalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILocalidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPrioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDocumento_ExtraviadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumento_ExtraviadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetTamano_de_NarizAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITamano_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITamano_de_NarizApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Nariz", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetCausas_de_InterrupcionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICausas_de_InterrupcionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_Datos_GeneralesAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Vida = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Vida != null && A_Tiempos_Con_Vida.Resource != null)
                ViewBag.A_Tiempos_Con_Vida = A_Tiempos_Con_Vida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Corporacion = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Corporacion != null && Municipios_Municipio_Corporacion.Resource != null)
                ViewBag.Municipios_Municipio_Corporacion = Municipios_Municipio_Corporacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_al_que_PerteneceApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_al_que_Perteneces_Grupo_al_que_pertenece = _IGrupo_al_que_PerteneceApiConsumer.SelAll(true);
            if (Grupo_al_que_Perteneces_Grupo_al_que_pertenece != null && Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource != null)
                ViewBag.Grupo_al_que_Perteneces_Grupo_al_que_pertenece = Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_al_que_Pertenece", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPreferencia_SexualApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Preferencia_Sexuals_Preferencia_Sexual = _IPreferencia_SexualApiConsumer.SelAll(true);
            if (Preferencia_Sexuals_Preferencia_Sexual != null && Preferencia_Sexuals_Preferencia_Sexual.Resource != null)
                ViewBag.Preferencia_Sexuals_Preferencia_Sexual = Preferencia_Sexuals_Preferencia_Sexual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Preferencia_Sexual", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_ = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_ != null && Escolaridads_Escolaridad_.Resource != null)
                ViewBag.Escolaridads_Escolaridad_ = Escolaridads_Escolaridad_.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstado_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_de_Involucrados_Estado_de_Involucrado = _IEstado_de_InvolucradoApiConsumer.SelAll(true);
            if (Estado_de_Involucrados_Estado_de_Involucrado != null && Estado_de_Involucrados_Estado_de_Involucrado.Resource != null)
                ViewBag.Estado_de_Involucrados_Estado_de_Involucrado = Estado_de_Involucrados_Estado_de_Involucrado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_de_Involucrado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo2 = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo2 != null && Generos_Sexo2.Resource != null)
                ViewBag.Generos_Sexo2 = Generos_Sexo2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad2 = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad2 != null && Nacionalidads_Nacionalidad2.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad2 = Nacionalidads_Nacionalidad2.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad2 = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad2 != null && Escolaridads_Escolaridad2.Resource != null)
                ViewBag.Escolaridads_Escolaridad2 = Escolaridads_Escolaridad2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_lugar_del_hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_lugar_del_hecho != null && Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_lugar_del_hecho = Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_de_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_de_Cabello != null && Forma_Cabellos_Forma_de_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_de_Cabello = Forma_Cabellos_Forma_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITamano_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Narizs_Tamano_Nariz = _ITamano_de_NarizApiConsumer.SelAll(true);
            if (Tamano_de_Narizs_Tamano_Nariz != null && Tamano_de_Narizs_Tamano_Nariz.Resource != null)
                ViewBag.Tamano_de_Narizs_Tamano_Nariz = Tamano_de_Narizs_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal != null && A_Tiempos_Causal.Resource != null)
                ViewBag.A_Tiempos_Causal = A_Tiempos_Causal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Vida = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Vida != null && A_Tiempos_Con_Vida.Resource != null)
                ViewBag.A_Tiempos_Con_Vida = A_Tiempos_Con_Vida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Corporacion = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Corporacion != null && Municipios_Municipio_Corporacion.Resource != null)
                ViewBag.Municipios_Municipio_Corporacion = Municipios_Municipio_Corporacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_al_que_PerteneceApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_al_que_Perteneces_Grupo_al_que_pertenece = _IGrupo_al_que_PerteneceApiConsumer.SelAll(true);
            if (Grupo_al_que_Perteneces_Grupo_al_que_pertenece != null && Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource != null)
                ViewBag.Grupo_al_que_Perteneces_Grupo_al_que_pertenece = Grupo_al_que_Perteneces_Grupo_al_que_pertenece.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_al_que_Pertenece", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPreferencia_SexualApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Preferencia_Sexuals_Preferencia_Sexual = _IPreferencia_SexualApiConsumer.SelAll(true);
            if (Preferencia_Sexuals_Preferencia_Sexual != null && Preferencia_Sexuals_Preferencia_Sexual.Resource != null)
                ViewBag.Preferencia_Sexuals_Preferencia_Sexual = Preferencia_Sexuals_Preferencia_Sexual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Preferencia_Sexual", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_ = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_ != null && Escolaridads_Escolaridad_.Resource != null)
                ViewBag.Escolaridads_Escolaridad_ = Escolaridads_Escolaridad_.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstado_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_de_Involucrados_Estado_de_Involucrado = _IEstado_de_InvolucradoApiConsumer.SelAll(true);
            if (Estado_de_Involucrados_Estado_de_Involucrado != null && Estado_de_Involucrados_Estado_de_Involucrado.Resource != null)
                ViewBag.Estado_de_Involucrados_Estado_de_Involucrado = Estado_de_Involucrados_Estado_de_Involucrado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_de_Involucrado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo2 = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo2 != null && Generos_Sexo2.Resource != null)
                ViewBag.Generos_Sexo2 = Generos_Sexo2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad2 = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad2 != null && Nacionalidads_Nacionalidad2.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad2 = Nacionalidads_Nacionalidad2.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad2 = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad2 != null && Escolaridads_Escolaridad2.Resource != null)
                ViewBag.Escolaridads_Escolaridad2 = Escolaridads_Escolaridad2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_lugar_del_hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_lugar_del_hecho != null && Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_lugar_del_hecho = Lugar_Tipos_Tipo_de_lugar_del_hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILargo_de_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Largo_de_Cabellos_Largo_de_Cabello = _ILargo_de_CabelloApiConsumer.SelAll(true);
            if (Largo_de_Cabellos_Largo_de_Cabello != null && Largo_de_Cabellos_Largo_de_Cabello.Resource != null)
                ViewBag.Largo_de_Cabellos_Largo_de_Cabello = Largo_de_Cabellos_Largo_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Largo_de_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_de_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_de_Cabello != null && Forma_Cabellos_Forma_de_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_de_Cabello = Forma_Cabellos_Forma_de_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITamano_de_NarizApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tamano_de_Narizs_Tamano_Nariz = _ITamano_de_NarizApiConsumer.SelAll(true);
            if (Tamano_de_Narizs_Tamano_Nariz != null && Tamano_de_Narizs_Tamano_Nariz.Resource != null)
                ViewBag.Tamano_de_Narizs_Tamano_Nariz = Tamano_de_Narizs_Tamano_Nariz.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tamano_de_Nariz", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal != null && A_Tiempos_Causal.Resource != null)
                ViewBag.A_Tiempos_Causal = A_Tiempos_Causal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Datos_GeneralesAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Datos_GeneralesAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Datos_GeneralesAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_GeneralesPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_Generaless == null)
                result.Detalle_de_Datos_Generaless = new List<Detalle_de_Datos_Generales>();

            return Json(new
            {
                data = result.Detalle_de_Datos_Generaless.Select(m => new Detalle_de_Datos_GeneralesGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
			,Datos_Confidenciales = m.Datos_Confidenciales
			,Se_Informo_sobre_el_Procedimiento = m.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Persona_Desaparecida = m.Persona_Desaparecida
			,Persona_Aparecio = m.Persona_Aparecio
                        ,Fecha_de_Aparicion = (m.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                        ,Con_VidaDescripcion = CultureHelper.GetTraduction(m.Con_Vida_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Vida_A_Tiempo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Q_Q_R_O_ = m.Q_Q_R_O_
			,Es_victima = m.Es_victima
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,CURP = m.CURP
			,RFC = m.RFC
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(m.Municipio_Corporacion_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Corporacion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Situacion_de_Vulnerabilidad = m.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                        ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(m.Preferencia_Sexual_Preferencia_Sexual.Clave.ToString(), "Descripcion") ?? (string)m.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No_de_Hijos = m.No_de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Escolaridad_Descripcion = CultureHelper.GetTraduction(m.Escolaridad__Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad__Escolaridad.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
			,Incompleto = m.Incompleto
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
                        ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(m.Estado_de_Involucrado_Estado_de_Involucrado.Clave.ToString(), "Descripcion") ?? (string)m.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
			,Se_Informaron_sobre_sus_Derechos = m.Se_Informaron_sobre_sus_Derechos
			,Gravidez = m.Gravidez
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Poblacion_TutorNombre = CultureHelper.GetTraduction(m.Poblacion_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Tutor_Colonia.Nombre
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Referencia_de_Domicilio_Tutor = m.Referencia_de_Domicilio_Tutor
			,Latitud_Tutor = m.Latitud_Tutor
			,Longitud_Tutor = m.Longitud_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombres2 = m.Nombres2
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,Sexo2Descripcion = CultureHelper.GetTraduction(m.Sexo2_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo2_Genero.Descripcion
                        ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad2_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad2_Nacionalidad.NacionalidadC
                        ,Escolaridad2Descripcion = CultureHelper.GetTraduction(m.Escolaridad2_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad2_Escolaridad.Descripcion
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_hechoNombre = CultureHelper.GetTraduction(m.Pais_del_hecho_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_hecho_Pais.Nombre
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Poblacion_HechosNombre = CultureHelper.GetTraduction(m.Poblacion_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Hechos_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_calle_de_los_hechos = m.Y_calle_de_los_hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_Hechos = m.Referencia_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
			,Documento_Extraviado = m.Documento_Extraviado
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Tamano_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Tamano_de_Nariz.Descripcion
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
                        ,CausalDescripcion = CultureHelper.GetTraduction(m.Causal_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", m.),
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
        /// Get List of Detalle_de_Datos_Generales from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Datos_Generales Entity</returns>
        public ActionResult GetDetalle_de_Datos_GeneralesList(UrlParametersModel param)
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
            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Datos_GeneralesPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Datos_GeneralesAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Datos_GeneralesAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Datos_GeneralesPropertyMapper oDetalle_de_Datos_GeneralesPropertyMapper = new Detalle_de_Datos_GeneralesPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Datos_GeneralesPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_Generaless == null)
                result.Detalle_de_Datos_Generaless = new List<Detalle_de_Datos_Generales>();

            return Json(new
            {
                aaData = result.Detalle_de_Datos_Generaless.Select(m => new Detalle_de_Datos_GeneralesGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
			,Datos_Confidenciales = m.Datos_Confidenciales
			,Se_Informo_sobre_el_Procedimiento = m.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Persona_Desaparecida = m.Persona_Desaparecida
			,Persona_Aparecio = m.Persona_Aparecio
                        ,Fecha_de_Aparicion = (m.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                        ,Con_VidaDescripcion = CultureHelper.GetTraduction(m.Con_Vida_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Vida_A_Tiempo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Q_Q_R_O_ = m.Q_Q_R_O_
			,Es_victima = m.Es_victima
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,CURP = m.CURP
			,RFC = m.RFC
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(m.Municipio_Corporacion_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Corporacion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Situacion_de_Vulnerabilidad = m.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                        ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(m.Preferencia_Sexual_Preferencia_Sexual.Clave.ToString(), "Descripcion") ?? (string)m.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No_de_Hijos = m.No_de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Escolaridad_Descripcion = CultureHelper.GetTraduction(m.Escolaridad__Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad__Escolaridad.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
			,Incompleto = m.Incompleto
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
                        ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(m.Estado_de_Involucrado_Estado_de_Involucrado.Clave.ToString(), "Descripcion") ?? (string)m.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
			,Se_Informaron_sobre_sus_Derechos = m.Se_Informaron_sobre_sus_Derechos
			,Gravidez = m.Gravidez
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Poblacion_TutorNombre = CultureHelper.GetTraduction(m.Poblacion_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Tutor_Colonia.Nombre
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Referencia_de_Domicilio_Tutor = m.Referencia_de_Domicilio_Tutor
			,Latitud_Tutor = m.Latitud_Tutor
			,Longitud_Tutor = m.Longitud_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombres2 = m.Nombres2
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,Sexo2Descripcion = CultureHelper.GetTraduction(m.Sexo2_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo2_Genero.Descripcion
                        ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad2_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad2_Nacionalidad.NacionalidadC
                        ,Escolaridad2Descripcion = CultureHelper.GetTraduction(m.Escolaridad2_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad2_Escolaridad.Descripcion
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_hechoNombre = CultureHelper.GetTraduction(m.Pais_del_hecho_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_hecho_Pais.Nombre
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Poblacion_HechosNombre = CultureHelper.GetTraduction(m.Poblacion_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Hechos_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_calle_de_los_hechos = m.Y_calle_de_los_hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_Hechos = m.Referencia_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
			,Documento_Extraviado = m.Documento_Extraviado
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Tamano_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Tamano_de_Nariz.Descripcion
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
                        ,CausalDescripcion = CultureHelper.GetTraduction(m.Causal_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Datos_Generales_Modulo_Atencion_Inicial_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Expediente_MASC_Solicitud(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Nacionalidad_Nacionalidad(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Pais_de_Origen_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Pais_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Colonia_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Estado_de_Nacimiento_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Municipio_de_Nacimiento_Municipio(string query, string where)
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

//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetOtros_Domicilios_Involucrado_Estado_Estado(string query, string where)
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
        public JsonResult GetOtros_Domicilios_Involucrado_Municipio_Municipio(string query, string where)
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
        public JsonResult GetOtros_Domicilios_Involucrado_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetOtros_Domicilios_Involucrado_Colonia_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Pais_de_Origen_Tutor_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Pais_del_Tutor_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Estado_del_Tutor_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Municipio_del_Tutor_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Poblacion_Tutor_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Colonia_del_Tutor_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Pais_del_hecho_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Estado_del_Hecho_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Municipio_de_los_Hechos_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Poblacion_Hechos_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Datos_Generales_Colonia_de_los_Hechos_Colonia(string query, string where)
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
        public string GetAdvanceFilter(Detalle_de_Datos_GeneralesAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Datos_Generales.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Datos_Generales.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Atencion_Inicial))
            {
                switch (filter.Modulo_Atencion_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_Atencion_InicialMultiple != null && filter.AdvanceModulo_Atencion_InicialMultiple.Count() > 0)
            {
                var Modulo_Atencion_InicialIds = string.Join(",", filter.AdvanceModulo_Atencion_InicialMultiple);

                where += " AND Detalle_de_Datos_Generales.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Expediente_MP In (" + Expediente_MPIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Expediente_MASC In (" + Expediente_MASCIds + ")";
            }

            if (filter.Datos_Confidenciales != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Datos_Confidenciales = " + Convert.ToInt32(filter.Datos_Confidenciales);

            if (filter.Se_Informo_sobre_el_Procedimiento != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Se_Informo_sobre_el_Procedimiento = " + Convert.ToInt32(filter.Se_Informo_sobre_el_Procedimiento);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Compareciente))
            {
                switch (filter.Tipo_de_ComparecienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '" + filter.AdvanceTipo_de_Compareciente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceTipo_de_Compareciente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Compareciente.Descripcion = '" + filter.AdvanceTipo_de_Compareciente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceTipo_de_Compareciente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ComparecienteMultiple != null && filter.AdvanceTipo_de_ComparecienteMultiple.Count() > 0)
            {
                var Tipo_de_ComparecienteIds = string.Join(",", filter.AdvanceTipo_de_ComparecienteMultiple);

                where += " AND Detalle_de_Datos_Generales.Tipo_de_Compareciente In (" + Tipo_de_ComparecienteIds + ")";
            }

            if (filter.Persona_Desaparecida != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Persona_Desaparecida = " + Convert.ToInt32(filter.Persona_Desaparecida);

            if (filter.Persona_Aparecio != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Persona_Aparecio = " + Convert.ToInt32(filter.Persona_Aparecio);

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Aparicion) || !string.IsNullOrEmpty(filter.ToFecha_de_Aparicion))
            {
                var Fecha_de_AparicionFrom = DateTime.ParseExact(filter.FromFecha_de_Aparicion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AparicionTo = DateTime.ParseExact(filter.ToFecha_de_Aparicion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Aparicion))
                    where += " AND Detalle_de_Datos_Generales.Fecha_de_Aparicion >= '" + Fecha_de_AparicionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Aparicion))
                    where += " AND Detalle_de_Datos_Generales.Fecha_de_Aparicion <= '" + Fecha_de_AparicionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCon_Vida))
            {
                switch (filter.Con_VidaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceCon_Vida + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCon_Vida + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceCon_Vida + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCon_Vida + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCon_VidaMultiple != null && filter.AdvanceCon_VidaMultiple.Count() > 0)
            {
                var Con_VidaIds = string.Join(",", filter.AdvanceCon_VidaMultiple);

                where += " AND Detalle_de_Datos_Generales.Con_Vida In (" + Con_VidaIds + ")";
            }

            if (filter.Persona_Moral != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Persona_Moral = " + Convert.ToInt32(filter.Persona_Moral);

            if (filter.Q_Q_R_O_ != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Q_Q_R_O_ = " + Convert.ToInt32(filter.Q_Q_R_O_);

            if (filter.Es_victima != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Es_victima = " + Convert.ToInt32(filter.Es_victima);

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
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
                    where += " AND Detalle_de_Datos_Generales.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Detalle_de_Datos_Generales.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Detalle_de_Datos_Generales.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Detalle_de_Datos_Generales.Edad <= " + filter.ToEdad;
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

                where += " AND Detalle_de_Datos_Generales.Sexo In (" + SexoIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CURP))
            {
                switch (filter.CURPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.CURP LIKE '" + filter.CURP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.CURP LIKE '%" + filter.CURP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.CURP = '" + filter.CURP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.CURP LIKE '%" + filter.CURP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC))
            {
                switch (filter.RFCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.RFC LIKE '" + filter.RFC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.RFC LIKE '%" + filter.RFC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.RFC = '" + filter.RFC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.RFC LIKE '%" + filter.RFC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Calidad_Juridica))
            {
                switch (filter.Calidad_JuridicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Calidad_Juridica LIKE '" + filter.Calidad_Juridica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Calidad_Juridica LIKE '%" + filter.Calidad_Juridica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Calidad_Juridica = '" + filter.Calidad_Juridica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Calidad_Juridica LIKE '%" + filter.Calidad_Juridica + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Razon_Social))
            {
                switch (filter.Razon_SocialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Razon_Social LIKE '" + filter.Razon_Social + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Razon_Social LIKE '%" + filter.Razon_Social + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Razon_Social = '" + filter.Razon_Social + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Razon_Social LIKE '%" + filter.Razon_Social + "%'";
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

                where += " AND Detalle_de_Datos_Generales.Nacionalidad In (" + NacionalidadIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Ocupacion In (" + OcupacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_Corporacion))
            {
                switch (filter.Municipio_CorporacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_Corporacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Corporacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_Corporacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Corporacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_CorporacionMultiple != null && filter.AdvanceMunicipio_CorporacionMultiple.Count() > 0)
            {
                var Municipio_CorporacionIds = string.Join(",", filter.AdvanceMunicipio_CorporacionMultiple);

                where += " AND Detalle_de_Datos_Generales.Municipio_Corporacion In (" + Municipio_CorporacionIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Corporacion In (" + CorporacionIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Pais_de_Origen In (" + Pais_de_OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de))
            {
                switch (filter.Originario_deFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Originario_de LIKE '" + filter.Originario_de + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Originario_de LIKE '%" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Originario_de = '" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Originario_de LIKE '%" + filter.Originario_de + "%'";
                        break;
                }
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

                where += " AND Detalle_de_Datos_Generales.Pais In (" + PaisIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Estado In (" + EstadoIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Poblacion In (" + PoblacionIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Datos_Generales.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Datos_Generales.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_de_Domicilio))
            {
                switch (filter.Referencia_de_DomicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio LIKE '" + filter.Referencia_de_Domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio LIKE '%" + filter.Referencia_de_Domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio = '" + filter.Referencia_de_Domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio LIKE '%" + filter.Referencia_de_Domicilio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromExtension) || !string.IsNullOrEmpty(filter.ToExtension))
            {
                if (!string.IsNullOrEmpty(filter.FromExtension))
                    where += " AND Detalle_de_Datos_Generales.Extension >= " + filter.FromExtension;
                if (!string.IsNullOrEmpty(filter.ToExtension))
                    where += " AND Detalle_de_Datos_Generales.Extension <= " + filter.ToExtension;
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (filter.Situacion_de_Vulnerabilidad != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Situacion_de_Vulnerabilidad = " + Convert.ToInt32(filter.Situacion_de_Vulnerabilidad);

            if (!string.IsNullOrEmpty(filter.AdvanceGrupo_al_que_pertenece))
            {
                switch (filter.Grupo_al_que_perteneceFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Grupo_al_que_Pertenece.Descripcion LIKE '" + filter.AdvanceGrupo_al_que_pertenece + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Grupo_al_que_Pertenece.Descripcion LIKE '%" + filter.AdvanceGrupo_al_que_pertenece + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Grupo_al_que_Pertenece.Descripcion = '" + filter.AdvanceGrupo_al_que_pertenece + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Grupo_al_que_Pertenece.Descripcion LIKE '%" + filter.AdvanceGrupo_al_que_pertenece + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGrupo_al_que_perteneceMultiple != null && filter.AdvanceGrupo_al_que_perteneceMultiple.Count() > 0)
            {
                var Grupo_al_que_perteneceIds = string.Join(",", filter.AdvanceGrupo_al_que_perteneceMultiple);

                where += " AND Detalle_de_Datos_Generales.Grupo_al_que_pertenece In (" + Grupo_al_que_perteneceIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePreferencia_Sexual))
            {
                switch (filter.Preferencia_SexualFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Preferencia_Sexual.Descripcion LIKE '" + filter.AdvancePreferencia_Sexual + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Preferencia_Sexual.Descripcion LIKE '%" + filter.AdvancePreferencia_Sexual + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Preferencia_Sexual.Descripcion = '" + filter.AdvancePreferencia_Sexual + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Preferencia_Sexual.Descripcion LIKE '%" + filter.AdvancePreferencia_Sexual + "%'";
                        break;
                }
            }
            else if (filter.AdvancePreferencia_SexualMultiple != null && filter.AdvancePreferencia_SexualMultiple.Count() > 0)
            {
                var Preferencia_SexualIds = string.Join(",", filter.AdvancePreferencia_SexualMultiple);

                where += " AND Detalle_de_Datos_Generales.Preferencia_Sexual In (" + Preferencia_SexualIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Etnia In (" + EtniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromNo_de_Hijos) || !string.IsNullOrEmpty(filter.ToNo_de_Hijos))
            {
                if (!string.IsNullOrEmpty(filter.FromNo_de_Hijos))
                    where += " AND Detalle_de_Datos_Generales.No_de_Hijos >= " + filter.FromNo_de_Hijos;
                if (!string.IsNullOrEmpty(filter.ToNo_de_Hijos))
                    where += " AND Detalle_de_Datos_Generales.No_de_Hijos <= " + filter.ToNo_de_Hijos;
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

                where += " AND Detalle_de_Datos_Generales.Religion In (" + ReligionIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Servicio_Medico In (" + Servicio_MedicoIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Escolaridad In (" + EscolaridadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad_))
            {
                switch (filter.Escolaridad_Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad_ + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_ + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad_ + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_ + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridad_Multiple != null && filter.AdvanceEscolaridad_Multiple.Count() > 0)
            {
                var Escolaridad_Ids = string.Join(",", filter.AdvanceEscolaridad_Multiple);

                where += " AND Detalle_de_Datos_Generales.Escolaridad_ In (" + Escolaridad_Ids + ")";
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

                where += " AND Detalle_de_Datos_Generales.Especialidad In (" + EspecialidadIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Estudios_Superiores In (" + Estudios_SuperioresIds + ")";
            }

            if (filter.Incompleto != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Incompleto = " + Convert.ToInt32(filter.Incompleto);

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

                where += " AND Detalle_de_Datos_Generales.Idioma In (" + IdiomaIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Calidad_Migratoria In (" + Calidad_MigratoriaIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Estado_de_Nacimiento In (" + Estado_de_NacimientoIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Municipio_de_Nacimiento In (" + Municipio_de_NacimientoIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Dialecto In (" + DialectoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_de_Involucrado))
            {
                switch (filter.Estado_de_InvolucradoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_de_Involucrado.Descripcion LIKE '" + filter.AdvanceEstado_de_Involucrado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_de_Involucrado.Descripcion LIKE '%" + filter.AdvanceEstado_de_Involucrado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_de_Involucrado.Descripcion = '" + filter.AdvanceEstado_de_Involucrado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_de_Involucrado.Descripcion LIKE '%" + filter.AdvanceEstado_de_Involucrado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_de_InvolucradoMultiple != null && filter.AdvanceEstado_de_InvolucradoMultiple.Count() > 0)
            {
                var Estado_de_InvolucradoIds = string.Join(",", filter.AdvanceEstado_de_InvolucradoMultiple);

                where += " AND Detalle_de_Datos_Generales.Estado_de_Involucrado In (" + Estado_de_InvolucradoIds + ")";
            }

            if (filter.Incapaz != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Incapaz = " + Convert.ToInt32(filter.Incapaz);

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

                where += " AND Detalle_de_Datos_Generales.Tipo_de_Inimputabilidad In (" + Tipo_de_InimputabilidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Especifique))
            {
                switch (filter.EspecifiqueFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Especifique LIKE '" + filter.Especifique + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Especifique LIKE '%" + filter.Especifique + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Especifique = '" + filter.Especifique + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Especifique LIKE '%" + filter.Especifique + "%'";
                        break;
                }
            }

            if (filter.Se_Informaron_sobre_sus_Derechos != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Se_Informaron_sobre_sus_Derechos = " + Convert.ToInt32(filter.Se_Informaron_sobre_sus_Derechos);

            if (filter.Gravidez != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Gravidez = " + Convert.ToInt32(filter.Gravidez);

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

                where += " AND Detalle_de_Datos_Generales.Discapacidad_Mental In (" + Discapacidad_MentalIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Discapacidad_Fisica In (" + Discapacidad_FisicaIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Discapacidad_Sensorial In (" + Discapacidad_SensorialIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Discapacidad_Psicosocial In (" + Discapacidad_PsicosocialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_del_Tutor))
            {
                switch (filter.Nombre_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '" + filter.Nombre_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '%" + filter.Nombre_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor = '" + filter.Nombre_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_del_Tutor LIKE '%" + filter.Nombre_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_del_Tutor))
            {
                switch (filter.Apellido_Paterno_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno_del_Tutor LIKE '" + filter.Apellido_Paterno_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno_del_Tutor LIKE '%" + filter.Apellido_Paterno_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno_del_Tutor = '" + filter.Apellido_Paterno_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno_del_Tutor LIKE '%" + filter.Apellido_Paterno_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_del_Tutor))
            {
                switch (filter.Apellido_Materno_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno_del_Tutor LIKE '" + filter.Apellido_Materno_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno_del_Tutor LIKE '%" + filter.Apellido_Materno_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno_del_Tutor = '" + filter.Apellido_Materno_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno_del_Tutor LIKE '%" + filter.Apellido_Materno_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo_del_Tutor))
            {
                switch (filter.Nombre_Completo_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor LIKE '" + filter.Nombre_Completo_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor LIKE '%" + filter.Nombre_Completo_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor = '" + filter.Nombre_Completo_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor LIKE '%" + filter.Nombre_Completo_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_del_Tutor) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_del_Tutor))
            {
                var Fecha_de_Nacimiento_del_TutorFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Nacimiento_del_TutorTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor >= '" + Fecha_de_Nacimiento_del_TutorFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor <= '" + Fecha_de_Nacimiento_del_TutorTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad_del_Tutor) || !string.IsNullOrEmpty(filter.ToEdad_del_Tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Edad_del_Tutor >= " + filter.FromEdad_del_Tutor;
                if (!string.IsNullOrEmpty(filter.ToEdad_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Edad_del_Tutor <= " + filter.ToEdad_del_Tutor;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo_del_Tutor))
            {
                switch (filter.Sexo_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexo_del_TutorMultiple != null && filter.AdvanceSexo_del_TutorMultiple.Count() > 0)
            {
                var Sexo_del_TutorIds = string.Join(",", filter.AdvanceSexo_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Sexo_del_Tutor In (" + Sexo_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Civil_del_Tutor))
            {
                switch (filter.Estado_Civil_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_Civil.Descripcion LIKE '" + filter.AdvanceEstado_Civil_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_Civil.Descripcion = '" + filter.AdvanceEstado_Civil_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_Civil_del_TutorMultiple != null && filter.AdvanceEstado_Civil_del_TutorMultiple.Count() > 0)
            {
                var Estado_Civil_del_TutorIds = string.Join(",", filter.AdvanceEstado_Civil_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Estado_Civil_del_Tutor In (" + Estado_Civil_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion_del_Tutor))
            {
                switch (filter.Tipo_de_Identificacion_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Identificacion_del_TutorMultiple != null && filter.AdvanceTipo_de_Identificacion_del_TutorMultiple.Count() > 0)
            {
                var Tipo_de_Identificacion_del_TutorIds = string.Join(",", filter.AdvanceTipo_de_Identificacion_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Tipo_de_Identificacion_del_Tutor In (" + Tipo_de_Identificacion_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion_del_Tutor))
            {
                switch (filter.Numero_de_Identificacion_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor LIKE '" + filter.Numero_de_Identificacion_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor LIKE '%" + filter.Numero_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor = '" + filter.Numero_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor LIKE '%" + filter.Numero_de_Identificacion_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CURP_Tutor))
            {
                switch (filter.CURP_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.CURP_Tutor LIKE '" + filter.CURP_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.CURP_Tutor LIKE '%" + filter.CURP_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.CURP_Tutor = '" + filter.CURP_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.CURP_Tutor LIKE '%" + filter.CURP_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC_Tutor))
            {
                switch (filter.RFC_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.RFC_Tutor LIKE '" + filter.RFC_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.RFC_Tutor LIKE '%" + filter.RFC_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.RFC_Tutor = '" + filter.RFC_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.RFC_Tutor LIKE '%" + filter.RFC_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad_del_Tutor))
            {
                switch (filter.Nacionalidad_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidad_del_TutorMultiple != null && filter.AdvanceNacionalidad_del_TutorMultiple.Count() > 0)
            {
                var Nacionalidad_del_TutorIds = string.Join(",", filter.AdvanceNacionalidad_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Nacionalidad_del_Tutor In (" + Nacionalidad_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad_del_Tutor))
            {
                switch (filter.Escolaridad_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridad_del_TutorMultiple != null && filter.AdvanceEscolaridad_del_TutorMultiple.Count() > 0)
            {
                var Escolaridad_del_TutorIds = string.Join(",", filter.AdvanceEscolaridad_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Escolaridad_del_Tutor In (" + Escolaridad_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOcupacion_del_Tutor))
            {
                switch (filter.Ocupacion_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ocupacion.Descripcion LIKE '" + filter.AdvanceOcupacion_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ocupacion.Descripcion = '" + filter.AdvanceOcupacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOcupacion_del_TutorMultiple != null && filter.AdvanceOcupacion_del_TutorMultiple.Count() > 0)
            {
                var Ocupacion_del_TutorIds = string.Join(",", filter.AdvanceOcupacion_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Ocupacion_del_Tutor In (" + Ocupacion_del_TutorIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Pais_de_Origen_Tutor In (" + Pais_de_Origen_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de_T))
            {
                switch (filter.Originario_de_TFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Originario_de_T LIKE '" + filter.Originario_de_T + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Originario_de_T LIKE '%" + filter.Originario_de_T + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Originario_de_T = '" + filter.Originario_de_T + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Originario_de_T LIKE '%" + filter.Originario_de_T + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_del_Tutor))
            {
                switch (filter.Pais_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_del_TutorMultiple != null && filter.AdvancePais_del_TutorMultiple.Count() > 0)
            {
                var Pais_del_TutorIds = string.Join(",", filter.AdvancePais_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Pais_del_Tutor In (" + Pais_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_del_Tutor))
            {
                switch (filter.Estado_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_del_TutorMultiple != null && filter.AdvanceEstado_del_TutorMultiple.Count() > 0)
            {
                var Estado_del_TutorIds = string.Join(",", filter.AdvanceEstado_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Estado_del_Tutor In (" + Estado_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_del_Tutor))
            {
                switch (filter.Municipio_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_del_TutorMultiple != null && filter.AdvanceMunicipio_del_TutorMultiple.Count() > 0)
            {
                var Municipio_del_TutorIds = string.Join(",", filter.AdvanceMunicipio_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Municipio_del_Tutor In (" + Municipio_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion_Tutor))
            {
                switch (filter.Poblacion_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacion_TutorMultiple != null && filter.AdvancePoblacion_TutorMultiple.Count() > 0)
            {
                var Poblacion_TutorIds = string.Join(",", filter.AdvancePoblacion_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Poblacion_Tutor In (" + Poblacion_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLocalidad_del_Tutor))
            {
                switch (filter.Localidad_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Localidad.Descripcion LIKE '" + filter.AdvanceLocalidad_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Localidad.Descripcion = '" + filter.AdvanceLocalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLocalidad_del_TutorMultiple != null && filter.AdvanceLocalidad_del_TutorMultiple.Count() > 0)
            {
                var Localidad_del_TutorIds = string.Join(",", filter.AdvanceLocalidad_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Localidad_del_Tutor In (" + Localidad_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_del_Tutor))
            {
                switch (filter.Colonia_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_del_TutorMultiple != null && filter.AdvanceColonia_del_TutorMultiple.Count() > 0)
            {
                var Colonia_del_TutorIds = string.Join(",", filter.AdvanceColonia_del_TutorMultiple);

                where += " AND Detalle_de_Datos_Generales.Colonia_del_Tutor In (" + Colonia_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_del_Tutor) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_del_Tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Codigo_Postal_del_Tutor >= " + filter.FromCodigo_Postal_del_Tutor;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Codigo_Postal_del_Tutor <= " + filter.ToCodigo_Postal_del_Tutor;
            }

            if (!string.IsNullOrEmpty(filter.Calle_del_Tutor))
            {
                switch (filter.Calle_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Calle_del_Tutor LIKE '" + filter.Calle_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Calle_del_Tutor LIKE '%" + filter.Calle_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Calle_del_Tutor = '" + filter.Calle_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Calle_del_Tutor LIKE '%" + filter.Calle_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_del_Tutor))
            {
                switch (filter.Numero_Exterior_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_del_Tutor LIKE '" + filter.Numero_Exterior_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_del_Tutor LIKE '%" + filter.Numero_Exterior_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_del_Tutor = '" + filter.Numero_Exterior_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_del_Tutor LIKE '%" + filter.Numero_Exterior_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_del_Tutor))
            {
                switch (filter.Numero_Interior_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_del_Tutor LIKE '" + filter.Numero_Interior_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_del_Tutor LIKE '%" + filter.Numero_Interior_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_del_Tutor = '" + filter.Numero_Interior_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_del_Tutor LIKE '%" + filter.Numero_Interior_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_de_Domicilio_Tutor))
            {
                switch (filter.Referencia_de_Domicilio_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor LIKE '" + filter.Referencia_de_Domicilio_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor LIKE '%" + filter.Referencia_de_Domicilio_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor = '" + filter.Referencia_de_Domicilio_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor LIKE '%" + filter.Referencia_de_Domicilio_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_Tutor))
            {
                switch (filter.Latitud_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Latitud_Tutor LIKE '" + filter.Latitud_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Latitud_Tutor LIKE '%" + filter.Latitud_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Latitud_Tutor = '" + filter.Latitud_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Latitud_Tutor LIKE '%" + filter.Latitud_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_Tutor))
            {
                switch (filter.Longitud_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Longitud_Tutor LIKE '" + filter.Longitud_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Longitud_Tutor LIKE '%" + filter.Longitud_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Longitud_Tutor = '" + filter.Longitud_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Longitud_Tutor LIKE '%" + filter.Longitud_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono_del_Tutor))
            {
                switch (filter.Telefono_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Telefono_del_Tutor LIKE '" + filter.Telefono_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Telefono_del_Tutor LIKE '%" + filter.Telefono_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Telefono_del_Tutor = '" + filter.Telefono_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Telefono_del_Tutor LIKE '%" + filter.Telefono_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromExtension_del_Tutor) || !string.IsNullOrEmpty(filter.ToExtension_del_Tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromExtension_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Extension_del_Tutor >= " + filter.FromExtension_del_Tutor;
                if (!string.IsNullOrEmpty(filter.ToExtension_del_Tutor))
                    where += " AND Detalle_de_Datos_Generales.Extension_del_Tutor <= " + filter.ToExtension_del_Tutor;
            }

            if (!string.IsNullOrEmpty(filter.Celular_del_Tutor))
            {
                switch (filter.Celular_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Celular_del_Tutor LIKE '" + filter.Celular_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Celular_del_Tutor LIKE '%" + filter.Celular_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Celular_del_Tutor = '" + filter.Celular_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Celular_del_Tutor LIKE '%" + filter.Celular_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico_del_Tutor))
            {
                switch (filter.Correo_Electronico_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico_del_Tutor LIKE '" + filter.Correo_Electronico_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico_del_Tutor LIKE '%" + filter.Correo_Electronico_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico_del_Tutor = '" + filter.Correo_Electronico_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Correo_Electronico_del_Tutor LIKE '%" + filter.Correo_Electronico_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombres2))
            {
                switch (filter.Nombres2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombres2 LIKE '" + filter.Nombres2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombres2 LIKE '%" + filter.Nombres2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombres2 = '" + filter.Nombres2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombres2 LIKE '%" + filter.Nombres2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno2))
            {
                switch (filter.Apellido_Paterno2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno2 LIKE '" + filter.Apellido_Paterno2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno2 LIKE '%" + filter.Apellido_Paterno2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno2 = '" + filter.Apellido_Paterno2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Paterno2 LIKE '%" + filter.Apellido_Paterno2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno2))
            {
                switch (filter.Apellido_Materno2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno2 LIKE '" + filter.Apellido_Materno2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno2 LIKE '%" + filter.Apellido_Materno2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno2 = '" + filter.Apellido_Materno2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Apellido_Materno2 LIKE '%" + filter.Apellido_Materno2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo2))
            {
                switch (filter.Nombre_Completo2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo2 LIKE '" + filter.Nombre_Completo2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo2 LIKE '%" + filter.Nombre_Completo2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo2 = '" + filter.Nombre_Completo2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo2 LIKE '%" + filter.Nombre_Completo2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo2))
            {
                switch (filter.Sexo2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexo2Multiple != null && filter.AdvanceSexo2Multiple.Count() > 0)
            {
                var Sexo2Ids = string.Join(",", filter.AdvanceSexo2Multiple);

                where += " AND Detalle_de_Datos_Generales.Sexo2 In (" + Sexo2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad2))
            {
                switch (filter.Nacionalidad2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidad2Multiple != null && filter.AdvanceNacionalidad2Multiple.Count() > 0)
            {
                var Nacionalidad2Ids = string.Join(",", filter.AdvanceNacionalidad2Multiple);

                where += " AND Detalle_de_Datos_Generales.Nacionalidad2 In (" + Nacionalidad2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad2))
            {
                switch (filter.Escolaridad2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridad2Multiple != null && filter.AdvanceEscolaridad2Multiple.Count() > 0)
            {
                var Escolaridad2Ids = string.Join(",", filter.AdvanceEscolaridad2Multiple);

                where += " AND Detalle_de_Datos_Generales.Escolaridad2 In (" + Escolaridad2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.ID_Estado_Institucion))
            {
                switch (filter.ID_Estado_InstitucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.ID_Estado_Institucion LIKE '" + filter.ID_Estado_Institucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.ID_Estado_Institucion LIKE '%" + filter.ID_Estado_Institucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.ID_Estado_Institucion = '" + filter.ID_Estado_Institucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.ID_Estado_Institucion LIKE '%" + filter.ID_Estado_Institucion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePrioridad_del_Hecho))
            {
                switch (filter.Prioridad_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '" + filter.AdvancePrioridad_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '%" + filter.AdvancePrioridad_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Prioridad_del_Hecho.Descripcion = '" + filter.AdvancePrioridad_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '%" + filter.AdvancePrioridad_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvancePrioridad_del_HechoMultiple != null && filter.AdvancePrioridad_del_HechoMultiple.Count() > 0)
            {
                var Prioridad_del_HechoIds = string.Join(",", filter.AdvancePrioridad_del_HechoMultiple);

                where += " AND Detalle_de_Datos_Generales.Prioridad_del_Hecho In (" + Prioridad_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND Detalle_de_Datos_Generales.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Detalle_de_Datos_Generales.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Detalle_de_Datos_Generales.Hora_Aproximada_del_Hecho) >='" + filter.FromHora_Aproximada_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Detalle_de_Datos_Generales.Hora_Aproximada_del_Hecho) <='" + filter.ToHora_Aproximada_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_del_hecho))
            {
                switch (filter.Pais_del_hechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_del_hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_del_hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_del_hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_del_hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_del_hechoMultiple != null && filter.AdvancePais_del_hechoMultiple.Count() > 0)
            {
                var Pais_del_hechoIds = string.Join(",", filter.AdvancePais_del_hechoMultiple);

                where += " AND Detalle_de_Datos_Generales.Pais_del_hecho In (" + Pais_del_hechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_del_Hecho))
            {
                switch (filter.Estado_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_del_HechoMultiple != null && filter.AdvanceEstado_del_HechoMultiple.Count() > 0)
            {
                var Estado_del_HechoIds = string.Join(",", filter.AdvanceEstado_del_HechoMultiple);

                where += " AND Detalle_de_Datos_Generales.Estado_del_Hecho In (" + Estado_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_de_los_Hechos))
            {
                switch (filter.Municipio_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_de_los_HechosMultiple != null && filter.AdvanceMunicipio_de_los_HechosMultiple.Count() > 0)
            {
                var Municipio_de_los_HechosIds = string.Join(",", filter.AdvanceMunicipio_de_los_HechosMultiple);

                where += " AND Detalle_de_Datos_Generales.Municipio_de_los_Hechos In (" + Municipio_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion_Hechos))
            {
                switch (filter.Poblacion_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacion_HechosMultiple != null && filter.AdvancePoblacion_HechosMultiple.Count() > 0)
            {
                var Poblacion_HechosIds = string.Join(",", filter.AdvancePoblacion_HechosMultiple);

                where += " AND Detalle_de_Datos_Generales.Poblacion_Hechos In (" + Poblacion_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_de_los_Hechos))
            {
                switch (filter.Colonia_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_de_los_HechosMultiple != null && filter.AdvanceColonia_de_los_HechosMultiple.Count() > 0)
            {
                var Colonia_de_los_HechosIds = string.Join(",", filter.AdvanceColonia_de_los_HechosMultiple);

                where += " AND Detalle_de_Datos_Generales.Colonia_de_los_Hechos In (" + Colonia_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_los_Hechos) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_de_los_Hechos))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_los_Hechos))
                    where += " AND Detalle_de_Datos_Generales.Codigo_Postal_de_los_Hechos >= " + filter.FromCodigo_Postal_de_los_Hechos;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_de_los_Hechos))
                    where += " AND Detalle_de_Datos_Generales.Codigo_Postal_de_los_Hechos <= " + filter.ToCodigo_Postal_de_los_Hechos;
            }

            if (!string.IsNullOrEmpty(filter.Calle_de_los_Hechos))
            {
                switch (filter.Calle_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Calle_de_los_Hechos LIKE '" + filter.Calle_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Calle_de_los_Hechos LIKE '%" + filter.Calle_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Calle_de_los_Hechos = '" + filter.Calle_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Calle_de_los_Hechos LIKE '%" + filter.Calle_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_de_los_Hechos))
            {
                switch (filter.Entre_Calle_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle_de_los_Hechos LIKE '" + filter.Entre_Calle_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle_de_los_Hechos LIKE '%" + filter.Entre_Calle_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle_de_los_Hechos = '" + filter.Entre_Calle_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Entre_Calle_de_los_Hechos LIKE '%" + filter.Entre_Calle_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_calle_de_los_hechos))
            {
                switch (filter.Y_calle_de_los_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Y_calle_de_los_hechos LIKE '" + filter.Y_calle_de_los_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Y_calle_de_los_hechos LIKE '%" + filter.Y_calle_de_los_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Y_calle_de_los_hechos = '" + filter.Y_calle_de_los_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Y_calle_de_los_hechos LIKE '%" + filter.Y_calle_de_los_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_de_los_Hechos))
            {
                switch (filter.Numero_Exterior_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos LIKE '" + filter.Numero_Exterior_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos LIKE '%" + filter.Numero_Exterior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos = '" + filter.Numero_Exterior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos LIKE '%" + filter.Numero_Exterior_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_de_los_Hechos))
            {
                switch (filter.Numero_Interior_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_de_los_Hechos LIKE '" + filter.Numero_Interior_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_de_los_Hechos LIKE '%" + filter.Numero_Interior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_de_los_Hechos = '" + filter.Numero_Interior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Numero_Interior_de_los_Hechos LIKE '%" + filter.Numero_Interior_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_Hechos))
            {
                switch (filter.Referencia_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Referencia_Hechos LIKE '" + filter.Referencia_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Referencia_Hechos LIKE '%" + filter.Referencia_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Referencia_Hechos = '" + filter.Referencia_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Referencia_Hechos LIKE '%" + filter.Referencia_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_de_los_Hechos))
            {
                switch (filter.Latitud_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Latitud_de_los_Hechos LIKE '" + filter.Latitud_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Latitud_de_los_Hechos LIKE '%" + filter.Latitud_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Latitud_de_los_Hechos = '" + filter.Latitud_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Latitud_de_los_Hechos LIKE '%" + filter.Latitud_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_de_los_Hechos))
            {
                switch (filter.Longitud_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Longitud_de_los_Hechos LIKE '" + filter.Longitud_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Longitud_de_los_Hechos LIKE '%" + filter.Longitud_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Longitud_de_los_Hechos = '" + filter.Longitud_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Longitud_de_los_Hechos LIKE '%" + filter.Longitud_de_los_Hechos + "%'";
                        break;
                }
            }

            if (filter.Documento_Extraviado != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Documento_Extraviado = " + Convert.ToInt32(filter.Documento_Extraviado);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Documento_Extraviado))
            {
                switch (filter.Tipo_de_Documento_ExtraviadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento_Extraviado.Descripcion LIKE '" + filter.AdvanceTipo_de_Documento_Extraviado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento_Extraviado.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento_Extraviado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento_Extraviado.Descripcion = '" + filter.AdvanceTipo_de_Documento_Extraviado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento_Extraviado.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento_Extraviado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Documento_ExtraviadoMultiple != null && filter.AdvanceTipo_de_Documento_ExtraviadoMultiple.Count() > 0)
            {
                var Tipo_de_Documento_ExtraviadoIds = string.Join(",", filter.AdvanceTipo_de_Documento_ExtraviadoMultiple);

                where += " AND Detalle_de_Datos_Generales.Tipo_de_Documento_Extraviado In (" + Tipo_de_Documento_ExtraviadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_lugar_del_hecho))
            {
                switch (filter.Tipo_de_lugar_del_hechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceTipo_de_lugar_del_hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_lugar_del_hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceTipo_de_lugar_del_hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_lugar_del_hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_lugar_del_hechoMultiple != null && filter.AdvanceTipo_de_lugar_del_hechoMultiple.Count() > 0)
            {
                var Tipo_de_lugar_del_hechoIds = string.Join(",", filter.AdvanceTipo_de_lugar_del_hechoMultiple);

                where += " AND Detalle_de_Datos_Generales.Tipo_de_lugar_del_hecho In (" + Tipo_de_lugar_del_hechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Peso))
            {
                switch (filter.PesoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Peso LIKE '" + filter.Peso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Peso LIKE '%" + filter.Peso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Peso = '" + filter.Peso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Peso LIKE '%" + filter.Peso + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Estatura))
            {
                switch (filter.EstaturaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Estatura LIKE '" + filter.Estatura + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Estatura LIKE '%" + filter.Estatura + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Estatura = '" + filter.Estatura + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Estatura LIKE '%" + filter.Estatura + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Padecimiento_de_Enfermedad))
            {
                switch (filter.Padecimiento_de_EnfermedadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Padecimiento_de_Enfermedad LIKE '" + filter.Padecimiento_de_Enfermedad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Padecimiento_de_Enfermedad = '" + filter.Padecimiento_de_Enfermedad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Padecimiento_de_Enfermedad LIKE '%" + filter.Padecimiento_de_Enfermedad + "%'";
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

                where += " AND Detalle_de_Datos_Generales.Forma_Cara In (" + Forma_CaraIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Tipo_de_Cejas In (" + Tipo_de_CejasIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Tamano_de_Cejas In (" + Tamano_de_CejasIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Cantidad_Cabello In (" + Cantidad_CabelloIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Implantacion_Cabello In (" + Implantacion_CabelloIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Complexion In (" + ComplexionIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Color_Piel In (" + Color_PielIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Frente In (" + FrenteIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Largo_de_Cabello In (" + Largo_de_CabelloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Cabello))
            {
                switch (filter.Forma_de_CabelloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Cabello.Descripcion LIKE '" + filter.AdvanceForma_de_Cabello + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Cabello.Descripcion LIKE '%" + filter.AdvanceForma_de_Cabello + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Cabello.Descripcion = '" + filter.AdvanceForma_de_Cabello + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Cabello.Descripcion LIKE '%" + filter.AdvanceForma_de_Cabello + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_CabelloMultiple != null && filter.AdvanceForma_de_CabelloMultiple.Count() > 0)
            {
                var Forma_de_CabelloIds = string.Join(",", filter.AdvanceForma_de_CabelloMultiple);

                where += " AND Detalle_de_Datos_Generales.Forma_de_Cabello In (" + Forma_de_CabelloIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Color_Cabello In (" + Color_CabelloIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Calvicie In (" + CalvicieIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Color_Ojos In (" + Color_OjosIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Tamano_de_Ojos In (" + Tamano_de_OjosIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Forma_Ojos In (" + Forma_OjosIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Anteojos In (" + AnteojosIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Forma_de_Nariz In (" + Forma_de_NarizIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTamano_Nariz))
            {
                switch (filter.Tamano_NarizFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tamano_de_Nariz.Descripcion LIKE '" + filter.AdvanceTamano_Nariz + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tamano_de_Nariz.Descripcion LIKE '%" + filter.AdvanceTamano_Nariz + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tamano_de_Nariz.Descripcion = '" + filter.AdvanceTamano_Nariz + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tamano_de_Nariz.Descripcion LIKE '%" + filter.AdvanceTamano_Nariz + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTamano_NarizMultiple != null && filter.AdvanceTamano_NarizMultiple.Count() > 0)
            {
                var Tamano_NarizIds = string.Join(",", filter.AdvanceTamano_NarizMultiple);

                where += " AND Detalle_de_Datos_Generales.Tamano_Nariz In (" + Tamano_NarizIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Labios In (" + LabiosIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Boca In (" + BocaIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Grosor_de_Labios In (" + Grosor_de_LabiosIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Menton In (" + MentonIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Forma_de_Menton In (" + Forma_de_MentonIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Barba In (" + BarbaIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Forma_Orejas In (" + Forma_OrejasIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Tamano_Orejas In (" + Tamano_OrejasIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Tipo_Lobulo In (" + Tipo_LobuloIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Bigote In (" + BigoteIds + ")";
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

                where += " AND Detalle_de_Datos_Generales.Senas_Particulares In (" + Senas_ParticularesIds + ")";
            }

            if (filter.Imagen_Tatuaje != RadioOptions.NoApply)
                where += " AND Detalle_de_Datos_Generales.Imagen_Tatuaje " + (filter.Imagen_Tatuaje == RadioOptions.Yes ? ">" : "==") + " 0";

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

                where += " AND Detalle_de_Datos_Generales.Situacion_Fisica In (" + Situacion_FisicaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Otras_Senas_Particulares))
            {
                switch (filter.Otras_Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Otras_Senas_Particulares LIKE '" + filter.Otras_Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Otras_Senas_Particulares = '" + filter.Otras_Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Otras_Senas_Particulares LIKE '%" + filter.Otras_Senas_Particulares + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCausal))
            {
                switch (filter.CausalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceCausal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCausal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceCausal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCausal + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCausalMultiple != null && filter.AdvanceCausalMultiple.Count() > 0)
            {
                var CausalIds = string.Join(",", filter.AdvanceCausalMultiple);

                where += " AND Detalle_de_Datos_Generales.Causal In (" + CausalIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCausa_de_Interrupcion))
            {
                switch (filter.Causa_de_InterrupcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Causas_de_Interrupcion.Descripcion LIKE '" + filter.AdvanceCausa_de_Interrupcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Causas_de_Interrupcion.Descripcion LIKE '%" + filter.AdvanceCausa_de_Interrupcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Causas_de_Interrupcion.Descripcion = '" + filter.AdvanceCausa_de_Interrupcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Causas_de_Interrupcion.Descripcion LIKE '%" + filter.AdvanceCausa_de_Interrupcion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCausa_de_InterrupcionMultiple != null && filter.AdvanceCausa_de_InterrupcionMultiple.Count() > 0)
            {
                var Causa_de_InterrupcionIds = string.Join(",", filter.AdvanceCausa_de_InterrupcionMultiple);

                where += " AND Detalle_de_Datos_Generales.Causa_de_Interrupcion In (" + Causa_de_InterrupcionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDatos_Insuficientes))
            {
                switch (filter.Datos_InsuficientesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceDatos_Insuficientes + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceDatos_Insuficientes + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceDatos_Insuficientes + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceDatos_Insuficientes + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDatos_InsuficientesMultiple != null && filter.AdvanceDatos_InsuficientesMultiple.Count() > 0)
            {
                var Datos_InsuficientesIds = string.Join(",", filter.AdvanceDatos_InsuficientesMultiple);

                where += " AND Detalle_de_Datos_Generales.Datos_Insuficientes In (" + Datos_InsuficientesIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Actualizacion_de_Sobreseimiento))
            {
                switch (filter.Actualizacion_de_SobreseimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento LIKE '" + filter.Actualizacion_de_Sobreseimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento LIKE '%" + filter.Actualizacion_de_Sobreseimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento = '" + filter.Actualizacion_de_Sobreseimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento LIKE '%" + filter.Actualizacion_de_Sobreseimiento + "%'";
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

        public ActionResult GetAdicciones_de_Involucrado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Adicciones_de_InvolucradoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IAdicciones_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Adicciones_de_Involucrado.Folio_Adicciones=" + RelationId;
            if("int" == "string")
            {
	           where = "Adicciones_de_Involucrado.Folio_Adicciones='" + RelationId + "'";
            }
            var result = _IAdicciones_de_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Adicciones_de_Involucrados == null)
                result.Adicciones_de_Involucrados = new List<Adicciones_de_Involucrado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Adicciones_de_Involucrados.Select(m => new Adicciones_de_InvolucradoGridModel
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
        public List<Adicciones_de_InvolucradoGridModel> GetAdicciones_de_InvolucradoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Adicciones_de_InvolucradoGridModel> resultData = new List<Adicciones_de_InvolucradoGridModel>();
            string where = "Adicciones_de_Involucrado.Folio_Adicciones=" + Id;
            if("int" == "string")
            {
                where = "Adicciones_de_Involucrado.Folio_Adicciones='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IAdicciones_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IAdicciones_de_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Adicciones_de_Involucrados != null)
            {
                resultData = result.Adicciones_de_Involucrados.Select(m => new Adicciones_de_InvolucradoGridModel
                    {
                        Clave = m.Clave

                        ,Descripcion = m.Descripcion
                        ,DescripcionDescripcion = CultureHelper.GetTraduction(m.Descripcion_Adicciones.Clave.ToString(), "Descripcion") ??(string)m.Descripcion_Adicciones.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetLugares_Frecuentes_Involucrado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Lugares_Frecuentes_InvolucradoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ILugares_Frecuentes_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Lugares_Frecuentes_Involucrado.Involucrado=" + RelationId;
            if("int" == "string")
            {
	           where = "Lugares_Frecuentes_Involucrado.Involucrado='" + RelationId + "'";
            }
            var result = _ILugares_Frecuentes_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Lugares_Frecuentes_Involucrados == null)
                result.Lugares_Frecuentes_Involucrados = new List<Lugares_Frecuentes_Involucrado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Lugares_Frecuentes_Involucrados.Select(m => new Lugares_Frecuentes_InvolucradoGridModel
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
        public List<Lugares_Frecuentes_InvolucradoGridModel> GetLugares_Frecuentes_InvolucradoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Lugares_Frecuentes_InvolucradoGridModel> resultData = new List<Lugares_Frecuentes_InvolucradoGridModel>();
            string where = "Lugares_Frecuentes_Involucrado.Involucrado=" + Id;
            if("int" == "string")
            {
                where = "Lugares_Frecuentes_Involucrado.Involucrado='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ILugares_Frecuentes_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ILugares_Frecuentes_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Lugares_Frecuentes_Involucrados != null)
            {
                resultData = result.Lugares_Frecuentes_Involucrados.Select(m => new Lugares_Frecuentes_InvolucradoGridModel
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
        public ActionResult GetDatos_Personales_Adicionales_Involucrado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Datos_Personales_Adicionales_InvolucradoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Datos_Personales_Adicionales_Involucrado.Involucrado=" + RelationId;
            if("int" == "string")
            {
	           where = "Datos_Personales_Adicionales_Involucrado.Involucrado='" + RelationId + "'";
            }
            var result = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Datos_Personales_Adicionales_Involucrados == null)
                result.Datos_Personales_Adicionales_Involucrados = new List<Datos_Personales_Adicionales_Involucrado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Datos_Personales_Adicionales_Involucrados.Select(m => new Datos_Personales_Adicionales_InvolucradoGridModel
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
        public List<Datos_Personales_Adicionales_InvolucradoGridModel> GetDatos_Personales_Adicionales_InvolucradoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Datos_Personales_Adicionales_InvolucradoGridModel> resultData = new List<Datos_Personales_Adicionales_InvolucradoGridModel>();
            string where = "Datos_Personales_Adicionales_Involucrado.Involucrado=" + Id;
            if("int" == "string")
            {
                where = "Datos_Personales_Adicionales_Involucrado.Involucrado='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Datos_Personales_Adicionales_Involucrados != null)
            {
                resultData = result.Datos_Personales_Adicionales_Involucrados.Select(m => new Datos_Personales_Adicionales_InvolucradoGridModel
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
        public ActionResult GetOtras_Identificaciones_Involucrado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Otras_Identificaciones_InvolucradoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Otras_Identificaciones_Involucrado.Involucrado=" + RelationId;
            if("int" == "string")
            {
	           where = "Otras_Identificaciones_Involucrado.Involucrado='" + RelationId + "'";
            }
            var result = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Otras_Identificaciones_Involucrados == null)
                result.Otras_Identificaciones_Involucrados = new List<Otras_Identificaciones_Involucrado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Otras_Identificaciones_Involucrados.Select(m => new Otras_Identificaciones_InvolucradoGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_identificacion = m.Tipo_de_identificacion
                        ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Otras_Identificaciones_InvolucradoGridModel> GetOtras_Identificaciones_InvolucradoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Otras_Identificaciones_InvolucradoGridModel> resultData = new List<Otras_Identificaciones_InvolucradoGridModel>();
            string where = "Otras_Identificaciones_Involucrado.Involucrado=" + Id;
            if("int" == "string")
            {
                where = "Otras_Identificaciones_Involucrado.Involucrado='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Otras_Identificaciones_Involucrados != null)
            {
                resultData = result.Otras_Identificaciones_Involucrados.Select(m => new Otras_Identificaciones_InvolucradoGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_identificacion = m.Tipo_de_identificacion
                        ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
			,Descripcion = m.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetOtros_Domicilios_Involucrado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Otros_Domicilios_InvolucradoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IOtros_Domicilios_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Otros_Domicilios_Involucrado.Involucrado=" + RelationId;
            if("int" == "string")
            {
	           where = "Otros_Domicilios_Involucrado.Involucrado='" + RelationId + "'";
            }
            var result = _IOtros_Domicilios_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Otros_Domicilios_Involucrados == null)
                result.Otros_Domicilios_Involucrados = new List<Otros_Domicilios_Involucrado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Otros_Domicilios_Involucrados.Select(m => new Otros_Domicilios_InvolucradoGridModel
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
			,Numero_Interior = m.Numero_Interior
			,Coordenada_X = m.Coordenada_X
			,Coordenada_Y = m.Coordenada_Y
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Otros_Domicilios_InvolucradoGridModel> GetOtros_Domicilios_InvolucradoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Otros_Domicilios_InvolucradoGridModel> resultData = new List<Otros_Domicilios_InvolucradoGridModel>();
            string where = "Otros_Domicilios_Involucrado.Involucrado=" + Id;
            if("int" == "string")
            {
                where = "Otros_Domicilios_Involucrado.Involucrado='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IOtros_Domicilios_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IOtros_Domicilios_InvolucradoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Otros_Domicilios_Involucrados != null)
            {
                resultData = result.Otros_Domicilios_Involucrados.Select(m => new Otros_Domicilios_InvolucradoGridModel
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
			,Numero_Interior = m.Numero_Interior
			,Coordenada_X = m.Coordenada_X
			,Coordenada_Y = m.Coordenada_Y
			,Observaciones = m.Observaciones


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
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Datos_Generales varDetalle_de_Datos_Generales = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IAdicciones_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Adicciones_de_Involucrado.Folio_Adicciones=" + id;
                    if("int" == "string")
                    {
	                where = "Adicciones_de_Involucrado.Folio_Adicciones='" + id + "'";
                    }
                    var Adicciones_de_InvolucradoInfo =
                        _IAdicciones_de_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Adicciones_de_InvolucradoInfo.Adicciones_de_Involucrados.Count > 0)
                    {
                        var resultAdicciones_de_Involucrado = true;
                        //Removing associated job history with attachment
                        foreach (var Adicciones_de_InvolucradoItem in Adicciones_de_InvolucradoInfo.Adicciones_de_Involucrados)
                            resultAdicciones_de_Involucrado = resultAdicciones_de_Involucrado
                                              && _IAdicciones_de_InvolucradoApiConsumer.Delete(Adicciones_de_InvolucradoItem.Clave, null,null).Resource;

                        if (!resultAdicciones_de_Involucrado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ILugares_Frecuentes_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Lugares_Frecuentes_Involucrado.Involucrado=" + id;
                    if("int" == "string")
                    {
	                where = "Lugares_Frecuentes_Involucrado.Involucrado='" + id + "'";
                    }
                    var Lugares_Frecuentes_InvolucradoInfo =
                        _ILugares_Frecuentes_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Lugares_Frecuentes_InvolucradoInfo.Lugares_Frecuentes_Involucrados.Count > 0)
                    {
                        var resultLugares_Frecuentes_Involucrado = true;
                        //Removing associated job history with attachment
                        foreach (var Lugares_Frecuentes_InvolucradoItem in Lugares_Frecuentes_InvolucradoInfo.Lugares_Frecuentes_Involucrados)
                            resultLugares_Frecuentes_Involucrado = resultLugares_Frecuentes_Involucrado
                                              && _ILugares_Frecuentes_InvolucradoApiConsumer.Delete(Lugares_Frecuentes_InvolucradoItem.Clave, null,null).Resource;

                        if (!resultLugares_Frecuentes_Involucrado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Datos_Personales_Adicionales_Involucrado.Involucrado=" + id;
                    if("int" == "string")
                    {
	                where = "Datos_Personales_Adicionales_Involucrado.Involucrado='" + id + "'";
                    }
                    var Datos_Personales_Adicionales_InvolucradoInfo =
                        _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Datos_Personales_Adicionales_InvolucradoInfo.Datos_Personales_Adicionales_Involucrados.Count > 0)
                    {
                        var resultDatos_Personales_Adicionales_Involucrado = true;
                        //Removing associated job history with attachment
                        foreach (var Datos_Personales_Adicionales_InvolucradoItem in Datos_Personales_Adicionales_InvolucradoInfo.Datos_Personales_Adicionales_Involucrados)
                            resultDatos_Personales_Adicionales_Involucrado = resultDatos_Personales_Adicionales_Involucrado
                                              && _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Delete(Datos_Personales_Adicionales_InvolucradoItem.Clave, null,null).Resource;

                        if (!resultDatos_Personales_Adicionales_Involucrado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Otras_Identificaciones_Involucrado.Involucrado=" + id;
                    if("int" == "string")
                    {
	                where = "Otras_Identificaciones_Involucrado.Involucrado='" + id + "'";
                    }
                    var Otras_Identificaciones_InvolucradoInfo =
                        _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Otras_Identificaciones_InvolucradoInfo.Otras_Identificaciones_Involucrados.Count > 0)
                    {
                        var resultOtras_Identificaciones_Involucrado = true;
                        //Removing associated job history with attachment
                        foreach (var Otras_Identificaciones_InvolucradoItem in Otras_Identificaciones_InvolucradoInfo.Otras_Identificaciones_Involucrados)
                            resultOtras_Identificaciones_Involucrado = resultOtras_Identificaciones_Involucrado
                                              && _IOtras_Identificaciones_InvolucradoApiConsumer.Delete(Otras_Identificaciones_InvolucradoItem.Clave, null,null).Resource;

                        if (!resultOtras_Identificaciones_Involucrado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IOtros_Domicilios_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Otros_Domicilios_Involucrado.Involucrado=" + id;
                    if("int" == "string")
                    {
	                where = "Otros_Domicilios_Involucrado.Involucrado='" + id + "'";
                    }
                    var Otros_Domicilios_InvolucradoInfo =
                        _IOtros_Domicilios_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Otros_Domicilios_InvolucradoInfo.Otros_Domicilios_Involucrados.Count > 0)
                    {
                        var resultOtros_Domicilios_Involucrado = true;
                        //Removing associated job history with attachment
                        foreach (var Otros_Domicilios_InvolucradoItem in Otros_Domicilios_InvolucradoInfo.Otros_Domicilios_Involucrados)
                            resultOtros_Domicilios_Involucrado = resultOtros_Domicilios_Involucrado
                                              && _IOtros_Domicilios_InvolucradoApiConsumer.Delete(Otros_Domicilios_InvolucradoItem.Clave, null,null).Resource;

                        if (!resultOtros_Domicilios_Involucrado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Datos_GeneralesModel varDetalle_de_Datos_Generales)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Datos_Generales.Imagen_TatuajeRemoveAttachment != 0 && varDetalle_de_Datos_Generales.Imagen_TatuajeFile == null)
                    {
                        varDetalle_de_Datos_Generales.Imagen_Tatuaje = 0;
                    }

                    if (varDetalle_de_Datos_Generales.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Datos_Generales.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Datos_Generales.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Datos_Generales.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Datos_GeneralesInfo = new Detalle_de_Datos_Generales
                    {
                        Clave = varDetalle_de_Datos_Generales.Clave
                        ,Modulo_Atencion_Inicial = varDetalle_de_Datos_Generales.Modulo_Atencion_Inicial
                        ,Expediente_MP = varDetalle_de_Datos_Generales.Expediente_MP
                        ,Expediente_MASC = varDetalle_de_Datos_Generales.Expediente_MASC
                        ,Datos_Confidenciales = varDetalle_de_Datos_Generales.Datos_Confidenciales
                        ,Se_Informo_sobre_el_Procedimiento = varDetalle_de_Datos_Generales.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_Compareciente = varDetalle_de_Datos_Generales.Tipo_de_Compareciente
                        ,Persona_Desaparecida = varDetalle_de_Datos_Generales.Persona_Desaparecida
                        ,Persona_Aparecio = varDetalle_de_Datos_Generales.Persona_Aparecio
                        ,Fecha_de_Aparicion = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_de_Aparicion)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_de_Aparicion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Con_Vida = varDetalle_de_Datos_Generales.Con_Vida
                        ,Persona_Moral = varDetalle_de_Datos_Generales.Persona_Moral
                        ,Q_Q_R_O_ = varDetalle_de_Datos_Generales.Q_Q_R_O_
                        ,Es_victima = varDetalle_de_Datos_Generales.Es_victima
                        ,Nombre = varDetalle_de_Datos_Generales.Nombre
                        ,Apellido_Paterno = varDetalle_de_Datos_Generales.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Datos_Generales.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Datos_Generales.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Datos_Generales.Edad
                        ,Sexo = varDetalle_de_Datos_Generales.Sexo
                        ,Estado_Civil = varDetalle_de_Datos_Generales.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Datos_Generales.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Datos_Generales.Numero_de_Identificacion
                        ,CURP = varDetalle_de_Datos_Generales.CURP
                        ,RFC = varDetalle_de_Datos_Generales.RFC
                        ,Calidad_Juridica = varDetalle_de_Datos_Generales.Calidad_Juridica
                        ,Razon_Social = varDetalle_de_Datos_Generales.Razon_Social
                        ,Nacionalidad = varDetalle_de_Datos_Generales.Nacionalidad
                        ,Ocupacion = varDetalle_de_Datos_Generales.Ocupacion
                        ,Municipio_Corporacion = varDetalle_de_Datos_Generales.Municipio_Corporacion
                        ,Corporacion = varDetalle_de_Datos_Generales.Corporacion
                        ,Pais_de_Origen = varDetalle_de_Datos_Generales.Pais_de_Origen
                        ,Originario_de = varDetalle_de_Datos_Generales.Originario_de
                        ,Pais = varDetalle_de_Datos_Generales.Pais
                        ,Estado = varDetalle_de_Datos_Generales.Estado
                        ,Municipio = varDetalle_de_Datos_Generales.Municipio
                        ,Poblacion = varDetalle_de_Datos_Generales.Poblacion
                        ,Colonia = varDetalle_de_Datos_Generales.Colonia
                        ,Codigo_Postal = varDetalle_de_Datos_Generales.Codigo_Postal
                        ,Calle = varDetalle_de_Datos_Generales.Calle
                        ,Entre_Calle = varDetalle_de_Datos_Generales.Entre_Calle
                        ,Y_Calle = varDetalle_de_Datos_Generales.Y_Calle
                        ,Numero_Exterior = varDetalle_de_Datos_Generales.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Datos_Generales.Numero_Interior
                        ,Referencia_de_Domicilio = varDetalle_de_Datos_Generales.Referencia_de_Domicilio
                        ,Latitud = varDetalle_de_Datos_Generales.Latitud
                        ,Longitud = varDetalle_de_Datos_Generales.Longitud
                        ,Telefono = varDetalle_de_Datos_Generales.Telefono
                        ,Extension = varDetalle_de_Datos_Generales.Extension
                        ,Celular = varDetalle_de_Datos_Generales.Celular
                        ,Correo_Electronico = varDetalle_de_Datos_Generales.Correo_Electronico
                        ,Situacion_de_Vulnerabilidad = varDetalle_de_Datos_Generales.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_pertenece = varDetalle_de_Datos_Generales.Grupo_al_que_pertenece
                        ,Preferencia_Sexual = varDetalle_de_Datos_Generales.Preferencia_Sexual
                        ,Etnia = varDetalle_de_Datos_Generales.Etnia
                        ,No_de_Hijos = varDetalle_de_Datos_Generales.No_de_Hijos
                        ,Religion = varDetalle_de_Datos_Generales.Religion
                        ,Servicio_Medico = varDetalle_de_Datos_Generales.Servicio_Medico
                        ,Escolaridad = varDetalle_de_Datos_Generales.Escolaridad
                        ,Escolaridad_ = varDetalle_de_Datos_Generales.Escolaridad_
                        ,Especialidad = varDetalle_de_Datos_Generales.Especialidad
                        ,Estudios_Superiores = varDetalle_de_Datos_Generales.Estudios_Superiores
                        ,Incompleto = varDetalle_de_Datos_Generales.Incompleto
                        ,Idioma = varDetalle_de_Datos_Generales.Idioma
                        ,Calidad_Migratoria = varDetalle_de_Datos_Generales.Calidad_Migratoria
                        ,Estado_de_Nacimiento = varDetalle_de_Datos_Generales.Estado_de_Nacimiento
                        ,Municipio_de_Nacimiento = varDetalle_de_Datos_Generales.Municipio_de_Nacimiento
                        ,Dialecto = varDetalle_de_Datos_Generales.Dialecto
                        ,Estado_de_Involucrado = varDetalle_de_Datos_Generales.Estado_de_Involucrado
                        ,Incapaz = varDetalle_de_Datos_Generales.Incapaz
                        ,Tipo_de_Inimputabilidad = varDetalle_de_Datos_Generales.Tipo_de_Inimputabilidad
                        ,Especifique = varDetalle_de_Datos_Generales.Especifique
                        ,Se_Informaron_sobre_sus_Derechos = varDetalle_de_Datos_Generales.Se_Informaron_sobre_sus_Derechos
                        ,Gravidez = varDetalle_de_Datos_Generales.Gravidez
                        ,Discapacidad_Mental = varDetalle_de_Datos_Generales.Discapacidad_Mental
                        ,Discapacidad_Fisica = varDetalle_de_Datos_Generales.Discapacidad_Fisica
                        ,Discapacidad_Sensorial = varDetalle_de_Datos_Generales.Discapacidad_Sensorial
                        ,Discapacidad_Psicosocial = varDetalle_de_Datos_Generales.Discapacidad_Psicosocial
                        ,Nombre_del_Tutor = varDetalle_de_Datos_Generales.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varDetalle_de_Datos_Generales.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varDetalle_de_Datos_Generales.Apellido_Materno_del_Tutor
                        ,Nombre_Completo_del_Tutor = varDetalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varDetalle_de_Datos_Generales.Edad_del_Tutor
                        ,Sexo_del_Tutor = varDetalle_de_Datos_Generales.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varDetalle_de_Datos_Generales.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varDetalle_de_Datos_Generales.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varDetalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor
                        ,CURP_Tutor = varDetalle_de_Datos_Generales.CURP_Tutor
                        ,RFC_Tutor = varDetalle_de_Datos_Generales.RFC_Tutor
                        ,Nacionalidad_del_Tutor = varDetalle_de_Datos_Generales.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varDetalle_de_Datos_Generales.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varDetalle_de_Datos_Generales.Ocupacion_del_Tutor
                        ,Pais_de_Origen_Tutor = varDetalle_de_Datos_Generales.Pais_de_Origen_Tutor
                        ,Originario_de_T = varDetalle_de_Datos_Generales.Originario_de_T
                        ,Pais_del_Tutor = varDetalle_de_Datos_Generales.Pais_del_Tutor
                        ,Estado_del_Tutor = varDetalle_de_Datos_Generales.Estado_del_Tutor
                        ,Municipio_del_Tutor = varDetalle_de_Datos_Generales.Municipio_del_Tutor
                        ,Poblacion_Tutor = varDetalle_de_Datos_Generales.Poblacion_Tutor
                        ,Localidad_del_Tutor = varDetalle_de_Datos_Generales.Localidad_del_Tutor
                        ,Colonia_del_Tutor = varDetalle_de_Datos_Generales.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varDetalle_de_Datos_Generales.Codigo_Postal_del_Tutor
                        ,Calle_del_Tutor = varDetalle_de_Datos_Generales.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varDetalle_de_Datos_Generales.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varDetalle_de_Datos_Generales.Numero_Interior_del_Tutor
                        ,Referencia_de_Domicilio_Tutor = varDetalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor
                        ,Latitud_Tutor = varDetalle_de_Datos_Generales.Latitud_Tutor
                        ,Longitud_Tutor = varDetalle_de_Datos_Generales.Longitud_Tutor
                        ,Telefono_del_Tutor = varDetalle_de_Datos_Generales.Telefono_del_Tutor
                        ,Extension_del_Tutor = varDetalle_de_Datos_Generales.Extension_del_Tutor
                        ,Celular_del_Tutor = varDetalle_de_Datos_Generales.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varDetalle_de_Datos_Generales.Correo_Electronico_del_Tutor
                        ,Nombres2 = varDetalle_de_Datos_Generales.Nombres2
                        ,Apellido_Paterno2 = varDetalle_de_Datos_Generales.Apellido_Paterno2
                        ,Apellido_Materno2 = varDetalle_de_Datos_Generales.Apellido_Materno2
                        ,Nombre_Completo2 = varDetalle_de_Datos_Generales.Nombre_Completo2
                        ,Sexo2 = varDetalle_de_Datos_Generales.Sexo2
                        ,Nacionalidad2 = varDetalle_de_Datos_Generales.Nacionalidad2
                        ,Escolaridad2 = varDetalle_de_Datos_Generales.Escolaridad2
                        ,ID_Estado_Institucion = varDetalle_de_Datos_Generales.ID_Estado_Institucion
                        ,Titulo_del_Hecho = varDetalle_de_Datos_Generales.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDetalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varDetalle_de_Datos_Generales.Prioridad_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Datos_Generales.Hora_Aproximada_del_Hecho
                        ,Pais_del_hecho = varDetalle_de_Datos_Generales.Pais_del_hecho
                        ,Estado_del_Hecho = varDetalle_de_Datos_Generales.Estado_del_Hecho
                        ,Municipio_de_los_Hechos = varDetalle_de_Datos_Generales.Municipio_de_los_Hechos
                        ,Poblacion_Hechos = varDetalle_de_Datos_Generales.Poblacion_Hechos
                        ,Colonia_de_los_Hechos = varDetalle_de_Datos_Generales.Colonia_de_los_Hechos
                        ,Codigo_Postal_de_los_Hechos = varDetalle_de_Datos_Generales.Codigo_Postal_de_los_Hechos
                        ,Calle_de_los_Hechos = varDetalle_de_Datos_Generales.Calle_de_los_Hechos
                        ,Entre_Calle_de_los_Hechos = varDetalle_de_Datos_Generales.Entre_Calle_de_los_Hechos
                        ,Y_calle_de_los_hechos = varDetalle_de_Datos_Generales.Y_calle_de_los_hechos
                        ,Numero_Exterior_de_los_Hechos = varDetalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos
                        ,Numero_Interior_de_los_Hechos = varDetalle_de_Datos_Generales.Numero_Interior_de_los_Hechos
                        ,Referencia_Hechos = varDetalle_de_Datos_Generales.Referencia_Hechos
                        ,Latitud_de_los_Hechos = varDetalle_de_Datos_Generales.Latitud_de_los_Hechos
                        ,Longitud_de_los_Hechos = varDetalle_de_Datos_Generales.Longitud_de_los_Hechos
                        ,Documento_Extraviado = varDetalle_de_Datos_Generales.Documento_Extraviado
                        ,Tipo_de_Documento_Extraviado = varDetalle_de_Datos_Generales.Tipo_de_Documento_Extraviado
                        ,Tipo_de_lugar_del_hecho = varDetalle_de_Datos_Generales.Tipo_de_lugar_del_hecho
                        ,Peso = varDetalle_de_Datos_Generales.Peso
                        ,Estatura = varDetalle_de_Datos_Generales.Estatura
                        ,Padecimiento_de_Enfermedad = varDetalle_de_Datos_Generales.Padecimiento_de_Enfermedad
                        ,Forma_Cara = varDetalle_de_Datos_Generales.Forma_Cara
                        ,Tipo_de_Cejas = varDetalle_de_Datos_Generales.Tipo_de_Cejas
                        ,Tamano_de_Cejas = varDetalle_de_Datos_Generales.Tamano_de_Cejas
                        ,Cantidad_Cabello = varDetalle_de_Datos_Generales.Cantidad_Cabello
                        ,Implantacion_Cabello = varDetalle_de_Datos_Generales.Implantacion_Cabello
                        ,Complexion = varDetalle_de_Datos_Generales.Complexion
                        ,Color_Piel = varDetalle_de_Datos_Generales.Color_Piel
                        ,Frente = varDetalle_de_Datos_Generales.Frente
                        ,Largo_de_Cabello = varDetalle_de_Datos_Generales.Largo_de_Cabello
                        ,Forma_de_Cabello = varDetalle_de_Datos_Generales.Forma_de_Cabello
                        ,Color_Cabello = varDetalle_de_Datos_Generales.Color_Cabello
                        ,Calvicie = varDetalle_de_Datos_Generales.Calvicie
                        ,Color_Ojos = varDetalle_de_Datos_Generales.Color_Ojos
                        ,Tamano_de_Ojos = varDetalle_de_Datos_Generales.Tamano_de_Ojos
                        ,Forma_Ojos = varDetalle_de_Datos_Generales.Forma_Ojos
                        ,Anteojos = varDetalle_de_Datos_Generales.Anteojos
                        ,Forma_de_Nariz = varDetalle_de_Datos_Generales.Forma_de_Nariz
                        ,Tamano_Nariz = varDetalle_de_Datos_Generales.Tamano_Nariz
                        ,Labios = varDetalle_de_Datos_Generales.Labios
                        ,Boca = varDetalle_de_Datos_Generales.Boca
                        ,Grosor_de_Labios = varDetalle_de_Datos_Generales.Grosor_de_Labios
                        ,Menton = varDetalle_de_Datos_Generales.Menton
                        ,Forma_de_Menton = varDetalle_de_Datos_Generales.Forma_de_Menton
                        ,Barba = varDetalle_de_Datos_Generales.Barba
                        ,Forma_Orejas = varDetalle_de_Datos_Generales.Forma_Orejas
                        ,Tamano_Orejas = varDetalle_de_Datos_Generales.Tamano_Orejas
                        ,Tipo_Lobulo = varDetalle_de_Datos_Generales.Tipo_Lobulo
                        ,Bigote = varDetalle_de_Datos_Generales.Bigote
                        ,Senas_Particulares = varDetalle_de_Datos_Generales.Senas_Particulares
                        ,Imagen_Tatuaje = (varDetalle_de_Datos_Generales.Imagen_Tatuaje.HasValue && varDetalle_de_Datos_Generales.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Datos_Generales.Imagen_Tatuaje.Value)) : null

                        ,Situacion_Fisica = varDetalle_de_Datos_Generales.Situacion_Fisica
                        ,Otras_Senas_Particulares = varDetalle_de_Datos_Generales.Otras_Senas_Particulares
                        ,Causal = varDetalle_de_Datos_Generales.Causal
                        ,Causa_de_Interrupcion = varDetalle_de_Datos_Generales.Causa_de_Interrupcion
                        ,Datos_Insuficientes = varDetalle_de_Datos_Generales.Datos_Insuficientes
                        ,Actualizacion_de_Sobreseimiento = varDetalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento

                    };

                    result = !IsNew ?
                        _IDetalle_de_Datos_GeneralesApiConsumer.Update(Detalle_de_Datos_GeneralesInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Datos_GeneralesApiConsumer.Insert(Detalle_de_Datos_GeneralesInfo, null, null).Resource.ToString();
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
        public bool CopyAdicciones_de_Involucrado(int MasterId, int referenceId, List<Adicciones_de_InvolucradoGridModelPost> Adicciones_de_InvolucradoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IAdicciones_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Adicciones_de_InvolucradoData = _IAdicciones_de_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, "Adicciones_de_Involucrado.Folio_Adicciones=" + referenceId,"").Resource;
                if (Adicciones_de_InvolucradoData == null || Adicciones_de_InvolucradoData.Adicciones_de_Involucrados.Count == 0)
                    return true;

                var result = true;

                Adicciones_de_InvolucradoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varAdicciones_de_Involucrado in Adicciones_de_InvolucradoData.Adicciones_de_Involucrados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Adicciones_de_Involucrado Adicciones_de_Involucrado1 = varAdicciones_de_Involucrado;

                    if (Adicciones_de_InvolucradoItems != null && Adicciones_de_InvolucradoItems.Any(m => m.Clave == Adicciones_de_Involucrado1.Clave))
                    {
                        modelDataToChange = Adicciones_de_InvolucradoItems.FirstOrDefault(m => m.Clave == Adicciones_de_Involucrado1.Clave);
                    }
                    //Chaning Id Value
                    varAdicciones_de_Involucrado.Folio_Adicciones = MasterId;
                    var insertId = _IAdicciones_de_InvolucradoApiConsumer.Insert(varAdicciones_de_Involucrado,null,null).Resource;
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
        public ActionResult PostAdicciones_de_Involucrado(List<Adicciones_de_InvolucradoGridModelPost> Adicciones_de_InvolucradoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyAdicciones_de_Involucrado(MasterId, referenceId, Adicciones_de_InvolucradoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Adicciones_de_InvolucradoItems != null && Adicciones_de_InvolucradoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IAdicciones_de_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Adicciones_de_InvolucradoItem in Adicciones_de_InvolucradoItems)
                    {



                        //Removal Request
                        if (Adicciones_de_InvolucradoItem.Removed)
                        {
                            result = result && _IAdicciones_de_InvolucradoApiConsumer.Delete(Adicciones_de_InvolucradoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Adicciones_de_InvolucradoItem.Clave = 0;

                        var Adicciones_de_InvolucradoData = new Adicciones_de_Involucrado
                        {
                            Folio_Adicciones = MasterId
                            ,Clave = Adicciones_de_InvolucradoItem.Clave
                            ,Descripcion = (Convert.ToInt32(Adicciones_de_InvolucradoItem.Descripcion) == 0 ? (Int32?)null : Convert.ToInt32(Adicciones_de_InvolucradoItem.Descripcion))

                        };

                        var resultId = Adicciones_de_InvolucradoItem.Clave > 0
                           ? _IAdicciones_de_InvolucradoApiConsumer.Update(Adicciones_de_InvolucradoData,null,null).Resource
                           : _IAdicciones_de_InvolucradoApiConsumer.Insert(Adicciones_de_InvolucradoData,null,null).Resource;

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
        public ActionResult GetAdicciones_de_Involucrado_AdiccionesAll()
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
        public bool CopyLugares_Frecuentes_Involucrado(int MasterId, int referenceId, List<Lugares_Frecuentes_InvolucradoGridModelPost> Lugares_Frecuentes_InvolucradoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ILugares_Frecuentes_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Lugares_Frecuentes_InvolucradoData = _ILugares_Frecuentes_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, "Lugares_Frecuentes_Involucrado.Involucrado=" + referenceId,"").Resource;
                if (Lugares_Frecuentes_InvolucradoData == null || Lugares_Frecuentes_InvolucradoData.Lugares_Frecuentes_Involucrados.Count == 0)
                    return true;

                var result = true;

                Lugares_Frecuentes_InvolucradoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varLugares_Frecuentes_Involucrado in Lugares_Frecuentes_InvolucradoData.Lugares_Frecuentes_Involucrados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Lugares_Frecuentes_Involucrado Lugares_Frecuentes_Involucrado1 = varLugares_Frecuentes_Involucrado;

                    if (Lugares_Frecuentes_InvolucradoItems != null && Lugares_Frecuentes_InvolucradoItems.Any(m => m.Clave == Lugares_Frecuentes_Involucrado1.Clave))
                    {
                        modelDataToChange = Lugares_Frecuentes_InvolucradoItems.FirstOrDefault(m => m.Clave == Lugares_Frecuentes_Involucrado1.Clave);
                    }
                    //Chaning Id Value
                    varLugares_Frecuentes_Involucrado.Involucrado = MasterId;
                    var insertId = _ILugares_Frecuentes_InvolucradoApiConsumer.Insert(varLugares_Frecuentes_Involucrado,null,null).Resource;
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
        public ActionResult PostLugares_Frecuentes_Involucrado(List<Lugares_Frecuentes_InvolucradoGridModelPost> Lugares_Frecuentes_InvolucradoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyLugares_Frecuentes_Involucrado(MasterId, referenceId, Lugares_Frecuentes_InvolucradoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Lugares_Frecuentes_InvolucradoItems != null && Lugares_Frecuentes_InvolucradoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ILugares_Frecuentes_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Lugares_Frecuentes_InvolucradoItem in Lugares_Frecuentes_InvolucradoItems)
                    {




                        //Removal Request
                        if (Lugares_Frecuentes_InvolucradoItem.Removed)
                        {
                            result = result && _ILugares_Frecuentes_InvolucradoApiConsumer.Delete(Lugares_Frecuentes_InvolucradoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Lugares_Frecuentes_InvolucradoItem.Clave = 0;

                        var Lugares_Frecuentes_InvolucradoData = new Lugares_Frecuentes_Involucrado
                        {
                            Involucrado = MasterId
                            ,Clave = Lugares_Frecuentes_InvolucradoItem.Clave
                            ,Tipo_de_Lugar = (Convert.ToInt32(Lugares_Frecuentes_InvolucradoItem.Tipo_de_Lugar) == 0 ? (Int32?)null : Convert.ToInt32(Lugares_Frecuentes_InvolucradoItem.Tipo_de_Lugar))
                            ,Descripcion = Lugares_Frecuentes_InvolucradoItem.Descripcion

                        };

                        var resultId = Lugares_Frecuentes_InvolucradoItem.Clave > 0
                           ? _ILugares_Frecuentes_InvolucradoApiConsumer.Update(Lugares_Frecuentes_InvolucradoData,null,null).Resource
                           : _ILugares_Frecuentes_InvolucradoApiConsumer.Insert(Lugares_Frecuentes_InvolucradoData,null,null).Resource;

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
        public ActionResult GetLugares_Frecuentes_Involucrado_LugaresAll()
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
        public bool CopyDatos_Personales_Adicionales_Involucrado(int MasterId, int referenceId, List<Datos_Personales_Adicionales_InvolucradoGridModelPost> Datos_Personales_Adicionales_InvolucradoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Datos_Personales_Adicionales_InvolucradoData = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, "Datos_Personales_Adicionales_Involucrado.Involucrado=" + referenceId,"").Resource;
                if (Datos_Personales_Adicionales_InvolucradoData == null || Datos_Personales_Adicionales_InvolucradoData.Datos_Personales_Adicionales_Involucrados.Count == 0)
                    return true;

                var result = true;

                Datos_Personales_Adicionales_InvolucradoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDatos_Personales_Adicionales_Involucrado in Datos_Personales_Adicionales_InvolucradoData.Datos_Personales_Adicionales_Involucrados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Datos_Personales_Adicionales_Involucrado Datos_Personales_Adicionales_Involucrado1 = varDatos_Personales_Adicionales_Involucrado;

                    if (Datos_Personales_Adicionales_InvolucradoItems != null && Datos_Personales_Adicionales_InvolucradoItems.Any(m => m.Clave == Datos_Personales_Adicionales_Involucrado1.Clave))
                    {
                        modelDataToChange = Datos_Personales_Adicionales_InvolucradoItems.FirstOrDefault(m => m.Clave == Datos_Personales_Adicionales_Involucrado1.Clave);
                    }
                    //Chaning Id Value
                    varDatos_Personales_Adicionales_Involucrado.Involucrado = MasterId;
                    var insertId = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Insert(varDatos_Personales_Adicionales_Involucrado,null,null).Resource;
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
        public ActionResult PostDatos_Personales_Adicionales_Involucrado(List<Datos_Personales_Adicionales_InvolucradoGridModelPost> Datos_Personales_Adicionales_InvolucradoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDatos_Personales_Adicionales_Involucrado(MasterId, referenceId, Datos_Personales_Adicionales_InvolucradoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Datos_Personales_Adicionales_InvolucradoItems != null && Datos_Personales_Adicionales_InvolucradoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Datos_Personales_Adicionales_InvolucradoItem in Datos_Personales_Adicionales_InvolucradoItems)
                    {






                        //Removal Request
                        if (Datos_Personales_Adicionales_InvolucradoItem.Removed)
                        {
                            result = result && _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Delete(Datos_Personales_Adicionales_InvolucradoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Datos_Personales_Adicionales_InvolucradoItem.Clave = 0;

                        var Datos_Personales_Adicionales_InvolucradoData = new Datos_Personales_Adicionales_Involucrado
                        {
                            Involucrado = MasterId
                            ,Clave = Datos_Personales_Adicionales_InvolucradoItem.Clave
                            ,Correo_Electronico = Datos_Personales_Adicionales_InvolucradoItem.Correo_Electronico
                            ,Numero_Telefonico = Datos_Personales_Adicionales_InvolucradoItem.Numero_Telefonico
                            ,Redes_Sociales = (Convert.ToInt32(Datos_Personales_Adicionales_InvolucradoItem.Redes_Sociales) == 0 ? (Int32?)null : Convert.ToInt32(Datos_Personales_Adicionales_InvolucradoItem.Redes_Sociales))
                            ,Observaciones = Datos_Personales_Adicionales_InvolucradoItem.Observaciones

                        };

                        var resultId = Datos_Personales_Adicionales_InvolucradoItem.Clave > 0
                           ? _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Update(Datos_Personales_Adicionales_InvolucradoData,null,null).Resource
                           : _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Insert(Datos_Personales_Adicionales_InvolucradoData,null,null).Resource;

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
        public ActionResult GetDatos_Personales_Adicionales_Involucrado_Redes_SocialesAll()
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
        public bool CopyOtras_Identificaciones_Involucrado(int MasterId, int referenceId, List<Otras_Identificaciones_InvolucradoGridModelPost> Otras_Identificaciones_InvolucradoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Otras_Identificaciones_InvolucradoData = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, "Otras_Identificaciones_Involucrado.Involucrado=" + referenceId,"").Resource;
                if (Otras_Identificaciones_InvolucradoData == null || Otras_Identificaciones_InvolucradoData.Otras_Identificaciones_Involucrados.Count == 0)
                    return true;

                var result = true;

                Otras_Identificaciones_InvolucradoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varOtras_Identificaciones_Involucrado in Otras_Identificaciones_InvolucradoData.Otras_Identificaciones_Involucrados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Otras_Identificaciones_Involucrado Otras_Identificaciones_Involucrado1 = varOtras_Identificaciones_Involucrado;

                    if (Otras_Identificaciones_InvolucradoItems != null && Otras_Identificaciones_InvolucradoItems.Any(m => m.Clave == Otras_Identificaciones_Involucrado1.Clave))
                    {
                        modelDataToChange = Otras_Identificaciones_InvolucradoItems.FirstOrDefault(m => m.Clave == Otras_Identificaciones_Involucrado1.Clave);
                    }
                    //Chaning Id Value
                    varOtras_Identificaciones_Involucrado.Involucrado = MasterId;
                    var insertId = _IOtras_Identificaciones_InvolucradoApiConsumer.Insert(varOtras_Identificaciones_Involucrado,null,null).Resource;
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
        public ActionResult PostOtras_Identificaciones_Involucrado(List<Otras_Identificaciones_InvolucradoGridModelPost> Otras_Identificaciones_InvolucradoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyOtras_Identificaciones_Involucrado(MasterId, referenceId, Otras_Identificaciones_InvolucradoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Otras_Identificaciones_InvolucradoItems != null && Otras_Identificaciones_InvolucradoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Otras_Identificaciones_InvolucradoItem in Otras_Identificaciones_InvolucradoItems)
                    {




                        //Removal Request
                        if (Otras_Identificaciones_InvolucradoItem.Removed)
                        {
                            result = result && _IOtras_Identificaciones_InvolucradoApiConsumer.Delete(Otras_Identificaciones_InvolucradoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Otras_Identificaciones_InvolucradoItem.Clave = 0;

                        var Otras_Identificaciones_InvolucradoData = new Otras_Identificaciones_Involucrado
                        {
                            Involucrado = MasterId
                            ,Clave = Otras_Identificaciones_InvolucradoItem.Clave
                            ,Tipo_de_identificacion = (Convert.ToInt32(Otras_Identificaciones_InvolucradoItem.Tipo_de_identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Otras_Identificaciones_InvolucradoItem.Tipo_de_identificacion))
                            ,Descripcion = Otras_Identificaciones_InvolucradoItem.Descripcion

                        };

                        var resultId = Otras_Identificaciones_InvolucradoItem.Clave > 0
                           ? _IOtras_Identificaciones_InvolucradoApiConsumer.Update(Otras_Identificaciones_InvolucradoData,null,null).Resource
                           : _IOtras_Identificaciones_InvolucradoApiConsumer.Insert(Otras_Identificaciones_InvolucradoData,null,null).Resource;

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
        public ActionResult GetOtras_Identificaciones_Involucrado_Tipo_de_IdentificacionAll()
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


        [NonAction]
        public bool CopyOtros_Domicilios_Involucrado(int MasterId, int referenceId, List<Otros_Domicilios_InvolucradoGridModelPost> Otros_Domicilios_InvolucradoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IOtros_Domicilios_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Otros_Domicilios_InvolucradoData = _IOtros_Domicilios_InvolucradoApiConsumer.ListaSelAll(1, int.MaxValue, "Otros_Domicilios_Involucrado.Involucrado=" + referenceId,"").Resource;
                if (Otros_Domicilios_InvolucradoData == null || Otros_Domicilios_InvolucradoData.Otros_Domicilios_Involucrados.Count == 0)
                    return true;

                var result = true;

                Otros_Domicilios_InvolucradoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varOtros_Domicilios_Involucrado in Otros_Domicilios_InvolucradoData.Otros_Domicilios_Involucrados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Otros_Domicilios_Involucrado Otros_Domicilios_Involucrado1 = varOtros_Domicilios_Involucrado;

                    if (Otros_Domicilios_InvolucradoItems != null && Otros_Domicilios_InvolucradoItems.Any(m => m.Clave == Otros_Domicilios_Involucrado1.Clave))
                    {
                        modelDataToChange = Otros_Domicilios_InvolucradoItems.FirstOrDefault(m => m.Clave == Otros_Domicilios_Involucrado1.Clave);
                    }
                    //Chaning Id Value
                    varOtros_Domicilios_Involucrado.Involucrado = MasterId;
                    var insertId = _IOtros_Domicilios_InvolucradoApiConsumer.Insert(varOtros_Domicilios_Involucrado,null,null).Resource;
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
        public ActionResult PostOtros_Domicilios_Involucrado(List<Otros_Domicilios_InvolucradoGridModelPost> Otros_Domicilios_InvolucradoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyOtros_Domicilios_Involucrado(MasterId, referenceId, Otros_Domicilios_InvolucradoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Otros_Domicilios_InvolucradoItems != null && Otros_Domicilios_InvolucradoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IOtros_Domicilios_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Otros_Domicilios_InvolucradoItem in Otros_Domicilios_InvolucradoItems)
                    {















                        //Removal Request
                        if (Otros_Domicilios_InvolucradoItem.Removed)
                        {
                            result = result && _IOtros_Domicilios_InvolucradoApiConsumer.Delete(Otros_Domicilios_InvolucradoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Otros_Domicilios_InvolucradoItem.Clave = 0;

                        var Otros_Domicilios_InvolucradoData = new Otros_Domicilios_Involucrado
                        {
                            Involucrado = MasterId
                            ,Clave = Otros_Domicilios_InvolucradoItem.Clave
                            ,Estado = (Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Estado))
                            ,Municipio = (Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Municipio))
                            ,Poblacion = (Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Poblacion) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Poblacion))
                            ,Colonia = (Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Otros_Domicilios_InvolucradoItem.Colonia))
                            ,Codigo_Postal = Otros_Domicilios_InvolucradoItem.Codigo_Postal
                            ,Calle = Otros_Domicilios_InvolucradoItem.Calle
                            ,Entre_Calle = Otros_Domicilios_InvolucradoItem.Entre_Calle
                            ,Y_Calle = Otros_Domicilios_InvolucradoItem.Y_Calle
                            ,Numero_Exterior = Otros_Domicilios_InvolucradoItem.Numero_Exterior
                            ,Numero_Interior = Otros_Domicilios_InvolucradoItem.Numero_Interior
                            ,Coordenada_X = Otros_Domicilios_InvolucradoItem.Coordenada_X
                            ,Coordenada_Y = Otros_Domicilios_InvolucradoItem.Coordenada_Y
                            ,Observaciones = Otros_Domicilios_InvolucradoItem.Observaciones

                        };

                        var resultId = Otros_Domicilios_InvolucradoItem.Clave > 0
                           ? _IOtros_Domicilios_InvolucradoApiConsumer.Update(Otros_Domicilios_InvolucradoData,null,null).Resource
                           : _IOtros_Domicilios_InvolucradoApiConsumer.Insert(Otros_Domicilios_InvolucradoData,null,null).Resource;

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
        public ActionResult GetOtros_Domicilios_Involucrado_EstadoAll()
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
        public ActionResult GetOtros_Domicilios_Involucrado_MunicipioAll()
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
        public ActionResult GetOtros_Domicilios_Involucrado_ColoniaAll()
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












        /// <summary>
        /// Write Element Array of Detalle_de_Datos_Generales script
        /// </summary>
        /// <param name="oDetalle_de_Datos_GeneralesElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Datos_GeneralesModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Datos_GeneralesModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Datos_GeneralesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Datos_GeneralesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Datos_GeneralesModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Datos_GeneralesModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Datos_GeneralesScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_Generales.js")))
            {
                strDetalle_de_Datos_GeneralesScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Datos_Generales element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Datos_GeneralesModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Datos_GeneralesScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Datos_GeneralesScript.Substring(indexOfArray, strDetalle_de_Datos_GeneralesScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Datos_GeneralesScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Datos_GeneralesScript.Substring(indexOfArrayHistory, strDetalle_de_Datos_GeneralesScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Datos_GeneralesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Datos_GeneralesScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Datos_GeneralesScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Datos_GeneralesModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_Generales.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_Generales.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_Generales.js")))
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
        public ActionResult Detalle_de_Datos_GeneralesPropertyBag()
        {
            return PartialView("Detalle_de_Datos_GeneralesPropertyBag", "Detalle_de_Datos_Generales");
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
        public ActionResult AddAdicciones_de_Involucrado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Adicciones_de_Involucrado/AddAdicciones_de_Involucrado");
        }

        [HttpGet]
        public ActionResult AddLugares_Frecuentes_Involucrado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Lugares_Frecuentes_Involucrado/AddLugares_Frecuentes_Involucrado");
        }

        [HttpGet]
        public ActionResult AddDatos_Personales_Adicionales_Involucrado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Datos_Personales_Adicionales_Involucrado/AddDatos_Personales_Adicionales_Involucrado");
        }

        [HttpGet]
        public ActionResult AddOtras_Identificaciones_Involucrado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Otras_Identificaciones_Involucrado/AddOtras_Identificaciones_Involucrado");
        }

        [HttpGet]
        public ActionResult AddOtros_Domicilios_Involucrado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Otros_Domicilios_Involucrado/AddOtros_Domicilios_Involucrado");
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
                var whereClauseFormat = "Object = 45106 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Datos_Generales.Clave= " + RecordId;
                            var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Datos_GeneralesPropertyMapper());
			
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
                    (Detalle_de_Datos_GeneralesAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Datos_GeneralesPropertyMapper oDetalle_de_Datos_GeneralesPropertyMapper = new Detalle_de_Datos_GeneralesPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Datos_GeneralesPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_Generaless == null)
                result.Detalle_de_Datos_Generaless = new List<Detalle_de_Datos_Generales>();

            var data = result.Detalle_de_Datos_Generaless.Select(m => new Detalle_de_Datos_GeneralesGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
			,Datos_Confidenciales = m.Datos_Confidenciales
			,Se_Informo_sobre_el_Procedimiento = m.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Persona_Desaparecida = m.Persona_Desaparecida
			,Persona_Aparecio = m.Persona_Aparecio
                        ,Fecha_de_Aparicion = (m.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                        ,Con_VidaDescripcion = CultureHelper.GetTraduction(m.Con_Vida_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Vida_A_Tiempo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Q_Q_R_O_ = m.Q_Q_R_O_
			,Es_victima = m.Es_victima
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,CURP = m.CURP
			,RFC = m.RFC
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(m.Municipio_Corporacion_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Corporacion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Situacion_de_Vulnerabilidad = m.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                        ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(m.Preferencia_Sexual_Preferencia_Sexual.Clave.ToString(), "Descripcion") ?? (string)m.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No_de_Hijos = m.No_de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Escolaridad_Descripcion = CultureHelper.GetTraduction(m.Escolaridad__Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad__Escolaridad.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
			,Incompleto = m.Incompleto
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
                        ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(m.Estado_de_Involucrado_Estado_de_Involucrado.Clave.ToString(), "Descripcion") ?? (string)m.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
			,Se_Informaron_sobre_sus_Derechos = m.Se_Informaron_sobre_sus_Derechos
			,Gravidez = m.Gravidez
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Poblacion_TutorNombre = CultureHelper.GetTraduction(m.Poblacion_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Tutor_Colonia.Nombre
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Referencia_de_Domicilio_Tutor = m.Referencia_de_Domicilio_Tutor
			,Latitud_Tutor = m.Latitud_Tutor
			,Longitud_Tutor = m.Longitud_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombres2 = m.Nombres2
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,Sexo2Descripcion = CultureHelper.GetTraduction(m.Sexo2_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo2_Genero.Descripcion
                        ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad2_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad2_Nacionalidad.NacionalidadC
                        ,Escolaridad2Descripcion = CultureHelper.GetTraduction(m.Escolaridad2_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad2_Escolaridad.Descripcion
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_hechoNombre = CultureHelper.GetTraduction(m.Pais_del_hecho_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_hecho_Pais.Nombre
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Poblacion_HechosNombre = CultureHelper.GetTraduction(m.Poblacion_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Hechos_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_calle_de_los_hechos = m.Y_calle_de_los_hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_Hechos = m.Referencia_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
			,Documento_Extraviado = m.Documento_Extraviado
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Tamano_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Tamano_de_Nariz.Descripcion
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
                        ,CausalDescripcion = CultureHelper.GetTraduction(m.Causal_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45106, arrayColumnsVisible), "Detalle_de_Datos_GeneralesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45106, arrayColumnsVisible), "Detalle_de_Datos_GeneralesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45106, arrayColumnsVisible), "Detalle_de_Datos_GeneralesList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Datos_GeneralesPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Datos_GeneralesAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Datos_GeneralesPropertyMapper oDetalle_de_Datos_GeneralesPropertyMapper = new Detalle_de_Datos_GeneralesPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Datos_GeneralesPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_Generaless == null)
                result.Detalle_de_Datos_Generaless = new List<Detalle_de_Datos_Generales>();

            var data = result.Detalle_de_Datos_Generaless.Select(m => new Detalle_de_Datos_GeneralesGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
			,Datos_Confidenciales = m.Datos_Confidenciales
			,Se_Informo_sobre_el_Procedimiento = m.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Persona_Desaparecida = m.Persona_Desaparecida
			,Persona_Aparecio = m.Persona_Aparecio
                        ,Fecha_de_Aparicion = (m.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                        ,Con_VidaDescripcion = CultureHelper.GetTraduction(m.Con_Vida_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Vida_A_Tiempo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Q_Q_R_O_ = m.Q_Q_R_O_
			,Es_victima = m.Es_victima
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,CURP = m.CURP
			,RFC = m.RFC
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(m.Municipio_Corporacion_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Corporacion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Situacion_de_Vulnerabilidad = m.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                        ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(m.Preferencia_Sexual_Preferencia_Sexual.Clave.ToString(), "Descripcion") ?? (string)m.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No_de_Hijos = m.No_de_Hijos
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Escolaridad_Descripcion = CultureHelper.GetTraduction(m.Escolaridad__Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad__Escolaridad.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
			,Incompleto = m.Incompleto
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
                        ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(m.Estado_de_Involucrado_Estado_de_Involucrado.Clave.ToString(), "Descripcion") ?? (string)m.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
			,Se_Informaron_sobre_sus_Derechos = m.Se_Informaron_sobre_sus_Derechos
			,Gravidez = m.Gravidez
                        ,Discapacidad_MentalDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Mental_Discapacidades_Mentales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Mental_Discapacidades_Mentales.Descripcion
                        ,Discapacidad_FisicaDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Fisica_Discapacidades_Fisicas.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Fisica_Discapacidades_Fisicas.Descripcion
                        ,Discapacidad_SensorialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Sensorial_Discapacidades_Sensoriales.Descripcion
                        ,Discapacidad_PsicosocialDescripcion = CultureHelper.GetTraduction(m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Clave.ToString(), "Descripcion") ?? (string)m.Discapacidad_Psicosocial_Discapacidades_Psicosociales.Descripcion
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Poblacion_TutorNombre = CultureHelper.GetTraduction(m.Poblacion_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Tutor_Colonia.Nombre
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Referencia_de_Domicilio_Tutor = m.Referencia_de_Domicilio_Tutor
			,Latitud_Tutor = m.Latitud_Tutor
			,Longitud_Tutor = m.Longitud_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombres2 = m.Nombres2
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,Sexo2Descripcion = CultureHelper.GetTraduction(m.Sexo2_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo2_Genero.Descripcion
                        ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad2_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad2_Nacionalidad.NacionalidadC
                        ,Escolaridad2Descripcion = CultureHelper.GetTraduction(m.Escolaridad2_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad2_Escolaridad.Descripcion
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_hechoNombre = CultureHelper.GetTraduction(m.Pais_del_hecho_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_hecho_Pais.Nombre
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Poblacion_HechosNombre = CultureHelper.GetTraduction(m.Poblacion_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Hechos_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_calle_de_los_hechos = m.Y_calle_de_los_hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_Hechos = m.Referencia_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
			,Documento_Extraviado = m.Documento_Extraviado
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion
			,Peso = m.Peso
			,Estatura = m.Estatura
			,Padecimiento_de_Enfermedad = m.Padecimiento_de_Enfermedad
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Tipo_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Cejas_Cejas.Descripcion
                        ,Tamano_de_CejasDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Cejas_Tamano_de_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Cejas_Tamano_de_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cabello_Forma_Cabello.Descripcion
                        ,Color_CabelloDescripcion = CultureHelper.GetTraduction(m.Color_Cabello_Color_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Color_Cabello_Color_de_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Tamano_de_OjosDescripcion = CultureHelper.GetTraduction(m.Tamano_de_Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_de_Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,AnteojosDescripcion = CultureHelper.GetTraduction(m.Anteojos_Anteojos.Clave.ToString(), "Descripcion") ?? (string)m.Anteojos_Anteojos.Descripcion
                        ,Forma_de_NarizDescripcion = CultureHelper.GetTraduction(m.Forma_de_Nariz_Forma_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Nariz_Forma_de_Nariz.Descripcion
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Tamano_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Tamano_de_Nariz.Descripcion
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
                        ,CausalDescripcion = CultureHelper.GetTraduction(m.Causal_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

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
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Datos_Generales_Datos_GeneralesModel varDetalle_de_Datos_Generales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Datos_Generales_Datos_GeneralesInfo = new Detalle_de_Datos_Generales_Datos_Generales
                {
                    Clave = varDetalle_de_Datos_Generales.Clave
                                            ,Modulo_Atencion_Inicial = varDetalle_de_Datos_Generales.Modulo_Atencion_Inicial
                        ,Expediente_MP = varDetalle_de_Datos_Generales.Expediente_MP
                        ,Expediente_MASC = varDetalle_de_Datos_Generales.Expediente_MASC
                        ,Datos_Confidenciales = varDetalle_de_Datos_Generales.Datos_Confidenciales
                        ,Se_Informo_sobre_el_Procedimiento = varDetalle_de_Datos_Generales.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_Compareciente = varDetalle_de_Datos_Generales.Tipo_de_Compareciente
                        ,Persona_Desaparecida = varDetalle_de_Datos_Generales.Persona_Desaparecida
                        ,Persona_Aparecio = varDetalle_de_Datos_Generales.Persona_Aparecio
                        ,Fecha_de_Aparicion = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_de_Aparicion)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_de_Aparicion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Con_Vida = varDetalle_de_Datos_Generales.Con_Vida
                        ,Persona_Moral = varDetalle_de_Datos_Generales.Persona_Moral
                        ,Q_Q_R_O_ = varDetalle_de_Datos_Generales.Q_Q_R_O_
                        ,Es_victima = varDetalle_de_Datos_Generales.Es_victima
                        ,Nombre = varDetalle_de_Datos_Generales.Nombre
                        ,Apellido_Paterno = varDetalle_de_Datos_Generales.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Datos_Generales.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Datos_Generales.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Datos_Generales.Edad
                        ,Sexo = varDetalle_de_Datos_Generales.Sexo
                        ,Estado_Civil = varDetalle_de_Datos_Generales.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Datos_Generales.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Datos_Generales.Numero_de_Identificacion
                        ,CURP = varDetalle_de_Datos_Generales.CURP
                        ,RFC = varDetalle_de_Datos_Generales.RFC
                        ,Calidad_Juridica = varDetalle_de_Datos_Generales.Calidad_Juridica
                        ,Razon_Social = varDetalle_de_Datos_Generales.Razon_Social
                        ,Nacionalidad = varDetalle_de_Datos_Generales.Nacionalidad
                        ,Ocupacion = varDetalle_de_Datos_Generales.Ocupacion
                        ,Municipio_Corporacion = varDetalle_de_Datos_Generales.Municipio_Corporacion
                        ,Corporacion = varDetalle_de_Datos_Generales.Corporacion
                        ,Pais_de_Origen = varDetalle_de_Datos_Generales.Pais_de_Origen
                        ,Originario_de = varDetalle_de_Datos_Generales.Originario_de
                        ,Pais = varDetalle_de_Datos_Generales.Pais
                        ,Estado = varDetalle_de_Datos_Generales.Estado
                        ,Municipio = varDetalle_de_Datos_Generales.Municipio
                        ,Poblacion = varDetalle_de_Datos_Generales.Poblacion
                        ,Colonia = varDetalle_de_Datos_Generales.Colonia
                        ,Codigo_Postal = varDetalle_de_Datos_Generales.Codigo_Postal
                        ,Calle = varDetalle_de_Datos_Generales.Calle
                        ,Entre_Calle = varDetalle_de_Datos_Generales.Entre_Calle
                        ,Y_Calle = varDetalle_de_Datos_Generales.Y_Calle
                        ,Numero_Exterior = varDetalle_de_Datos_Generales.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Datos_Generales.Numero_Interior
                        ,Referencia_de_Domicilio = varDetalle_de_Datos_Generales.Referencia_de_Domicilio
                        ,Latitud = varDetalle_de_Datos_Generales.Latitud
                        ,Longitud = varDetalle_de_Datos_Generales.Longitud
                        ,Telefono = varDetalle_de_Datos_Generales.Telefono
                        ,Extension = varDetalle_de_Datos_Generales.Extension
                        ,Celular = varDetalle_de_Datos_Generales.Celular
                        ,Correo_Electronico = varDetalle_de_Datos_Generales.Correo_Electronico
                        ,Situacion_de_Vulnerabilidad = varDetalle_de_Datos_Generales.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_pertenece = varDetalle_de_Datos_Generales.Grupo_al_que_pertenece
                        ,Preferencia_Sexual = varDetalle_de_Datos_Generales.Preferencia_Sexual
                        ,Etnia = varDetalle_de_Datos_Generales.Etnia
                        ,No_de_Hijos = varDetalle_de_Datos_Generales.No_de_Hijos
                        ,Religion = varDetalle_de_Datos_Generales.Religion
                        ,Servicio_Medico = varDetalle_de_Datos_Generales.Servicio_Medico
                        ,Escolaridad = varDetalle_de_Datos_Generales.Escolaridad
                        ,Escolaridad_ = varDetalle_de_Datos_Generales.Escolaridad_
                        ,Especialidad = varDetalle_de_Datos_Generales.Especialidad
                        ,Estudios_Superiores = varDetalle_de_Datos_Generales.Estudios_Superiores
                        ,Incompleto = varDetalle_de_Datos_Generales.Incompleto
                        ,Idioma = varDetalle_de_Datos_Generales.Idioma
                        ,Calidad_Migratoria = varDetalle_de_Datos_Generales.Calidad_Migratoria
                        ,Estado_de_Nacimiento = varDetalle_de_Datos_Generales.Estado_de_Nacimiento
                        ,Municipio_de_Nacimiento = varDetalle_de_Datos_Generales.Municipio_de_Nacimiento
                        ,Dialecto = varDetalle_de_Datos_Generales.Dialecto
                        ,Estado_de_Involucrado = varDetalle_de_Datos_Generales.Estado_de_Involucrado
                        ,Incapaz = varDetalle_de_Datos_Generales.Incapaz
                        ,Tipo_de_Inimputabilidad = varDetalle_de_Datos_Generales.Tipo_de_Inimputabilidad
                        ,Especifique = varDetalle_de_Datos_Generales.Especifique
                        ,Se_Informaron_sobre_sus_Derechos = varDetalle_de_Datos_Generales.Se_Informaron_sobre_sus_Derechos
                        ,Gravidez = varDetalle_de_Datos_Generales.Gravidez
                        ,Discapacidad_Mental = varDetalle_de_Datos_Generales.Discapacidad_Mental
                        ,Discapacidad_Fisica = varDetalle_de_Datos_Generales.Discapacidad_Fisica
                        ,Discapacidad_Sensorial = varDetalle_de_Datos_Generales.Discapacidad_Sensorial
                        ,Discapacidad_Psicosocial = varDetalle_de_Datos_Generales.Discapacidad_Psicosocial
                    
                };

                result = _IDetalle_de_Datos_GeneralesApiConsumer.Update_Datos_Generales(Detalle_de_Datos_Generales_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Datos_GeneralesApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Adicciones_de_Involucrado;
                var Adicciones_de_InvolucradoData = GetAdicciones_de_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_de_Involucrado);
                int RowCount_Lugares_Frecuentes_Involucrado;
                var Lugares_Frecuentes_InvolucradoData = GetLugares_Frecuentes_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Involucrado);
                int RowCount_Datos_Personales_Adicionales_Involucrado;
                var Datos_Personales_Adicionales_InvolucradoData = GetDatos_Personales_Adicionales_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Involucrado);
                int RowCount_Otras_Identificaciones_Involucrado;
                var Otras_Identificaciones_InvolucradoData = GetOtras_Identificaciones_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Involucrado);
                int RowCount_Otros_Domicilios_Involucrado;
                var Otros_Domicilios_InvolucradoData = GetOtros_Domicilios_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Involucrado);

                var result = new Detalle_de_Datos_Generales_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_MASC = m.Expediente_MASC
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
			,Datos_Confidenciales = m.Datos_Confidenciales
			,Se_Informo_sobre_el_Procedimiento = m.Se_Informo_sobre_el_Procedimiento
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Persona_Desaparecida = m.Persona_Desaparecida
			,Persona_Aparecio = m.Persona_Aparecio
                        ,Fecha_de_Aparicion = (m.Fecha_de_Aparicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aparicion).ToString(ConfigurationProperty.DateFormat))
                        ,Con_Vida = m.Con_Vida
                        ,Con_VidaDescripcion = CultureHelper.GetTraduction(m.Con_Vida_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Vida_A_Tiempo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Q_Q_R_O_ = m.Q_Q_R_O_
			,Es_victima = m.Es_victima
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,CURP = m.CURP
			,RFC = m.RFC
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Municipio_Corporacion = m.Municipio_Corporacion
                        ,Municipio_CorporacionNombre = CultureHelper.GetTraduction(m.Municipio_Corporacion_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Corporacion_Municipio.Nombre
                        ,Corporacion = m.Corporacion
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
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
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Situacion_de_Vulnerabilidad = m.Situacion_de_Vulnerabilidad
                        ,Grupo_al_que_pertenece = m.Grupo_al_que_pertenece
                        ,Grupo_al_que_perteneceDescripcion = CultureHelper.GetTraduction(m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_al_que_pertenece_Grupo_al_que_Pertenece.Descripcion
                        ,Preferencia_Sexual = m.Preferencia_Sexual
                        ,Preferencia_SexualDescripcion = CultureHelper.GetTraduction(m.Preferencia_Sexual_Preferencia_Sexual.Clave.ToString(), "Descripcion") ?? (string)m.Preferencia_Sexual_Preferencia_Sexual.Descripcion
                        ,Etnia = m.Etnia
                        ,EtniaDescripcion = CultureHelper.GetTraduction(m.Etnia_Etnia.Clave.ToString(), "Descripcion") ?? (string)m.Etnia_Etnia.Descripcion
			,No_de_Hijos = m.No_de_Hijos
                        ,Religion = m.Religion
                        ,ReligionDescripcion = CultureHelper.GetTraduction(m.Religion_Religion.Clave.ToString(), "Descripcion") ?? (string)m.Religion_Religion.Descripcion
                        ,Servicio_Medico = m.Servicio_Medico
                        ,Servicio_MedicoDescripcion = CultureHelper.GetTraduction(m.Servicio_Medico_Servicio_Medico.Clave.ToString(), "Descripcion") ?? (string)m.Servicio_Medico_Servicio_Medico.Descripcion
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Escolaridad_ = m.Escolaridad_
                        ,Escolaridad_Descripcion = CultureHelper.GetTraduction(m.Escolaridad__Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad__Escolaridad.Descripcion
                        ,Especialidad = m.Especialidad
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad.Descripcion
                        ,Estudios_Superiores = m.Estudios_Superiores
                        ,Estudios_SuperioresDescripcion = CultureHelper.GetTraduction(m.Estudios_Superiores_Estudios_Superiores.Clave.ToString(), "Descripcion") ?? (string)m.Estudios_Superiores_Estudios_Superiores.Descripcion
			,Incompleto = m.Incompleto
                        ,Idioma = m.Idioma
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Calidad_Migratoria = m.Calidad_Migratoria
                        ,Calidad_MigratoriaDescripcion = CultureHelper.GetTraduction(m.Calidad_Migratoria_Calidad_Migratoria.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_Migratoria_Calidad_Migratoria.Descripcion
                        ,Estado_de_Nacimiento = m.Estado_de_Nacimiento
                        ,Estado_de_NacimientoNombre = CultureHelper.GetTraduction(m.Estado_de_Nacimiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Nacimiento_Estado.Nombre
                        ,Municipio_de_Nacimiento = m.Municipio_de_Nacimiento
                        ,Municipio_de_NacimientoNombre = CultureHelper.GetTraduction(m.Municipio_de_Nacimiento_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Nacimiento_Municipio.Nombre
                        ,Dialecto = m.Dialecto
                        ,DialectoDescripcion = CultureHelper.GetTraduction(m.Dialecto_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Dialecto_Dialecto.Descripcion
                        ,Estado_de_Involucrado = m.Estado_de_Involucrado
                        ,Estado_de_InvolucradoDescripcion = CultureHelper.GetTraduction(m.Estado_de_Involucrado_Estado_de_Involucrado.Clave.ToString(), "Descripcion") ?? (string)m.Estado_de_Involucrado_Estado_de_Involucrado.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_Inimputabilidad = m.Tipo_de_Inimputabilidad
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
			,Se_Informaron_sobre_sus_Derechos = m.Se_Informaron_sobre_sus_Derechos
			,Gravidez = m.Gravidez
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
                    ,Adicciones_de_Involucrado = Adicciones_de_InvolucradoData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_InvolucradoData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_InvolucradoData
                    ,Otras_Identificaciones = Otras_Identificaciones_InvolucradoData
                    ,Otros_Domicilios = Otros_Domicilios_InvolucradoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Tutor(Detalle_de_Datos_Generales_Datos_del_TutorModel varDetalle_de_Datos_Generales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Datos_Generales_Datos_del_TutorInfo = new Detalle_de_Datos_Generales_Datos_del_Tutor
                {
                    Clave = varDetalle_de_Datos_Generales.Clave
                                            ,Nombre_del_Tutor = varDetalle_de_Datos_Generales.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varDetalle_de_Datos_Generales.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varDetalle_de_Datos_Generales.Apellido_Materno_del_Tutor
                        ,Nombre_Completo_del_Tutor = varDetalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varDetalle_de_Datos_Generales.Edad_del_Tutor
                        ,Sexo_del_Tutor = varDetalle_de_Datos_Generales.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varDetalle_de_Datos_Generales.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varDetalle_de_Datos_Generales.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varDetalle_de_Datos_Generales.Numero_de_Identificacion_del_Tutor
                        ,CURP_Tutor = varDetalle_de_Datos_Generales.CURP_Tutor
                        ,RFC_Tutor = varDetalle_de_Datos_Generales.RFC_Tutor
                        ,Nacionalidad_del_Tutor = varDetalle_de_Datos_Generales.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varDetalle_de_Datos_Generales.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varDetalle_de_Datos_Generales.Ocupacion_del_Tutor
                        ,Pais_de_Origen_Tutor = varDetalle_de_Datos_Generales.Pais_de_Origen_Tutor
                        ,Originario_de_T = varDetalle_de_Datos_Generales.Originario_de_T
                        ,Pais_del_Tutor = varDetalle_de_Datos_Generales.Pais_del_Tutor
                        ,Estado_del_Tutor = varDetalle_de_Datos_Generales.Estado_del_Tutor
                        ,Municipio_del_Tutor = varDetalle_de_Datos_Generales.Municipio_del_Tutor
                        ,Poblacion_Tutor = varDetalle_de_Datos_Generales.Poblacion_Tutor
                        ,Localidad_del_Tutor = varDetalle_de_Datos_Generales.Localidad_del_Tutor
                        ,Colonia_del_Tutor = varDetalle_de_Datos_Generales.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varDetalle_de_Datos_Generales.Codigo_Postal_del_Tutor
                        ,Calle_del_Tutor = varDetalle_de_Datos_Generales.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varDetalle_de_Datos_Generales.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varDetalle_de_Datos_Generales.Numero_Interior_del_Tutor
                        ,Referencia_de_Domicilio_Tutor = varDetalle_de_Datos_Generales.Referencia_de_Domicilio_Tutor
                        ,Latitud_Tutor = varDetalle_de_Datos_Generales.Latitud_Tutor
                        ,Longitud_Tutor = varDetalle_de_Datos_Generales.Longitud_Tutor
                        ,Telefono_del_Tutor = varDetalle_de_Datos_Generales.Telefono_del_Tutor
                        ,Extension_del_Tutor = varDetalle_de_Datos_Generales.Extension_del_Tutor
                        ,Celular_del_Tutor = varDetalle_de_Datos_Generales.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varDetalle_de_Datos_Generales.Correo_Electronico_del_Tutor
                    
                };

                result = _IDetalle_de_Datos_GeneralesApiConsumer.Update_Datos_del_Tutor(Detalle_de_Datos_Generales_Datos_del_TutorInfo).Resource.ToString();
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
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Datos_GeneralesApiConsumer.Get_Datos_del_Tutor(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Adicciones_de_Involucrado;
                var Adicciones_de_InvolucradoData = GetAdicciones_de_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_de_Involucrado);
                int RowCount_Lugares_Frecuentes_Involucrado;
                var Lugares_Frecuentes_InvolucradoData = GetLugares_Frecuentes_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Involucrado);
                int RowCount_Datos_Personales_Adicionales_Involucrado;
                var Datos_Personales_Adicionales_InvolucradoData = GetDatos_Personales_Adicionales_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Involucrado);
                int RowCount_Otras_Identificaciones_Involucrado;
                var Otras_Identificaciones_InvolucradoData = GetOtras_Identificaciones_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Involucrado);
                int RowCount_Otros_Domicilios_Involucrado;
                var Otros_Domicilios_InvolucradoData = GetOtros_Domicilios_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Involucrado);

                var result = new Detalle_de_Datos_Generales_Datos_del_TutorModel
                {
                    Clave = m.Clave
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_de_Origen_Tutor = m.Pais_de_Origen_Tutor
                        ,Pais_de_Origen_TutorNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Tutor_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Poblacion_Tutor = m.Poblacion_Tutor
                        ,Poblacion_TutorNombre = CultureHelper.GetTraduction(m.Poblacion_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Tutor_Colonia.Nombre
                        ,Localidad_del_Tutor = m.Localidad_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Referencia_de_Domicilio_Tutor = m.Referencia_de_Domicilio_Tutor
			,Latitud_Tutor = m.Latitud_Tutor
			,Longitud_Tutor = m.Longitud_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor

                    
                };
				var resultData = new
                {
                    data = result
                    ,Adicciones_de_Involucrado = Adicciones_de_InvolucradoData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_InvolucradoData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_InvolucradoData
                    ,Otras_Identificaciones = Otras_Identificaciones_InvolucradoData
                    ,Otros_Domicilios = Otros_Domicilios_InvolucradoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Representante_Legal(Detalle_de_Datos_Generales_Representante_LegalModel varDetalle_de_Datos_Generales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Datos_Generales_Representante_LegalInfo = new Detalle_de_Datos_Generales_Representante_Legal
                {
                    Clave = varDetalle_de_Datos_Generales.Clave
                                            ,Nombres2 = varDetalle_de_Datos_Generales.Nombres2
                        ,Apellido_Paterno2 = varDetalle_de_Datos_Generales.Apellido_Paterno2
                        ,Apellido_Materno2 = varDetalle_de_Datos_Generales.Apellido_Materno2
                        ,Nombre_Completo2 = varDetalle_de_Datos_Generales.Nombre_Completo2
                        ,Sexo2 = varDetalle_de_Datos_Generales.Sexo2
                        ,Nacionalidad2 = varDetalle_de_Datos_Generales.Nacionalidad2
                        ,Escolaridad2 = varDetalle_de_Datos_Generales.Escolaridad2
                        ,ID_Estado_Institucion = varDetalle_de_Datos_Generales.ID_Estado_Institucion
                    
                };

                result = _IDetalle_de_Datos_GeneralesApiConsumer.Update_Representante_Legal(Detalle_de_Datos_Generales_Representante_LegalInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Representante_Legal(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Datos_GeneralesApiConsumer.Get_Representante_Legal(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Adicciones_de_Involucrado;
                var Adicciones_de_InvolucradoData = GetAdicciones_de_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_de_Involucrado);
                int RowCount_Lugares_Frecuentes_Involucrado;
                var Lugares_Frecuentes_InvolucradoData = GetLugares_Frecuentes_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Involucrado);
                int RowCount_Datos_Personales_Adicionales_Involucrado;
                var Datos_Personales_Adicionales_InvolucradoData = GetDatos_Personales_Adicionales_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Involucrado);
                int RowCount_Otras_Identificaciones_Involucrado;
                var Otras_Identificaciones_InvolucradoData = GetOtras_Identificaciones_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Involucrado);
                int RowCount_Otros_Domicilios_Involucrado;
                var Otros_Domicilios_InvolucradoData = GetOtros_Domicilios_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Involucrado);

                var result = new Detalle_de_Datos_Generales_Representante_LegalModel
                {
                    Clave = m.Clave
			,Nombres2 = m.Nombres2
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,Sexo2 = m.Sexo2
                        ,Sexo2Descripcion = CultureHelper.GetTraduction(m.Sexo2_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo2_Genero.Descripcion
                        ,Nacionalidad2 = m.Nacionalidad2
                        ,Nacionalidad2NacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad2_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad2_Nacionalidad.NacionalidadC
                        ,Escolaridad2 = m.Escolaridad2
                        ,Escolaridad2Descripcion = CultureHelper.GetTraduction(m.Escolaridad2_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad2_Escolaridad.Descripcion
			,ID_Estado_Institucion = m.ID_Estado_Institucion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Adicciones_de_Involucrado = Adicciones_de_InvolucradoData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_InvolucradoData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_InvolucradoData
                    ,Otras_Identificaciones = Otras_Identificaciones_InvolucradoData
                    ,Otros_Domicilios = Otros_Domicilios_InvolucradoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_los_Hechos(Detalle_de_Datos_Generales_Datos_de_los_HechosModel varDetalle_de_Datos_Generales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Datos_Generales_Datos_de_los_HechosInfo = new Detalle_de_Datos_Generales_Datos_de_los_Hechos
                {
                    Clave = varDetalle_de_Datos_Generales.Clave
                                            ,Titulo_del_Hecho = varDetalle_de_Datos_Generales.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDetalle_de_Datos_Generales.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varDetalle_de_Datos_Generales.Prioridad_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Datos_Generales.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Datos_Generales.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Datos_Generales.Hora_Aproximada_del_Hecho
                        ,Pais_del_hecho = varDetalle_de_Datos_Generales.Pais_del_hecho
                        ,Estado_del_Hecho = varDetalle_de_Datos_Generales.Estado_del_Hecho
                        ,Municipio_de_los_Hechos = varDetalle_de_Datos_Generales.Municipio_de_los_Hechos
                        ,Poblacion_Hechos = varDetalle_de_Datos_Generales.Poblacion_Hechos
                        ,Colonia_de_los_Hechos = varDetalle_de_Datos_Generales.Colonia_de_los_Hechos
                        ,Codigo_Postal_de_los_Hechos = varDetalle_de_Datos_Generales.Codigo_Postal_de_los_Hechos
                        ,Calle_de_los_Hechos = varDetalle_de_Datos_Generales.Calle_de_los_Hechos
                        ,Entre_Calle_de_los_Hechos = varDetalle_de_Datos_Generales.Entre_Calle_de_los_Hechos
                        ,Y_calle_de_los_hechos = varDetalle_de_Datos_Generales.Y_calle_de_los_hechos
                        ,Numero_Exterior_de_los_Hechos = varDetalle_de_Datos_Generales.Numero_Exterior_de_los_Hechos
                        ,Numero_Interior_de_los_Hechos = varDetalle_de_Datos_Generales.Numero_Interior_de_los_Hechos
                        ,Referencia_Hechos = varDetalle_de_Datos_Generales.Referencia_Hechos
                        ,Latitud_de_los_Hechos = varDetalle_de_Datos_Generales.Latitud_de_los_Hechos
                        ,Longitud_de_los_Hechos = varDetalle_de_Datos_Generales.Longitud_de_los_Hechos
                        ,Documento_Extraviado = varDetalle_de_Datos_Generales.Documento_Extraviado
                        ,Tipo_de_Documento_Extraviado = varDetalle_de_Datos_Generales.Tipo_de_Documento_Extraviado
                        ,Tipo_de_lugar_del_hecho = varDetalle_de_Datos_Generales.Tipo_de_lugar_del_hecho
                    
                };

                result = _IDetalle_de_Datos_GeneralesApiConsumer.Update_Datos_de_los_Hechos(Detalle_de_Datos_Generales_Datos_de_los_HechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_los_Hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Datos_GeneralesApiConsumer.Get_Datos_de_los_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Adicciones_de_Involucrado;
                var Adicciones_de_InvolucradoData = GetAdicciones_de_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_de_Involucrado);
                int RowCount_Lugares_Frecuentes_Involucrado;
                var Lugares_Frecuentes_InvolucradoData = GetLugares_Frecuentes_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Involucrado);
                int RowCount_Datos_Personales_Adicionales_Involucrado;
                var Datos_Personales_Adicionales_InvolucradoData = GetDatos_Personales_Adicionales_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Involucrado);
                int RowCount_Otras_Identificaciones_Involucrado;
                var Otras_Identificaciones_InvolucradoData = GetOtras_Identificaciones_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Involucrado);
                int RowCount_Otros_Domicilios_Involucrado;
                var Otros_Domicilios_InvolucradoData = GetOtros_Domicilios_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Involucrado);

                var result = new Detalle_de_Datos_Generales_Datos_de_los_HechosModel
                {
                    Clave = m.Clave
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_hecho = m.Pais_del_hecho
                        ,Pais_del_hechoNombre = CultureHelper.GetTraduction(m.Pais_del_hecho_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_del_hecho_Pais.Nombre
                        ,Estado_del_Hecho = m.Estado_del_Hecho
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_de_los_Hechos = m.Municipio_de_los_Hechos
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Poblacion_Hechos = m.Poblacion_Hechos
                        ,Poblacion_HechosNombre = CultureHelper.GetTraduction(m.Poblacion_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Hechos_Colonia.Nombre
                        ,Colonia_de_los_Hechos = m.Colonia_de_los_Hechos
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_calle_de_los_hechos = m.Y_calle_de_los_hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_Hechos = m.Referencia_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
			,Documento_Extraviado = m.Documento_Extraviado
                        ,Tipo_de_Documento_Extraviado = m.Tipo_de_Documento_Extraviado
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_lugar_del_hecho = m.Tipo_de_lugar_del_hecho
                        ,Tipo_de_lugar_del_hechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_lugar_del_hecho_Lugar_Tipo.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Adicciones_de_Involucrado = Adicciones_de_InvolucradoData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_InvolucradoData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_InvolucradoData
                    ,Otras_Identificaciones = Otras_Identificaciones_InvolucradoData
                    ,Otros_Domicilios = Otros_Domicilios_InvolucradoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_Media_Filiacion(Detalle_de_Datos_Generales_Datos_de_Media_FiliacionModel varDetalle_de_Datos_Generales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Datos_Generales.Imagen_TatuajeRemoveAttachment != 0 && varDetalle_de_Datos_Generales.Imagen_TatuajeFile == null)
                    {
                        varDetalle_de_Datos_Generales.Imagen_Tatuaje = 0;
                    }

                    if (varDetalle_de_Datos_Generales.Imagen_TatuajeFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Datos_Generales.Imagen_TatuajeFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Datos_Generales.Imagen_Tatuaje = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Datos_Generales.Imagen_TatuajeFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Datos_Generales_Datos_de_Media_FiliacionInfo = new Detalle_de_Datos_Generales_Datos_de_Media_Filiacion
                {
                    Clave = varDetalle_de_Datos_Generales.Clave
                                            ,Peso = varDetalle_de_Datos_Generales.Peso
                        ,Estatura = varDetalle_de_Datos_Generales.Estatura
                        ,Padecimiento_de_Enfermedad = varDetalle_de_Datos_Generales.Padecimiento_de_Enfermedad
                        ,Forma_Cara = varDetalle_de_Datos_Generales.Forma_Cara
                        ,Tipo_de_Cejas = varDetalle_de_Datos_Generales.Tipo_de_Cejas
                        ,Tamano_de_Cejas = varDetalle_de_Datos_Generales.Tamano_de_Cejas
                        ,Cantidad_Cabello = varDetalle_de_Datos_Generales.Cantidad_Cabello
                        ,Implantacion_Cabello = varDetalle_de_Datos_Generales.Implantacion_Cabello
                        ,Complexion = varDetalle_de_Datos_Generales.Complexion
                        ,Color_Piel = varDetalle_de_Datos_Generales.Color_Piel
                        ,Frente = varDetalle_de_Datos_Generales.Frente
                        ,Largo_de_Cabello = varDetalle_de_Datos_Generales.Largo_de_Cabello
                        ,Forma_de_Cabello = varDetalle_de_Datos_Generales.Forma_de_Cabello
                        ,Color_Cabello = varDetalle_de_Datos_Generales.Color_Cabello
                        ,Calvicie = varDetalle_de_Datos_Generales.Calvicie
                        ,Color_Ojos = varDetalle_de_Datos_Generales.Color_Ojos
                        ,Tamano_de_Ojos = varDetalle_de_Datos_Generales.Tamano_de_Ojos
                        ,Forma_Ojos = varDetalle_de_Datos_Generales.Forma_Ojos
                        ,Anteojos = varDetalle_de_Datos_Generales.Anteojos
                        ,Forma_de_Nariz = varDetalle_de_Datos_Generales.Forma_de_Nariz
                        ,Tamano_Nariz = varDetalle_de_Datos_Generales.Tamano_Nariz
                        ,Labios = varDetalle_de_Datos_Generales.Labios
                        ,Boca = varDetalle_de_Datos_Generales.Boca
                        ,Grosor_de_Labios = varDetalle_de_Datos_Generales.Grosor_de_Labios
                        ,Menton = varDetalle_de_Datos_Generales.Menton
                        ,Forma_de_Menton = varDetalle_de_Datos_Generales.Forma_de_Menton
                        ,Barba = varDetalle_de_Datos_Generales.Barba
                        ,Forma_Orejas = varDetalle_de_Datos_Generales.Forma_Orejas
                        ,Tamano_Orejas = varDetalle_de_Datos_Generales.Tamano_Orejas
                        ,Tipo_Lobulo = varDetalle_de_Datos_Generales.Tipo_Lobulo
                        ,Bigote = varDetalle_de_Datos_Generales.Bigote
                        ,Senas_Particulares = varDetalle_de_Datos_Generales.Senas_Particulares
                        ,Imagen_Tatuaje = (varDetalle_de_Datos_Generales.Imagen_Tatuaje.HasValue && varDetalle_de_Datos_Generales.Imagen_Tatuaje != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Datos_Generales.Imagen_Tatuaje.Value)) : null

                        ,Situacion_Fisica = varDetalle_de_Datos_Generales.Situacion_Fisica
                        ,Otras_Senas_Particulares = varDetalle_de_Datos_Generales.Otras_Senas_Particulares
                    
                };

                result = _IDetalle_de_Datos_GeneralesApiConsumer.Update_Datos_de_Media_Filiacion(Detalle_de_Datos_Generales_Datos_de_Media_FiliacionInfo).Resource.ToString();
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
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Datos_GeneralesApiConsumer.Get_Datos_de_Media_Filiacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Adicciones_de_Involucrado;
                var Adicciones_de_InvolucradoData = GetAdicciones_de_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_de_Involucrado);
                int RowCount_Lugares_Frecuentes_Involucrado;
                var Lugares_Frecuentes_InvolucradoData = GetLugares_Frecuentes_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Involucrado);
                int RowCount_Datos_Personales_Adicionales_Involucrado;
                var Datos_Personales_Adicionales_InvolucradoData = GetDatos_Personales_Adicionales_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Involucrado);
                int RowCount_Otras_Identificaciones_Involucrado;
                var Otras_Identificaciones_InvolucradoData = GetOtras_Identificaciones_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Involucrado);
                int RowCount_Otros_Domicilios_Involucrado;
                var Otros_Domicilios_InvolucradoData = GetOtros_Domicilios_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Involucrado);

                var result = new Detalle_de_Datos_Generales_Datos_de_Media_FiliacionModel
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
                        ,Largo_de_Cabello = m.Largo_de_Cabello
                        ,Largo_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Largo_de_Cabello_Largo_de_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Largo_de_Cabello_Largo_de_Cabello.Descripcion
                        ,Forma_de_Cabello = m.Forma_de_Cabello
                        ,Forma_de_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cabello_Forma_Cabello.Descripcion
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
                        ,Tamano_NarizDescripcion = CultureHelper.GetTraduction(m.Tamano_Nariz_Tamano_de_Nariz.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Nariz_Tamano_de_Nariz.Descripcion
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
                    ,Adicciones_de_Involucrado = Adicciones_de_InvolucradoData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_InvolucradoData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_InvolucradoData
                    ,Otras_Identificaciones = Otras_Identificaciones_InvolucradoData
                    ,Otros_Domicilios = Otros_Domicilios_InvolucradoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Desestimacion(Detalle_de_Datos_Generales_DesestimacionModel varDetalle_de_Datos_Generales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Datos_Generales_DesestimacionInfo = new Detalle_de_Datos_Generales_Desestimacion
                {
                    Clave = varDetalle_de_Datos_Generales.Clave
                                            ,Causal = varDetalle_de_Datos_Generales.Causal
                        ,Causa_de_Interrupcion = varDetalle_de_Datos_Generales.Causa_de_Interrupcion
                        ,Datos_Insuficientes = varDetalle_de_Datos_Generales.Datos_Insuficientes
                        ,Actualizacion_de_Sobreseimiento = varDetalle_de_Datos_Generales.Actualizacion_de_Sobreseimiento
                    
                };

                result = _IDetalle_de_Datos_GeneralesApiConsumer.Update_Desestimacion(Detalle_de_Datos_Generales_DesestimacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Desestimacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Datos_GeneralesApiConsumer.Get_Desestimacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Adicciones_de_Involucrado;
                var Adicciones_de_InvolucradoData = GetAdicciones_de_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Adicciones_de_Involucrado);
                int RowCount_Lugares_Frecuentes_Involucrado;
                var Lugares_Frecuentes_InvolucradoData = GetLugares_Frecuentes_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Lugares_Frecuentes_Involucrado);
                int RowCount_Datos_Personales_Adicionales_Involucrado;
                var Datos_Personales_Adicionales_InvolucradoData = GetDatos_Personales_Adicionales_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Datos_Personales_Adicionales_Involucrado);
                int RowCount_Otras_Identificaciones_Involucrado;
                var Otras_Identificaciones_InvolucradoData = GetOtras_Identificaciones_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otras_Identificaciones_Involucrado);
                int RowCount_Otros_Domicilios_Involucrado;
                var Otros_Domicilios_InvolucradoData = GetOtros_Domicilios_InvolucradoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Otros_Domicilios_Involucrado);

                var result = new Detalle_de_Datos_Generales_DesestimacionModel
                {
                    Clave = m.Clave
                        ,Causal = m.Causal
                        ,CausalDescripcion = CultureHelper.GetTraduction(m.Causal_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_A_Tiempo.Descripcion
                        ,Causa_de_Interrupcion = m.Causa_de_Interrupcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_Insuficientes = m.Datos_Insuficientes
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

                    
                };
				var resultData = new
                {
                    data = result
                    ,Adicciones_de_Involucrado = Adicciones_de_InvolucradoData
                    ,Lugares_que_Frecuenta = Lugares_Frecuentes_InvolucradoData
                    ,Datos_Personales_Adicionales = Datos_Personales_Adicionales_InvolucradoData
                    ,Otras_Identificaciones = Otras_Identificaciones_InvolucradoData
                    ,Otros_Domicilios = Otros_Domicilios_InvolucradoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

