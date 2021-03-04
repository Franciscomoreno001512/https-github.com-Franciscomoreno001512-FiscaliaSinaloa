using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ResolucionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public string Resolucion_Padre_para_AutorizacionDescripcion { get; set; }
        public bool Generar_Judicializacion { get; set; }
        public string ClaveFiscalia { get; set; }
        public bool Resolucion_AT { get; set; }
        public bool Resolucion_MP { get; set; }
        public bool Aplica_para_Adolescentes { get; set; }
        public bool Aplica_para_Denuncia { get; set; }
        public bool Aplica_para_Carpeta_de_Investigacion { get; set; }
        public string Abreviacion { get; set; }
        public string Vigencia { get; set; }
        public string MostrarDependencia { get; set; }
        [Range(0, 9999999999)]
        public int? Conteo { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus_esp { get; set; }
        [Range(0, 9999999999)]
        public int? Mostrar_Estadistico { get; set; }

    }
	
	public class Resolucion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public int? Resolucion_Padre_para_Autorizacion { get; set; }
        public string Resolucion_Padre_para_AutorizacionDescripcion { get; set; }
        public bool? Generar_Judicializacion { get; set; }
        public string ClaveFiscalia { get; set; }
        public bool? Resolucion_AT { get; set; }
        public bool? Resolucion_MP { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }
        public bool? Aplica_para_Denuncia { get; set; }
        public bool? Aplica_para_Carpeta_de_Investigacion { get; set; }
        public string Abreviacion { get; set; }
        public string Vigencia { get; set; }
        public string MostrarDependencia { get; set; }
        [Range(0, 9999999999)]
        public int? Conteo { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus_esp { get; set; }
        [Range(0, 9999999999)]
        public int? Mostrar_Estadistico { get; set; }

    }


}

