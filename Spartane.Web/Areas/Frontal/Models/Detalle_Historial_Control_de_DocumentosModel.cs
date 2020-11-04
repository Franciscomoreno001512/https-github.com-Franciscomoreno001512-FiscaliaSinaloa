using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Historial_Control_de_DocumentosModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Modificaciones_Realizadas { get; set; }
        public string Cuerpo_del_Documento { get; set; }

    }
	
	public class Detalle_Historial_Control_de_Documentos_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Modificaciones_Realizadas { get; set; }
        public string Cuerpo_del_Documento { get; set; }

    }


}

