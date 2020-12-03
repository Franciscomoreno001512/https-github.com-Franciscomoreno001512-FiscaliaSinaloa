using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AseguramientosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente { get; set; }
        public string Expedientenic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }

    }
	
	public class Aseguramientos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente { get; set; }
        public string Expedientenic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }

    }

	public class Aseguramientos_Medios_de_Transporte_InvolucradosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Aseguramientos_Drogas_InvolucradasModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Aseguramientos_Armas_InvolucradasModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Aseguramientos_Objetos_AseguradosModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Aseguramientos_Otros_AseguramientosModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

