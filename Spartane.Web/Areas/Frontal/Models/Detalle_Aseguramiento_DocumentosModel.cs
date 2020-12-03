using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

    }
	
	public class Detalle_Aseguramiento_Documentos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

    }


}

