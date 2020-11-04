using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Servicios_de_ApoyoGridModel
    {
        public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteNombre_Completo { get; set; }
        
    }
}

