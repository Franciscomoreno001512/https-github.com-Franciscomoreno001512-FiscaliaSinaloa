using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Acta_de_Lectura_de_DerechosAdvanceSearchModel
    {
        public Acta_de_Lectura_de_DerechosAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters NUCFilter { set; get; }
        public string NUC { set; get; }

        public Filters NICFilter { set; get; }
        public string NIC { set; get; }

        public Filters FolioFilter { set; get; }
        public string Folio { set; get; }

        public Filters UbicacionFilter { set; get; }
        public string Ubicacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha { set; get; }

        public string ToHora { set; get; }
        public string FromHora { set; get; }

        public Filters Agente_de_la_PMFilter { set; get; }
        public string Agente_de_la_PM { set; get; }

        public Filters Plaza_de_AdscripcionFilter { set; get; }
        public string Plaza_de_Adscripcion { set; get; }

        public Filters Domicilio_de_la_ComandanciaFilter { set; get; }
        public string Domicilio_de_la_Comandancia { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string Municipio { set; get; }

        public Filters EstadoFilter { set; get; }
        public string Estado { set; get; }


    }
}
