using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Carga_de_Documentos_Lectura_de_DerechosGridModel
    {
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short? Adjuntar_Documento { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Estatus_de_Actualizacion { get; set; }
        public string Estatus_de_ActualizacionDescripcion { get; set; }
        
    }
}

