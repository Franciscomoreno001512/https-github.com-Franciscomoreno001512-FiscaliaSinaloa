using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Calidad_Migratoria
{
    public class Calidad_MigratoriaPagingModel
    {
        public List<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> Calidad_Migratorias { set; get; }
        public int RowCount { set; get; }
    }
}
