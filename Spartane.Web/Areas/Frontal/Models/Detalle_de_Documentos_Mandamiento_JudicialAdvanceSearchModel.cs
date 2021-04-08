using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_Mandamiento_JudicialAdvanceSearchModel
    {
        public Detalle_de_Documentos_Mandamiento_JudicialAdvanceSearchModel()
        {
            Documentos = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Registro_de_Orden_de_AprehensionFilter { set; get; }
        public string AdvanceRegistro_de_Orden_de_Aprehension { set; get; }
        public int[] AdvanceRegistro_de_Orden_de_AprehensionMultiple { set; get; }

        public RadioOptions Documentos { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }


    }
}
