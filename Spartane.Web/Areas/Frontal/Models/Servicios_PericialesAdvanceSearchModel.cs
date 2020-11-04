using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_PericialesAdvanceSearchModel
    {
        public Servicios_PericialesAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters ServicioFilter { set; get; }
        public string Servicio { set; get; }

        public Filters Rol_de_Donde_ProvieneFilter { set; get; }
        public string AdvanceRol_de_Donde_Proviene { set; get; }
        public int[] AdvanceRol_de_Donde_ProvieneMultiple { set; get; }


    }
}
