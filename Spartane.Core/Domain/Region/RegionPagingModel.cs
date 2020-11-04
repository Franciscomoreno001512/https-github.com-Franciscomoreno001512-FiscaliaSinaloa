using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Region
{
    public class RegionPagingModel
    {
        public List<Spartane.Core.Domain.Region.Region> Regions { set; get; }
        public int RowCount { set; get; }
    }
}
