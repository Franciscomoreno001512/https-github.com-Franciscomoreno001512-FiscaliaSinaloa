using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class TurnosAdvanceSearchModel
    {
        public TurnosAdvanceSearchModel()
        {
            Activo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Clave_de_MunicipioFilter { set; get; }
        public string Clave_de_Municipio { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters Clave_de_AgenciaFilter { set; get; }
        public string Clave_de_Agencia { set; get; }

        public Filters Clave_de_MunicipioAgenciaFilter { set; get; }
        public string Clave_de_MunicipioAgencia { set; get; }

        public Filters Depende_deFilter { set; get; }
        public string Depende_de { set; get; }

        public RadioOptions Activo { set; get; }

        public Filters PrioridadFilter { set; get; }
        public string Prioridad { set; get; }


    }
}
