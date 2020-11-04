using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Circunstancia_DefuncionGridModel
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_Defuncion { get; set; }
        public string Tipo_DefuncionDescripcion { get; set; }
        
    }
}

