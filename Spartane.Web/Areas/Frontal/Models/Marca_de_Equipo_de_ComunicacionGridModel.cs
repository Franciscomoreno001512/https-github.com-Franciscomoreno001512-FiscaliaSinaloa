using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Marca_de_Equipo_de_ComunicacionGridModel
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_de_Equipo { get; set; }
        public string Tipo_de_EquipoDescripcion { get; set; }
        
    }
}

