using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class SolicitudModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Numero_de_Folio { get; set; }
        public int? Unidad_MASC { get; set; }
        public string Unidad_MASCDescripcion { get; set; }
        public string Remitente { get; set; }
        public int? NUAT { get; set; }
        public string NUATNUAT { get; set; }
        public string NUAT_Codigo { get; set; }
        public int? Expediente_MPI { get; set; }
        public string Expediente_MPInic { get; set; }
        public int? Expediente_CausaPenal { get; set; }
        public string Expediente_CausaPenalObservaciones { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public string NUC { get; set; }
        public string CDI { get; set; }
        public string Causa_Penal { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Fecha_en_que_llega_a_Coordinador { get; set; }
        public string Fecha_en_que_llega_a_Especialista { get; set; }
        public int? Agente_del_Ministerio_Publico_Orientador { get; set; }
        public string Agente_del_Ministerio_Publico_OrientadorName { get; set; }
        public int? Agente_del_Ministerio_Publico_Invest { get; set; }
        public string Agente_del_Ministerio_Publico_InvestName { get; set; }
        public string Juez_de_Control { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public int? PaisH { get; set; }
        public string PaisHNombre { get; set; }
        public int? EstadoH { get; set; }
        public string EstadoHNombre { get; set; }
        public int? MunicipioH { get; set; }
        public string MunicipioHNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? ColoniaH { get; set; }
        public string ColoniaHNombre { get; set; }
        public string CalleH { get; set; }
        public string Numero_InteriorH { get; set; }
        public string Numero_ExteriorH { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }
        public int? Especialista_AsignadoA { get; set; }
        public string Especialista_AsignadoAName { get; set; }
        public string Motivo_cambio_facilitador { get; set; }
        public bool Asignar_Especialista_Automatico { get; set; }
        public string Razone { get; set; }
        public string Fecha_de_AsignacionA { get; set; }
        public string Hora_de_AsignacionA { get; set; }
        public string Fecha_de_Atencion_del_Especialista { get; set; }
        public string Hora_de_Atencion_del_Especialista { get; set; }
        public bool Rechazar { get; set; }
        public int? Motivo_de_Rechazo { get; set; }
        public string Motivo_de_RechazoDescripcion { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public string Acuerdo_CumplidoDescripcion { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Razon_de_IncumplimientoDescripcion { get; set; }
        public int? Tipo_de_Conclusion_Anticipada { get; set; }
        public string Tipo_de_Conclusion_AnticipadaDescripcion { get; set; }
        public string Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }
        public int? Usuario_que_Resuelve_Solicitud { get; set; }
        public string Usuario_que_Resuelve_SolicitudName { get; set; }
        public int? Resolucion_Solicitud { get; set; }
        public string Resolucion_SolicitudDescripcion { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public string Tipo_de_MecanismoDescripcion { get; set; }
        public string Observaciones_Solicitud { get; set; }
        public string Fecha_Validacion { get; set; }
        public string Hora_Validacion { get; set; }
        public int? Usuario_que_Valida { get; set; }
        public string Usuario_que_ValidaName { get; set; }
        public short? Autoriza_Cierre_de_Expediente { get; set; }
        public string Autoriza_Cierre_de_ExpedienteDescripcion { get; set; }
        public string Motivo_de_Rechazo_Solicitud { get; set; }
        public string Fecha_de_Resolucion_Procedimiento { get; set; }
        public string Hora_de_Resolucion_Procedimiento { get; set; }
        public int? Resolucion_de_Procedimiento { get; set; }
        public string Resolucion_de_ProcedimientoDescripcion { get; set; }
        public int? Usuario_que_Resuelve_Procedimiento { get; set; }
        public string Usuario_que_Resuelve_ProcedimientoName { get; set; }
        public string Observaciones_Procedimiento { get; set; }
        public string Fecha_de_Validacion_Procedimiento { get; set; }
        public string Hora_de_Validacion_Procedimiento { get; set; }
        public int? Usuario_que_Valida_Procedimiento { get; set; }
        public string Usuario_que_Valida_ProcedimientoName { get; set; }
        public short? Resultado_Procedimiento { get; set; }
        public string Resultado_ProcedimientoDescripcion { get; set; }
        public string Motivo_de_Rechazo_Procedimiento { get; set; }

    }
	
	public class Solicitud_SolicitudModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Numero_de_Folio { get; set; }
        public int? Unidad_MASC { get; set; }
        public string Unidad_MASCDescripcion { get; set; }
        public string Remitente { get; set; }
        public int? NUAT { get; set; }
        public string NUATNUAT { get; set; }
        public string NUAT_Codigo { get; set; }
        public int? Expediente_MPI { get; set; }
        public string Expediente_MPInic { get; set; }
        public int? Expediente_CausaPenal { get; set; }
        public string Expediente_CausaPenalObservaciones { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public string NUC { get; set; }
        public string CDI { get; set; }
        public string Causa_Penal { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Fecha_en_que_llega_a_Coordinador { get; set; }
        public string Fecha_en_que_llega_a_Especialista { get; set; }

    }

	public class Solicitud_ControlModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Agente_del_Ministerio_Publico_Orientador { get; set; }
        public string Agente_del_Ministerio_Publico_OrientadorName { get; set; }
        public int? Agente_del_Ministerio_Publico_Invest { get; set; }
        public string Agente_del_Ministerio_Publico_InvestName { get; set; }
        public string Juez_de_Control { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }

    }

	public class Solicitud_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public int? PaisH { get; set; }
        public string PaisHNombre { get; set; }
        public int? EstadoH { get; set; }
        public string EstadoHNombre { get; set; }
        public int? MunicipioH { get; set; }
        public string MunicipioHNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? ColoniaH { get; set; }
        public string ColoniaHNombre { get; set; }
        public string CalleH { get; set; }
        public string Numero_InteriorH { get; set; }
        public string Numero_ExteriorH { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalH { get; set; }
        public string Entre_Calle { get; set; }
        public string y_Calle { get; set; }
        public string LongitudH { get; set; }
        public string LatitudH { get; set; }

    }

	public class Solicitud_AsignacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Especialista_AsignadoA { get; set; }
        public string Especialista_AsignadoAName { get; set; }
        public string Motivo_cambio_facilitador { get; set; }
        public bool? Asignar_Especialista_Automatico { get; set; }
        public string Razone { get; set; }
        public string Fecha_de_AsignacionA { get; set; }
        public string Hora_de_AsignacionA { get; set; }
        public string Fecha_de_Atencion_del_Especialista { get; set; }
        public string Hora_de_Atencion_del_Especialista { get; set; }

    }

	public class Solicitud_Resolucion_de_SolicitudModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Rechazar { get; set; }
        public int? Motivo_de_Rechazo { get; set; }
        public string Motivo_de_RechazoDescripcion { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public string Acuerdo_CumplidoDescripcion { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Razon_de_IncumplimientoDescripcion { get; set; }
        public int? Tipo_de_Conclusion_Anticipada { get; set; }
        public string Tipo_de_Conclusion_AnticipadaDescripcion { get; set; }
        public string Fecha_de_Cierre { get; set; }
        public string Hora_de_Cierre { get; set; }
        public int? Usuario_que_Resuelve_Solicitud { get; set; }
        public string Usuario_que_Resuelve_SolicitudName { get; set; }
        public int? Resolucion_Solicitud { get; set; }
        public string Resolucion_SolicitudDescripcion { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public string Tipo_de_MecanismoDescripcion { get; set; }
        public string Observaciones_Solicitud { get; set; }
        public string Fecha_Validacion { get; set; }
        public string Hora_Validacion { get; set; }
        public int? Usuario_que_Valida { get; set; }
        public string Usuario_que_ValidaName { get; set; }
        public short? Autoriza_Cierre_de_Expediente { get; set; }
        public string Autoriza_Cierre_de_ExpedienteDescripcion { get; set; }
        public string Motivo_de_Rechazo_Solicitud { get; set; }

    }

	public class Solicitud_Resolucion_de_ProcedimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Resolucion_Procedimiento { get; set; }
        public string Hora_de_Resolucion_Procedimiento { get; set; }
        public int? Resolucion_de_Procedimiento { get; set; }
        public string Resolucion_de_ProcedimientoDescripcion { get; set; }
        public int? Usuario_que_Resuelve_Procedimiento { get; set; }
        public string Usuario_que_Resuelve_ProcedimientoName { get; set; }
        public string Observaciones_Procedimiento { get; set; }
        public string Fecha_de_Validacion_Procedimiento { get; set; }
        public string Hora_de_Validacion_Procedimiento { get; set; }
        public int? Usuario_que_Valida_Procedimiento { get; set; }
        public string Usuario_que_Valida_ProcedimientoName { get; set; }
        public short? Resultado_Procedimiento { get; set; }
        public string Resultado_ProcedimientoDescripcion { get; set; }
        public string Motivo_de_Rechazo_Procedimiento { get; set; }

    }

	public class Solicitud_Bitacora_de_CoincidenciasModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Solicitud_Historial_de_MovimientosModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

