using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Adicciones_Probable_ResponsableModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }

    }
	
	public class Adicciones_Probable_Responsable_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }

    }


}

