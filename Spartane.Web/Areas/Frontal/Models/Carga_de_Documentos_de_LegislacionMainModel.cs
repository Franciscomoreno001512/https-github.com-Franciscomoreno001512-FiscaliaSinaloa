using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Carga_de_Documentos_de_LegislacionMainModel
    {
        public Carga_de_Documentos_de_LegislacionModel Carga_de_Documentos_de_LegislacionInfo { set; get; }
        public Detalle_de_Documentos_de_LegislacionGridModelPost Detalle_de_Documentos_de_LegislacionGridInfo { set; get; }

    }

    public class Detalle_de_Documentos_de_LegislacionGridModelPost
    {
        public int Clave { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public int? Estatus { get; set; }

        public bool Removed { set; get; }
    }



}

