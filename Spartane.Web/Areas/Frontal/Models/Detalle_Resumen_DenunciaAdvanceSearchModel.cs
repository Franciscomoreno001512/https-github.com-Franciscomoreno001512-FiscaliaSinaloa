using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Resumen_DenunciaAdvanceSearchModel
    {
        public Detalle_Resumen_DenunciaAdvanceSearchModel()
        {
            Generado = RadioOptions.NoApply;
            Archivo_Descargado = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Modulo_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_Atencion_InicialMultiple { set; get; }

        public Filters Probable_ResponsableFilter { set; get; }
        public string Probable_Responsable { set; get; }

        public Filters DelitoFilter { set; get; }
        public string Delito { set; get; }

        public Filters VictimaFilter { set; get; }
        public string Victima { set; get; }

        public Filters RelacionFilter { set; get; }
        public string Relacion { set; get; }

        public Filters HechosFilter { set; get; }
        public string Hechos { set; get; }

        public RadioOptions Generado { set; get; }

        public RadioOptions Archivo_Descargado { set; get; }

        public Filters Usuario_que_registraFilter { set; get; }
        public string AdvanceUsuario_que_registra { set; get; }
        public int[] AdvanceUsuario_que_registraMultiple { set; get; }

        public Filters DocumentoFilter { set; get; }
        public string AdvanceDocumento { set; get; }
        public int[] AdvanceDocumentoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromArchivo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromArchivo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToArchivo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_registro { set; get; }

        public string ToHora_de_registro { set; get; }
        public string FromHora_de_registro { set; get; }


    }
}
