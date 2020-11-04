using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Coincidencias_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public string NUC { get; set; }
        public string Rol { get; set; }

    }
	
	public class Detalle_de_Coincidencias_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string NUAT { get; set; }
        public string NUC { get; set; }
        public string Rol { get; set; }

    }


}

