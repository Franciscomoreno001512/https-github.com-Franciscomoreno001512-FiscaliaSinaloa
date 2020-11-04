using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Tutor
{
    public class Detalle_de_TutorPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Tutor.Detalle_de_Tutor> Detalle_de_Tutors { set; get; }
        public int RowCount { set; get; }
    }
}
