using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.TTFolioConsecutivo
{
    public class TTFolioConsecutivoPagingModel
    {
        public List<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> TTFolioConsecutivos { set; get; }
        public int RowCount { set; get; }
    }
}
