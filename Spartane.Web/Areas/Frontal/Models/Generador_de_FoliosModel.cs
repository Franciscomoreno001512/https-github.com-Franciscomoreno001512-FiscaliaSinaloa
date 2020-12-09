using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_de_FoliosModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Generador_de_Folio { get; set; }
        [Range(0, 9999999999)]
        public short? Anio_de_Generador_de_Folio { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }

    }
	
	public class Generador_de_Folios_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Generador_de_Folio { get; set; }
        [Range(0, 9999999999)]
        public short? Anio_de_Generador_de_Folio { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public string Tipo_de_DenunciaDescripcion { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }

    }


}

