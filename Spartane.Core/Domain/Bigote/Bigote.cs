﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Bigote
{
    /// <summary>
    /// Bigote table
    /// </summary>
    public class Bigote: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Bigote_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

