using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Usuario
{
    public class UsuarioPagingModel
    {
        public List<Spartane.Core.Domain.Usuario.Usuario> Usuarios { set; get; }
        public int RowCount { set; get; }
    }
}
