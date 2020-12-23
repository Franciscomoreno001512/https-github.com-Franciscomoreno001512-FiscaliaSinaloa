using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Consulta_de_Mandamientos_JudicialesGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        
    }
}

