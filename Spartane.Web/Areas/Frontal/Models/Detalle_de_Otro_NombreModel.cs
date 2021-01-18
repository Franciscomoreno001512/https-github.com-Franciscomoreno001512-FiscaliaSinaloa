using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Otro_NombreModel
    {
        [Required]
        public int Clave { get; set; }
        public string Otro_Nombre_del_Individuo { get; set; }
        public string Otro_Apellido_Paterno_del_Individuo { get; set; }
        public string Otro_Apellido_Materno_del_Individuo { get; set; }
        public string Otro_Alias_del_Individuo { get; set; }

    }
	
	public class Detalle_de_Otro_Nombre_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Otro_Nombre_del_Individuo { get; set; }
        public string Otro_Apellido_Paterno_del_Individuo { get; set; }
        public string Otro_Apellido_Materno_del_Individuo { get; set; }
        public string Otro_Alias_del_Individuo { get; set; }

    }


}

