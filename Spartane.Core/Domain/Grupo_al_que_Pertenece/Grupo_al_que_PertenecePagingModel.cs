using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Grupo_al_que_Pertenece
{
    public class Grupo_al_que_PertenecePagingModel
    {
        public List<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> Grupo_al_que_Perteneces { set; get; }
        public int RowCount { set; get; }
    }
}
