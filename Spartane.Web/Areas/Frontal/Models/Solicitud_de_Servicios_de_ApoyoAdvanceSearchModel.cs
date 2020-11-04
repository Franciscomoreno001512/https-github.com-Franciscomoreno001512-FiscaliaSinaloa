using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel
    {
        public Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Folio_del_CasoFilter { set; get; }
        public string AdvanceFolio_del_Caso { set; get; }
        public int[] AdvanceFolio_del_CasoMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public Filters DictamenFilter { set; get; }
        public string Dictamen { set; get; }

        public Filters ResponsableFilter { set; get; }
        public string Responsable { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave_MR { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave_MR", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave_MR { set; get; }

        public Filters ComparecienteFilter { set; get; }
        public string AdvanceCompareciente { set; get; }
        public int[] AdvanceComparecienteMultiple { set; get; }


    }
}
