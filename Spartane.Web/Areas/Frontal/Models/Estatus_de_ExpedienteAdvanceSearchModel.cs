using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Estatus_de_ExpedienteAdvanceSearchModel
    {
        public Estatus_de_ExpedienteAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Estatus_GeneralFilter { set; get; }
        public string Estatus_General { set; get; }

        public Filters Estatus_EspecificoFilter { set; get; }
        public string Estatus_Especifico { set; get; }

        public Filters Estatus_Tipo_CasoFilter { set; get; }
        public string Estatus_Tipo_Caso { set; get; }

        public Filters Estatus_Descripcion_GeneralFilter { set; get; }
        public string Estatus_Descripcion_General { set; get; }

        public Filters Estatus_Descripcion_EspecificoFilter { set; get; }
        public string Estatus_Descripcion_Especifico { set; get; }

        public Filters Estatus_CompletoFilter { set; get; }
        public string Estatus_Completo { set; get; }


    }
}
