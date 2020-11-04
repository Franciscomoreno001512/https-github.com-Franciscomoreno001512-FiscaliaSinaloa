using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class UnidadAdvanceSearchModel
    {
        public UnidadAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave_Unica_Municipio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave_Unica_Municipio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave_Unica_Municipio { set; get; }

        public Filters Clave_de_MunicipioFilter { set; get; }
        public string AdvanceClave_de_Municipio { set; get; }
        public int[] AdvanceClave_de_MunicipioMultiple { set; get; }

        public Filters Clave_de_RegionFilter { set; get; }
        public string AdvanceClave_de_Region { set; get; }
        public int[] AdvanceClave_de_RegionMultiple { set; get; }

        public Filters AbreviacionFilter { set; get; }
        public string Abreviacion { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters Descripcion_CortaFilter { set; get; }
        public string Descripcion_Corta { set; get; }

        public Filters VigenciaFilter { set; get; }
        public string AdvanceVigencia { set; get; }
        public int[] AdvanceVigenciaMultiple { set; get; }

        public Filters DireccionFilter { set; get; }
        public string Direccion { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters SupervisorFilter { set; get; }
        public string AdvanceSupervisor { set; get; }
        public int[] AdvanceSupervisorMultiple { set; get; }


    }
}
