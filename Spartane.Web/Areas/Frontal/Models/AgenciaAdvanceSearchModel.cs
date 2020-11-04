using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AgenciaAdvanceSearchModel
    {
        public AgenciaAdvanceSearchModel()
        {
            Activa = RadioOptions.NoApply;

        }
        public Filters ClaveFilter { set; get; }
        public string Clave { set; get; }

        public Filters Clave_de_MunicipioFilter { set; get; }
        public string Clave_de_Municipio { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public RadioOptions Activa { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClaveID { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClaveID", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClaveID { set; get; }


    }
}
