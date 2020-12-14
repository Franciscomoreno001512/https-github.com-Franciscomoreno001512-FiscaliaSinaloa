using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Medidas_de_ProteccionAdvanceSearchModel
    {
        public Medidas_de_ProteccionAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Expediente_ATFilter { set; get; }
        public string AdvanceExpediente_AT { set; get; }
        public int[] AdvanceExpediente_ATMultiple { set; get; }

        public Filters Expediente_MASCFilter { set; get; }
        public string AdvanceExpediente_MASC { set; get; }
        public int[] AdvanceExpediente_MASCMultiple { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Orden_de_ProteccionFilter { set; get; }
        public string Orden_de_Proteccion { set; get; }

        public Filters Tipo_de_MedidaFilter { set; get; }
        public string AdvanceTipo_de_Medida { set; get; }
        public int[] AdvanceTipo_de_MedidaMultiple { set; get; }

        public Filters Sub_TipoFilter { set; get; }
        public string AdvanceSub_Tipo { set; get; }
        public int[] AdvanceSub_TipoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Inicio { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Inicio", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Inicio { set; get; }

        public string ToHora_de_Inicio { set; get; }
        public string FromHora_de_Inicio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Conclusion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Conclusion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Conclusion { set; get; }

        public string ToHora_de_Conclusion { set; get; }
        public string FromHora_de_Conclusion { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromDuracion_en_Dias { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromDuracion_en_Dias", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToDuracion_en_Dias { set; get; }

        public Filters Aplicar_aFilter { set; get; }
        public string AdvanceAplicar_a { set; get; }
        public int[] AdvanceAplicar_aMultiple { set; get; }


    }
}
