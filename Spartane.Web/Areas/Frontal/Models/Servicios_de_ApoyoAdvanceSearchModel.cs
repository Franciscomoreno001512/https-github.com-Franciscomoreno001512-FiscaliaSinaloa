using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_de_ApoyoAdvanceSearchModel
    {
        public Servicios_de_ApoyoAdvanceSearchModel()
        {
            Justicia_Alternativa = RadioOptions.NoApply;
            Derechos = RadioOptions.NoApply;
            Procedimiento = RadioOptions.NoApply;
            Solicita_Medios_Alternativos = RadioOptions.NoApply;
            Investigacion_con_Detenido = RadioOptions.NoApply;
            Investigacion_sin_Detenido = RadioOptions.NoApply;
            Turnar_a_Justicia_Alternativa = RadioOptions.NoApply;
            Instancia_Externa = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Folio_del_CasoFilter { set; get; }
        public string AdvanceFolio_del_Caso { set; get; }
        public int[] AdvanceFolio_del_CasoMultiple { set; get; }

        public RadioOptions Justicia_Alternativa { set; get; }

        public Filters Medios_AlternativosFilter { set; get; }
        public string AdvanceMedios_Alternativos { set; get; }
        public int[] AdvanceMedios_AlternativosMultiple { set; get; }

        public Filters MotivoFilter { set; get; }
        public string Motivo { set; get; }

        public RadioOptions Derechos { set; get; }

        public RadioOptions Procedimiento { set; get; }

        public RadioOptions Solicita_Medios_Alternativos { set; get; }

        public Filters Se_CanalizaFilter { set; get; }
        public string AdvanceSe_Canaliza { set; get; }
        public int[] AdvanceSe_CanalizaMultiple { set; get; }

        public RadioOptions Investigacion_con_Detenido { set; get; }

        public RadioOptions Investigacion_sin_Detenido { set; get; }

        public RadioOptions Turnar_a_Justicia_Alternativa { set; get; }

        public RadioOptions Instancia_Externa { set; get; }


    }
}
