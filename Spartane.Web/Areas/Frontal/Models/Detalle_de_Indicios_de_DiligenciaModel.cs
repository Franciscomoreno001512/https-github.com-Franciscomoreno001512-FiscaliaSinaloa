using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Indicios_de_DiligenciaModel
    {
        [Required]
        public int Folio { get; set; }
        public string Indicio { get; set; }
        public bool Seleccionar { get; set; }
        [Range(0, 9999999999)]
        public int? IndicioId { get; set; }

    }
	
	public class Detalle_de_Indicios_de_Diligencia_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Indicio { get; set; }
        public bool? Seleccionar { get; set; }
        [Range(0, 9999999999)]
        public int? IndicioId { get; set; }

    }


}

