using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel
    {
        public Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel()
        {
            Acreditada = RadioOptions.NoApply;
            Centralizada = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters AreaFilter { set; get; }
        public string AdvanceArea { set; get; }
        public int[] AdvanceAreaMultiple { set; get; }

        public Filters SubAreaFilter { set; get; }
        public string AdvanceSubArea { set; get; }
        public int[] AdvanceSubAreaMultiple { set; get; }

        public RadioOptions Acreditada { set; get; }

        public RadioOptions Centralizada { set; get; }


    }
}
