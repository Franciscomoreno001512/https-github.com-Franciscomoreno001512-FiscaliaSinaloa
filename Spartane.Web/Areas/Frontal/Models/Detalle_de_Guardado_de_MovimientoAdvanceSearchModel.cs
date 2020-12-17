using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Guardado_de_MovimientoAdvanceSearchModel
    {
        public Detalle_de_Guardado_de_MovimientoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Registro_de_MovimientoFilter { set; get; }
        public string AdvanceRegistro_de_Movimiento { set; get; }
        public int[] AdvanceRegistro_de_MovimientoMultiple { set; get; }

        public Filters CampoFilter { set; get; }
        public string AdvanceCampo { set; get; }
        public int[] AdvanceCampoMultiple { set; get; }

        public Filters EtiquetaFilter { set; get; }
        public string Etiqueta { set; get; }

        public Filters ValorFilter { set; get; }
        public string Valor { set; get; }


    }
}
