using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Recepcion_de_Pago_MASCAdvanceSearchModel
    {
        public Recepcion_de_Pago_MASCAdvanceSearchModel()
        {
            Pago_Completo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Recepcion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Recepcion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Recepcion { set; get; }

        public string ToHora_de_Recepcion { set; get; }
        public string FromHora_de_Recepcion { set; get; }

        public Filters Usuario_que_RecibeFilter { set; get; }
        public string AdvanceUsuario_que_Recibe { set; get; }
        public int[] AdvanceUsuario_que_RecibeMultiple { set; get; }

        public Filters Numero_de_ExpedienteFilter { set; get; }
        public string AdvanceNumero_de_Expediente { set; get; }
        public int[] AdvanceNumero_de_ExpedienteMultiple { set; get; }

        public Filters RequeridoFilter { set; get; }
        public string AdvanceRequerido { set; get; }
        public int[] AdvanceRequeridoMultiple { set; get; }

        public Filters Nombre_de_la_Persona_que_entregaFilter { set; get; }
        public string Nombre_de_la_Persona_que_entrega { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_de_Pago { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_de_Pago", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_de_Pago { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_del_Pago { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_del_Pago", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_del_Pago { set; get; }

        public RadioOptions Pago_Completo { set; get; }

        public Filters Motivo_para_no_entregar_pago_completoFilter { set; get; }
        public string Motivo_para_no_entregar_pago_completo { set; get; }


    }
}
