using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Control_de_Folios_de_Mandamiento_Judicial
{
    /// <summary>
    /// Control_de_Folios_de_Mandamiento_Judicial table
    /// </summary>
    public class Control_de_Folios_de_Mandamiento_Judicial: BaseEntity
    {
        public int Consecutivo { get; set; }
        public int? Folio { get; set; }
        public short? Ano { get; set; }


    }
	
	public class Control_de_Folios_de_Mandamiento_Judicial_Datos_Generales
    {
                public int Consecutivo { get; set; }
        public int? Folio { get; set; }
        public short? Ano { get; set; }

		
    }


}

