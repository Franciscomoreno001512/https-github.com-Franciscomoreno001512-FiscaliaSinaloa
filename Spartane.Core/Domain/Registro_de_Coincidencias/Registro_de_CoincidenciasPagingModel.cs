using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Registro_de_Coincidencias
{
    public class Registro_de_CoincidenciasPagingModel
    {
        public List<Spartane.Core.Domain.Registro_de_Coincidencias.Registro_de_Coincidencias> Registro_de_Coincidenciass { set; get; }
        public int RowCount { set; get; }
    }
}
