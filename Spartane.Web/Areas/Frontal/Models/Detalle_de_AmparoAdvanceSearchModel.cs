using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_AmparoAdvanceSearchModel
    {
        public Detalle_de_AmparoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Orden_de_AprehensionFilter { set; get; }
        public string AdvanceOrden_de_Aprehension { set; get; }
        public int[] AdvanceOrden_de_AprehensionMultiple { set; get; }

        public Filters Tipo_de_AmparoFilter { set; get; }
        public string AdvanceTipo_de_Amparo { set; get; }
        public int[] AdvanceTipo_de_AmparoMultiple { set; get; }

        public Filters Numero_de_AmparoFilter { set; get; }
        public string Numero_de_Amparo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Amparo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Amparo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Amparo { set; get; }

        public Filters Entidad_que_Emitio_AmparoFilter { set; get; }
        public string AdvanceEntidad_que_Emitio_Amparo { set; get; }
        public int[] AdvanceEntidad_que_Emitio_AmparoMultiple { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string AdvanceResolucion { set; get; }
        public int[] AdvanceResolucionMultiple { set; get; }


    }
}
