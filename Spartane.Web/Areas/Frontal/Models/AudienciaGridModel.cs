using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AudienciaGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Audiencia { get; set; }
        public string Tipo_de_AudienciaDescripcion { get; set; }
        
    }
}

