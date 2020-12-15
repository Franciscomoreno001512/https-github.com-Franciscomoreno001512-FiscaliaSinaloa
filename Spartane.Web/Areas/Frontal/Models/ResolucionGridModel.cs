using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ResolucionGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public string Resolucion_Padre_para_AutorizacionDescripcion { get; set; }
        public bool? Generar_Judicializacion { get; set; }
        
    }
}

