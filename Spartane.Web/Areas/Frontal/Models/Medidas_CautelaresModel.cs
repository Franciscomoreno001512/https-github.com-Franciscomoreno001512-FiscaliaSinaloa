using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Medidas_CautelaresModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Fraccion { get; set; }
        public bool Aplica_para_Adolescentes { get; set; }
        public bool Aplica_para_Adultos { get; set; }
        public string Tipo { get; set; }

    }
	
	public class Medidas_Cautelares_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Fraccion { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Adultos { get; set; }
        public string Tipo { get; set; }

    }


}

