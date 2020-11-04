using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class TurnosGridModel
    {
        public int Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public string Clave_de_Agencia { get; set; }
        public string Clave_de_MunicipioAgencia { get; set; }
        public string Depende_de { get; set; }
        public bool? Activo { get; set; }
        public string Prioridad { get; set; }
        
    }
}

