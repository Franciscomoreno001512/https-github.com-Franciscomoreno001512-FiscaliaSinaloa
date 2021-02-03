using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_Solicitud_Denuncia_CiudadanaGridModel
    {
        public int Folio { get; set; }
        public string Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Denuncia_Ultimo_Generado { get; set; }
        
    }
}

