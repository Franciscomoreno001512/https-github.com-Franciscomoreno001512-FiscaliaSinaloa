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

        public Filters Tipo_de_DenunciaFilter { set; get; }
        public string AdvanceTipo_de_Denuncia { set; get; }
        public int[] AdvanceTipo_de_DenunciaMultiple { set; get; }

        public Filters MP_AsignadoFilter { set; get; }
        public string AdvanceMP_Asignado { set; get; }
        public int[] AdvanceMP_AsignadoMultiple { set; get; }

        public Filters unidadFilter { set; get; }
        public string Advanceunidad { set; get; }
        public int[] AdvanceunidadMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

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

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public Filters Lugar_de_los_HechosFilter { set; get; }
        public string AdvanceLugar_de_los_Hechos { set; get; }
        public int[] AdvanceLugar_de_los_HechosMultiple { set; get; }

        public Filters PaisHFilter { set; get; }
        public string AdvancePaisH { set; get; }
        public int[] AdvancePaisHMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters Municipio_HechosFilter { set; get; }
        public string AdvanceMunicipio_Hechos { set; get; }
        public int[] AdvanceMunicipio_HechosMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaHFilter { set; get; }
        public string AdvanceColoniaH { set; get; }
        public int[] AdvanceColoniaHMultiple { set; get; }

        public Filters CalleHFilter { set; get; }
        public string CalleH { set; get; }

        public Filters Numero_InteriorHFilter { set; get; }
        public string Numero_InteriorH { set; get; }

        public Filters Numero_ExteriorHFilter { set; get; }
        public string Numero_ExteriorH { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_PostalH { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_PostalH", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_PostalH { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Y_CalleFilter { set; get; }
        public string Y_Calle { set; get; }

        public Filters LongitudHFilter { set; get; }
        public string LongitudH { set; get; }

        public Filters LatitudHFilter { set; get; }
        public string LatitudH { set; get; }

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

        public Filters acepta_acuerdoFilter { set; get; }
        public string Advanceacepta_acuerdo { set; get; }
        public int[] Advanceacepta_acuerdoMultiple { set; get; }

        public Filters motivo_de_rechazo_de_acuerdoFilter { set; get; }
        public string motivo_de_rechazo_de_acuerdo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string Fromfecha_de_cierre { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("Fromfecha_de_cierre", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofecha_de_cierre { set; get; }

        public string Tohora_de_cierre { set; get; }
        public string Fromhora_de_cierre { set; get; }

        public Filters Usuario_que_CierraFilter { set; get; }
        public string AdvanceUsuario_que_Cierra { set; get; }
        public int[] AdvanceUsuario_que_CierraMultiple { set; get; }

        public Filters tipo_de_cierreFilter { set; get; }
        public string Advancetipo_de_cierre { set; get; }
        public int[] Advancetipo_de_cierreMultiple { set; get; }

        public Filters comentarios_de_cierreFilter { set; get; }
        public string comentarios_de_cierre { set; get; }


    }
}
