using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_CumplimientoAdvanceSearchModel
    {
        public Registro_de_CumplimientoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Mandamiento_JudicialFilter { set; get; }
        public string AdvanceMandamiento_Judicial { set; get; }
        public int[] AdvanceMandamiento_JudicialMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_de_RegistroFilter { set; get; }
        public string AdvanceUsuario_de_Registro { set; get; }
        public int[] AdvanceUsuario_de_RegistroMultiple { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string AdvanceResolucion { set; get; }
        public int[] AdvanceResolucionMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Resolucion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Resolucion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Resolucion { set; get; }

        public Filters Numero_de_OficioFilter { set; get; }
        public string Numero_de_Oficio { set; get; }

        public Filters RadiogramaFilter { set; get; }
        public string Radiograma { set; get; }

        public Filters Partida_que_cumplimentaFilter { set; get; }
        public string AdvancePartida_que_cumplimenta { set; get; }
        public int[] AdvancePartida_que_cumplimentaMultiple { set; get; }

        public Filters Area_que_envia_cumplimientoFilter { set; get; }
        public string AdvanceArea_que_envia_cumplimiento { set; get; }
        public int[] AdvanceArea_que_envia_cumplimientoMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        public Filters Observaciones_del_CumplimientoFilter { set; get; }
        public string Observaciones_del_Cumplimiento { set; get; }


    }
}
