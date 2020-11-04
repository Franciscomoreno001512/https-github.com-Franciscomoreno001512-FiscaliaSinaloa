using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Reporte_PrincipalModel
    {
        [Required]
        public int Clave { get; set; }
        public string Expediente { get; set; }
        [Range(0, 9999999999)]
        public int? Total_de_Expedientes { get; set; }
        public string Fecha_de_Registro { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Caso { get; set; }
        [Range(0, 9999999999)]
        public int? Creciente { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }

    }
	
	public class Reporte_Principal_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Expediente { get; set; }
        [Range(0, 9999999999)]
        public int? Total_de_Expedientes { get; set; }
        public string Fecha_de_Registro { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Caso { get; set; }
        [Range(0, 9999999999)]
        public int? Creciente { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }

    }


}

