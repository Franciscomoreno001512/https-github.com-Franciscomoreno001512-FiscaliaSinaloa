using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Plan_Actos_de_InvestigacionModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Servicio_a_Solicitar { get; set; }
        public string Servicio_a_SolicitarServicio { get; set; }
        public string Hecho_Delictivo_Acreditado { get; set; }
        [Range(0, 9999999999)]
        public short? Tiempo_Estandar { get; set; }
        [Range(0, 9999999999)]
        public short? Ponderacion { get; set; }
        public string Fecha_Contestacion { get; set; }
        public string Hora_Contestacion { get; set; }
        public string Contestacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }
        public int? Usuario_que_Contesta { get; set; }
        public string Usuario_que_ContestaName { get; set; }

    }
	
	public class Detalle_Plan_Actos_de_Investigacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Servicio_a_Solicitar { get; set; }
        public string Servicio_a_SolicitarServicio { get; set; }
        public string Hecho_Delictivo_Acreditado { get; set; }
        [Range(0, 9999999999)]
        public short? Tiempo_Estandar { get; set; }
        [Range(0, 9999999999)]
        public short? Ponderacion { get; set; }
        public string Fecha_Contestacion { get; set; }
        public string Hora_Contestacion { get; set; }
        public string Contestacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }
        public int? Usuario_que_Contesta { get; set; }
        public string Usuario_que_ContestaName { get; set; }

    }


}

