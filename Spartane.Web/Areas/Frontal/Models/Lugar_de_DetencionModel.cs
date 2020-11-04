using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Lugar_de_DetencionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public string Municipio_de_DetencionNombre { get; set; }
        public int? Corporacion { get; set; }
        public string CorporacionDescripcion { get; set; }
        public bool Suspension_Condicional { get; set; }
        public string Fecha_de_Suspension_Condicional { get; set; }

    }
	
	public class Lugar_de_Detencion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public string Municipio_de_DetencionNombre { get; set; }
        public int? Corporacion { get; set; }
        public string CorporacionDescripcion { get; set; }
        public bool? Suspension_Condicional { get; set; }
        public string Fecha_de_Suspension_Condicional { get; set; }

    }


}

