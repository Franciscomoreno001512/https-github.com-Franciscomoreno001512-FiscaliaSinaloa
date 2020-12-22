using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_MASCAdvanceSearchModel
    {
        public Resolucion_MASCAdvanceSearchModel()
        {
            Rechazo = RadioOptions.NoApply;
            Resolucion_para_Solicitud = RadioOptions.NoApply;
            Resolucion_para_Procedimiento = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public RadioOptions Rechazo { set; get; }

        public RadioOptions Resolucion_para_Solicitud { set; get; }

        public RadioOptions Resolucion_para_Procedimiento { set; get; }

        public Filters ClaveFiscaliaFilter { set; get; }
        public string ClaveFiscalia { set; get; }


    }
}
