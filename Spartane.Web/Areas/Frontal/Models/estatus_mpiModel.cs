using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class estatus_mpiModel
    {
        [Required]
        public short clave { get; set; }
        public string descripcion { get; set; }

    }
	
	public class estatus_mpi_Datos_GeneralesModel
    {
        [Required]
        public short clave { get; set; }
        public string descripcion { get; set; }

    }


}

