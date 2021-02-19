using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ErmeOficioModel
    {
        [Required]
        public int Clave { get; set; }
        public string Oficio { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaClave { get; set; }

    }
	
	public class ErmeOficio_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Oficio { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaClave { get; set; }

    }


}

