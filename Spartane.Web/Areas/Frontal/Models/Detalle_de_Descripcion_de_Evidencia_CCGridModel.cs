using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Descripcion_de_Evidencia_CCGridModel
    {
        public int Clave { get; set; }
        public int? Numero_de_Evidencia { get; set; }
        public string Descripcion_de_la_Evidencia { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public int? Examen_Solicitado { get; set; }
        public string Codigo_de_Barras { get; set; }
        public string Archivo_de_Foto { get; set; }
        
    }
}

