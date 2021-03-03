using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ColoniaGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }
        public int? cod_pais { get; set; }
        public int? cod_edo { get; set; }
        public int? loc_justicia { get; set; }
        public int? pob_justicia { get; set; }
        public int? sector { get; set; }
        public string estatus { get; set; }
        public int? cod_localidad { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        
    }
}

