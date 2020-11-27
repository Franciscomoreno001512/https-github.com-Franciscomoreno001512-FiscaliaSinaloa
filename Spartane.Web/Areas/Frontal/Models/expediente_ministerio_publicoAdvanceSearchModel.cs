using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class expediente_ministerio_publicoAdvanceSearchModel
    {
        public expediente_ministerio_publicoAdvanceSearchModel()
        {
            acepta_acuerdo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromclave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromclave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Toclave { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfecha_de_registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfecha_de_registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofecha_de_registro { set; get; }

        public string Tohora_de_registro { set; get; }
        public string Fromhora_de_registro { set; get; }

        public Filters usuario_que_registraFilter { set; get; }
        public string Advanceusuario_que_registra { set; get; }
        public int[] Advanceusuario_que_registraMultiple { set; get; }

        public Filters unidadFilter { set; get; }
        public string Advanceunidad { set; get; }
        public int[] AdvanceunidadMultiple { set; get; }

        public Filters nuatFilter { set; get; }
        public string nuat { set; get; }

        public Filters nicFilter { set; get; }
        public string nic { set; get; }

        public Filters detenidoFilter { set; get; }
        public string Advancedetenido { set; get; }
        public int[] AdvancedetenidoMultiple { set; get; }

        public string Tohora_del_detenido { set; get; }
        public string Fromhora_del_detenido { set; get; }

        public string Tohora_puesto_a_disposicion { set; get; }
        public string Fromhora_puesto_a_disposicion { set; get; }

        public Filters estatusFilter { set; get; }
        public string Advanceestatus { set; get; }
        public int[] AdvanceestatusMultiple { set; get; }

        public Filters observacionesFilter { set; get; }
        public string Advanceobservaciones { set; get; }
        public int[] AdvanceobservacionesMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Canalizacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Canalizacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Canalizacion { set; get; }

        public string ToHora_de_Canalizacion { set; get; }
        public string FromHora_de_Canalizacion { set; get; }

        public Filters usuario_que_canalizaFilter { set; get; }
        public string Advanceusuario_que_canaliza { set; get; }
        public int[] Advanceusuario_que_canalizaMultiple { set; get; }

        public Filters canalizar_aFilter { set; get; }
        public string Advancecanalizar_a { set; get; }
        public int[] Advancecanalizar_aMultiple { set; get; }

        public Filters tipo_de_acuerdoFilter { set; get; }
        public string Advancetipo_de_acuerdo { set; get; }
        public int[] Advancetipo_de_acuerdoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfecha_de_inicio_de_acuerdo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfecha_de_inicio_de_acuerdo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofecha_de_inicio_de_acuerdo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfecha_de_cumplimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfecha_de_cumplimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofecha_de_cumplimiento { set; get; }

        public string Tohora_de_cumplimiento { set; get; }
        public string Fromhora_de_cumplimiento { set; get; }

        public Filters domicilio_para_el_cumplimientoFilter { set; get; }
        public string domicilio_para_el_cumplimiento { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Frommonto_de_reparacion_de_danos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Frommonto_de_reparacion_de_danos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tomonto_de_reparacion_de_danos { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromparcialidades { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromparcialidades", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Toparcialidades { set; get; }

        public Filters periodicidadFilter { set; get; }
        public string Advanceperiodicidad { set; get; }
        public int[] AdvanceperiodicidadMultiple { set; get; }

        public RadioOptions acepta_acuerdo { set; get; }

        public Filters motivo_de_rechazo_de_acuerdoFilter { set; get; }
        public string motivo_de_rechazo_de_acuerdo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfecha_de_cierre { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfecha_de_cierre", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofecha_de_cierre { set; get; }

        public string Tohora_de_cierre { set; get; }
        public string Fromhora_de_cierre { set; get; }

        public Filters tipo_de_cierreFilter { set; get; }
        public string Advancetipo_de_cierre { set; get; }
        public int[] Advancetipo_de_cierreMultiple { set; get; }

        public Filters comentarios_de_cierreFilter { set; get; }
        public string comentarios_de_cierre { set; get; }


    }
}
