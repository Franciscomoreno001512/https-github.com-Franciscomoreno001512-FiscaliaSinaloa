using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Delito_de_JusticiaAdvanceSearchModel
    {
        public Detalle_de_Delito_de_JusticiaAdvanceSearchModel()
        {
            Violencia_de_Genero = RadioOptions.NoApply;
            Delito_Principal = RadioOptions.NoApply;
            Robo_de_Vehiculo = RadioOptions.NoApply;
            El_vehiculo_esta_asegurado = RadioOptions.NoApply;
            El_Vehiculo_Transportaba_Mercancia = RadioOptions.NoApply;
            Persona_Moral = RadioOptions.NoApply;
            Persona_Fisica = RadioOptions.NoApply;
            Denunciante = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromidRegistroAT { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromidRegistroAT", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToidRegistroAT { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromidRegistroUI { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromidRegistroUI", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToidRegistroUI { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        public Filters Tipo_de_DenunciaFilter { set; get; }
        public string AdvanceTipo_de_Denuncia { set; get; }
        public int[] AdvanceTipo_de_DenunciaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Delito { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Delito", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Delito { set; get; }

        public RadioOptions Violencia_de_Genero { set; get; }

        public Filters Delito_Violencia_GeneroFilter { set; get; }
        public string AdvanceDelito_Violencia_Genero { set; get; }
        public int[] AdvanceDelito_Violencia_GeneroMultiple { set; get; }

        public string ToHora_de_Delito { set; get; }
        public string FromHora_de_Delito { set; get; }

        public Filters Tipo_de_DelitoFilter { set; get; }
        public string AdvanceTipo_de_Delito { set; get; }
        public int[] AdvanceTipo_de_DelitoMultiple { set; get; }

        public Filters Grupo_de_DelitoFilter { set; get; }
        public string AdvanceGrupo_de_Delito { set; get; }
        public int[] AdvanceGrupo_de_DelitoMultiple { set; get; }

        public Filters DelitoFilter { set; get; }
        public string AdvanceDelito { set; get; }
        public int[] AdvanceDelitoMultiple { set; get; }

        public RadioOptions Delito_Principal { set; get; }

        public Filters Forma_de_Comision_de_DelitoFilter { set; get; }
        public string AdvanceForma_de_Comision_de_Delito { set; get; }
        public int[] AdvanceForma_de_Comision_de_DelitoMultiple { set; get; }

        public Filters Forma_de_Accion_de_DelitoFilter { set; get; }
        public string AdvanceForma_de_Accion_de_Delito { set; get; }
        public int[] AdvanceForma_de_Accion_de_DelitoMultiple { set; get; }

        public Filters Modalidad_de_DelitoFilter { set; get; }
        public string AdvanceModalidad_de_Delito { set; get; }
        public int[] AdvanceModalidad_de_DelitoMultiple { set; get; }

        public Filters Elementos_de_Comision_de_DelitoFilter { set; get; }
        public string AdvanceElementos_de_Comision_de_Delito { set; get; }
        public int[] AdvanceElementos_de_Comision_de_DelitoMultiple { set; get; }

        public Filters Clasificacion_con_Orden_de_ResultadoFilter { set; get; }
        public string AdvanceClasificacion_con_Orden_de_Resultado { set; get; }
        public int[] AdvanceClasificacion_con_Orden_de_ResultadoMultiple { set; get; }

        public Filters ConcursoFilter { set; get; }
        public string AdvanceConcurso { set; get; }
        public int[] AdvanceConcursoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_Reparacion_de_Danos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_Reparacion_de_Danos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_Reparacion_de_Danos { set; get; }

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

        public Filters Calle_del_DelitoFilter { set; get; }
        public string Calle_del_Delito { set; get; }

        public Filters Entre_Calle_del_DelitoFilter { set; get; }
        public string Entre_Calle_del_Delito { set; get; }

        public Filters Y_Calle_del_DelitoFilter { set; get; }
        public string Y_Calle_del_Delito { set; get; }

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

        public RadioOptions Robo_de_Vehiculo { set; get; }

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

        public Filters Circunstancia_de_Robo_de_VehiculoFilter { set; get; }
        public string AdvanceCircunstancia_de_Robo_de_Vehiculo { set; get; }
        public int[] AdvanceCircunstancia_de_Robo_de_VehiculoMultiple { set; get; }

        public Filters MarcaFilter { set; get; }
        public string AdvanceMarca { set; get; }
        public int[] AdvanceMarcaMultiple { set; get; }

        public Filters Sub_MarcaFilter { set; get; }
        public string AdvanceSub_Marca { set; get; }
        public int[] AdvanceSub_MarcaMultiple { set; get; }

        public Filters Tipo_de_vehiculoFilter { set; get; }
        public string AdvanceTipo_de_vehiculo { set; get; }
        public int[] AdvanceTipo_de_vehiculoMultiple { set; get; }

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

        public Filters MotorFilter { set; get; }
        public string Motor { set; get; }

        public Filters SerieFilter { set; get; }
        public string Serie { set; get; }

        public Filters Estado_De_RoboFilter { set; get; }
        public string AdvanceEstado_De_Robo { set; get; }
        public int[] AdvanceEstado_De_RoboMultiple { set; get; }

        public Filters Municipio_de_RoboFilter { set; get; }
        public string AdvanceMunicipio_de_Robo { set; get; }
        public int[] AdvanceMunicipio_de_RoboMultiple { set; get; }

        public Filters Colonia_de_RoboFilter { set; get; }
        public string AdvanceColonia_de_Robo { set; get; }
        public int[] AdvanceColonia_de_RoboMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_de_Robo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_de_Robo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_de_Robo { set; get; }

        public Filters Calle_de_RoboFilter { set; get; }
        public string Calle_de_Robo { set; get; }

        public Filters Entre_Calle_de_RoboFilter { set; get; }
        public string Entre_Calle_de_Robo { set; get; }

        public Filters Y_Calle_de_RoboFilter { set; get; }
        public string Y_Calle_de_Robo { set; get; }

        public Filters Numero_Exterior_de_RoboFilter { set; get; }
        public string Numero_Exterior_de_Robo { set; get; }

        public Filters Numero_Interior_de_RoboFilter { set; get; }
        public string Numero_Interior_de_Robo { set; get; }

        public Filters Referencia_de_RoboFilter { set; get; }
        public string Referencia_de_Robo { set; get; }

        public Filters Latitud_de_RoboFilter { set; get; }
        public string Latitud_de_Robo { set; get; }

        public Filters Longitud_de_RoboFilter { set; get; }
        public string Longitud_de_Robo { set; get; }

        public Filters Lugar_de_RoboFilter { set; get; }
        public string AdvanceLugar_de_Robo { set; get; }
        public int[] AdvanceLugar_de_RoboMultiple { set; get; }

        public RadioOptions El_vehiculo_esta_asegurado { set; get; }

        public Filters Nombre_de_la_AseguradoraFilter { set; get; }
        public string AdvanceNombre_de_la_Aseguradora { set; get; }
        public int[] AdvanceNombre_de_la_AseguradoraMultiple { set; get; }

        public Filters Ruta_del_Servicio_PublicoFilter { set; get; }
        public string Ruta_del_Servicio_Publico { set; get; }

        public RadioOptions El_Vehiculo_Transportaba_Mercancia { set; get; }

        public Filters Descripcion_de_lo_que_TransportabaFilter { set; get; }
        public string Descripcion_de_lo_que_Transportaba { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_carga { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_carga", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_carga { set; get; }

        public Filters Senas_particularesFilter { set; get; }
        public string Senas_particulares { set; get; }

        public Filters Cuenta_con_GPSFilter { set; get; }
        public string AdvanceCuenta_con_GPS { set; get; }
        public int[] AdvanceCuenta_con_GPSMultiple { set; get; }

        public Filters Tipo_de_RoboFilter { set; get; }
        public string AdvanceTipo_de_Robo { set; get; }
        public int[] AdvanceTipo_de_RoboMultiple { set; get; }

        public Filters Tipo_de_Lugar_del_RoboFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Robo { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_RoboMultiple { set; get; }

        public Filters Tipo_de_CarreteraFilter { set; get; }
        public string AdvanceTipo_de_Carretera { set; get; }
        public int[] AdvanceTipo_de_CarreteraMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public Filters Numero_de_SerieFilter { set; get; }
        public string Numero_de_Serie { set; get; }

        public Filters Numero_de_MotorFilter { set; get; }
        public string Numero_de_Motor { set; get; }

        public RadioOptions Persona_Moral { set; get; }

        public Filters Nombre_Completo_Persona_MoralFilter { set; get; }
        public string AdvanceNombre_Completo_Persona_Moral { set; get; }
        public int[] AdvanceNombre_Completo_Persona_MoralMultiple { set; get; }

        public RadioOptions Persona_Fisica { set; get; }

        public Filters Nombre_Completo_Persona_FisicaFilter { set; get; }
        public string AdvanceNombre_Completo_Persona_Fisica { set; get; }
        public int[] AdvanceNombre_Completo_Persona_FisicaMultiple { set; get; }

        public RadioOptions Denunciante { set; get; }

        public Filters Nombre_Completo_DenuncianteFilter { set; get; }
        public string AdvanceNombre_Completo_Denunciante { set; get; }
        public int[] AdvanceNombre_Completo_DenuncianteMultiple { set; get; }


    }
}
