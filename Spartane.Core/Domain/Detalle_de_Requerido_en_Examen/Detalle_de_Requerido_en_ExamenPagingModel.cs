using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Requerido_en_Examen
{
    public class Detalle_de_Requerido_en_ExamenPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Requerido_en_Examen.Detalle_de_Requerido_en_Examen> Detalle_de_Requerido_en_Examens { set; get; }
        public int RowCount { set; get; }
    }
}
