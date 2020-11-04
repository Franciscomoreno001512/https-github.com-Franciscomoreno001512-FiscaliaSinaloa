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

        public Filters Numero_de_PreguntasFilter { set; get; }
        public string AdvanceNumero_de_Preguntas { set; get; }
        public int[] AdvanceNumero_de_PreguntasMultiple { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        public Filters Pregunta1Filter { set; get; }
        public string AdvancePregunta1 { set; get; }
        public int[] AdvancePregunta1Multiple { set; get; }

        public Filters Pregunta2Filter { set; get; }
        public string AdvancePregunta2 { set; get; }
        public int[] AdvancePregunta2Multiple { set; get; }

        public Filters Pregunta3Filter { set; get; }
        public string AdvancePregunta3 { set; get; }
        public int[] AdvancePregunta3Multiple { set; get; }

        public Filters Pregunta4Filter { set; get; }
        public string AdvancePregunta4 { set; get; }
        public int[] AdvancePregunta4Multiple { set; get; }

        public Filters Pregunta5Filter { set; get; }
        public string AdvancePregunta5 { set; get; }
        public int[] AdvancePregunta5Multiple { set; get; }

        public Filters Pregunta6Filter { set; get; }
        public string AdvancePregunta6 { set; get; }
        public int[] AdvancePregunta6Multiple { set; get; }

        public Filters Pregunta7Filter { set; get; }
        public string AdvancePregunta7 { set; get; }
        public int[] AdvancePregunta7Multiple { set; get; }

        public Filters Pregunta8Filter { set; get; }
        public string AdvancePregunta8 { set; get; }
        public int[] AdvancePregunta8Multiple { set; get; }

        public Filters Pregunta9Filter { set; get; }
        public string AdvancePregunta9 { set; get; }
        public int[] AdvancePregunta9Multiple { set; get; }

        public Filters Pregunta10Filter { set; get; }
        public string AdvancePregunta10 { set; get; }
        public int[] AdvancePregunta10Multiple { set; get; }


    }
}
