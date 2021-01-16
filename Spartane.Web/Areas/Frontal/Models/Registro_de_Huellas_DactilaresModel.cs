using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Huellas_DactilaresModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public string Carpeta_de_Investigacionnic { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo { get; set; }
        public int? Mano_Izquierda_4_Dedos { get; set; }
        public HttpPostedFileBase Mano_Izquierda_4_DedosFile { set; get; }
        public int Mano_Izquierda_4_DedosRemoveAttachment { set; get; }
        public int? Mano_Derecha_4_Dedos { get; set; }
        public HttpPostedFileBase Mano_Derecha_4_DedosFile { set; get; }
        public int Mano_Derecha_4_DedosRemoveAttachment { set; get; }
        public int? Pulgares { get; set; }
        public HttpPostedFileBase PulgaresFile { set; get; }
        public int PulgaresRemoveAttachment { set; get; }
        [Range(0, 9999999999)]
        public int? Izquierda_Menique { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Anular { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Medio { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Indice { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Pulgar { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Menique { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Anular { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Medio { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Indice { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Pulgar { get; set; }

    }
	
	public class Registro_de_Huellas_Dactilares_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public string Carpeta_de_Investigacionnic { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo { get; set; }
        public int? Mano_Izquierda_4_Dedos { get; set; }
        public HttpPostedFileBase Mano_Izquierda_4_DedosFile { set; get; }
        public int Mano_Izquierda_4_DedosRemoveAttachment { set; get; }
        public int? Mano_Derecha_4_Dedos { get; set; }
        public HttpPostedFileBase Mano_Derecha_4_DedosFile { set; get; }
        public int Mano_Derecha_4_DedosRemoveAttachment { set; get; }
        public int? Pulgares { get; set; }
        public HttpPostedFileBase PulgaresFile { set; get; }
        public int PulgaresRemoveAttachment { set; get; }
        [Range(0, 9999999999)]
        public int? Izquierda_Menique { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Anular { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Medio { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Indice { get; set; }
        [Range(0, 9999999999)]
        public int? Izquierda_Pulgar { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Menique { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Anular { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Medio { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Indice { get; set; }
        [Range(0, 9999999999)]
        public int? Derecha_Pulgar { get; set; }

    }


}

