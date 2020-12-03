using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_InmueblesModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Terreno { get; set; }
        public string TerrenoDescripcion { get; set; }
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
	
	public class Detalle_Aseguramiento_Inmuebles_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Terreno { get; set; }
        public string TerrenoDescripcion { get; set; }
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

