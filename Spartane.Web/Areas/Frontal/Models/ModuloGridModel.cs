using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ModuloGridModel
    {
        public int Clave { get; set; }
        public short? Numero_de_Modulo { get; set; }
        public string Descripcion { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public string Unidad_de_AtencionDescripcion { get; set; }
        public int? Orientador { get; set; }
        public string OrientadorName { get; set; }
        
    }
}

