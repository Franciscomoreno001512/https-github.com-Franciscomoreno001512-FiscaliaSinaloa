using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Medidas_CautelaresGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Fraccion { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Adultos { get; set; }
        public string Tipo { get; set; }
        
    }
}

