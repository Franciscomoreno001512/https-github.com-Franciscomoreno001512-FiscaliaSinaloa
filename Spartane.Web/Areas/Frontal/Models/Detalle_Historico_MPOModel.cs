using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Historico_MPOModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario { get; set; }
        public string Estatus { get; set; }

    }
	
	public class Detalle_Historico_MPO_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario { get; set; }
        public string Estatus { get; set; }

    }


}

