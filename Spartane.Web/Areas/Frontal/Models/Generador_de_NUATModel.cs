using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_de_NUATModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Generador_de_NUAT { get; set; }
        [Range(0, 9999999999)]
        public short? Anio_de_Generador_de_NUAT { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }
        public string NUAT_Ultimo_Generado { get; set; }

    }
	
	public class Generador_de_NUAT_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Generador_de_NUAT { get; set; }
        [Range(0, 9999999999)]
        public short? Anio_de_Generador_de_NUAT { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }
        public string NUAT_Ultimo_Generado { get; set; }

    }


}

