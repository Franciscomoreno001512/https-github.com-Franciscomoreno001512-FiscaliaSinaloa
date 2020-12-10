using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Audiencia_InicialAdvanceSearchModel
    {
        public Audiencia_InicialAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Nombre_del_Juez_de_ControlFilter { set; get; }
        public string Nombre_del_Juez_de_Control { set; get; }

        public Filters TipoFilter { set; get; }
        public string AdvanceTipo { set; get; }
        public int[] AdvanceTipoMultiple { set; get; }

        public Filters causa_penalFilter { set; get; }
        public string causa_penal { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Audiencia_Inicial { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Audiencia_Inicial", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Audiencia_Inicial { set; get; }

        public string ToHora_Audiencia_Inicial { set; get; }
        public string FromHora_Audiencia_Inicial { set; get; }

        public Filters Sala_de_AudienciaFilter { set; get; }
        public string Sala_de_Audiencia { set; get; }

        public Filters Con_DetenidoFilter { set; get; }
        public string AdvanceCon_Detenido { set; get; }
        public int[] AdvanceCon_DetenidoMultiple { set; get; }

        public Filters Especificar_DetencionFilter { set; get; }
        public string AdvanceEspecificar_Detencion { set; get; }
        public int[] AdvanceEspecificar_DetencionMultiple { set; get; }

        public Filters Control_de_DetencionFilter { set; get; }
        public string AdvanceControl_de_Detencion { set; get; }
        public int[] AdvanceControl_de_DetencionMultiple { set; get; }

        public Filters Especificar_Control_DetencionFilter { set; get; }
        public string AdvanceEspecificar_Control_Detencion { set; get; }
        public int[] AdvanceEspecificar_Control_DetencionMultiple { set; get; }

        public Filters Formulacion_de_ImputacionFilter { set; get; }
        public string AdvanceFormulacion_de_Imputacion { set; get; }
        public int[] AdvanceFormulacion_de_ImputacionMultiple { set; get; }


    }
}
