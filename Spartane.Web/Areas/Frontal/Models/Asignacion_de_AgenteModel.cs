﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_de_AgenteModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public string Usuario_que_AsignaName { get; set; }
        public int? Agente_Asignado { get; set; }
        public string Agente_AsignadoName { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Asignacion_de_Agente_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public string Usuario_que_AsignaName { get; set; }
        public int? Agente_Asignado { get; set; }
        public string Agente_AsignadoName { get; set; }
        public string Observaciones { get; set; }

    }


}

