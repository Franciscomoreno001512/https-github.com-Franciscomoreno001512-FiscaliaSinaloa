using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_IndiciosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Indicio { get; set; }
        public string Motivo_de_Indicio { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaServicio { get; set; }
        public string Ubicacion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }
	
	public class Detalle_de_Indicios_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Indicio { get; set; }
        public string Motivo_de_Indicio { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaServicio { get; set; }
        public string Ubicacion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }


}

