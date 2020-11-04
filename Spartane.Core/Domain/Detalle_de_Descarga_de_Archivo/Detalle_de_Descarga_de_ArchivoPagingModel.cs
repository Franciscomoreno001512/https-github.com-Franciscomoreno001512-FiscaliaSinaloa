using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Descarga_de_Archivo
{
    public class Detalle_de_Descarga_de_ArchivoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Descarga_de_Archivo.Detalle_de_Descarga_de_Archivo> Detalle_de_Descarga_de_Archivos { set; get; }
        public int RowCount { set; get; }
    }
}
