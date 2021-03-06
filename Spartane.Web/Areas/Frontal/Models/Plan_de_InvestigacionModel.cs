﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Plan_de_InvestigacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Fecha_Reunion_Mando_Ministerial { get; set; }
        public string Hora_Reunion_Mando_Ministerial { get; set; }
        public string Asistentes { get; set; }
        public string Acuerdos { get; set; }

    }
	
	public class Plan_de_Investigacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Fecha_Reunion_Mando_Ministerial { get; set; }
        public string Hora_Reunion_Mando_Ministerial { get; set; }
        public string Asistentes { get; set; }
        public string Acuerdos { get; set; }

    }

	public class Plan_de_Investigacion_Actos_de_InvestigacionModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

