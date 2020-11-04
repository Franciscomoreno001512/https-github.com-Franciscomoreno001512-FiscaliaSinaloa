using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_MPOMainModel
    {
        public Detalle_de_Documentos_MPOModel Detalle_de_Documentos_MPOInfo { set; get; }
        public Detalle_Involucrados_en_DocumentosGridModelPost Detalle_Involucrados_en_DocumentosGridInfo { set; get; }
        public Detalle_Probable_Responsable_de_DocumentosGridModelPost Detalle_Probable_Responsable_de_DocumentosGridInfo { set; get; }
        public Detalle_Delitos_de_DocumentosGridModelPost Detalle_Delitos_de_DocumentosGridInfo { set; get; }

    }

    public class Detalle_Involucrados_en_DocumentosGridModelPost
    {
        public int Clave { get; set; }
        public int? Involucrado { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Probable_Responsable_de_DocumentosGridModelPost
    {
        public int Clave { get; set; }
        public int? Probable_Responsable { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Delitos_de_DocumentosGridModelPost
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }

        public bool Removed { set; get; }
    }



}

