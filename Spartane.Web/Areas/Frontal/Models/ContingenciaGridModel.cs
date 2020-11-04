using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ContingenciaGridModel
    {
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Usuario { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Observaciones { get; set; }
        
    }
}

