using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Datos_de_Apoyo
{
    public class Detalle_de_Solicitud_Datos_de_ApoyoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Solicitud_Datos_de_Apoyo.Detalle_de_Solicitud_Datos_de_Apoyo> Detalle_de_Solicitud_Datos_de_Apoyos { set; get; }
        public int RowCount { set; get; }
    }
}
