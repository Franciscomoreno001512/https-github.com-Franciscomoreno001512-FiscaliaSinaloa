using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_Cargador_CartuchosModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? cartuchos_municiones { get; set; }
        public string Cartuchos_Habiles { get; set; }
        [Range(0, 9999999999)]
        public int? Cartuchos_Percutidos { get; set; }
        [Range(0, 9999999999)]
        public int? cargadores { get; set; }

    }
	
	public class Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? cartuchos_municiones { get; set; }
        public string Cartuchos_Habiles { get; set; }
        [Range(0, 9999999999)]
        public int? Cartuchos_Percutidos { get; set; }
        [Range(0, 9999999999)]
        public int? cargadores { get; set; }

    }


}

