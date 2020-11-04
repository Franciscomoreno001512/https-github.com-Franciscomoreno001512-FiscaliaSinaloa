using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ParentescoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Complemento { get; set; }
        public string Tipo_de_Relacion { get; set; }
        public string Relacion_con_Involucrado { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Parentesco_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Complemento { get; set; }
        public string Tipo_de_Relacion { get; set; }
        public string Relacion_con_Involucrado { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }

    }


}

