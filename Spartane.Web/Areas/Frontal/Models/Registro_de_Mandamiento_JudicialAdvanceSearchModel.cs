using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Mandamiento_JudicialAdvanceSearchModel
    {
        public Registro_de_Mandamiento_JudicialAdvanceSearchModel()
        {
            Usa_Anteojos = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Folio_de_la_Orden_de_AprehensionFilter { set; get; }
        public string Folio_de_la_Orden_de_Aprehension { set; get; }

        public Filters Pais_al_que_Pertenece_la_InformacionFilter { set; get; }
        public string AdvancePais_al_que_Pertenece_la_Informacion { set; get; }
        public int[] AdvancePais_al_que_Pertenece_la_InformacionMultiple { set; get; }

        public Filters Estado_que_Envia_la_InformacionFilter { set; get; }
        public string AdvanceEstado_que_Envia_la_Informacion { set; get; }
        public int[] AdvanceEstado_que_Envia_la_InformacionMultiple { set; get; }

        public Filters Municipio_que_Envia_la_InformacionFilter { set; get; }
        public string AdvanceMunicipio_que_Envia_la_Informacion { set; get; }
        public int[] AdvanceMunicipio_que_Envia_la_InformacionMultiple { set; get; }

        public Filters Institucion_que_RemiteFilter { set; get; }
        public string AdvanceInstitucion_que_Remite { set; get; }
        public int[] AdvanceInstitucion_que_RemiteMultiple { set; get; }

        public Filters Entidad_que_Emite_MandamientoFilter { set; get; }
        public string AdvanceEntidad_que_Emite_Mandamiento { set; get; }
        public int[] AdvanceEntidad_que_Emite_MandamientoMultiple { set; get; }

        public Filters Juzgado_que_Emitio_MandamientoFilter { set; get; }
        public string AdvanceJuzgado_que_Emitio_Mandamiento { set; get; }
        public int[] AdvanceJuzgado_que_Emitio_MandamientoMultiple { set; get; }

        public Filters Numero_de_MandamientoFilter { set; get; }
        public string Numero_de_Mandamiento { set; get; }

        public Filters Oficio_de_JuzgadoFilter { set; get; }
        public string Oficio_de_Juzgado { set; get; }

        public Filters NombreFilter { set; get; }
        public string Nombre { set; get; }

        public Filters AliasFilter { set; get; }
        public string Alias { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEstatura { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEstatura", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEstatura { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromPeso { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromPeso", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToPeso { set; get; }

        public RadioOptions Usa_Anteojos { set; get; }

        public Filters SexoFilter { set; get; }
        public string AdvanceSexo { set; get; }
        public int[] AdvanceSexoMultiple { set; get; }

        public Filters Estado_CivilFilter { set; get; }
        public string AdvanceEstado_Civil { set; get; }
        public int[] AdvanceEstado_CivilMultiple { set; get; }

        public Filters Tipo_de_IdentificacionFilter { set; get; }
        public string AdvanceTipo_de_Identificacion { set; get; }
        public int[] AdvanceTipo_de_IdentificacionMultiple { set; get; }

        public Filters Numero_de_IdentificacionFilter { set; get; }
        public string Numero_de_Identificacion { set; get; }

        public Filters NacionalidadFilter { set; get; }
        public string AdvanceNacionalidad { set; get; }
        public int[] AdvanceNacionalidadMultiple { set; get; }

        public Filters EscolaridadFilter { set; get; }
        public string AdvanceEscolaridad { set; get; }
        public int[] AdvanceEscolaridadMultiple { set; get; }

        public Filters OcupacionFilter { set; get; }
        public string AdvanceOcupacion { set; get; }
        public int[] AdvanceOcupacionMultiple { set; get; }

        public Filters Pais_de_NacimientoFilter { set; get; }
        public string AdvancePais_de_Nacimiento { set; get; }
        public int[] AdvancePais_de_NacimientoMultiple { set; get; }

        public Filters Estado_de_NacimientoFilter { set; get; }
        public string AdvanceEstado_de_Nacimiento { set; get; }
        public int[] AdvanceEstado_de_NacimientoMultiple { set; get; }

        public Filters Tipo_de_OrdenFilter { set; get; }
        public string AdvanceTipo_de_Orden { set; get; }
        public int[] AdvanceTipo_de_OrdenMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Orden { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Orden", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Orden { set; get; }

        public string ToHora_de_Orden { set; get; }
        public string FromHora_de_Orden { set; get; }

        public Filters Dirigida_PorFilter { set; get; }
        public string Dirigida_Por { set; get; }

        public Filters AmbitoFilter { set; get; }
        public string AdvanceAmbito { set; get; }
        public int[] AdvanceAmbitoMultiple { set; get; }

        public Filters JuzgadoFilter { set; get; }
        public string AdvanceJuzgado { set; get; }
        public int[] AdvanceJuzgadoMultiple { set; get; }

        public Filters JuezFilter { set; get; }
        public string Juez { set; get; }

        public Filters EspecialidadFilter { set; get; }
        public string AdvanceEspecialidad { set; get; }
        public int[] AdvanceEspecialidadMultiple { set; get; }

        public Filters Numero_de_CausaFilter { set; get; }
        public string Numero_de_Causa { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Oficio { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Oficio", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Oficio { set; get; }

        public Filters Tipo_de_CuantiaFilter { set; get; }
        public string AdvanceTipo_de_Cuantia { set; get; }
        public int[] AdvanceTipo_de_CuantiaMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters Forma_CaraFilter { set; get; }
        public string AdvanceForma_Cara { set; get; }
        public int[] AdvanceForma_CaraMultiple { set; get; }

        public Filters CejasFilter { set; get; }
        public string AdvanceCejas { set; get; }
        public int[] AdvanceCejasMultiple { set; get; }

        public Filters Cantidad_CabelloFilter { set; get; }
        public string AdvanceCantidad_Cabello { set; get; }
        public int[] AdvanceCantidad_CabelloMultiple { set; get; }

        public Filters Implantacion_CabelloFilter { set; get; }
        public string AdvanceImplantacion_Cabello { set; get; }
        public int[] AdvanceImplantacion_CabelloMultiple { set; get; }

        public Filters ComplexionFilter { set; get; }
        public string AdvanceComplexion { set; get; }
        public int[] AdvanceComplexionMultiple { set; get; }

        public Filters Color_PielFilter { set; get; }
        public string AdvanceColor_Piel { set; get; }
        public int[] AdvanceColor_PielMultiple { set; get; }

        public Filters FrenteFilter { set; get; }
        public string AdvanceFrente { set; get; }
        public int[] AdvanceFrenteMultiple { set; get; }

        public Filters Forma_CabelloFilter { set; get; }
        public string AdvanceForma_Cabello { set; get; }
        public int[] AdvanceForma_CabelloMultiple { set; get; }

        public Filters Color_CabelloFilter { set; get; }
        public string AdvanceColor_Cabello { set; get; }
        public int[] AdvanceColor_CabelloMultiple { set; get; }

        public Filters CalvicieFilter { set; get; }
        public string AdvanceCalvicie { set; get; }
        public int[] AdvanceCalvicieMultiple { set; get; }

        public Filters Color_OjosFilter { set; get; }
        public string AdvanceColor_Ojos { set; get; }
        public int[] AdvanceColor_OjosMultiple { set; get; }

        public Filters OjosFilter { set; get; }
        public string AdvanceOjos { set; get; }
        public int[] AdvanceOjosMultiple { set; get; }

        public Filters Forma_OjosFilter { set; get; }
        public string AdvanceForma_Ojos { set; get; }
        public int[] AdvanceForma_OjosMultiple { set; get; }

        public Filters Nariz_BaseFilter { set; get; }
        public string AdvanceNariz_Base { set; get; }
        public int[] AdvanceNariz_BaseMultiple { set; get; }

        public Filters LabiosFilter { set; get; }
        public string AdvanceLabios { set; get; }
        public int[] AdvanceLabiosMultiple { set; get; }

        public Filters BocaFilter { set; get; }
        public string AdvanceBoca { set; get; }
        public int[] AdvanceBocaMultiple { set; get; }

        public Filters MentonFilter { set; get; }
        public string AdvanceMenton { set; get; }
        public int[] AdvanceMentonMultiple { set; get; }

        public Filters BarbaFilter { set; get; }
        public string AdvanceBarba { set; get; }
        public int[] AdvanceBarbaMultiple { set; get; }

        public Filters Forma_OrejasFilter { set; get; }
        public string AdvanceForma_Orejas { set; get; }
        public int[] AdvanceForma_OrejasMultiple { set; get; }

        public Filters Tamano_OrejasFilter { set; get; }
        public string AdvanceTamano_Orejas { set; get; }
        public int[] AdvanceTamano_OrejasMultiple { set; get; }

        public Filters Tipo_LobuloFilter { set; get; }
        public string AdvanceTipo_Lobulo { set; get; }
        public int[] AdvanceTipo_LobuloMultiple { set; get; }

        public Filters BigoteFilter { set; get; }
        public string AdvanceBigote { set; get; }
        public int[] AdvanceBigoteMultiple { set; get; }

        public Filters Situacion_FisicaFilter { set; get; }
        public string AdvanceSituacion_Fisica { set; get; }
        public int[] AdvanceSituacion_FisicaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Libramiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Libramiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Libramiento { set; get; }

        public Filters FuerzoFilter { set; get; }
        public string AdvanceFuerzo { set; get; }
        public int[] AdvanceFuerzoMultiple { set; get; }

        public Filters Tipo_MandatoFilter { set; get; }
        public string AdvanceTipo_Mandato { set; get; }
        public int[] AdvanceTipo_MandatoMultiple { set; get; }

        public Filters Numero_de_Proceso_JudicialFilter { set; get; }
        public string Numero_de_Proceso_Judicial { set; get; }

        public Filters Numero_de_AveriguacionFilter { set; get; }
        public string Numero_de_Averiguacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Captura { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Captura", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Captura { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Recepcion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Recepcion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Recepcion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Prescripcion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Prescripcion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Prescripcion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cumplimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cumplimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cumplimiento { set; get; }

        public Filters Oficio_de_CumplimientoFilter { set; get; }
        public string Oficio_de_Cumplimiento { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cancelacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cancelacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cancelacion { set; get; }

        public Filters Motivo_de_CancelacionFilter { set; get; }
        public string AdvanceMotivo_de_Cancelacion { set; get; }
        public int[] AdvanceMotivo_de_CancelacionMultiple { set; get; }

        public Filters Oficio_de_CancelacionFilter { set; get; }
        public string Oficio_de_Cancelacion { set; get; }

        public Filters Tipo_de_ProcesoFilter { set; get; }
        public string AdvanceTipo_de_Proceso { set; get; }
        public int[] AdvanceTipo_de_ProcesoMultiple { set; get; }

        public Filters Proceso_de_ExtradiccionFilter { set; get; }
        public string AdvanceProceso_de_Extradiccion { set; get; }
        public int[] AdvanceProceso_de_ExtradiccionMultiple { set; get; }

        public Filters ObservacionesxFilter { set; get; }
        public string Observacionesx { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromHuellas_Digitales { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromHuellas_Digitales", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToHuellas_Digitales { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMano_Izquierda_dedos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMano_Izquierda_dedos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMano_Izquierda_dedos { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMano_Derecha_Pulgar { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMano_Derecha_Pulgar", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMano_Derecha_Pulgar { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMano_Derecha_Dedos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMano_Derecha_Dedos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMano_Derecha_Dedos { set; get; }


    }
}
