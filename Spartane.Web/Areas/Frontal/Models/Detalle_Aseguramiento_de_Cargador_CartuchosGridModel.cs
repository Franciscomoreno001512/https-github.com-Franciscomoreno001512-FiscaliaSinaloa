using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_Cargador_CartuchosGridModel
    {
        public int Clave { get; set; }
        public short? Calibre { get; set; }
        public string CalibreDescripcion { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public int? cartuchos_municiones { get; set; }
        public string Cartuchos_Habiles { get; set; }
        public int? Cartuchos_Percutidos { get; set; }
        public int? cargadores { get; set; }
        
    }
}

