using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Servicios_de_Apoyo
{
    public class Servicios_de_ApoyoPagingModel
    {
        public List<Spartane.Core.Domain.Servicios_de_Apoyo.Servicios_de_Apoyo> Servicios_de_Apoyos { set; get; }
        public int RowCount { set; get; }
    }
}
