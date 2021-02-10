using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DelitoAdvanceSearchModel
    {
        public DelitoAdvanceSearchModel()
        {
            Grave = RadioOptions.NoApply;
            Alto_Impacto = RadioOptions.NoApply;
            Alta_Incidencia = RadioOptions.NoApply;
            Tentativa = RadioOptions.NoApply;
            Activo = RadioOptions.NoApply;
            Robo_de_Vehiculo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Titulo_del_DelitoFilter { set; get; }
        public string AdvanceTitulo_del_Delito { set; get; }
        public int[] AdvanceTitulo_del_DelitoMultiple { set; get; }

        public Filters Grupo_del_DelitoFilter { set; get; }
        public string AdvanceGrupo_del_Delito { set; get; }
        public int[] AdvanceGrupo_del_DelitoMultiple { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public RadioOptions Grave { set; get; }

        public RadioOptions Alto_Impacto { set; get; }

        public RadioOptions Alta_Incidencia { set; get; }

        public RadioOptions Tentativa { set; get; }

        public RadioOptions Activo { set; get; }

        public RadioOptions Robo_de_Vehiculo { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromdelitox { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromdelitox", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Todelitox { set; get; }

        public Filters ARTICULOFilter { set; get; }
        public string ARTICULO { set; get; }

        public Filters DETALLEFilter { set; get; }
        public string DETALLE { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromTIPO_AGENCIA { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromTIPO_AGENCIA", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToTIPO_AGENCIA { set; get; }

        public Filters ESTADISTICO_SSPFilter { set; get; }
        public string ESTADISTICO_SSP { set; get; }

        public Filters VAL_VEHICULOFilter { set; get; }
        public string VAL_VEHICULO { set; get; }

        public Filters TIPO_DELITOFilter { set; get; }
        public string AdvanceTIPO_DELITO { set; get; }
        public int[] AdvanceTIPO_DELITOMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromcircunstancia_clasif { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromcircunstancia_clasif", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tocircunstancia_clasif { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromPRINCIPAL { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromPRINCIPAL", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToPRINCIPAL { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromorden { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromorden", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Toorden { set; get; }


    }
}
