using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DocumentoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaDescripcion { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public string Tipo_de_DocumentoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? idFormato { get; set; }
        public bool Requerido { get; set; }
        public bool Solicitante { get; set; }
        public bool Requerido_o_Solicitante { get; set; }
        public bool Solicitar_Archivo_Adjunto { get; set; }
        public bool Solicitar_Numero_de_Oficio { get; set; }

    }
	
	public class Documento_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaDescripcion { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public string Tipo_de_DocumentoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? idFormato { get; set; }
        public bool? Requerido { get; set; }
        public bool? Solicitante { get; set; }
        public bool? Requerido_o_Solicitante { get; set; }
        public bool? Solicitar_Archivo_Adjunto { get; set; }
        public bool? Solicitar_Numero_de_Oficio { get; set; }

    }


}

