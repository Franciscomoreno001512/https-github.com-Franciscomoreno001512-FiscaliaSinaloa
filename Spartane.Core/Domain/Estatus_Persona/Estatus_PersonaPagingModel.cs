using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_Persona
{
    public class Estatus_PersonaPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_Persona.Estatus_Persona> Estatus_Personas { set; get; }
        public int RowCount { set; get; }
    }
}
