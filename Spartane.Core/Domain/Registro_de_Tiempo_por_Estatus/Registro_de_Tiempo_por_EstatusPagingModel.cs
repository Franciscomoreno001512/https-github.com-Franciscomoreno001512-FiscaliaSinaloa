using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus
{
    public class Registro_de_Tiempo_por_EstatusPagingModel
    {
        public List<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus> Registro_de_Tiempo_por_Estatuss { set; get; }
        public int RowCount { set; get; }
    }
}
