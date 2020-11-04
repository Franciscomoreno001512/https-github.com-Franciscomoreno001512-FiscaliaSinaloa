using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Grupo_del_DelitoGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public string Tipo_de_DelitoDescripcion { get; set; }
        public int? Titulo_del_Delito { get; set; }
        public string Titulo_del_DelitoDescripcion { get; set; }
        
    }
}

