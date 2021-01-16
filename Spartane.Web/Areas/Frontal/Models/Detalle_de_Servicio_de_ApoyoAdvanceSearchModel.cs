using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Servicio_de_ApoyoAdvanceSearchModel
    {
        public Detalle_de_Servicio_de_ApoyoAdvanceSearchModel()
        {
            Requiere_Traductor = RadioOptions.NoApply;
            Imagen = RadioOptions.NoApply;
            Contestacion_lista_para_enviarse = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters OrigenFilter { set; get; }
        public string AdvanceOrigen { set; get; }
        public int[] AdvanceOrigenMultiple { set; get; }

        public Filters Modulo_de_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_de_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_de_Atencion_InicialMultiple { set; get; }

        public Filters Modulo_Mecanismos_AlternosFilter { set; get; }
        public string AdvanceModulo_Mecanismos_Alternos { set; get; }
        public int[] AdvanceModulo_Mecanismos_AlternosMultiple { set; get; }

        public Filters Modulo_Ministerio_PublicoFilter { set; get; }
        public string AdvanceModulo_Ministerio_Publico { set; get; }
        public int[] AdvanceModulo_Ministerio_PublicoMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public RadioOptions Requiere_Traductor { set; get; }

        public Filters Lengua_OriginariaFilter { set; get; }
        public string AdvanceLengua_Originaria { set; get; }
        public int[] AdvanceLengua_OriginariaMultiple { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters ResponsableFilter { set; get; }
        public string Responsable { set; get; }

        public Filters ComparecienteFilter { set; get; }
        public string AdvanceCompareciente { set; get; }
        public int[] AdvanceComparecienteMultiple { set; get; }

        public Filters DiligenciaFilter { set; get; }
        public string AdvanceDiligencia { set; get; }
        public int[] AdvanceDiligenciaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromArchivo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromArchivo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToArchivo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Solicitud { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Solicitud", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Solicitud { set; get; }

        public Filters Numero_OficioFilter { set; get; }
        public string Numero_Oficio { set; get; }

        public RadioOptions Imagen { set; get; }

        public Filters Nombre_SolicitanteFilter { set; get; }
        public string Nombre_Solicitante { set; get; }

        public Filters Rango_SolicitanteFilter { set; get; }
        public string Rango_Solicitante { set; get; }

        public Filters AutoridadesFilter { set; get; }
        public string AdvanceAutoridades { set; get; }
        public int[] AdvanceAutoridadesMultiple { set; get; }

        public Filters AgenciaFilter { set; get; }
        public string AdvanceAgencia { set; get; }
        public int[] AdvanceAgenciaMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters DictamenFilter { set; get; }
        public string AdvanceDictamen { set; get; }
        public int[] AdvanceDictamenMultiple { set; get; }

        public RadioOptions Contestacion_lista_para_enviarse { set; get; }

        public Filters Area_PericialFilter { set; get; }
        public string AdvanceArea_Pericial { set; get; }
        public int[] AdvanceArea_PericialMultiple { set; get; }

        public Filters PeritoFilter { set; get; }
        public string AdvancePerito { set; get; }
        public int[] AdvancePeritoMultiple { set; get; }


    }
}
