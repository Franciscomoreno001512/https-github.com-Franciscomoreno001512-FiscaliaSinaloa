using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Circunstancia_DefuncionModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_Defuncion { get; set; }
        public string Tipo_DefuncionDescripcion { get; set; }

    }
	
	public class Circunstancia_Defuncion_Datos_GeneralesModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_Defuncion { get; set; }
        public string Tipo_DefuncionDescripcion { get; set; }

    }


}

