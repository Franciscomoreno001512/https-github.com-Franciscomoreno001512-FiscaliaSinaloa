using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configuracion_de_Servicios_de_ApoyoMainModel
    {
        public Configuracion_de_Servicios_de_ApoyoModel Configuracion_de_Servicios_de_ApoyoInfo { set; get; }
        public Detalle_Solicitud_Disponibles_ConfiguracionGridModelPost Detalle_Solicitud_Disponibles_ConfiguracionGridInfo { set; get; }

    }

    public class Detalle_Solicitud_Disponibles_ConfiguracionGridModelPost
    {
        public int Clave { get; set; }
        public int? Documento { get; set; }

        public bool Removed { set; get; }
    }



}

