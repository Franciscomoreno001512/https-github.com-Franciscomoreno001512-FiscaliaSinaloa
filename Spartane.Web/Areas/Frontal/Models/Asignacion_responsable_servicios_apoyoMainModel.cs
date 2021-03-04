using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_responsable_servicios_apoyoMainModel
    {
        public Asignacion_responsable_servicios_apoyoModel Asignacion_responsable_servicios_apoyoInfo { set; get; }
        public Detalle_subareas_responsable_servicio_apoyoGridModelPost Detalle_subareas_responsable_servicio_apoyoGridInfo { set; get; }

    }

    public class Detalle_subareas_responsable_servicio_apoyoGridModelPost
    {
        public int Clave { get; set; }
        public int? SubArea_Asignada { get; set; }

        public bool Removed { set; get; }
    }



}

