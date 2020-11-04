using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ModuloModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Numero_de_Modulo { get; set; }
        public string Descripcion { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public string Unidad_de_AtencionDescripcion { get; set; }
        public int? Orientador { get; set; }
        public string OrientadorName { get; set; }

    }
	
	public class Modulo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Numero_de_Modulo { get; set; }
        public string Descripcion { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public string Unidad_de_AtencionDescripcion { get; set; }
        public int? Orientador { get; set; }
        public string OrientadorName { get; set; }

    }


}

