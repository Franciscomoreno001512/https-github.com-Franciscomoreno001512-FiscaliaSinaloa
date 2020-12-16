using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configurador_de_MovimientosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Fase { get; set; }
        public string FaseDescripcion { get; set; }
        public bool Aplica_para_Adolescentes { get; set; }

    }
	
	public class Configurador_de_Movimientos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Fase { get; set; }
        public string FaseDescripcion { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }

    }


}

