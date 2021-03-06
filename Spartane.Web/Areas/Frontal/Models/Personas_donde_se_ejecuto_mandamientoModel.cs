﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Personas_donde_se_ejecuto_mandamientoModel
    {
        [Required]
        public int Folio { get; set; }
        public string Persona { get; set; }
        public bool Seleccionar { get; set; }
        [Range(0, 9999999999)]
        public int? PersonaId { get; set; }

    }
	
	public class Personas_donde_se_ejecuto_mandamiento_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        [Range(0, 9999999999)]
        public int? PersonaId { get; set; }

    }


}

