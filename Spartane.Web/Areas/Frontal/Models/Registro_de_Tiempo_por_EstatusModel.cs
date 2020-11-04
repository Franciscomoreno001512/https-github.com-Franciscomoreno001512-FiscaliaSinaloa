using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Tiempo_por_EstatusModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? NUAT { get; set; }
        public string NUATNUAT { get; set; }
        public int? Estatus_Interno { get; set; }
        public string Estatus_InternoDescripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

    }
	
	public class Registro_de_Tiempo_por_Estatus_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? NUAT { get; set; }
        public string NUATNUAT { get; set; }
        public int? Estatus_Interno { get; set; }
        public string Estatus_InternoDescripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

    }


}

