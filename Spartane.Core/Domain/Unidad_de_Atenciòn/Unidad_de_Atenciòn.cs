﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Unidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Unidad_de_Atenciòn
{
    /// <summary>
    /// Unidad_de_Atenciòn table
    /// </summary>
    public class Unidad_de_Atenciòn: BaseEntity
    {
        public int Clave { get; set; }
        public int? Unidad { get; set; }

        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }
	
	public class Unidad_de_Atenciòn_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Unidad { get; set; }

		        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }


}

