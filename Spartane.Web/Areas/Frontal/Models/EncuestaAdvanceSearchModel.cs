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

        public Filters Pregunta_6Filter { set; get; }
        public string Pregunta_6 { set; get; }

        public Filters Pregunta_7Filter { set; get; }
        public string Pregunta_7 { set; get; }

        public Filters Pregunta_8Filter { set; get; }
        public string Pregunta_8 { set; get; }

        public Filters Pregunta_9Filter { set; get; }
        public string Pregunta_9 { set; get; }

        public Filters Pregunta_10Filter { set; get; }
        public string Pregunta_10 { set; get; }


    }
}
