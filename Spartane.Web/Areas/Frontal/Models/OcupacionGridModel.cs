﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class OcupacionGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Justicia { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        public string Vigenciax { get; set; }
        
    }
}

