using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Dilgencia_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Diligencia { get; set; }
        public string Tipo_de_DiligenciaDescripcion { get; set; }

    }
	
	public class Dilgencia_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Diligencia { get; set; }
        public string Tipo_de_DiligenciaDescripcion { get; set; }

    }


}

