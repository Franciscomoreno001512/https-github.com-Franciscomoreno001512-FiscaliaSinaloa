using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class PasaTurnosModel
    {
        [Required]
        public int Folio { get; set; }
        [Range(0, 9999999999)]
        public int? Turno { get; set; }
        [Range(0, 9999999999)]
        public int? Modulo { get; set; }
        public string Unidad { get; set; }

    }
	
	public class PasaTurnos_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        [Range(0, 9999999999)]
        public int? Turno { get; set; }
        [Range(0, 9999999999)]
        public int? Modulo { get; set; }
        public string Unidad { get; set; }

    }


}

