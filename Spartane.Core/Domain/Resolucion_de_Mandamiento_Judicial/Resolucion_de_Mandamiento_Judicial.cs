﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial
{
    /// <summary>
    /// Resolucion_de_Mandamiento_Judicial table
    /// </summary>
    public class Resolucion_de_Mandamiento_Judicial: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Resolucion_de_Mandamiento_Judicial_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

