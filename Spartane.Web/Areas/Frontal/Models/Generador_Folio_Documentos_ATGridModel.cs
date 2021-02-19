using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_Folio_Documentos_ATGridModel
    {
        public int Folio { get; set; }
        public string Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }
        
    }
}

