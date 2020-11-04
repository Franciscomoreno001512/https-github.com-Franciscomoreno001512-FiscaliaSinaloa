using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Distrito_JudicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Codigo { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }

    }
	
	public class Distrito_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Codigo { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }

    }


}

