using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Diligencias_MPAdvanceSearchModel
    {
        public Diligencias_MPAdvanceSearchModel()
        {
            Archivo_Adjunto = RadioOptions.NoApply;
            Lista_para_periciales = RadioOptions.NoApply;

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

        public Filters Numero_de_OficioFilter { set; get; }
        public string Numero_de_Oficio { set; get; }

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

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public RadioOptions Lista_para_periciales { set; get; }


    }
}
