using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Uso_del_medio_de_transporteModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Uso_del_medio_de_transporte_Datos_GeneralesModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

