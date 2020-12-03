using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class expediente_ministerio_publicoMainModel
    {
        public expediente_ministerio_publicoModel expediente_ministerio_publicoInfo { set; get; }
        public detalle_de_observaciones_mpiGridModelPost detalle_de_observaciones_mpiGridInfo { set; get; }

    }

    public class detalle_de_observaciones_mpiGridModelPost
    {
        public int clave { get; set; }
        public string observaciones { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int? usuario_que_realiza_observacion { get; set; }

        public bool Removed { set; get; }
    }



}

