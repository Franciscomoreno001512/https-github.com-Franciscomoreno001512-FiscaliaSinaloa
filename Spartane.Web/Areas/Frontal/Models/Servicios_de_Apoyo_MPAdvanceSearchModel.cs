using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_de_Apoyo_MPAdvanceSearchModel
    {
        public Servicios_de_Apoyo_MPAdvanceSearchModel()
        {
            Archivo = RadioOptions.NoApply;
            Archivo_Adjunto = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

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

        public Filters CategoriaFilter { set; get; }
        public string AdvanceCategoria { set; get; }
        public int[] AdvanceCategoriaMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string Solicitud { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Termino_para_Entrega { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Termino_para_Entrega", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Termino_para_Entrega { set; get; }

        public string ToHora_de_Termino_para_Entrega { set; get; }
        public string FromHora_de_Termino_para_Entrega { set; get; }

        public Filters Diligencia_a_EnviarFilter { set; get; }
        public string AdvanceDiligencia_a_Enviar { set; get; }
        public int[] AdvanceDiligencia_a_EnviarMultiple { set; get; }

        public RadioOptions Archivo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Atencion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Atencion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Atencion { set; get; }

        public string ToHora_de_Atencion { set; get; }
        public string FromHora_de_Atencion { set; get; }

        public Filters Usuario_que_AtiendeFilter { set; get; }
        public string AdvanceUsuario_que_Atiende { set; get; }
        public int[] AdvanceUsuario_que_AtiendeMultiple { set; get; }

        public RadioOptions Archivo_Adjunto { set; get; }


    }
}
