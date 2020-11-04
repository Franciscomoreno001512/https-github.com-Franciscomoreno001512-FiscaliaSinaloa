using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Delito_Principal_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string Delito { get; set; }

    }
	
	public class Delito_Principal_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Delito { get; set; }

    }


}

