using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Relaciones_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Expediente { get; set; }
        public string Numero_de_Procedimiento { get; set; }
        public int? idRelacionOrigen { get; set; }
        public string idRelacionOrigenDescripcion { get; set; }
        public bool Requiere_cambiar_la_relacion { get; set; }
        public string Motivo_de_Cambio { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }
        public string Fecha_de_Resolucion_solicitud { get; set; }
        public string Hora_de_Resolucion_solicitud { get; set; }
        public int? Usuario_que_Resuelve_solicitud { get; set; }
        public string Usuario_que_Resuelve_solicitudName { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public string Tipo_de_MecanismoDescripcion { get; set; }
        public string Observaciones_solicitud { get; set; }
        public string Fecha_de_Validacion_solicitud { get; set; }
        public string Hora_de_Validacion_solicitud { get; set; }
        public int? Usuario_que_Valida_solicitud { get; set; }
        public string Usuario_que_Valida_solicitudName { get; set; }
        public short? resultado_solicitud { get; set; }
        public string resultado_solicitudDescripcion { get; set; }
        public string motivo_rechazo_solicitud { get; set; }
        public string Fecha_de_Resolucion_proc { get; set; }
        public string hora_resolucion_proc { get; set; }
        public int? usuario_resuelve_proc { get; set; }
        public string usuario_resuelve_procName { get; set; }
        public int? Resolucion_proc { get; set; }
        public string Resolucion_procDescripcion { get; set; }
        public string Observaciones_proc { get; set; }
        public string Fecha_de_Validacion_proc { get; set; }
        public string Hora_de_Validacion_proc { get; set; }
        public int? Usuario_que_Valida_proc { get; set; }
        public string Usuario_que_Valida_procName { get; set; }
        public short? Resultado_proc { get; set; }
        public string Resultado_procDescripcion { get; set; }
        public string Motivo_de_Rechazo_proc { get; set; }

    }
	
	public class Relaciones_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Expediente { get; set; }
        public string Numero_de_Procedimiento { get; set; }
        public int? idRelacionOrigen { get; set; }
        public string idRelacionOrigenDescripcion { get; set; }
        public bool? Requiere_cambiar_la_relacion { get; set; }
        public string Motivo_de_Cambio { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }

    }

	public class Relaciones_MASC_Resolucion_de_SolicitudModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Resolucion_solicitud { get; set; }
        public string Hora_de_Resolucion_solicitud { get; set; }
        public int? Usuario_que_Resuelve_solicitud { get; set; }
        public string Usuario_que_Resuelve_solicitudName { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public string Tipo_de_MecanismoDescripcion { get; set; }
        public string Observaciones_solicitud { get; set; }
        public string Fecha_de_Validacion_solicitud { get; set; }
        public string Hora_de_Validacion_solicitud { get; set; }
        public int? Usuario_que_Valida_solicitud { get; set; }
        public string Usuario_que_Valida_solicitudName { get; set; }
        public short? resultado_solicitud { get; set; }
        public string resultado_solicitudDescripcion { get; set; }
        public string motivo_rechazo_solicitud { get; set; }

    }

	public class Relaciones_MASC_Resolucion_de_ProcedimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Resolucion_proc { get; set; }
        public string hora_resolucion_proc { get; set; }
        public int? usuario_resuelve_proc { get; set; }
        public string usuario_resuelve_procName { get; set; }
        public int? Resolucion_proc { get; set; }
        public string Resolucion_procDescripcion { get; set; }
        public string Observaciones_proc { get; set; }
        public string Fecha_de_Validacion_proc { get; set; }
        public string Hora_de_Validacion_proc { get; set; }
        public int? Usuario_que_Valida_proc { get; set; }
        public string Usuario_que_Valida_procName { get; set; }
        public short? Resultado_proc { get; set; }
        public string Resultado_procDescripcion { get; set; }
        public string Motivo_de_Rechazo_proc { get; set; }

    }


}

