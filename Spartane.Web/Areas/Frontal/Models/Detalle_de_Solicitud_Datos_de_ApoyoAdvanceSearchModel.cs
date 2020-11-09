using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_Datos_de_ApoyoAdvanceSearchModel
    {
        public Detalle_de_Solicitud_Datos_de_ApoyoAdvanceSearchModel()
        {
            Archivo_Adjunto = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_registraFilter { set; get; }
        public string AdvanceUsuario_que_registra { set; get; }
        public int[] AdvanceUsuario_que_registraMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public Filters DictamenFilter { set; get; }
        public string Dictamen { set; get; }

        public Filters SolicitanteFilter { set; get; }
        public string AdvanceSolicitante { set; get; }
        public int[] AdvanceSolicitanteMultiple { set; get; }

        public Filters ResponsableFilter { set; get; }
        public string Responsable { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters Lengua_OriginariaFilter { set; get; }
        public string AdvanceLengua_Originaria { set; get; }
        public int[] AdvanceLengua_OriginariaMultiple { set; get; }

        public Filters Diligencia_a_EnviarFilter { set; get; }
        public string AdvanceDiligencia_a_Enviar { set; get; }
        public int[] AdvanceDiligencia_a_EnviarMultiple { set; get; }

        public RadioOptions Archivo_Adjunto { set; get; }


    }
}
