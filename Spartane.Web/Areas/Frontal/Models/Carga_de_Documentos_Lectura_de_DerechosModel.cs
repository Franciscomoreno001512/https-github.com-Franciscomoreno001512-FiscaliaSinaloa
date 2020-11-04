using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Carga_de_Documentos_Lectura_de_DerechosModel
    {
        [Required]
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Adjuntar_Documento { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Estatus_de_Actualizacion { get; set; }
        public string Estatus_de_ActualizacionDescripcion { get; set; }

    }
	
	public class Carga_de_Documentos_Lectura_de_Derechos_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Adjuntar_Documento { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Estatus_de_Actualizacion { get; set; }
        public string Estatus_de_ActualizacionDescripcion { get; set; }

    }


}

