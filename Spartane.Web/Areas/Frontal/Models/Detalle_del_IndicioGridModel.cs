using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_del_IndicioGridModel
    {
        public int Clave { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_del_Indicio { get; set; }
        public string Descripcion_del_Indicio { get; set; }
        public string Motivo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Ubicacion_de_Indicio { get; set; }
        
    }
}

