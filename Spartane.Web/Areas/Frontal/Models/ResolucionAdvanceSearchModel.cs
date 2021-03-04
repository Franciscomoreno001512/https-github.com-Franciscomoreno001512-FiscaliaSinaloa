using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ResolucionAdvanceSearchModel
    {
        public ResolucionAdvanceSearchModel()
        {
            Generar_Judicializacion = RadioOptions.NoApply;
            Resolucion_AT = RadioOptions.NoApply;
            Resolucion_MP = RadioOptions.NoApply;
            Aplica_para_Adolescentes = RadioOptions.NoApply;
            Aplica_para_Denuncia = RadioOptions.NoApply;
            Aplica_para_Carpeta_de_Investigacion = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters TipoFilter { set; get; }
        public string AdvanceTipo { set; get; }
        public int[] AdvanceTipoMultiple { set; get; }

        public Filters Resolucion_Padre_para_AutorizacionFilter { set; get; }
        public string AdvanceResolucion_Padre_para_Autorizacion { set; get; }
        public int[] AdvanceResolucion_Padre_para_AutorizacionMultiple { set; get; }

        public RadioOptions Generar_Judicializacion { set; get; }

        public Filters ClaveFiscaliaFilter { set; get; }
        public string ClaveFiscalia { set; get; }

        public RadioOptions Resolucion_AT { set; get; }

        public RadioOptions Resolucion_MP { set; get; }

        public RadioOptions Aplica_para_Adolescentes { set; get; }

        public RadioOptions Aplica_para_Denuncia { set; get; }

        public RadioOptions Aplica_para_Carpeta_de_Investigacion { set; get; }

        public Filters AbreviacionFilter { set; get; }
        public string Abreviacion { set; get; }

        public Filters VigenciaFilter { set; get; }
        public string Vigencia { set; get; }

        public Filters MostrarDependenciaFilter { set; get; }
        public string MostrarDependencia { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromConteo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromConteo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToConteo { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEstatus { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEstatus", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEstatus { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEstatus_esp { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEstatus_esp", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEstatus_esp { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMostrar_Estadistico { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMostrar_Estadistico", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMostrar_Estadistico { set; get; }


    }
}
