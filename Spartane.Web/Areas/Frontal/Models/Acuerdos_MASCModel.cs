using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Acuerdos_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public int? Forma_de_Cumplimiento { get; set; }
        public string Forma_de_CumplimientoDescripcion { get; set; }
        public string Descripcion_del_Cumplimiento { get; set; }
        public int? Relacion { get; set; }
        public string RelacionDescripcion { get; set; }
        public string Lugar_Acordado { get; set; }
        public string Domicilio_Acordado { get; set; }
        public string Hora_de_Acuerdo { get; set; }
        public string Fecha_de_Inicio_de_Acuerdo { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_Total { get; set; }
        [Range(0, 9999999999)]
        public short? Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public string PeriodicidadDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_la_Parcialidad { get; set; }
        public int? Personal_de_Seguimiento_Asignado { get; set; }
        public string Personal_de_Seguimiento_AsignadoName { get; set; }
        public int? Acuerdo { get; set; }
        public HttpPostedFileBase AcuerdoFile { set; get; }
        public int AcuerdoRemoveAttachment { set; get; }
        public string Comentarios { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public string Acuerdo_CumplidoDescripcion { get; set; }
        public string Fecha_de_Cumplimiento_de_Acuerdo { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Razon_de_IncumplimientoDescripcion { get; set; }
        public string Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public string Usuario_que_RevisaName { get; set; }
        public short? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

    }
	
	public class Acuerdos_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public int? Forma_de_Cumplimiento { get; set; }
        public string Forma_de_CumplimientoDescripcion { get; set; }
        public string Descripcion_del_Cumplimiento { get; set; }
        public int? Relacion { get; set; }
        public string RelacionDescripcion { get; set; }
        public string Lugar_Acordado { get; set; }
        public string Domicilio_Acordado { get; set; }
        public string Hora_de_Acuerdo { get; set; }
        public string Fecha_de_Inicio_de_Acuerdo { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_Total { get; set; }
        [Range(0, 9999999999)]
        public short? Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public string PeriodicidadDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_de_la_Parcialidad { get; set; }
        public int? Personal_de_Seguimiento_Asignado { get; set; }
        public string Personal_de_Seguimiento_AsignadoName { get; set; }
        public int? Acuerdo { get; set; }
        public HttpPostedFileBase AcuerdoFile { set; get; }
        public int AcuerdoRemoveAttachment { set; get; }
        public string Comentarios { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public string Acuerdo_CumplidoDescripcion { get; set; }
        public string Fecha_de_Cumplimiento_de_Acuerdo { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Razon_de_IncumplimientoDescripcion { get; set; }

    }

	public class Acuerdos_MASC_AutorizacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public string Usuario_que_RevisaName { get; set; }
        public short? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

    }


}

