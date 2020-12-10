using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Especialidad_MP;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Control_de_Folios_por_Especialidad
{
    /// <summary>
    /// Control_de_Folios_por_Especialidad table
    /// </summary>
    public class Control_de_Folios_por_Especialidad: BaseEntity
    {
        public int Folio { get; set; }
        public short? Ano { get; set; }
        public int? Especialidad { get; set; }
        public int? Consecutivo { get; set; }

        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad_MP.Especialidad_MP Especialidad_Especialidad_MP { get; set; }

    }
	
	public class Control_de_Folios_por_Especialidad_Datos_Generales
    {
                public int Folio { get; set; }
        public short? Ano { get; set; }
        public int? Especialidad { get; set; }
        public int? Consecutivo { get; set; }

		        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad_MP.Especialidad_MP Especialidad_Especialidad_MP { get; set; }

    }


}

