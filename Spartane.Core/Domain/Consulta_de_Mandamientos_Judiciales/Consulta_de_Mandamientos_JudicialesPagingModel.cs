using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales
{
    public class Consulta_de_Mandamientos_JudicialesPagingModel
    {
        public List<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> Consulta_de_Mandamientos_Judicialess { set; get; }
        public int RowCount { set; get; }
    }
}
