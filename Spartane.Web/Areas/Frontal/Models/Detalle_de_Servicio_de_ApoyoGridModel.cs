using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Servicio_de_ApoyoGridModel
    {
        public int Clave { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public string Modulo_de_Atencion_InicialNUAT { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteNombre_Completo { get; set; }
        
    }
}

