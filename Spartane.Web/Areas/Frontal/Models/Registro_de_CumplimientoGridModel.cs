using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_CumplimientoGridModel
    {
        public int Clave { get; set; }
        public int? Mandamiento_Judicial { get; set; }
        public string Mandamiento_JudicialNumero_de_Mandamiento { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_de_Registro { get; set; }
        public string Usuario_de_RegistroName { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        public string Fecha_de_Resolucion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public string Radiograma { get; set; }
        public int? Partida_que_cumplimenta { get; set; }
        public string Partida_que_cumplimentaDescripcion { get; set; }
        public int? Area_que_envia_cumplimiento { get; set; }
        public string Area_que_envia_cumplimientoDescripcion { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Observaciones_del_Cumplimiento { get; set; }
        
    }
}

