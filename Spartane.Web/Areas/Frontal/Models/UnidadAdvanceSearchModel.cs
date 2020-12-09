using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class UnidadAdvanceSearchModel
    {
        public UnidadAdvanceSearchModel()
        {
            ReceptorDeclinaciones = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave_Unica_Municipio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave_Unica_Municipio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave_Unica_Municipio { set; get; }

        public Filters Clave_de_MunicipioFilter { set; get; }
        public string AdvanceClave_de_Municipio { set; get; }
        public int[] AdvanceClave_de_MunicipioMultiple { set; get; }

        public Filters Clave_de_RegionFilter { set; get; }
        public string AdvanceClave_de_Region { set; get; }
        public int[] AdvanceClave_de_RegionMultiple { set; get; }

        public Filters AbreviacionFilter { set; get; }
        public string Abreviacion { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters Descripcion_CortaFilter { set; get; }
        public string Descripcion_Corta { set; get; }

        public Filters EspecialidadFilter { set; get; }
        public string AdvanceEspecialidad { set; get; }
        public int[] AdvanceEspecialidadMultiple { set; get; }

        public Filters VigenciaFilter { set; get; }
        public string AdvanceVigencia { set; get; }
        public int[] AdvanceVigenciaMultiple { set; get; }

        public Filters DireccionFilter { set; get; }
        public string Direccion { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters SupervisorFilter { set; get; }
        public string AdvanceSupervisor { set; get; }
        public int[] AdvanceSupervisorMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromConsecutivo_CDI { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromConsecutivo_CDI", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToConsecutivo_CDI { set; get; }

        public Filters Tipo_de_Asignacion_de_MPFilter { set; get; }
        public string AdvanceTipo_de_Asignacion_de_MP { set; get; }
        public int[] AdvanceTipo_de_Asignacion_de_MPMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromcod_pais { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromcod_pais", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tocod_pais { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromcod_edo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromcod_edo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tocod_edo { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromcod_agencia { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromcod_agencia", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tocod_agencia { set; get; }

        public Filters FTIPOFilter { set; get; }
        public string FTIPO { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfcreada { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfcreada", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofcreada { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfbaja { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfbaja", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofbaja { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromULTAVREGIS { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromULTAVREGIS", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToULTAVREGIS { set; get; }

        public Filters FUBICACIONFilter { set; get; }
        public string FUBICACION { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromvr_agen { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromvr_agen", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tovr_agen { set; get; }

        public Filters EspecialFilter { set; get; }
        public string Especial { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromAgenAV { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromAgenAV", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToAgenAV { set; get; }

        public Filters AgenUni_NSJPFilter { set; get; }
        public string AgenUni_NSJP { set; get; }

        public Filters NomenclaturaFilter { set; get; }
        public string Nomenclatura { set; get; }

        public Filters AlcanceFilter { set; get; }
        public string Alcance { set; get; }

        public RadioOptions ReceptorDeclinaciones { set; get; }


    }
}
