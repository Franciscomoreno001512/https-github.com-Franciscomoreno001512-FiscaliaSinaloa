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


    }
}
