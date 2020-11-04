using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_PericialesGridModel
    {
        public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }
        
    }
}

