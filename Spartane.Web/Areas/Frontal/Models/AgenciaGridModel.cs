using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AgenciaGridModel
    {
        public string Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public int ClaveID { get; set; }
        
    }
}

