using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Mandamiento_JudicialAdvanceSearchModel
    {
        public Registro_de_Mandamiento_JudicialAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

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

        public Filters Numero_de_MandamientoFilter { set; get; }
        public string Numero_de_Mandamiento { set; get; }

        public Filters Tipo_MandatoFilter { set; get; }
        public string AdvanceTipo_Mandato { set; get; }
        public int[] AdvanceTipo_MandatoMultiple { set; get; }

        public Filters FuenteFilter { set; get; }
        public string AdvanceFuente { set; get; }
        public int[] AdvanceFuenteMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Solicitud { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Solicitud", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Solicitud { set; get; }

        public Filters Pais_al_que_Pertenece_la_InformacionFilter { set; get; }
        public string AdvancePais_al_que_Pertenece_la_Informacion { set; get; }
        public int[] AdvancePais_al_que_Pertenece_la_InformacionMultiple { set; get; }

        public Filters Estado_que_Envia_la_InformacionFilter { set; get; }
        public string AdvanceEstado_que_Envia_la_Informacion { set; get; }
        public int[] AdvanceEstado_que_Envia_la_InformacionMultiple { set; get; }

        public Filters Municipio_que_Envia_la_InformacionFilter { set; get; }
        public string AdvanceMunicipio_que_Envia_la_Informacion { set; get; }
        public int[] AdvanceMunicipio_que_Envia_la_InformacionMultiple { set; get; }

        public Filters Institucion_que_RemiteFilter { set; get; }
        public string AdvanceInstitucion_que_Remite { set; get; }
        public int[] AdvanceInstitucion_que_RemiteMultiple { set; get; }

        public Filters Dependencia_Autoridad_RemitenteFilter { set; get; }
        public string Dependencia_Autoridad_Remitente { set; get; }

        public Filters Entidad_que_Emite_MandamientoFilter { set; get; }
        public string AdvanceEntidad_que_Emite_Mandamiento { set; get; }
        public int[] AdvanceEntidad_que_Emite_MandamientoMultiple { set; get; }

        public Filters Juzgado_que_Emitio_MandamientoFilter { set; get; }
        public string AdvanceJuzgado_que_Emitio_Mandamiento { set; get; }
        public int[] AdvanceJuzgado_que_Emitio_MandamientoMultiple { set; get; }

        public Filters Oficio_de_JuzgadoFilter { set; get; }
        public string Oficio_de_Juzgado { set; get; }

        public Filters Area_que_envia_OrdenFilter { set; get; }
        public string AdvanceArea_que_envia_Orden { set; get; }
        public int[] AdvanceArea_que_envia_OrdenMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters Numero_de_Proceso_JudicialFilter { set; get; }
        public string Numero_de_Proceso_Judicial { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Libramiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Libramiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Libramiento { set; get; }

        public Filters Oficio_de_LibramientoFilter { set; get; }
        public string Oficio_de_Libramiento { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Transcripcion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Transcripcion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Transcripcion { set; get; }

        public Filters Oficio_TranscripcionFilter { set; get; }
        public string Oficio_Transcripcion { set; get; }

        public Filters Carpeta_de_InvestigacionFilter { set; get; }
        public string AdvanceCarpeta_de_Investigacion { set; get; }
        public int[] AdvanceCarpeta_de_InvestigacionMultiple { set; get; }

        public Filters Causa_PenalFilter { set; get; }
        public string AdvanceCausa_Penal { set; get; }
        public int[] AdvanceCausa_PenalMultiple { set; get; }


    }
}
