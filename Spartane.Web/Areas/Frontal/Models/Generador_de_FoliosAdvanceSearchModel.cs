using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_de_FoliosAdvanceSearchModel
    {
        public Generador_de_FoliosAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFolio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFolio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFolio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Generador_de_Folio { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Generador_de_Folio", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Generador_de_Folio { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromAnio_de_Generador_de_Folio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromAnio_de_Generador_de_Folio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToAnio_de_Generador_de_Folio { set; get; }

        public Filters Tipo_de_DenunciaFilter { set; get; }
        public string AdvanceTipo_de_Denuncia { set; get; }
        public int[] AdvanceTipo_de_DenunciaMultiple { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters UnidadFilter { set; get; }
        public string AdvanceUnidad { set; get; }
        public int[] AdvanceUnidadMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromConsecutivo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromConsecutivo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToConsecutivo { set; get; }

        public Filters Folio_Ultimo_GeneradoFilter { set; get; }
        public string Folio_Ultimo_Generado { set; get; }


    }
}
