using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_Folios_por_EspecialidadModel
    {
        [Required]
        public int Folio { get; set; }
        [Range(0, 9999999999)]
        public short? Ano { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }

    }
	
	public class Control_de_Folios_por_Especialidad_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        [Range(0, 9999999999)]
        public short? Ano { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }

    }


}

