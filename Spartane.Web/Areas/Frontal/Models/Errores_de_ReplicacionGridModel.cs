using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Errores_de_ReplicacionGridModel
    {
        public int Clave { get; set; }
        public string ID_del_Dispositivo { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Fecha_del_Error { get; set; }
        public string Hora_del_Error { get; set; }
        public string Campo_con_Error { get; set; }
        public string Valor_del_Campo_en_Dispositivo { get; set; }
        public string Valor_del_Campo_en_Web { get; set; }
        public int? Folio { get; set; }
        
    }
}

