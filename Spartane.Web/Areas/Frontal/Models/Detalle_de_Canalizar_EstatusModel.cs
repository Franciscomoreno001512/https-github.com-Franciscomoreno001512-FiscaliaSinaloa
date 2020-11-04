using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Canalizar_EstatusModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public int? Estatus_Interno { get; set; }
        public string Estatus_InternoDescripcion { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }
        public string Estatus_de_CanalizacionDescripcion { get; set; }

    }
	
	public class Detalle_de_Canalizar_Estatus_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public int? Estatus_Interno { get; set; }
        public string Estatus_InternoDescripcion { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }
        public string Estatus_de_CanalizacionDescripcion { get; set; }

    }


}

