﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Causas_de_InterrupcionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Causas_de_Interrupcion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

