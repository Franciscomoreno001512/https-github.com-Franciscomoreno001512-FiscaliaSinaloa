using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Encuesta1AdvanceSearchModel
    {
        public Encuesta1AdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters FolioFilter { set; get; }
        public string Folio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Enviado { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Enviado", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Enviado { set; get; }

        public string ToHora_Enviado { set; get; }
        public string FromHora_Enviado { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Respuesta { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Respuesta", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Respuesta { set; get; }

        public string ToHora_Respuesta { set; get; }
        public string FromHora_Respuesta { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        public Filters ModuloFilter { set; get; }
        public string AdvanceModulo { set; get; }
        public int[] AdvanceModuloMultiple { set; get; }

        public Filters Tipo_EncuestaFilter { set; get; }
        public string AdvanceTipo_Encuesta { set; get; }
        public int[] AdvanceTipo_EncuestaMultiple { set; get; }

        public Filters Numero_de_PreguntasFilter { set; get; }
        public string AdvanceNumero_de_Preguntas { set; get; }
        public int[] AdvanceNumero_de_PreguntasMultiple { set; get; }

        public Filters Pregunta1Filter { set; get; }
        public string Pregunta1 { set; get; }

        public Filters Respuesta_1Filter { set; get; }
        public string AdvanceRespuesta_1 { set; get; }
        public int[] AdvanceRespuesta_1Multiple { set; get; }

        public Filters Pregunta2Filter { set; get; }
        public string Pregunta2 { set; get; }

        public Filters Respuesta_2Filter { set; get; }
        public string AdvanceRespuesta_2 { set; get; }
        public int[] AdvanceRespuesta_2Multiple { set; get; }

        public Filters Pregunta3Filter { set; get; }
        public string Pregunta3 { set; get; }

        public Filters Respuesta_3Filter { set; get; }
        public string AdvanceRespuesta_3 { set; get; }
        public int[] AdvanceRespuesta_3Multiple { set; get; }

        public Filters Pregunta4Filter { set; get; }
        public string Pregunta4 { set; get; }

        public Filters Respuesta_4Filter { set; get; }
        public string AdvanceRespuesta_4 { set; get; }
        public int[] AdvanceRespuesta_4Multiple { set; get; }

        public Filters Pregunta5Filter { set; get; }
        public string Pregunta5 { set; get; }

        public Filters Respuesta_5Filter { set; get; }
        public string AdvanceRespuesta_5 { set; get; }
        public int[] AdvanceRespuesta_5Multiple { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }


    }
}
