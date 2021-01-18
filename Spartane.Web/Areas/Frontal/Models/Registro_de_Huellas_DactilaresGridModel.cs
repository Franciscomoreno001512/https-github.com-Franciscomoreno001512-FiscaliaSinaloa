using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Huellas_DactilaresGridModel
    {
        public int Clave { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public string Carpeta_de_Investigacionnic { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo { get; set; }
        public int? Mano_Izquierda_4_Dedos { get; set; }
        public Grid_File Mano_Izquierda_4_DedosFileInfo { set; get; }
        public int? Mano_Derecha_4_Dedos { get; set; }
        public Grid_File Mano_Derecha_4_DedosFileInfo { set; get; }
        public int? Pulgares { get; set; }
        public Grid_File PulgaresFileInfo { set; get; }
        public int? Izquierda_Menique { get; set; }
        public int? Izquierda_Anular { get; set; }
        public int? Izquierda_Medio { get; set; }
        public int? Izquierda_Indice { get; set; }
        public int? Izquierda_Pulgar { get; set; }
        public int? Derecha_Menique { get; set; }
        public int? Derecha_Anular { get; set; }
        public int? Derecha_Medio { get; set; }
        public int? Derecha_Indice { get; set; }
        public int? Derecha_Pulgar { get; set; }
        
    }
}

