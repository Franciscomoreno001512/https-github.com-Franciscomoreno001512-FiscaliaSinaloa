using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Bitacora_de_Canalizacion_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public short? Estatus_Interno { get; set; }
        public string Estatus_InternoDescripcion { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }
        public string Estatus_de_CanalizacionDescripcion { get; set; }

    }
	
	public class Detalle_Bitacora_de_Canalizacion_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public short? Estatus_Interno { get; set; }
        public string Estatus_InternoDescripcion { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }
        public string Estatus_de_CanalizacionDescripcion { get; set; }

    }


}

