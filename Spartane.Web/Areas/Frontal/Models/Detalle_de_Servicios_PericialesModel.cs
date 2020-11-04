using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Servicios_PericialesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        [Range(0, 9999999999)]
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Estatus_del_DictamenDescripcion { get; set; }
        public string Observaciones { get; set; }
        public string Fecha_del_Dictamen { get; set; }
        [Range(0, 9999999999)]
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }
        public string ObservacionesD { get; set; }

    }
	
	public class Detalle_de_Servicios_Periciales_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        [Range(0, 9999999999)]
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Estatus_del_DictamenDescripcion { get; set; }
        public string Observaciones { get; set; }
        public string Fecha_del_Dictamen { get; set; }
        [Range(0, 9999999999)]
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }
        public string ObservacionesD { get; set; }

    }


}

