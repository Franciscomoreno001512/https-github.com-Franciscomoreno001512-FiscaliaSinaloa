using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Recepcion_de_Pago_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public string Usuario_que_RecibeName { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Expediente { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo { get; set; }
        public string Nombre_de_la_Persona_que_entrega { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Pago { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_del_Pago { get; set; }
        public bool Pago_Completo { get; set; }
        public string Motivo_para_no_entregar_pago_completo { get; set; }

    }
	
	public class Recepcion_de_Pago_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public string Usuario_que_RecibeName { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Expediente { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo { get; set; }
        public string Nombre_de_la_Persona_que_entrega { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Pago { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Monto_del_Pago { get; set; }
        public bool? Pago_Completo { get; set; }
        public string Motivo_para_no_entregar_pago_completo { get; set; }

    }


}

