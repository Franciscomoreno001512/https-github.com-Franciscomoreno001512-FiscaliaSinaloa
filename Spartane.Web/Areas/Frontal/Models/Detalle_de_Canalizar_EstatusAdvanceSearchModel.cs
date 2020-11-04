using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Canalizar_EstatusAdvanceSearchModel
    {
        public Detalle_de_Canalizar_EstatusAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Modulo_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_Atencion_InicialMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cambio_de_Estatus { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cambio_de_Estatus", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cambio_de_Estatus { set; get; }

        public string ToHora_de_Cambio_de_Estatus { set; get; }
        public string FromHora_de_Cambio_de_Estatus { set; get; }

        public Filters Estatus_InternoFilter { set; get; }
        public string AdvanceEstatus_Interno { set; get; }
        public int[] AdvanceEstatus_InternoMultiple { set; get; }

        public Filters Estatus_de_CanalizacionFilter { set; get; }
        public string AdvanceEstatus_de_Canalizacion { set; get; }
        public int[] AdvanceEstatus_de_CanalizacionMultiple { set; get; }


    }
}
