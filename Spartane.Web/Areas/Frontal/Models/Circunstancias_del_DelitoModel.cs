﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Circunstancias_del_DelitoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Tipo_de_LugarDescripcion { get; set; }

    }
	
	public class Circunstancias_del_Delito_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Tipo_de_LugarDescripcion { get; set; }

    }


}

