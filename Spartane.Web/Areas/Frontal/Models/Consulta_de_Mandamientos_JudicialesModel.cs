﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Consulta_de_Mandamientos_JudicialesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? MandamientoJudicialId { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Juzgado { get; set; }
        public string JuzgadoNombre { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

    }
	
	public class Consulta_de_Mandamientos_Judiciales_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? MandamientoJudicialId { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Juzgado { get; set; }
        public string JuzgadoNombre { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

    }


}

