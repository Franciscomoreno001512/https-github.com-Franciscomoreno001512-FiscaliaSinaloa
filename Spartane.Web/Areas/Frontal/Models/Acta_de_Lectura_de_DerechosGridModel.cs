using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Acta_de_Lectura_de_DerechosGridModel
    {
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string NIC { get; set; }
        public string Folio { get; set; }
        public string Ubicacion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Agente_de_la_PM { get; set; }
        public string Plaza_de_Adscripcion { get; set; }
        public string Domicilio_de_la_Comandancia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        
    }
}

