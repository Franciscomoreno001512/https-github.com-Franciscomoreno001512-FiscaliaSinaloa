using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_AbogadoModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string Nombre_del_Representado { get; set; }
        public string Tipo_de_Representante { get; set; }
        public string Comentarios { get; set; }

    }
	
	public class Detalle_de_Abogado_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string Nombre_del_Representado { get; set; }
        public string Tipo_de_Representante { get; set; }
        public string Comentarios { get; set; }

    }


}

