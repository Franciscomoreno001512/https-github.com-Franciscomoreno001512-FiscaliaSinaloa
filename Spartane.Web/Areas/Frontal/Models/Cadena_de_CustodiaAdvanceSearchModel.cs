using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Cadena_de_CustodiaAdvanceSearchModel
    {
        public Cadena_de_CustodiaAdvanceSearchModel()
        {
            Fijacion_Planimetrica = RadioOptions.NoApply;
            Probables_Detenidos = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters NUCFilter { set; get; }
        public string NUC { set; get; }

        public Filters NICFilter { set; get; }
        public string NIC { set; get; }

        public Filters Delito_ReferenciaFilter { set; get; }
        public string AdvanceDelito_Referencia { set; get; }
        public int[] AdvanceDelito_ReferenciaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha { set; get; }

        public string ToHora { set; get; }
        public string FromHora { set; get; }

        public Filters Lugar_Exacto_del_LevantamientoFilter { set; get; }
        public string Lugar_Exacto_del_Levantamiento { set; get; }

        public Filters Condicion_y_UbicacionFilter { set; get; }
        public string Condicion_y_Ubicacion { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromLevantada_por { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromLevantada_por", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToLevantada_por { set; get; }

        public Filters CargoFilter { set; get; }
        public string AdvanceCargo { set; get; }
        public int[] AdvanceCargoMultiple { set; get; }

        public Filters AsignarFilter { set; get; }
        public string AdvanceAsignar { set; get; }
        public int[] AdvanceAsignarMultiple { set; get; }

        public Filters Folio_NUEFilter { set; get; }
        public string Folio_NUE { set; get; }

        public Filters Unidad_PolicialFilter { set; get; }
        public string AdvanceUnidad_Policial { set; get; }
        public int[] AdvanceUnidad_PolicialMultiple { set; get; }

        public Filters Caracterististicas_del_indicioFilter { set; get; }
        public string Caracterististicas_del_indicio { set; get; }

        public Filters Condiciones_De_ManejoFilter { set; get; }
        public string Condiciones_De_Manejo { set; get; }

        public Filters Numero_de_ParteFilter { set; get; }
        public string Numero_de_Parte { set; get; }

        public Filters CUIPFilter { set; get; }
        public string CUIP { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters ClimaFilter { set; get; }
        public string Clima { set; get; }

        public Filters GradosFilter { set; get; }
        public string Grados { set; get; }

        public RadioOptions Fijacion_Planimetrica { set; get; }

        public Filters MensajeFilter { set; get; }
        public string Mensaje { set; get; }

        public Filters Unidad_AdministrativaFilter { set; get; }
        public string AdvanceUnidad_Administrativa { set; get; }
        public int[] AdvanceUnidad_AdministrativaMultiple { set; get; }

        public Filters Entidad_FederativaFilter { set; get; }
        public string AdvanceEntidad_Federativa { set; get; }
        public int[] AdvanceEntidad_FederativaMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters Numero_de_OficioFilter { set; get; }
        public string Numero_de_Oficio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_CC { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_CC", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_CC { set; get; }

        public string ToHora_CC { set; get; }
        public string FromHora_CC { set; get; }

        public Filters Motivo_de_IntervencionFilter { set; get; }
        public string AdvanceMotivo_de_Intervencion { set; get; }
        public int[] AdvanceMotivo_de_IntervencionMultiple { set; get; }

        public Filters OtroFilter { set; get; }
        public string Otro { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromUsuario_que_Registra { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromUsuario_que_Registra", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToUsuario_que_Registra { set; get; }

        public Filters FAEFilter { set; get; }
        public string FAE { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_la_Emergencia { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_la_Emergencia", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_la_Emergencia { set; get; }

        public string ToHora_de_la_Emergencia { set; get; }
        public string FromHora_de_la_Emergencia { set; get; }

        public Filters FuenteFilter { set; get; }
        public string Fuente { set; get; }

        public Filters TelefonoFilter { set; get; }
        public string Telefono { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        public Filters Red_SocialFilter { set; get; }
        public string Red_Social { set; get; }

        public Filters Medio_MasivoFilter { set; get; }
        public string Medio_Masivo { set; get; }

        public Filters Cargo_de_la_AutoridadFilter { set; get; }
        public string Cargo_de_la_Autoridad { set; get; }

        public Filters Tipo_de_EmergenciaFilter { set; get; }
        public string Tipo_de_Emergencia { set; get; }

        public Filters Descripcion_de_la_EmergenciaFilter { set; get; }
        public string Descripcion_de_la_Emergencia { set; get; }

        public RadioOptions Probables_Detenidos { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_la_Detencion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_la_Detencion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_la_Detencion { set; get; }

        public string ToHora_de_la_Detencion { set; get; }
        public string FromHora_de_la_Detencion { set; get; }

        public Filters Pais_EmergenciaFilter { set; get; }
        public string Pais_Emergencia { set; get; }

        public Filters Estado_EmergenciaFilter { set; get; }
        public string Estado_Emergencia { set; get; }

        public Filters Municipio_EmergenciaFilter { set; get; }
        public string Municipio_Emergencia { set; get; }

        public Filters Colonia_EmergenciaFilter { set; get; }
        public string Colonia_Emergencia { set; get; }

        public Filters Calle_EmergenciaFilter { set; get; }
        public string Calle_Emergencia { set; get; }

        public Filters Entre_Calle_EmergenciaFilter { set; get; }
        public string Entre_Calle_Emergencia { set; get; }

        public Filters Y_Calle_EmergenciaFilter { set; get; }
        public string Y_Calle_Emergencia { set; get; }

        public Filters Latitud_EmergenciaFilter { set; get; }
        public string Latitud_Emergencia { set; get; }

        public Filters Longitud_EmergenciaFilter { set; get; }
        public string Longitud_Emergencia { set; get; }

        public Filters Nombre_de_la_AutoridadFilter { set; get; }
        public string Nombre_de_la_Autoridad { set; get; }

        public Filters EspecifiqueFilter { set; get; }
        public string Especifique { set; get; }

        public Filters Tipo_de_AgenteFilter { set; get; }
        public string Tipo_de_Agente { set; get; }

        public Filters AreaFilter { set; get; }
        public string Area { set; get; }

        public Filters UnidadFilter { set; get; }
        public string Unidad { set; get; }

        public Filters ZonaFilter { set; get; }
        public string Zona { set; get; }

        public Filters Agente_InvestigadorFilter { set; get; }
        public string Agente_Investigador { set; get; }

        public Filters Narrativa_de_los_HechosFilter { set; get; }
        public string Narrativa_de_los_Hechos { set; get; }

        public Filters Probable_Delito_PrincipalFilter { set; get; }
        public string Probable_Delito_Principal { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Asignacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Asignacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Asignacion { set; get; }

        public string ToHora_de_Asignacion { set; get; }
        public string FromHora_de_Asignacion { set; get; }

        public Filters Estatus_NUEFilter { set; get; }
        public string Estatus_NUE { set; get; }

        public Filters Inicio_de_Cadena_de_CustodiaFilter { set; get; }
        public string AdvanceInicio_de_Cadena_de_Custodia { set; get; }
        public int[] AdvanceInicio_de_Cadena_de_CustodiaMultiple { set; get; }

        public Filters Calidad_de_quien_aportaFilter { set; get; }
        public string AdvanceCalidad_de_quien_aporta { set; get; }
        public int[] AdvanceCalidad_de_quien_aportaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_arribo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_arribo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_arribo { set; get; }

        public string ToHora_del_arribo { set; get; }
        public string FromHora_del_arribo { set; get; }

        public Filters Descripcion_de_recoleccionFilter { set; get; }
        public string AdvanceDescripcion_de_recoleccion { set; get; }
        public int[] AdvanceDescripcion_de_recoleccionMultiple { set; get; }

        public Filters Movil_para_TrasladoFilter { set; get; }
        public string AdvanceMovil_para_Traslado { set; get; }
        public int[] AdvanceMovil_para_TrasladoMultiple { set; get; }

        public Filters Servidor_Publico_que_PreservaFilter { set; get; }
        public string Servidor_Publico_que_Preserva { set; get; }

        public Filters Servidor_Publico_que_BuscaFilter { set; get; }
        public string Servidor_Publico_que_Busca { set; get; }

        public Filters Servidor_Publico_que_LocalizaFilter { set; get; }
        public string Servidor_Publico_que_Localiza { set; get; }

        public Filters Servidor_Publico_que_RecolectaFilter { set; get; }
        public string Servidor_Publico_que_Recolecta { set; get; }

        public Filters Servidor_Publico_que_TrasladaFilter { set; get; }
        public string Servidor_Publico_que_Traslada { set; get; }

        public Filters PreservacionFilter { set; get; }
        public string Preservacion { set; get; }

        public Filters BusquedaFilter { set; get; }
        public string Busqueda { set; get; }

        public Filters LocalizacionFilter { set; get; }
        public string Localizacion { set; get; }

        public Filters RecoleccionFilter { set; get; }
        public string Recoleccion { set; get; }


    }
}
