using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Bitacora_de_Usuarios
{
    public class Bitacora_de_UsuariosPagingModel
    {
        public List<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> Bitacora_de_Usuarioss { set; get; }
        public int RowCount { set; get; }
    }
}
