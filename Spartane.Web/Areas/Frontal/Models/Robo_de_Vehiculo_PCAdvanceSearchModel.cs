using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Robo_de_Vehiculo_PCAdvanceSearchModel
    {
        public Robo_de_Vehiculo_PCAdvanceSearchModel()
        {
            Robo_de_Vehiculo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        public Filters Tipo_de_SolicitudFilter { set; get; }
        public string AdvanceTipo_de_Solicitud { set; get; }
        public int[] AdvanceTipo_de_SolicitudMultiple { set; get; }

        public RadioOptions Robo_de_Vehiculo { set; get; }

        public Filters MarcaFilter { set; get; }
        public string AdvanceMarca { set; get; }
        public int[] AdvanceMarcaMultiple { set; get; }

        public Filters Sub_MarcaFilter { set; get; }
        public string AdvanceSub_Marca { set; get; }
        public int[] AdvanceSub_MarcaMultiple { set; get; }

        public Filters Tipo_de_VehiculoFilter { set; get; }
        public string AdvanceTipo_de_Vehiculo { set; get; }
        public int[] AdvanceTipo_de_VehiculoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromModelo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromModelo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToModelo { set; get; }

        public Filters ColorFilter { set; get; }
        public string AdvanceColor { set; get; }
        public int[] AdvanceColorMultiple { set; get; }

        public Filters PlacasFilter { set; get; }
        public string Placas { set; get; }

        public Filters Senas_ParticularesFilter { set; get; }
        public string Senas_Particulares { set; get; }


    }
}
