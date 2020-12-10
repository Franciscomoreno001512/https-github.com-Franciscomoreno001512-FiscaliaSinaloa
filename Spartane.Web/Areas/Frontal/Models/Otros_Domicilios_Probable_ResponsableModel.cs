using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Otros_Domicilios_Probable_ResponsableModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Coordenada_X { get; set; }
        public string Coordenada_Y { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Otros_Domicilios_Probable_Responsable_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Coordenada_X { get; set; }
        public string Coordenada_Y { get; set; }
        public string Observaciones { get; set; }

    }


}

