using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DocumentoAdvanceSearchModel
    {
        public DocumentoAdvanceSearchModel()
        {
            Requerido = RadioOptions.NoApply;
            Solicitante = RadioOptions.NoApply;
            Solicitar_Archivo_Adjunto = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters DiligenciaFilter { set; get; }
        public string AdvanceDiligencia { set; get; }
        public int[] AdvanceDiligenciaMultiple { set; get; }

        public Filters OrigenFilter { set; get; }
        public string AdvanceOrigen { set; get; }
        public int[] AdvanceOrigenMultiple { set; get; }

        public Filters Tipo_de_DocumentoFilter { set; get; }
        public string AdvanceTipo_de_Documento { set; get; }
        public int[] AdvanceTipo_de_DocumentoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromidFormato { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromidFormato", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToidFormato { set; get; }

        public RadioOptions Requerido { set; get; }

        public RadioOptions Solicitante { set; get; }

        public RadioOptions Solicitar_Archivo_Adjunto { set; get; }


    }
}
