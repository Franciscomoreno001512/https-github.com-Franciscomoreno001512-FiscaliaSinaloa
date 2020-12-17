using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Resumen_DenunciaModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public string Probable_Responsable { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public string Hechos { get; set; }
        public bool Generado { get; set; }
        public bool Archivo_Descargado { get; set; }
        public string Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }

    }
	
	public class Detalle_Resumen_Denuncia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public string Probable_Responsable { get; set; }
        public string Delito { get; set; }
        public string Victima { get; set; }
        public string Relacion { get; set; }
        public string Hechos { get; set; }
        public bool? Generado { get; set; }
        public bool? Archivo_Descargado { get; set; }
        public string Fecha_de_registro { get; set; }
        public string Hora_de_registro { get; set; }

    }


}

