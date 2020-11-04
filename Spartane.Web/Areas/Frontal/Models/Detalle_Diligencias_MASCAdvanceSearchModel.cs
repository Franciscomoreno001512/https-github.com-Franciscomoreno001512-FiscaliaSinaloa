using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Diligencias_MASCAdvanceSearchModel
    {
        public Detalle_Diligencias_MASCAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha { set; get; }

        public string ToHora { set; get; }
        public string FromHora { set; get; }

        public Filters FacilitadorFilter { set; get; }
        public string AdvanceFacilitador { set; get; }
        public int[] AdvanceFacilitadorMultiple { set; get; }

        public Filters Tipo_de_DiligenciaFilter { set; get; }
        public string AdvanceTipo_de_Diligencia { set; get; }
        public int[] AdvanceTipo_de_DiligenciaMultiple { set; get; }

        public Filters DiligenciaFilter { set; get; }
        public string AdvanceDiligencia { set; get; }
        public int[] AdvanceDiligenciaMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }


    }
}
