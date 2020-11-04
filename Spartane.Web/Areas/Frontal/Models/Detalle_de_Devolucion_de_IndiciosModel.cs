using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Devolucion_de_IndiciosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        public string Nombre_de_Persona_que_Entrega { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Numero_de_IndicioDescripcion { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Devolucion_de_Indicio { get; set; }
        public int? Diligencia_que_Devuelve { get; set; }
        public string Diligencia_que_DevuelveServicio { get; set; }

    }
	
	public class Detalle_de_Devolucion_de_Indicios_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        public string Nombre_de_Persona_que_Entrega { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Numero_de_IndicioDescripcion { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Devolucion_de_Indicio { get; set; }
        public int? Diligencia_que_Devuelve { get; set; }
        public string Diligencia_que_DevuelveServicio { get; set; }

    }


}

