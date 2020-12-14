using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Datos_de_los_Hechos_ATAdvanceSearchModel
    {
        public Datos_de_los_Hechos_ATAdvanceSearchModel()
        {
            Documento_Extraviado = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Modulo_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_Atencion_InicialMultiple { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters Expediente_MASCFilter { set; get; }
        public string AdvanceExpediente_MASC { set; get; }
        public int[] AdvanceExpediente_MASCMultiple { set; get; }

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        public Filters Prioridad_del_HechoFilter { set; get; }
        public string AdvancePrioridad_del_Hecho { set; get; }
        public int[] AdvancePrioridad_del_HechoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public Filters PaisFilter { set; get; }
        public string AdvancePais { set; get; }
        public int[] AdvancePaisMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Y_CalleFilter { set; get; }
        public string Y_Calle { set; get; }

        public Filters Numero_ExteriorFilter { set; get; }
        public string Numero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters ReferenciaFilter { set; get; }
        public string Referencia { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public RadioOptions Documento_Extraviado { set; get; }

        public Filters Tipo_de_Documento_ExtraviadoFilter { set; get; }
        public string AdvanceTipo_de_Documento_Extraviado { set; get; }
        public int[] AdvanceTipo_de_Documento_ExtraviadoMultiple { set; get; }

        public Filters Tipo_de_Lugar_del_HechoFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_HechoMultiple { set; get; }


    }
}
