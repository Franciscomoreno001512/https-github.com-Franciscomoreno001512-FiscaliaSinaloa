using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Delito_Mandamiento_JudicialModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public short? Modalidad { get; set; }
        public string ModalidadDescripcion { get; set; }

    }
	
	public class Detalle_de_Delito_Mandamiento_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public short? Modalidad { get; set; }
        public string ModalidadDescripcion { get; set; }

    }


}

