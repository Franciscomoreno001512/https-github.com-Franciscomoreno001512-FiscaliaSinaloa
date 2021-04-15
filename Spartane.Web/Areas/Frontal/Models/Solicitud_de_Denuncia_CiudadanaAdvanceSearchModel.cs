using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel
    {
        public Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters FolioFilter { set; get; }
        public string Folio { set; get; }

        public Filters ContrasenaFilter { set; get; }
        public string Contrasena { set; get; }

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

        public Filters Tipo_de_SolicitudFilter { set; get; }
        public string AdvanceTipo_de_Solicitud { set; get; }
        public int[] AdvanceTipo_de_SolicitudMultiple { set; get; }

        public Filters Estatus_de_SolicitudFilter { set; get; }
        public string AdvanceEstatus_de_Solicitud { set; get; }
        public int[] AdvanceEstatus_de_SolicitudMultiple { set; get; }

        public Filters MotivoFilter { set; get; }
        public string Motivo { set; get; }

        public Filters Canalizar_aFilter { set; get; }
        public string AdvanceCanalizar_a { set; get; }
        public int[] AdvanceCanalizar_aMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Revision { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Revision", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Revision { set; get; }

        public string ToHora_de_Revision { set; get; }
        public string FromHora_de_Revision { set; get; }

        public Filters Usuario_que_RevisaFilter { set; get; }
        public string AdvanceUsuario_que_Revisa { set; get; }
        public int[] AdvanceUsuario_que_RevisaMultiple { set; get; }

        public Filters Tipo_de_ResolucionFilter { set; get; }
        public string AdvanceTipo_de_Resolucion { set; get; }
        public int[] AdvanceTipo_de_ResolucionMultiple { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters Unidad_canalizaFilter { set; get; }
        public string AdvanceUnidad_canaliza { set; get; }
        public int[] AdvanceUnidad_canalizaMultiple { set; get; }

        public Filters ContestacionFilter { set; get; }
        public string Contestacion { set; get; }

        public Filters Observaciones_resolucionFilter { set; get; }
        public string Observaciones_resolucion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Asignacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Asignacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Asignacion { set; get; }

        public string ToHora_de_Asignacion { set; get; }
        public string FromHora_de_Asignacion { set; get; }

        public Filters Usuario_que_AsignaFilter { set; get; }
        public string AdvanceUsuario_que_Asigna { set; get; }
        public int[] AdvanceUsuario_que_AsignaMultiple { set; get; }

        public Filters Responsable_AsignadoFilter { set; get; }
        public string AdvanceResponsable_Asignado { set; get; }
        public int[] AdvanceResponsable_AsignadoMultiple { set; get; }

        public Filters Observaciones_responsableFilter { set; get; }
        public string Observaciones_responsable { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Atencion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Atencion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Atencion { set; get; }

        public string ToHora_de_Atencion { set; get; }
        public string FromHora_de_Atencion { set; get; }

        public Filters Usuario_que_AtiendeFilter { set; get; }
        public string AdvanceUsuario_que_Atiende { set; get; }
        public int[] AdvanceUsuario_que_AtiendeMultiple { set; get; }

        public Filters Atencion_RealizadaFilter { set; get; }
        public string AdvanceAtencion_Realizada { set; get; }
        public int[] AdvanceAtencion_RealizadaMultiple { set; get; }

        public Filters Observaciones_atencionFilter { set; get; }
        public string Observaciones_atencion { set; get; }


    }
}
