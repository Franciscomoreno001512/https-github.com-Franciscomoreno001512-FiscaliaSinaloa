﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tipo_de_Invitacion
{
    /// <summary>
    /// Tipo_de_Invitacion table
    /// </summary>
    public class Tipo_de_Invitacion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Tipo_de_Invitacion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

