using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_Servicio_de_ApoyoGridModel
    {
        public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        
    }
}

