using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_SeguimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre { get; set; }
        public string Fecha_Requerida { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad_del_Monto { get; set; }
        public int? Especialista { get; set; }
        public string EspecialistaName { get; set; }
        public string Comentarios { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }
	
	public class Detalle_de_Solicitud_Seguimiento_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre { get; set; }
        public string Fecha_Requerida { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad_del_Monto { get; set; }
        public int? Especialista { get; set; }
        public string EspecialistaName { get; set; }
        public string Comentarios { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }


}

