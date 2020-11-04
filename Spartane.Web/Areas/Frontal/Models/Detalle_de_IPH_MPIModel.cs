using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_IPH_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUE { get; set; }
        public string Folio { get; set; }
        public string Fecha { get; set; }
        public string Documentos { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public string Hora { get; set; }

    }
	
	public class Detalle_de_IPH_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUE { get; set; }
        public string Folio { get; set; }
        public string Fecha { get; set; }
        public string Documentos { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public string Hora { get; set; }

    }


}

