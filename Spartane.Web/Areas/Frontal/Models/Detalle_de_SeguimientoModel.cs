using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_SeguimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Especialista { get; set; }
        public string Solicitante { get; set; }
        public string Requerido { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public string Observaciones { get; set; }
        public string Cumplimiento { get; set; }
        public int? Tipo_de_Seguimiento { get; set; }
        public string Tipo_de_SeguimientoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad_del_Monto { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }

    }
	
	public class Detalle_de_Seguimiento_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Especialista { get; set; }
        public string Solicitante { get; set; }
        public string Requerido { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public string Observaciones { get; set; }
        public string Cumplimiento { get; set; }
        public int? Tipo_de_Seguimiento { get; set; }
        public string Tipo_de_SeguimientoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad_del_Monto { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }

    }


}

