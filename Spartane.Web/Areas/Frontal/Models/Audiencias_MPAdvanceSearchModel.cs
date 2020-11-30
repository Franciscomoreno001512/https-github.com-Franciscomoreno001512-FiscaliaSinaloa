using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Audiencias_MPAdvanceSearchModel
    {
        public Audiencias_MPAdvanceSearchModel()
        {
            Asignar_MP_Litigacion = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters Tipo_de_AudienciaFilter { set; get; }
        public string AdvanceTipo_de_Audiencia { set; get; }
        public int[] AdvanceTipo_de_AudienciaMultiple { set; get; }

        public Filters AudienciaFilter { set; get; }
        public string AdvanceAudiencia { set; get; }
        public int[] AdvanceAudienciaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha { set; get; }

        public string ToHora { set; get; }
        public string FromHora { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters Resultado_de_AudienciaFilter { set; get; }
        public string AdvanceResultado_de_Audiencia { set; get; }
        public int[] AdvanceResultado_de_AudienciaMultiple { set; get; }

        public RadioOptions Asignar_MP_Litigacion { set; get; }

        public Filters MP_LitigacionFilter { set; get; }
        public string AdvanceMP_Litigacion { set; get; }
        public int[] AdvanceMP_LitigacionMultiple { set; get; }


    }
}
