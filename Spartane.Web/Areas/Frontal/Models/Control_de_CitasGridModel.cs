using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_CitasGridModel
    {
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public string Usuario_que_AtiendeName { get; set; }
        public string Fecha_de_la_Cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public int? Proceso { get; set; }
        public string ProcesoDescripcion { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Tipo_de_Cita { get; set; }
        public string Cita { get; set; }
        public bool? Cumplida { get; set; }
        public string Observaciones { get; set; }
        
    }
}

