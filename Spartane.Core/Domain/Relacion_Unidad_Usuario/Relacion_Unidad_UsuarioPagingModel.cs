using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Relacion_Unidad_Usuario
{
    public class Relacion_Unidad_UsuarioPagingModel
    {
        public List<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> Relacion_Unidad_Usuarios { set; get; }
        public int RowCount { set; get; }
    }
}
