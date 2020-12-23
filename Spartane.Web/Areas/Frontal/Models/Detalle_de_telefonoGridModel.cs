using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_telefonoGridModel
    {
        public int Clave { get; set; }
        public int? Tipo_de_Telefono { get; set; }
        public string Tipo_de_TelefonoDescripcion { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }
        
    }
}

