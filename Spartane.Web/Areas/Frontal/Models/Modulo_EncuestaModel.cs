﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_EncuestaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }

    }
	
	public class Modulo_Encuesta_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }

    }


}

