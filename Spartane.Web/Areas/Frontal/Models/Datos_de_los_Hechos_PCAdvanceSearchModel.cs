using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Datos_de_los_Hechos_PCAdvanceSearchModel
    {
        public Datos_de_los_Hechos_PCAdvanceSearchModel()
        {
            Tiene_alguna_Foto_o_Evidencia = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public RadioOptions Tiene_alguna_Foto_o_Evidencia { set; get; }

        public Filters Fosa_clandestinaFilter { set; get; }
        public string AdvanceFosa_clandestina { set; get; }
        public int[] AdvanceFosa_clandestinaMultiple { set; get; }

        public Filters Conoce_la_direccionFilter { set; get; }
        public string AdvanceConoce_la_direccion { set; get; }
        public int[] AdvanceConoce_la_direccionMultiple { set; get; }

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

        public Filters Es_una_direccion_exacta_o_aproximadaFilter { set; get; }
        public string AdvanceEs_una_direccion_exacta_o_aproximada { set; get; }
        public int[] AdvanceEs_una_direccion_exacta_o_aproximadaMultiple { set; get; }


    }
}
