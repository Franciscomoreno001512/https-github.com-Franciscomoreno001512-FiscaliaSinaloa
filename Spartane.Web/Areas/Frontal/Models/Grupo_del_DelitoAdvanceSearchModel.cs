using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Grupo_del_DelitoAdvanceSearchModel
    {
        public Grupo_del_DelitoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters Tipo_de_DelitoFilter { set; get; }
        public string AdvanceTipo_de_Delito { set; get; }
        public int[] AdvanceTipo_de_DelitoMultiple { set; get; }

        public Filters Titulo_del_DelitoFilter { set; get; }
        public string AdvanceTitulo_del_Delito { set; get; }
        public int[] AdvanceTitulo_del_DelitoMultiple { set; get; }


    }
}
