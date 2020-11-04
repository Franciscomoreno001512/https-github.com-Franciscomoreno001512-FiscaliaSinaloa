using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documento_MPOGridModel
    {
        public int Clave { get; set; }
        public string Documento { get; set; }
        public int? Archivo { get; set; }
        public Grid_File ArchivoFileInfo { set; get; }
        public string Fecha { get; set; }
        
    }
}

