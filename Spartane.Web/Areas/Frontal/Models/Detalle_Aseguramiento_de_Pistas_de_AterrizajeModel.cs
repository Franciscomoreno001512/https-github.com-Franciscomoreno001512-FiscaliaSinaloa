using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_Pistas_de_AterrizajeModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo { get; set; }
        public string Suelo { get; set; }
        public string Descripcion { get; set; }
        public string Localizacion_1 { get; set; }
        public string Localizacion_2 { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Orientacion_de { get; set; }
        public string Orientacion_deDescripcion { get; set; }
        public int? Orientacion { get; set; }
        public string OrientacionDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Largo { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Ancho { get; set; }

    }
	
	public class Detalle_Aseguramiento_de_Pistas_de_Aterrizaje_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo { get; set; }
        public string Suelo { get; set; }
        public string Descripcion { get; set; }
        public string Localizacion_1 { get; set; }
        public string Localizacion_2 { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Orientacion_de { get; set; }
        public string Orientacion_deDescripcion { get; set; }
        public int? Orientacion { get; set; }
        public string OrientacionDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Largo { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Ancho { get; set; }

    }


}

