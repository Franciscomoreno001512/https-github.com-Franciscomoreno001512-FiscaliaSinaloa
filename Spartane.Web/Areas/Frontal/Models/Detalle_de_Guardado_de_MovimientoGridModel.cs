using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Guardado_de_MovimientoGridModel
    {
        public int Clave { get; set; }
        public int? Registro_de_Movimiento { get; set; }
        public string Registro_de_MovimientoInformacion { get; set; }
        public int? Campo { get; set; }
        public string CampoDato { get; set; }
        public string Etiqueta { get; set; }
        public string Valor { get; set; }
        
    }
}

