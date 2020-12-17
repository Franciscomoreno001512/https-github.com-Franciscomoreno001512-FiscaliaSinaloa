﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configurador_de_MovimientosGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Fase { get; set; }
        public string FaseDescripcion { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplicar_para_Adultos { get; set; }
        
    }
}

