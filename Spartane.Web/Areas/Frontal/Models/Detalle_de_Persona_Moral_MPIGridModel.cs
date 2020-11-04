using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Persona_Moral_MPIGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Localidad { get; set; }
        public string LocalidadDescripcion { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public short? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        
    }
}

