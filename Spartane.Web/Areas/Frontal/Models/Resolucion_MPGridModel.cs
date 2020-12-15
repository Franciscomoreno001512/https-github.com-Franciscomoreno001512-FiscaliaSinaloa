using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_MPGridModel
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Resolucion { get; set; }
        public int? Persona_que_Resuelve { get; set; }
        public string Persona_que_ResuelveName { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        public int? Juzgado { get; set; }
        public string JuzgadoNombre { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public int? No__De_Causa_o_Cuadernillo { get; set; }
        public int? Ano_de_Causa_o_Cuadernillo { get; set; }
        public string Ano_de_Causa_o_CuadernilloDescripcion { get; set; }
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

