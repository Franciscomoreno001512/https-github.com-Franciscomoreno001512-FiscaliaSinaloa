using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class EncuestaAdvanceSearchModel
    {
        public EncuestaAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters ModuloFilter { set; get; }
        public string AdvanceModulo { set; get; }
        public int[] AdvanceModuloMultiple { set; get; }

        public Filters Tipo_EncuestaFilter { set; get; }
        public string AdvanceTipo_Encuesta { set; get; }
        public int[] AdvanceTipo_EncuestaMultiple { set; get; }

        public Filters Numero_de_PreguntasFilter { set; get; }
        public string AdvanceNumero_de_Preguntas { set; get; }
        public int[] AdvanceNumero_de_PreguntasMultiple { set; get; }

        public Filters Pregunta_1Filter { set; get; }
        public string Pregunta_1 { set; get; }

        public Filters Pregunta_2Filter { set; get; }
        public string Pregunta_2 { set; get; }

        public Filters Pregunta_3Filter { set; get; }
        public string Pregunta_3 { set; get; }

        public Filters Pregunta_4Filter { set; get; }
        public string Pregunta_4 { set; get; }

        public Filters Pregunta_5Filter { set; get; }
        public string Pregunta_5 { set; get; }


    }
}
