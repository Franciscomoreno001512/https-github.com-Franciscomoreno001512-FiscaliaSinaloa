using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_ResultadosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fuente { get; set; }
        public string Tipo_de_Mandamiento { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public string Sexo { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Juzgado { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

    }
	
	public class Detalle_de_Resultados_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fuente { get; set; }
        public string Tipo_de_Mandamiento { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public string Sexo { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Juzgado { get; set; }
        public string Oficio_Solicitud_Juzgado { get; set; }
        public string Carpeta_de_Investigacion { get; set; }
        public string Causa_Penal { get; set; }

    }


}

