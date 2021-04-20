using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_MPOAdvanceSearchModel
    {
        public Detalle_de_Documentos_MPOAdvanceSearchModel()
        {
            Archivo_Adjunto = RadioOptions.NoApply;
            Lista_para_periciales = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Modulo_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_Atencion_InicialMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha { set; get; }

        public string ToHora { set; get; }
        public string FromHora { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Tipo_de_DocumentoFilter { set; get; }
        public string AdvanceTipo_de_Documento { set; get; }
        public int[] AdvanceTipo_de_DocumentoMultiple { set; get; }

        public Filters DocumentoFilter { set; get; }
        public string AdvanceDocumento { set; get; }
        public int[] AdvanceDocumentoMultiple { set; get; }

        public Filters InvolucradoFilter { set; get; }
        public string AdvanceInvolucrado { set; get; }
        public int[] AdvanceInvolucradoMultiple { set; get; }

        public Filters Probable_ResponsableFilter { set; get; }
        public string AdvanceProbable_Responsable { set; get; }
        public int[] AdvanceProbable_ResponsableMultiple { set; get; }

        public RadioOptions Archivo_Adjunto { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromArchivo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromArchivo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToArchivo { set; get; }

        public RadioOptions Lista_para_periciales { set; get; }

        public Filters FolioFilter { set; get; }
        public string Folio { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters Estatus_PersonaFilter { set; get; }
        public string AdvanceEstatus_Persona { set; get; }
        public int[] AdvanceEstatus_PersonaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Localizacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Localizacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Localizacion { set; get; }

        public string ToHora_Localizacion { set; get; }
        public string FromHora_Localizacion { set; get; }

        public Filters Condiciones_de_LocalizacionFilter { set; get; }
        public string AdvanceCondiciones_de_Localizacion { set; get; }
        public int[] AdvanceCondiciones_de_LocalizacionMultiple { set; get; }

        public Filters Lugar_de_HallazgoFilter { set; get; }
        public string AdvanceLugar_de_Hallazgo { set; get; }
        public int[] AdvanceLugar_de_HallazgoMultiple { set; get; }

        public Filters Posible_Causa_de_la_DesaparacionFilter { set; get; }
        public string Posible_Causa_de_la_Desaparacion { set; get; }

        public Filters PaisFilter { set; get; }
        public string AdvancePais { set; get; }
        public int[] AdvancePaisMultiple { set; get; }

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

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters Numero_ExteriorFilter { set; get; }
        public string Numero_Exterior { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters Ente_que_localiza_al_no_localizadoFilter { set; get; }
        public string AdvanceEnte_que_localiza_al_no_localizado { set; get; }
        public int[] AdvanceEnte_que_localiza_al_no_localizadoMultiple { set; get; }

        public Filters ente_PaternoFilter { set; get; }
        public string ente_Paterno { set; get; }

        public Filters ente_MaternoFilter { set; get; }
        public string ente_Materno { set; get; }

        public Filters ente_NombreFilter { set; get; }
        public string ente_Nombre { set; get; }

        public Filters Autoridad_que_conoce_el_hechoFilter { set; get; }
        public string Autoridad_que_conoce_el_hecho { set; get; }

        public Filters autoridad_PaternoFilter { set; get; }
        public string autoridad_Paterno { set; get; }

        public Filters autoridad_MaternoFilter { set; get; }
        public string autoridad_Materno { set; get; }

        public Filters autoridad_NombreFilter { set; get; }
        public string autoridad_Nombre { set; get; }


    }
}
