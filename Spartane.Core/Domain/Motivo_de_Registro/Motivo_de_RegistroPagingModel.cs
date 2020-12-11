using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Motivo_de_Registro
{
    public class Motivo_de_RegistroPagingModel
    {
        public List<Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro> Motivo_de_Registros { set; get; }
        public int RowCount { set; get; }
    }
}
