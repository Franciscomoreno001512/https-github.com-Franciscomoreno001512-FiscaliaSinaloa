using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Solicitud_de_Apoyo
{
    public class Estatus_de_Solicitud_de_ApoyoPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Solicitud_de_Apoyo.Estatus_de_Solicitud_de_Apoyo> Estatus_de_Solicitud_de_Apoyos { set; get; }
        public int RowCount { set; get; }
    }
}
