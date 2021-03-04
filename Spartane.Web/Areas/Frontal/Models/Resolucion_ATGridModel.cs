using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_ATGridModel
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public string Fecha_de_Resolucion { get; set; }
        public int? Persona_que_Resuelve { get; set; }
        public string Persona_que_ResuelveName { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        public int? Relacion { get; set; }
        public string RelacionDescripcion { get; set; }
        public string Observaciones { get; set; }
        public string Fecha_de_Validacion { get; set; }
        public string Hora_de_Validacion { get; set; }
        public int? Dictaminador { get; set; }
        public string DictaminadorName { get; set; }
        public int? Resultado_de_Validacion { get; set; }
        public string Resultado_de_ValidacionDescripcion { get; set; }
        public string Observaciones_Dictaminador { get; set; }
        
    }
}

