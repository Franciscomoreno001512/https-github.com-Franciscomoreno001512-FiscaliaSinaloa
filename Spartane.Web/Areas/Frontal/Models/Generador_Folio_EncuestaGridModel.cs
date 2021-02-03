using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_Folio_EncuestaGridModel
    {
        public int Folio { get; set; }
        public string Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Modulo_Encuesta { get; set; }
        public string Modulo_EncuestaDescripcion { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Encuesta_Ultimo_Generado { get; set; }
        
    }
}

