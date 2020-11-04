using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Errores_de_ReplicacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string ID_del_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Fecha_del_Error { get; set; }
        public string Hora_del_Error { get; set; }
        public string Campo_con_Error { get; set; }
        public string Valor_del_Campo_en_Dispositivo { get; set; }
        public string Valor_del_Campo_en_Web { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }

    }
	
	public class Errores_de_Replicacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string ID_del_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Fecha_del_Error { get; set; }
        public string Hora_del_Error { get; set; }
        public string Campo_con_Error { get; set; }
        public string Valor_del_Campo_en_Dispositivo { get; set; }
        public string Valor_del_Campo_en_Web { get; set; }
        [Range(0, 9999999999)]
        public int? Folio { get; set; }

    }


}

