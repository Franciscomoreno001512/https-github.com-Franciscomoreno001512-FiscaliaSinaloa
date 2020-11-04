using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Datos_Personales_Adicionales_Probable_ResponsableGridModel
    {
        public int Clave { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Redes_SocialesDescripcion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

