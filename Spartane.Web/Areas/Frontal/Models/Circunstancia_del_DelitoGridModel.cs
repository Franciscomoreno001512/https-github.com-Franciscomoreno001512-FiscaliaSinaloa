using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Circunstancia_del_DelitoGridModel
    {
        public int Clave { get; set; }
        public int? Titulo_del_Delito { get; set; }
        public string Titulo_del_DelitoDescripcion { get; set; }
        public int? Grupo_del_Delito { get; set; }
        public string Grupo_del_DelitoDescripcion { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public string Descripcion { get; set; }
        
    }
}

