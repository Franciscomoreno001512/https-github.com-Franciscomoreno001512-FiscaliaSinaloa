using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_de_TurnosAdvanceSearchModel
    {
        public Asignacion_de_TurnosAdvanceSearchModel()
        {
            Urgencia = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFolio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFolio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFolio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Turno { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Turno", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Turno { set; get; }

        public string ToHora_de_Turno { set; get; }
        public string FromHora_de_Turno { set; get; }

        public Filters Numero_de_TurnoFilter { set; get; }
        public string Numero_de_Turno { set; get; }

        public Filters Unidad_de_AtencionFilter { set; get; }
        public string AdvanceUnidad_de_Atencion { set; get; }
        public int[] AdvanceUnidad_de_AtencionMultiple { set; get; }

        public Filters RecepcionFilter { set; get; }
        public string AdvanceRecepcion { set; get; }
        public int[] AdvanceRecepcionMultiple { set; get; }

        public Filters NombresFilter { set; get; }
        public string Nombres { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        public Filters SexoFilter { set; get; }
        public string AdvanceSexo { set; get; }
        public int[] AdvanceSexoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad { set; get; }

        public Filters Tipo_de_AtencionFilter { set; get; }
        public string AdvanceTipo_de_Atencion { set; get; }
        public int[] AdvanceTipo_de_AtencionMultiple { set; get; }

        public Filters Tipo_de_IdentificacionFilter { set; get; }
        public string AdvanceTipo_de_Identificacion { set; get; }
        public int[] AdvanceTipo_de_IdentificacionMultiple { set; get; }

        public Filters Otra_IdentificacionFilter { set; get; }
        public string Otra_Identificacion { set; get; }

        public Filters Numero_de_IdentificacionFilter { set; get; }
        public string Numero_de_Identificacion { set; get; }

        public RadioOptions Urgencia { set; get; }

        public Filters Tipo_de_UrgenciaFilter { set; get; }
        public string AdvanceTipo_de_Urgencia { set; get; }
        public int[] AdvanceTipo_de_UrgenciaMultiple { set; get; }

        public Filters OrientadorFilter { set; get; }
        public string AdvanceOrientador { set; get; }
        public int[] AdvanceOrientadorMultiple { set; get; }

        public Filters Estatus_de_TurnoFilter { set; get; }
        public string AdvanceEstatus_de_Turno { set; get; }
        public int[] AdvanceEstatus_de_TurnoMultiple { set; get; }

        public Filters ModuloFilter { set; get; }
        public string AdvanceModulo { set; get; }
        public int[] AdvanceModuloMultiple { set; get; }

        public Filters Motivo_Finalizacion_TurnoFilter { set; get; }
        public string AdvanceMotivo_Finalizacion_Turno { set; get; }
        public int[] AdvanceMotivo_Finalizacion_TurnoMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Asignacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Asignacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Asignacion { set; get; }

        public string ToHora_de_Asignacion { set; get; }
        public string FromHora_de_Asignacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Finalizacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Finalizacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Finalizacion { set; get; }

        public string ToHora_de_Finalizacion { set; get; }
        public string FromHora_de_Finalizacion { set; get; }


    }
}
