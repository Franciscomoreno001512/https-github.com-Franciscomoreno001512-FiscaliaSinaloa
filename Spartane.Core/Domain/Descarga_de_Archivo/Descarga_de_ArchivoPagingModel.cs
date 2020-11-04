using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Descarga_de_Archivo
{
    public class Descarga_de_ArchivoPagingModel
    {
        public List<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> Descarga_de_Archivos { set; get; }
        public int RowCount { set; get; }
    }
}
