using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_responsable_servicios_apoyoAdvanceSearchModel
    {
        public Asignacion_responsable_servicios_apoyoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters UsuarioFilter { set; get; }
        public string AdvanceUsuario { set; get; }
        public int[] AdvanceUsuarioMultiple { set; get; }

        public Filters Area_AsignadaFilter { set; get; }
        public string AdvanceArea_Asignada { set; get; }
        public int[] AdvanceArea_AsignadaMultiple { set; get; }


    }
}
