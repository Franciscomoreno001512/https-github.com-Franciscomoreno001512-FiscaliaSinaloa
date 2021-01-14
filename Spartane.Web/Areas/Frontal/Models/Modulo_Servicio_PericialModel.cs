using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_Servicio_PericialModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Servicio_Pericial { get; set; }
        public string Servicio_PericialResponsable { get; set; }
        public int? Usuario_Asignado { get; set; }
        public string Usuario_AsignadoName { get; set; }

    }
	
	public class Modulo_Servicio_Pericial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Servicio_Pericial { get; set; }
        public string Servicio_PericialResponsable { get; set; }
        public int? Usuario_Asignado { get; set; }
        public string Usuario_AsignadoName { get; set; }

    }


}

