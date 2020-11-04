using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class IndiciosGridModel
    {
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? NUC { get; set; }
        public string NUCNUC { get; set; }
        public string NIC { get; set; }
        public int? Delegacion { get; set; }
        public string DelegacionDescripcion { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaDescripcion { get; set; }
        public string Clave_Indicio { get; set; }
        
    }
}

