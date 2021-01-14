using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_Solicitud_Denuncia_CiudadanaModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_Genera { get; set; }
        [Range(0, 9999999999)]
        public short? Anio_Genera { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }
        public string Folio_Denuncia_Ultimo_Generado { get; set; }

    }
	
	public class Generador_Solicitud_Denuncia_Ciudadana_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_Genera { get; set; }
        [Range(0, 9999999999)]
        public short? Anio_Genera { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }
        public string Folio_Denuncia_Ultimo_Generado { get; set; }

    }


}

