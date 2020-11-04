using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Diligencias_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Facilitador { get; set; }
        public string FacilitadorName { get; set; }
        public int? Tipo_de_Diligencia { get; set; }
        public string Tipo_de_DiligenciaDescripcion { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaDescripcion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Detalle_Diligencias_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Facilitador { get; set; }
        public string FacilitadorName { get; set; }
        public int? Tipo_de_Diligencia { get; set; }
        public string Tipo_de_DiligenciaDescripcion { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaDescripcion { get; set; }
        public string Observaciones { get; set; }

    }


}

