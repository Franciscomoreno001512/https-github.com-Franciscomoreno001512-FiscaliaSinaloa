using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ColoniaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }
        [Range(0, 9999999999)]
        public int? cod_pais { get; set; }
        [Range(0, 9999999999)]
        public int? cod_edo { get; set; }
        [Range(0, 9999999999)]
        public int? loc_justicia { get; set; }
        [Range(0, 9999999999)]
        public int? pob_justicia { get; set; }
        [Range(0, 9999999999)]
        public int? sector { get; set; }
        public string estatus { get; set; }
        [Range(0, 9999999999)]
        public int? cod_localidad { get; set; }

    }
	
	public class Colonia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }
        [Range(0, 9999999999)]
        public int? cod_pais { get; set; }
        [Range(0, 9999999999)]
        public int? cod_edo { get; set; }
        [Range(0, 9999999999)]
        public int? loc_justicia { get; set; }
        [Range(0, 9999999999)]
        public int? pob_justicia { get; set; }
        [Range(0, 9999999999)]
        public int? sector { get; set; }
        public string estatus { get; set; }
        [Range(0, 9999999999)]
        public int? cod_localidad { get; set; }

    }


}

