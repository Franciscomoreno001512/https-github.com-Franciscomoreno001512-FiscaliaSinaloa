using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_Folios_de_Mandamiento_JudicialModel
    {
        [Required]
        public int Consecutivo { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }
        [Range(0, 9999999999)]
        public short? Ano { get; set; }

    }
	
	public class Control_de_Folios_de_Mandamiento_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Consecutivo { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }
        [Range(0, 9999999999)]
        public short? Ano { get; set; }

    }


}

