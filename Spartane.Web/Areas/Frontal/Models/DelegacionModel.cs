using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DelegacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Clave_Expediente { get; set; }
        public string Direccion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo_MPO { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo_MPI { get; set; }
        public int? Distrito { get; set; }
        public string DistritoDescripcion { get; set; }
        public string Abreviacion_Delegacion { get; set; }

    }
	
	public class Delegacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Clave_Expediente { get; set; }
        public string Direccion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo_MPO { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo_MPI { get; set; }
        public int? Distrito { get; set; }
        public string DistritoDescripcion { get; set; }
        public string Abreviacion_Delegacion { get; set; }

    }


}

