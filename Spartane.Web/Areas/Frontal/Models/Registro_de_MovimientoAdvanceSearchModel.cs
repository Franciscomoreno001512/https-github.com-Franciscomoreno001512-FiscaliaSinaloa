using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_MovimientoAdvanceSearchModel
    {
        public Registro_de_MovimientoAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters JudicializacionFilter { set; get; }
        public string AdvanceJudicializacion { set; get; }
        public int[] AdvanceJudicializacionMultiple { set; get; }

        public Filters FaseFilter { set; get; }
        public string AdvanceFase { set; get; }
        public int[] AdvanceFaseMultiple { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Movimiento_RealizadoFilter { set; get; }
        public string AdvanceMovimiento_Realizado { set; get; }
        public int[] AdvanceMovimiento_RealizadoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Movimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Movimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Movimiento { set; get; }

        public string ToHora_de_Movimiento { set; get; }
        public string FromHora_de_Movimiento { set; get; }

        public Filters InformacionFilter { set; get; }
        public string Informacion { set; get; }


    }
}
