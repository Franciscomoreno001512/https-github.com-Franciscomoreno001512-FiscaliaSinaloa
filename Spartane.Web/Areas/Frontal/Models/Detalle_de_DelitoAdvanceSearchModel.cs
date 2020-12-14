using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_DelitoAdvanceSearchModel
    {
        public Detalle_de_DelitoAdvanceSearchModel()
        {
            Robo_de_Vehiculo = RadioOptions.NoApply;
            Violencia_de_Genero = RadioOptions.NoApply;
            Delito_Principal = RadioOptions.NoApply;
            Se_Informaron_sus_Derechos = RadioOptions.NoApply;
            Se_Informo_el_Procedimiento = RadioOptions.NoApply;
            Levantamiento_de_Cadaver = RadioOptions.NoApply;
            Vehiculo_Robado = RadioOptions.NoApply;
            El_Vehiculo_esta_Asegurado = RadioOptions.NoApply;
            Mercancia = RadioOptions.NoApply;
            Cuenta_con_GPS = RadioOptions.NoApply;
            Estado_del_Conductor = RadioOptions.NoApply;
            Persona_Moral_Dueno = RadioOptions.NoApply;
            Persona_Fisica_Dueno = RadioOptions.NoApply;
            Denunciante_dueno = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Descripcion_cortaFilter { set; get; }
        public string Descripcion_corta { set; get; }

        public RadioOptions Robo_de_Vehiculo { set; get; }

        public Filters Expediente_InicialFilter { set; get; }
        public string AdvanceExpediente_Inicial { set; get; }
        public int[] AdvanceExpediente_InicialMultiple { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters Expediente_MASCFilter { set; get; }
        public string AdvanceExpediente_MASC { set; get; }
        public int[] AdvanceExpediente_MASCMultiple { set; get; }

        public Filters Tipo_de_DenunciaFilter { set; get; }
        public string AdvanceTipo_de_Denuncia { set; get; }
        public int[] AdvanceTipo_de_DenunciaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Delito { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Delito", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Delito { set; get; }

        public string ToHora_del_Delito { set; get; }
        public string FromHora_del_Delito { set; get; }

        public RadioOptions Violencia_de_Genero { set; get; }

        public Filters Delito_Violencia_GeneroFilter { set; get; }
        public string AdvanceDelito_Violencia_Genero { set; get; }
        public int[] AdvanceDelito_Violencia_GeneroMultiple { set; get; }

        public Filters Tipo_de_DelitoFilter { set; get; }
        public string AdvanceTipo_de_Delito { set; get; }
        public int[] AdvanceTipo_de_DelitoMultiple { set; get; }

        public Filters Grupo_DelitoFilter { set; get; }
        public string AdvanceGrupo_Delito { set; get; }
        public int[] AdvanceGrupo_DelitoMultiple { set; get; }

        public Filters DelitoFilter { set; get; }
        public string AdvanceDelito { set; get; }
        public int[] AdvanceDelitoMultiple { set; get; }

        public Filters Circunstancia_DelitoFilter { set; get; }
        public string AdvanceCircunstancia_Delito { set; get; }
        public int[] AdvanceCircunstancia_DelitoMultiple { set; get; }

        public Filters Articulado_de_DelitoFilter { set; get; }
        public string Articulado_de_Delito { set; get; }

        public RadioOptions Delito_Principal { set; get; }

        public Filters Forma_Comision_DelitoFilter { set; get; }
        public string AdvanceForma_Comision_Delito { set; get; }
        public int[] AdvanceForma_Comision_DelitoMultiple { set; get; }

        public Filters Forma_Accion_DelitoFilter { set; get; }
        public string AdvanceForma_Accion_Delito { set; get; }
        public int[] AdvanceForma_Accion_DelitoMultiple { set; get; }

        public Filters Modalidad_DelitoFilter { set; get; }
        public string AdvanceModalidad_Delito { set; get; }
        public int[] AdvanceModalidad_DelitoMultiple { set; get; }

        public Filters Elementos_Comision_DelitoFilter { set; get; }
        public string AdvanceElementos_Comision_Delito { set; get; }
        public int[] AdvanceElementos_Comision_DelitoMultiple { set; get; }

        public Filters Clasificacion_con_Orden_de_ResultadoFilter { set; get; }
        public string AdvanceClasificacion_con_Orden_de_Resultado { set; get; }
        public int[] AdvanceClasificacion_con_Orden_de_ResultadoMultiple { set; get; }

        public Filters ConcursoFilter { set; get; }
        public string AdvanceConcurso { set; get; }
        public int[] AdvanceConcursoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto { set; get; }

        public Filters Estado_del_DelitoFilter { set; get; }
        public string AdvanceEstado_del_Delito { set; get; }
        public int[] AdvanceEstado_del_DelitoMultiple { set; get; }

        public Filters Municipio_del_DelitoFilter { set; get; }
        public string AdvanceMunicipio_del_Delito { set; get; }
        public int[] AdvanceMunicipio_del_DelitoMultiple { set; get; }

        public Filters Colonia_del_DelitoFilter { set; get; }
        public string AdvanceColonia_del_Delito { set; get; }
        public int[] AdvanceColonia_del_DelitoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters y_CalleFilter { set; get; }
        public string y_Calle { set; get; }

        public Filters Numero_Exterior_del_DelitoFilter { set; get; }
        public string Numero_Exterior_del_Delito { set; get; }

        public Filters Numero_Interior_del_DelitoFilter { set; get; }
        public string Numero_Interior_del_Delito { set; get; }

        public Filters ReferenciaFilter { set; get; }
        public string Referencia { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public Filters Puede_Ser_Canalizado_a_JAFilter { set; get; }
        public string AdvancePuede_Ser_Canalizado_a_JA { set; get; }
        public int[] AdvancePuede_Ser_Canalizado_a_JAMultiple { set; get; }

        public Filters Motivo_de_no_canalizacionFilter { set; get; }
        public string AdvanceMotivo_de_no_canalizacion { set; get; }
        public int[] AdvanceMotivo_de_no_canalizacionMultiple { set; get; }

        public RadioOptions Se_Informaron_sus_Derechos { set; get; }

        public RadioOptions Se_Informo_el_Procedimiento { set; get; }

        public RadioOptions Levantamiento_de_Cadaver { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Robo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Robo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Robo { set; get; }

        public string ToHora_del_Robo { set; get; }
        public string FromHora_del_Robo { set; get; }

        public Filters Robo_deFilter { set; get; }
        public string AdvanceRobo_de { set; get; }
        public int[] AdvanceRobo_deMultiple { set; get; }

        public Filters Registro_Federal_VehicularFilter { set; get; }
        public string Registro_Federal_Vehicular { set; get; }

        public Filters Numero_de_Registro_Publico_VehicularFilter { set; get; }
        public string Numero_de_Registro_Publico_Vehicular { set; get; }

        public Filters Circunstancia_de_VehiculoFilter { set; get; }
        public string AdvanceCircunstancia_de_Vehiculo { set; get; }
        public int[] AdvanceCircunstancia_de_VehiculoMultiple { set; get; }

        public Filters ClaseFilter { set; get; }
        public string AdvanceClase { set; get; }
        public int[] AdvanceClaseMultiple { set; get; }

        public RadioOptions Vehiculo_Robado { set; get; }

        public Filters MarcaFilter { set; get; }
        public string AdvanceMarca { set; get; }
        public int[] AdvanceMarcaMultiple { set; get; }

        public Filters Sub_MarcaFilter { set; get; }
        public string AdvanceSub_Marca { set; get; }
        public int[] AdvanceSub_MarcaMultiple { set; get; }

        public Filters Tipo_de_VehiculoFilter { set; get; }
        public string AdvanceTipo_de_Vehiculo { set; get; }
        public int[] AdvanceTipo_de_VehiculoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromModelo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromModelo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToModelo { set; get; }

        public Filters ColorFilter { set; get; }
        public string AdvanceColor { set; get; }
        public int[] AdvanceColorMultiple { set; get; }

        public Filters PlacasFilter { set; get; }
        public string Placas { set; get; }

        public Filters Estado_de_Origen_de_las_PlacasFilter { set; get; }
        public string AdvanceEstado_de_Origen_de_las_Placas { set; get; }
        public int[] AdvanceEstado_de_Origen_de_las_PlacasMultiple { set; get; }

        public Filters Numero_de_MotorFilter { set; get; }
        public string Numero_de_Motor { set; get; }

        public Filters Numero_de_SerieFilter { set; get; }
        public string Numero_de_Serie { set; get; }

        public Filters Estado_del_RoboFilter { set; get; }
        public string AdvanceEstado_del_Robo { set; get; }
        public int[] AdvanceEstado_del_RoboMultiple { set; get; }

        public Filters Municipio_del_RoboFilter { set; get; }
        public string AdvanceMunicipio_del_Robo { set; get; }
        public int[] AdvanceMunicipio_del_RoboMultiple { set; get; }

        public Filters Colonia_del_RoboFilter { set; get; }
        public string AdvanceColonia_del_Robo { set; get; }
        public int[] AdvanceColonia_del_RoboMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_Robo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_Robo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_Robo { set; get; }

        public Filters Calle_RoboFilter { set; get; }
        public string Calle_Robo { set; get; }

        public Filters Entre_Calle_RoboFilter { set; get; }
        public string Entre_Calle_Robo { set; get; }

        public Filters y_Calle_RoboFilter { set; get; }
        public string y_Calle_Robo { set; get; }

        public Filters Numero_Exterior_del_Delito_RoboFilter { set; get; }
        public string Numero_Exterior_del_Delito_Robo { set; get; }

        public Filters Numero_Interior_del_Delito_RoboFilter { set; get; }
        public string Numero_Interior_del_Delito_Robo { set; get; }

        public Filters Referencia_RoboFilter { set; get; }
        public string Referencia_Robo { set; get; }

        public Filters Latitud_RoboFilter { set; get; }
        public string Latitud_Robo { set; get; }

        public Filters Longitud_RoboFilter { set; get; }
        public string Longitud_Robo { set; get; }

        public Filters Lugar_del_RoboFilter { set; get; }
        public string AdvanceLugar_del_Robo { set; get; }
        public int[] AdvanceLugar_del_RoboMultiple { set; get; }

        public RadioOptions El_Vehiculo_esta_Asegurado { set; get; }

        public Filters Nombre_de_la_AseguradoraFilter { set; get; }
        public string AdvanceNombre_de_la_Aseguradora { set; get; }
        public int[] AdvanceNombre_de_la_AseguradoraMultiple { set; get; }

        public Filters MotorFilter { set; get; }
        public string Motor { set; get; }

        public Filters SerieFilter { set; get; }
        public string Serie { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public Filters Ruta_del_Servicio_PublicoFilter { set; get; }
        public string Ruta_del_Servicio_Publico { set; get; }

        public Filters ProcedenciaFilter { set; get; }
        public string AdvanceProcedencia { set; get; }
        public int[] AdvanceProcedenciaMultiple { set; get; }

        public RadioOptions Mercancia { set; get; }

        public Filters Descripcion_de_lo_que_TransportabaFilter { set; get; }
        public string Descripcion_de_lo_que_Transportaba { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_la_Carga { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_la_Carga", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_la_Carga { set; get; }

        public Filters Senas_ParticularesFilter { set; get; }
        public string Senas_Particulares { set; get; }

        public RadioOptions Cuenta_con_GPS { set; get; }

        public Filters Tipo_de_RoboFilter { set; get; }
        public string AdvanceTipo_de_Robo { set; get; }
        public int[] AdvanceTipo_de_RoboMultiple { set; get; }

        public Filters Tipo_de_Lugar_del_RoboFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Robo { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_RoboMultiple { set; get; }

        public Filters Tipo_de_CarreteraFilter { set; get; }
        public string AdvanceTipo_de_Carretera { set; get; }
        public int[] AdvanceTipo_de_CarreteraMultiple { set; get; }

        public Filters Modalidad_del_RoboFilter { set; get; }
        public string AdvanceModalidad_del_Robo { set; get; }
        public int[] AdvanceModalidad_del_RoboMultiple { set; get; }

        public Filters Causa_de_MuerteFilter { set; get; }
        public string Causa_de_Muerte { set; get; }

        public Filters Circunstancia_DefuncionFilter { set; get; }
        public string AdvanceCircunstancia_Defuncion { set; get; }
        public int[] AdvanceCircunstancia_DefuncionMultiple { set; get; }

        public Filters Consecuencia_DefuncionFilter { set; get; }
        public string AdvanceConsecuencia_Defuncion { set; get; }
        public int[] AdvanceConsecuencia_DefuncionMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Levantamiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Levantamiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Levantamiento { set; get; }

        public string ToHora_Levantamiento { set; get; }
        public string FromHora_Levantamiento { set; get; }

        public Filters Tipo_de_Lugar_del_HechoFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_HechoMultiple { set; get; }

        public Filters PaisFilter { set; get; }
        public string AdvancePais { set; get; }
        public int[] AdvancePaisMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        public Filters Colonia_no_CatalogadaFilter { set; get; }
        public string Colonia_no_Catalogada { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters NecropsiaFilter { set; get; }
        public string Necropsia { set; get; }

        public Filters CronotanatodiagnosticoFilter { set; get; }
        public string Cronotanatodiagnostico { set; get; }

        public Filters RutaFilter { set; get; }
        public string Ruta { set; get; }

        public RadioOptions Estado_del_Conductor { set; get; }

        public RadioOptions Persona_Moral_Dueno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string AdvanceNombre_Completo { set; get; }
        public int[] AdvanceNombre_CompletoMultiple { set; get; }

        public RadioOptions Persona_Fisica_Dueno { set; get; }

        public Filters Nombre_Completo_InvolucradoFilter { set; get; }
        public string AdvanceNombre_Completo_Involucrado { set; get; }
        public int[] AdvanceNombre_Completo_InvolucradoMultiple { set; get; }

        public RadioOptions Denunciante_dueno { set; get; }

        public Filters Nombre_Completo_DuenoFilter { set; get; }
        public string AdvanceNombre_Completo_Dueno { set; get; }
        public int[] AdvanceNombre_Completo_DuenoMultiple { set; get; }


    }
}
