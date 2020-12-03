using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel
    {
        public int Clave { get; set; }
        public short? Aparatos { get; set; }
        public string AparatosDescripcion { get; set; }
        public short? Documentos_Multimedia { get; set; }
        public string Documentos_MultimediaDescripcion { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string A_resguardo { get; set; }
        
    }
}

