using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Folio_Asignado_de_UsuarioModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }
        public int? Estatus_de_Folio { get; set; }
        public string Estatus_de_FolioDescripcion { get; set; }
        public string Fecha_de_Registro { get; set; }

    }
	
	public class Detalle_de_Folio_Asignado_de_Usuario_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }
        public int? Estatus_de_Folio { get; set; }
        public string Estatus_de_FolioDescripcion { get; set; }
        public string Fecha_de_Registro { get; set; }

    }


}

