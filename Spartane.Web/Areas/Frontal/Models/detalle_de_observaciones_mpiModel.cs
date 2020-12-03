﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class detalle_de_observaciones_mpiModel
    {
        [Required]
        public int clave { get; set; }
        public string observaciones { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int? usuario_que_realiza_observacion { get; set; }
        public string usuario_que_realiza_observacionName { get; set; }

    }
	
	public class detalle_de_observaciones_mpi_Datos_GeneralesModel
    {
        [Required]
        public int clave { get; set; }
        public string observaciones { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int? usuario_que_realiza_observacion { get; set; }
        public string usuario_que_realiza_observacionName { get; set; }

    }


}

