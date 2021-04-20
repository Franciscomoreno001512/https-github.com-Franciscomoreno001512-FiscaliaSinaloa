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
        public Detalle_Delitos_de_DocumentosGridModelPost Detalle_Delitos_de_DocumentosGridInfo { set; get; }
        public Detalle_de_Indicios_de_DiligenciaGridModelPost Detalle_de_Indicios_de_DiligenciaGridInfo { set; get; }

    }

    public class Detalle_Delitos_de_DocumentosGridModelPost
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Indicios_de_DiligenciaGridModelPost
    {
        public int Folio { get; set; }
        public string Indicio { get; set; }
        public bool? Seleccionar { get; set; }
        public int? IndicioId { get; set; }

        public bool Removed { set; get; }
    }



}

