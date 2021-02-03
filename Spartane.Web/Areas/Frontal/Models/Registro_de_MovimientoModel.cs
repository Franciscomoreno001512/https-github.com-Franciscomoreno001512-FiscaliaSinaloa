using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_MovimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Judicializacion { get; set; }
        public string Judicializacioncausa_o_cuadernillo { get; set; }
        public int? Fase { get; set; }
        public string FaseDescripcion { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Movimiento_Realizado { get; set; }
        public string Movimiento_RealizadoDescripcion { get; set; }
        public string Fecha_de_Movimiento { get; set; }
        public string Hora_de_Movimiento { get; set; }
        public string Informacion { get; set; }

    }
	
	public class Registro_de_Movimiento_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Judicializacion { get; set; }
        public string Judicializacioncausa_o_cuadernillo { get; set; }
        public int? Fase { get; set; }
        public string FaseDescripcion { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Movimiento_Realizado { get; set; }
        public string Movimiento_RealizadoDescripcion { get; set; }
        public string Fecha_de_Movimiento { get; set; }
        public string Hora_de_Movimiento { get; set; }
		[AllowHtml]
        public string Informacion { get; set; }

    }


}

