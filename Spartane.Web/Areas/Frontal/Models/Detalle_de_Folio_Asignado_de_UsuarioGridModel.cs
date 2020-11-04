using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Folio_Asignado_de_UsuarioGridModel
    {
        public int Clave { get; set; }
        public int? Folio { get; set; }
        public int? Estatus_de_Folio { get; set; }
        public string Estatus_de_FolioDescripcion { get; set; }
        public string Fecha_de_Registro { get; set; }
        
    }
}

