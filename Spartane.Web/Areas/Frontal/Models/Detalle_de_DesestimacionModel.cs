using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_DesestimacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Nombre_Completo { get; set; }
        public string Nombre_CompletoNombre_Completo { get; set; }
        public short? Causal_de_Interrupcion { get; set; }
        public string Causal_de_InterrupcionDescripcion { get; set; }
        public int? Causa_de_Interrupcion { get; set; }
        public string Causa_de_InterrupcionDescripcion { get; set; }
        public short? Datos_Insuficientes { get; set; }
        public string Datos_InsuficientesDescripcion { get; set; }
        public string Actualizacion_de_Sobreseimiento { get; set; }

    }
	
	public class Detalle_de_Desestimacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Nombre_Completo { get; set; }
        public string Nombre_CompletoNombre_Completo { get; set; }
        public short? Causal_de_Interrupcion { get; set; }
        public string Causal_de_InterrupcionDescripcion { get; set; }
        public int? Causa_de_Interrupcion { get; set; }
        public string Causa_de_InterrupcionDescripcion { get; set; }
        public short? Datos_Insuficientes { get; set; }
        public string Datos_InsuficientesDescripcion { get; set; }
        public string Actualizacion_de_Sobreseimiento { get; set; }

    }


}

