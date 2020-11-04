using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.PasaTurnos
{
    /// <summary>
    /// PasaTurnos table
    /// </summary>
    public class PasaTurnos: BaseEntity
    {
        public int Folio { get; set; }
        public int? Turno { get; set; }
        public int? Modulo { get; set; }
        public string Unidad { get; set; }


    }
	
	public class PasaTurnos_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Turno { get; set; }
        public int? Modulo { get; set; }
        public string Unidad { get; set; }

		
    }


}

