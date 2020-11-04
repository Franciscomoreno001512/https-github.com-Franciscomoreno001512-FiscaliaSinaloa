using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Indicios_para_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Indicio { get; set; }

    }
	
	public class Indicios_para_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Indicio { get; set; }

    }


}

