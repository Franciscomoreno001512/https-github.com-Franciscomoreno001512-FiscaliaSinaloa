using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Apoyo_ExternaAdvanceSearchModel
    {
        public Solicitud_de_Apoyo_ExternaAdvanceSearchModel()
        {
            Archivo_Adjunto = RadioOptions.NoApply;
            Ver_Documento = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFolio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFolio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFolio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_registro { set; get; }
        public string FromHora_de_registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters UnidadFilter { set; get; }
        public string AdvanceUnidad { set; get; }
        public int[] AdvanceUnidadMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromAnio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromAnio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToAnio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Solicitud { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Solicitud", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Solicitud { set; get; }

        public Filters Numero_de_Oficio_ExternoFilter { set; get; }
        public string Numero_de_Oficio_Externo { set; get; }

        public Filters SolicitanteFilter { set; get; }
        public string Solicitante { set; get; }

        public Filters RangoFilter { set; get; }
        public string Rango { set; get; }

        public Filters Autoridad_ExternaFilter { set; get; }
        public string AdvanceAutoridad_Externa { set; get; }
        public int[] AdvanceAutoridad_ExternaMultiple { set; get; }

        public Filters Narracion_SolicitudFilter { set; get; }
        public string Narracion_Solicitud { set; get; }

        public RadioOptions Archivo_Adjunto { set; get; }

        public Filters Area_AsignadaFilter { set; get; }
        public string AdvanceArea_Asignada { set; get; }
        public int[] AdvanceArea_AsignadaMultiple { set; get; }

        public Filters SubArea_AsignadaFilter { set; get; }
        public string AdvanceSubArea_Asignada { set; get; }
        public int[] AdvanceSubArea_AsignadaMultiple { set; get; }

        public Filters Dictamen_SolicitadoFilter { set; get; }
        public string AdvanceDictamen_Solicitado { set; get; }
        public int[] AdvanceDictamen_SolicitadoMultiple { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Contestacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Contestacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Contestacion { set; get; }

        public string ToHora_de_Contestacion { set; get; }
        public string FromHora_de_Contestacion { set; get; }

        public Filters Responsable_que_ContestaFilter { set; get; }
        public string AdvanceResponsable_que_Contesta { set; get; }
        public int[] AdvanceResponsable_que_ContestaMultiple { set; get; }

        public Filters No__ContestacionFilter { set; get; }
        public string No__Contestacion { set; get; }

        public Filters DictamenFilter { set; get; }
        public string AdvanceDictamen { set; get; }
        public int[] AdvanceDictamenMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public RadioOptions Ver_Documento { set; get; }


    }
}
