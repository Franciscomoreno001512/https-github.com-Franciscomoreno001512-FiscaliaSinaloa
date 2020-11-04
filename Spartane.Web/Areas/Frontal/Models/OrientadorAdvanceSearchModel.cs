using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class OrientadorAdvanceSearchModel
    {
        public OrientadorAdvanceSearchModel()
        {
            Atencion_Medica = RadioOptions.NoApply;
            Atencion_Psicologica = RadioOptions.NoApply;
            Traductor = RadioOptions.NoApply;
            HViolencia_de_Genero = RadioOptions.NoApply;
            Vehiculo_Robado = RadioOptions.NoApply;
            Seguro = RadioOptions.NoApply;
            Mercancia = RadioOptions.NoApply;
            Estado_Operador = RadioOptions.NoApply;
            Delito_Principal_o_Secundario = RadioOptions.NoApply;
            Conocido = RadioOptions.NoApply;
            Desconocido = RadioOptions.NoApply;
            Autoriza = RadioOptions.NoApply;
            Autoriza2 = RadioOptions.NoApply;
            Autoriza3 = RadioOptions.NoApply;
            Menor_de_Edad = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public RadioOptions Atencion_Medica { set; get; }

        public RadioOptions Atencion_Psicologica { set; get; }

        public RadioOptions Traductor { set; get; }

        public Filters Narrativa_DMFilter { set; get; }
        public string Narrativa_DM { set; get; }

        public Filters Narrativa_DPFilter { set; get; }
        public string Narrativa_DP { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters NombreFilter { set; get; }
        public string Nombre { set; get; }

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

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters LocalidadFilter { set; get; }
        public string AdvanceLocalidad { set; get; }
        public int[] AdvanceLocalidadMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters TelefonoFilter { set; get; }
        public string Telefono { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public Filters Tipo_de_Lugar_del_HechoFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_HechoMultiple { set; get; }

        public Filters Calle2Filter { set; get; }
        public string Calle2 { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior2 { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior2", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior2 { set; get; }

        public Filters Numero_Interior2Filter { set; get; }
        public string Numero_Interior2 { set; get; }

        public Filters Colonia2Filter { set; get; }
        public string AdvanceColonia2 { set; get; }
        public int[] AdvanceColonia2Multiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal2 { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal2", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal2 { set; get; }

        public Filters ZonaFilter { set; get; }
        public string AdvanceZona { set; get; }
        public int[] AdvanceZonaMultiple { set; get; }

        public Filters Municipio2Filter { set; get; }
        public string AdvanceMunicipio2 { set; get; }
        public int[] AdvanceMunicipio2Multiple { set; get; }

        public Filters Estado2Filter { set; get; }
        public string AdvanceEstado2 { set; get; }
        public int[] AdvanceEstado2Multiple { set; get; }

        public Filters Grupo_DelitoFilter { set; get; }
        public string AdvanceGrupo_Delito { set; get; }
        public int[] AdvanceGrupo_DelitoMultiple { set; get; }

        public Filters DelitoFilter { set; get; }
        public string AdvanceDelito { set; get; }
        public int[] AdvanceDelitoMultiple { set; get; }

        public Filters CircunstanciaFilter { set; get; }
        public string AdvanceCircunstancia { set; get; }
        public int[] AdvanceCircunstanciaMultiple { set; get; }

        public Filters Tipo_DelitoFilter { set; get; }
        public string AdvanceTipo_Delito { set; get; }
        public int[] AdvanceTipo_DelitoMultiple { set; get; }

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

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto { set; get; }

        public RadioOptions HViolencia_de_Genero { set; get; }

        public Filters Calificacion_del_DelitoFilter { set; get; }
        public string Calificacion_del_Delito { set; get; }

        public Filters CircunstanciaVFilter { set; get; }
        public string AdvanceCircunstanciaV { set; get; }
        public int[] AdvanceCircunstanciaVMultiple { set; get; }

        public Filters Clase_EspecificaFilter { set; get; }
        public string AdvanceClase_Especifica { set; get; }
        public int[] AdvanceClase_EspecificaMultiple { set; get; }

        public Filters MarcaFilter { set; get; }
        public string AdvanceMarca { set; get; }
        public int[] AdvanceMarcaMultiple { set; get; }

        public Filters Sub_MarcaFilter { set; get; }
        public string AdvanceSub_Marca { set; get; }
        public int[] AdvanceSub_MarcaMultiple { set; get; }

        public Filters Tipo_de_VehiculoFilter { set; get; }
        public string AdvanceTipo_de_Vehiculo { set; get; }
        public int[] AdvanceTipo_de_VehiculoMultiple { set; get; }

        public Filters ModeloFilter { set; get; }
        public string Modelo { set; get; }

        public Filters ColorFilter { set; get; }
        public string AdvanceColor { set; get; }
        public int[] AdvanceColorMultiple { set; get; }

        public Filters PlacasFilter { set; get; }
        public string Placas { set; get; }

        public Filters Estado_PlacasFilter { set; get; }
        public string AdvanceEstado_Placas { set; get; }
        public int[] AdvanceEstado_PlacasMultiple { set; get; }

        public RadioOptions Vehiculo_Robado { set; get; }

        public RadioOptions Seguro { set; get; }

        public Filters AseguradoraFilter { set; get; }
        public string AdvanceAseguradora { set; get; }
        public int[] AdvanceAseguradoraMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public Filters Ruta_del_Servicio_PublicoFilter { set; get; }
        public string Ruta_del_Servicio_Publico { set; get; }

        public RadioOptions Mercancia { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_la_Carga { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_la_Carga", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_la_Carga { set; get; }

        public Filters Senas_ParticularesFilter { set; get; }
        public string Senas_Particulares { set; get; }

        public Filters Modalidad_del_RoboFilter { set; get; }
        public string AdvanceModalidad_del_Robo { set; get; }
        public int[] AdvanceModalidad_del_RoboMultiple { set; get; }

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

        public Filters DomicilioFilter { set; get; }
        public string Domicilio { set; get; }

        public Filters Numero_Interior3Filter { set; get; }
        public string Numero_Interior3 { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior3 { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior3", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior3 { set; get; }

        public Filters Colonia3Filter { set; get; }
        public string AdvanceColonia3 { set; get; }
        public int[] AdvanceColonia3Multiple { set; get; }

        public Filters Colonia_no_CatalogadaFilter { set; get; }
        public string Colonia_no_Catalogada { set; get; }

        public Filters Zona2Filter { set; get; }
        public string AdvanceZona2 { set; get; }
        public int[] AdvanceZona2Multiple { set; get; }

        public Filters Municipio3Filter { set; get; }
        public string AdvanceMunicipio3 { set; get; }
        public int[] AdvanceMunicipio3Multiple { set; get; }

        public Filters Estado3Filter { set; get; }
        public string AdvanceEstado3 { set; get; }
        public int[] AdvanceEstado3Multiple { set; get; }

        public Filters NecropsiaFilter { set; get; }
        public string Necropsia { set; get; }

        public Filters CronotanatodiagnosticoFilter { set; get; }
        public string Cronotanatodiagnostico { set; get; }

        public Filters RutaFilter { set; get; }
        public string Ruta { set; get; }

        public RadioOptions Estado_Operador { set; get; }

        public RadioOptions Delito_Principal_o_Secundario { set; get; }

        public Filters ConcursoFilter { set; get; }
        public string Concurso { set; get; }

        public Filters ComparecienteFilter { set; get; }
        public string AdvanceCompareciente { set; get; }
        public int[] AdvanceComparecienteMultiple { set; get; }

        public Filters NombreCFilter { set; get; }
        public string NombreC { set; get; }

        public Filters Apellido_PaternoCFilter { set; get; }
        public string Apellido_PaternoC { set; get; }

        public Filters Apellido_MaternoCFilter { set; get; }
        public string Apellido_MaternoC { set; get; }

        public Filters NombreTFilter { set; get; }
        public string NombreT { set; get; }

        public Filters Apellido_PaternoTFilter { set; get; }
        public string Apellido_PaternoT { set; get; }

        public Filters Apellido_MaternoTFilter { set; get; }
        public string Apellido_MaternoT { set; get; }

        public Filters CalleCFilter { set; get; }
        public string CalleC { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_ExteriorC { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_ExteriorC", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_ExteriorC { set; get; }

        public Filters Numero_InteriorCFilter { set; get; }
        public string Numero_InteriorC { set; get; }

        public Filters ColoniaCFilter { set; get; }
        public string AdvanceColoniaC { set; get; }
        public int[] AdvanceColoniaCMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_PostalC { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_PostalC", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_PostalC { set; get; }

        public Filters ZonaCFilter { set; get; }
        public string AdvanceZonaC { set; get; }
        public int[] AdvanceZonaCMultiple { set; get; }

        public Filters MunicipioCFilter { set; get; }
        public string AdvanceMunicipioC { set; get; }
        public int[] AdvanceMunicipioCMultiple { set; get; }

        public Filters EstadoCFilter { set; get; }
        public string AdvanceEstadoC { set; get; }
        public int[] AdvanceEstadoCMultiple { set; get; }

        public Filters NarrativaCFilter { set; get; }
        public string NarrativaC { set; get; }

        public RadioOptions Conocido { set; get; }

        public RadioOptions Desconocido { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_de_Imputados { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_de_Imputados", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_de_Imputados { set; get; }

        public Filters ProcedenciaFilter { set; get; }
        public string AdvanceProcedencia { set; get; }
        public int[] AdvanceProcedenciaMultiple { set; get; }

        public Filters MotorFilter { set; get; }
        public string Motor { set; get; }

        public Filters SerieFilter { set; get; }
        public string Serie { set; get; }

        public Filters Causa_de_MuerteFilter { set; get; }
        public string Causa_de_Muerte { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Entre_Calle2Filter { set; get; }
        public string Entre_Calle2 { set; get; }

        public RadioOptions Autoriza { set; get; }

        public RadioOptions Autoriza2 { set; get; }

        public RadioOptions Autoriza3 { set; get; }

        public RadioOptions Menor_de_Edad { set; get; }


    }
}
