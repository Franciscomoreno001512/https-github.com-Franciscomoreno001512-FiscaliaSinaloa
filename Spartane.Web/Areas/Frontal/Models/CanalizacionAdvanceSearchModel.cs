using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class CanalizacionAdvanceSearchModel
    {
        public CanalizacionAdvanceSearchModel()
        {
            Hubo_modificacion_en_la_relacion = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters Expediente_ATFilter { set; get; }
        public string AdvanceExpediente_AT { set; get; }
        public int[] AdvanceExpediente_ATMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Canalizacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Canalizacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Canalizacion { set; get; }

        public string ToHora_de_Canalizacion { set; get; }
        public string FromHora_de_Canalizacion { set; get; }

        public Filters Usuario_que_CanalizaFilter { set; get; }
        public string AdvanceUsuario_que_Canaliza { set; get; }
        public int[] AdvanceUsuario_que_CanalizaMultiple { set; get; }

        public Filters Relacion_a_CanalizarFilter { set; get; }
        public string AdvanceRelacion_a_Canalizar { set; get; }
        public int[] AdvanceRelacion_a_CanalizarMultiple { set; get; }

        public Filters Canalizar_aFilter { set; get; }
        public string AdvanceCanalizar_a { set; get; }
        public int[] AdvanceCanalizar_aMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters UnidadFilter { set; get; }
        public string AdvanceUnidad { set; get; }
        public int[] AdvanceUnidadMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Resolucion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Resolucion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Resolucion { set; get; }

        public string ToHora_de_Resolucion { set; get; }
        public string FromHora_de_Resolucion { set; get; }

        public RadioOptions Hubo_modificacion_en_la_relacion { set; get; }

        public Filters Nueva_RelacionFilter { set; get; }
        public string Nueva_Relacion { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromResolucionId { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromResolucionId", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToResolucionId { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string Resolucion { set; get; }

        public Filters Detalle_de_la_ResolucionFilter { set; get; }
        public string Detalle_de_la_Resolucion { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }


    }
}
