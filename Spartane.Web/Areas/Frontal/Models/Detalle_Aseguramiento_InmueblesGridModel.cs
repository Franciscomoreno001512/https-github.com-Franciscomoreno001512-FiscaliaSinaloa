using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_InmueblesGridModel
    {
        public int Clave { get; set; }
        public short? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public string Tipo { get; set; }
        public string Especifique_Otro { get; set; }
        public string Calle { get; set; }
        public string Exterior { get; set; }
        public string Interior { get; set; }
        public string C_P { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public string Colonia { get; set; }
        public string Registro_Publico_Propiedad { get; set; }
        public string Entrecalles { get; set; }
        public string Propietario { get; set; }
        public string Observaciones { get; set; }
        
    }
}

