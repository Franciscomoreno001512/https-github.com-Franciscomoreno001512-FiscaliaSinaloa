using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Medidas_CautelaresAdvanceSearchModel
    {
        public Medidas_CautelaresAdvanceSearchModel()
        {
            Aplica_para_Adolescentes = RadioOptions.NoApply;
            Aplica_para_Adultos = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters FraccionFilter { set; get; }
        public string Fraccion { set; get; }

        public RadioOptions Aplica_para_Adolescentes { set; get; }

        public RadioOptions Aplica_para_Adultos { set; get; }

        public Filters TipoFilter { set; get; }
        public string Tipo { set; get; }


    }
}
