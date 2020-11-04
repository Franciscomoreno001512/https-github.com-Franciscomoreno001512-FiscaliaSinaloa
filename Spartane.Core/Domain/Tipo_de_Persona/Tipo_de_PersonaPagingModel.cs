using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Persona
{
    public class Tipo_de_PersonaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> Tipo_de_Personas { set; get; }
        public int RowCount { set; get; }
    }
}
