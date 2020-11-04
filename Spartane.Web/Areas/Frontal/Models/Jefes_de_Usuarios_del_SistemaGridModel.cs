using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Jefes_de_Usuarios_del_SistemaGridModel
    {
        public int Clave { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public string Ministerio_Publico_en_Turno { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

