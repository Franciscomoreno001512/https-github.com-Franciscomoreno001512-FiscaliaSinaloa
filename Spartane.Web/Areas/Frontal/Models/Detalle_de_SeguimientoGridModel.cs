using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_SeguimientoGridModel
    {
        public int Clave { get; set; }
        public string Especialista { get; set; }
        public string Solicitante { get; set; }
        public string Requerido { get; set; }
        public short? Archivo { get; set; }
        public string Observaciones { get; set; }
        public string Cumplimiento { get; set; }
        public int? Tipo_de_Seguimiento { get; set; }
        public string Tipo_de_SeguimientoDescripcion { get; set; }
        public decimal? Cantidad_del_Monto { get; set; }
        public string Fecha_de_Cumplimiento { get; set; }
        
    }
}

