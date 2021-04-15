﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class RegionGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
        public bool? recepcion_servicios_apoyo { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        public int? Consecutivo_CDI { get; set; }
        
    }
}

