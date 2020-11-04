using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Descarga_de_ArchivoMainModel
    {
        public Descarga_de_ArchivoModel Descarga_de_ArchivoInfo { set; get; }
        public Detalle_de_Descarga_de_ArchivoGridModelPost Detalle_de_Descarga_de_ArchivoGridInfo { set; get; }

    }

    public class Detalle_de_Descarga_de_ArchivoGridModelPost
    {
        public int Clave { get; set; }
        public short? Documento { get; set; }

        public bool Removed { set; get; }
    }



}

