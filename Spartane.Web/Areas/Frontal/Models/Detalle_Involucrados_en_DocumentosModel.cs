using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Involucrados_en_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }
        public string IdDocumentos { get; set; }
        public int? Involucrado { get; set; }
        public string InvolucradoNombre_Completo_del_Tutor { get; set; }

    }
	
	public class Detalle_Involucrados_en_Documentos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string IdDocumentos { get; set; }
        public int? Involucrado { get; set; }
        public string InvolucradoNombre_Completo_del_Tutor { get; set; }

    }


}

