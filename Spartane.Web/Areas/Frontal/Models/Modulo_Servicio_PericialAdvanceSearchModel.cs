using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_Servicio_PericialAdvanceSearchModel
    {
        public Modulo_Servicio_PericialAdvanceSearchModel()
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

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters Servicio_PericialFilter { set; get; }
        public string AdvanceServicio_Pericial { set; get; }
        public int[] AdvanceServicio_PericialMultiple { set; get; }

        public Filters Usuario_AsignadoFilter { set; get; }
        public string AdvanceUsuario_Asignado { set; get; }
        public int[] AdvanceUsuario_AsignadoMultiple { set; get; }

        public Filters Modulo_Mecanismos_AlternosFilter { set; get; }
        public string AdvanceModulo_Mecanismos_Alternos { set; get; }
        public int[] AdvanceModulo_Mecanismos_AlternosMultiple { set; get; }

        public Filters Modulo_Ministerio_PublicoFilter { set; get; }
        public string AdvanceModulo_Ministerio_Publico { set; get; }
        public int[] AdvanceModulo_Ministerio_PublicoMultiple { set; get; }

        public Filters OrigenFilter { set; get; }
        public string AdvanceOrigen { set; get; }
        public int[] AdvanceOrigenMultiple { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }


    }
}
