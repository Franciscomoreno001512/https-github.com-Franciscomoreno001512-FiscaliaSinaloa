using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DelegacionGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public short? Clave_Expediente { get; set; }
        public string Direccion { get; set; }
        public int? Consecutivo_MPO { get; set; }
        public int? Consecutivo_MPI { get; set; }
        public int? Distrito { get; set; }
        public string DistritoDescripcion { get; set; }
        public string Abreviacion_Delegacion { get; set; }
        
    }
}

