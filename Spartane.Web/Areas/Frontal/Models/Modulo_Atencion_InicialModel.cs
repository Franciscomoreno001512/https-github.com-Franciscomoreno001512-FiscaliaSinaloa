using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_Atencion_InicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Turno_Asignado { get; set; }
        public string Turno_AsignadoNumero_de_Turno { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public string NUAT { get; set; }
        public string CDI { get; set; }
        public string Expedientes_Relacionados { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Generar_Cita { get; set; }
        public string Nombres_del_Remitente { get; set; }
        public string Apellido_Paterno_del_Remitente { get; set; }
        public string Apellido_Materno_del_Remitente { get; set; }
        public string Fecha_en_que_llega_para_validacion { get; set; }
        public int? Delegacion { get; set; }
        public string DelegacionDescripcion { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaDescripcion { get; set; }
        public int? Ministerio_Publico_en_Turno { get; set; }
        public string Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno { get; set; }
        public string Nombres_turno { get; set; }
        public string Apellido_Paterno_turno { get; set; }
        public string Apellido_Materno_turno { get; set; }
        public int? Sexo_turno { get; set; }
        public string Sexo_turnoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Edad_turno { get; set; }
        public int? Tipo_de_Atencion_turno { get; set; }
        public string Tipo_de_Atencion_turnoDescripcion { get; set; }
        public int? Tipo_de_Identificacion_turno { get; set; }
        public string Tipo_de_Identificacion_turnoNombre { get; set; }
        public string Numero_de_Identificacion_turno { get; set; }
        public bool Urgencia_turno { get; set; }
        public int? Tipo_de_Urgencia_turno { get; set; }
        public string Tipo_de_Urgencia_turnoDescripcion { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Motivo_Finalizacion_TurnoDescripcion { get; set; }
        public string Observaciones_turno { get; set; }
        public bool Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public bool Autoriza_Traductor { get; set; }
        public bool Finalizar_Servicios_de_Apoyo { get; set; }
        public int? Estatus2 { get; set; }
        public string Estatus2Descripcion { get; set; }
        public int? Unidad_canaliza { get; set; }
        public string Unidad_canalizaDescripcion { get; set; }
        public bool Enviar_a_MP { get; set; }
        public bool Correccion_de_Estatus { get; set; }
        public bool Requiere_Servicios_de_Apoyo { get; set; }
        public bool Persona_Moral { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public int? Orientador { get; set; }
        public string OrientadorName { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public string Pais_de_los_HechosNombre { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public string Estado_de_los_HechosNombre { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public string Municipio_de_los_HechosNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public string Colonia_de_los_HechosNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exrterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public int? Zona_de_los_Hechos { get; set; }
        public string Zona_de_los_HechosDescripcion { get; set; }
        public string Turno { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public string Fecha_de_Inicio_de_Acuerdo { get; set; }
        public string Fecha_de_Cumplimiento_del_Acuerdo { get; set; }
        public string Hora_de_Cumplimiento_del_Acuerdo { get; set; }
        public string Domicilio_para_el_Cumplimiento { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        [Range(0, 9999999999)]
        public int? Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public string PeriodicidadDescripcion { get; set; }
        public bool Se_Acepta_Acuerdo { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }
        public bool Cerrar { get; set; }
        public string Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }
        public string NUC { get; set; }
        public string Fecha_de_Vencimiento_1 { get; set; }
        public string EspecialistaJA { get; set; }
        public string Campo_Oculto1 { get; set; }
        public int? JefeMPO { get; set; }
        public string JefeMPOMinisterio_Publico_en_Turno { get; set; }
        public string Campo_Oculto2 { get; set; }
        public string Campo_Oculto3 { get; set; }
        public int? CoordinadorJA { get; set; }
        public string CoordinadorJAName { get; set; }
        public int? EspJA { get; set; }
        public string EspJAName { get; set; }
        public string Ano_Actual { get; set; }
        [Range(0, 9999999999)]
        public int? Secuencial { get; set; }

    }
	
	public class Modulo_Atencion_Inicial_Datos_del_CasoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Turno_Asignado { get; set; }
        public string Turno_AsignadoNumero_de_Turno { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public string NUAT { get; set; }
        public string CDI { get; set; }
        public string Expedientes_Relacionados { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Generar_Cita { get; set; }
        public string Nombres_del_Remitente { get; set; }
        public string Apellido_Paterno_del_Remitente { get; set; }
        public string Apellido_Materno_del_Remitente { get; set; }
        public string Fecha_en_que_llega_para_validacion { get; set; }
        public int? Delegacion { get; set; }
        public string DelegacionDescripcion { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaDescripcion { get; set; }
        public int? Ministerio_Publico_en_Turno { get; set; }
        public string Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno { get; set; }

    }

	public class Modulo_Atencion_Inicial_Informacion_de_TurnoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombres_turno { get; set; }
        public string Apellido_Paterno_turno { get; set; }
        public string Apellido_Materno_turno { get; set; }
        public int? Sexo_turno { get; set; }
        public string Sexo_turnoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Edad_turno { get; set; }
        public int? Tipo_de_Atencion_turno { get; set; }
        public string Tipo_de_Atencion_turnoDescripcion { get; set; }
        public int? Tipo_de_Identificacion_turno { get; set; }
        public string Tipo_de_Identificacion_turnoNombre { get; set; }
        public string Numero_de_Identificacion_turno { get; set; }
        public bool? Urgencia_turno { get; set; }
        public int? Tipo_de_Urgencia_turno { get; set; }
        public string Tipo_de_Urgencia_turnoDescripcion { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Motivo_Finalizacion_TurnoDescripcion { get; set; }
        public string Observaciones_turno { get; set; }

    }

	public class Modulo_Atencion_Inicial_Servicios_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public bool? Autoriza_Traductor { get; set; }
        public bool? Finalizar_Servicios_de_Apoyo { get; set; }

    }

	public class Modulo_Atencion_Inicial_CanalizarModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Estatus2 { get; set; }
        public string Estatus2Descripcion { get; set; }
        public int? Unidad_canaliza { get; set; }
        public string Unidad_canalizaDescripcion { get; set; }
        public bool? Enviar_a_MP { get; set; }
        public bool? Correccion_de_Estatus { get; set; }

    }

	public class Modulo_Atencion_Inicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Requiere_Servicios_de_Apoyo { get; set; }
        public bool? Persona_Moral { get; set; }

    }

	public class Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPOModel
    {
        [Required]
        public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public int? Orientador { get; set; }
        public string OrientadorName { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_del_Hecho { get; set; }
        public int? Pais_de_los_Hechos { get; set; }
        public string Pais_de_los_HechosNombre { get; set; }
        public int? Estado_de_los_Hechos { get; set; }
        public string Estado_de_los_HechosNombre { get; set; }
        public int? Municipio_de_los_Hechos { get; set; }
        public string Municipio_de_los_HechosNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia_de_los_Hechos { get; set; }
        public string Colonia_de_los_HechosNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_de_los_Hechos { get; set; }
        public string Calle_de_los_Hechos { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exrterior_de_los_Hechos { get; set; }
        public string Numero_Interior_de_los_Hechos { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public int? Zona_de_los_Hechos { get; set; }
        public string Zona_de_los_HechosDescripcion { get; set; }
        public string Turno { get; set; }

    }

	public class Modulo_Atencion_Inicial_Datos_del_AcuerdoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public string Fecha_de_Inicio_de_Acuerdo { get; set; }
        public string Fecha_de_Cumplimiento_del_Acuerdo { get; set; }
        public string Hora_de_Cumplimiento_del_Acuerdo { get; set; }
        public string Domicilio_para_el_Cumplimiento { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        [Range(0, 9999999999)]
        public int? Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public string PeriodicidadDescripcion { get; set; }
        public bool? Se_Acepta_Acuerdo { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

    }

	public class Modulo_Atencion_Inicial_Bitacora_de_CoincidenciasModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Modulo_Atencion_Inicial_CierreModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Cerrar { get; set; }
        public string Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }

    }

	public class Modulo_Atencion_Inicial_Historial_de_movimientosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Modulo_Atencion_Inicial_Campos_OcultosModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string Fecha_de_Vencimiento_1 { get; set; }
        public string EspecialistaJA { get; set; }
        public string Campo_Oculto1 { get; set; }
        public int? JefeMPO { get; set; }
        public string JefeMPOMinisterio_Publico_en_Turno { get; set; }
        public string Campo_Oculto2 { get; set; }
        public string Campo_Oculto3 { get; set; }
        public int? CoordinadorJA { get; set; }
        public string CoordinadorJAName { get; set; }
        public int? EspJA { get; set; }
        public string EspJAName { get; set; }
        public string Ano_Actual { get; set; }
        [Range(0, 9999999999)]
        public int? Secuencial { get; set; }

    }


}

