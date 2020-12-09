using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_Folios_por_EspecialidadGridModel
    {
        public int Folio { get; set; }
        public short? Ano { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        public int? Consecutivo { get; set; }
        
    }
}

