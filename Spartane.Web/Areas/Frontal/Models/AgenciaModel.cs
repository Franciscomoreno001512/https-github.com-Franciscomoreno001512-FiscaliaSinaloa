using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AgenciaModel
    {
        public string Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        [Required]
        public int ClaveID { get; set; }

    }
	
	public class Agencia_Datos_GeneralesModel
    {
        public string Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        [Required]
        public int ClaveID { get; set; }

    }


}

