using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Historial_Estatus_Modulo_Servicio_PericialGridModel
    {
        public int Clave { get; set; }
        public int? Estatus_Servicio_Pericial { get; set; }
        public string Estatus_Servicio_PericialDescripcion { get; set; }
        public string Fecha_Registro { get; set; }
        public bool? Activo { get; set; }
        public string Fecha_Cierre { get; set; }
        public int? Modulo_Servicio_Pericial { get; set; }
        public string Modulo_Servicio_PericialDescripcion { get; set; }
        
    }
}

