using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Audiencias_MPGridModel
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Tipo_de_Audiencia { get; set; }
        public string Tipo_de_AudienciaDescripcion { get; set; }
        public int? Audiencia { get; set; }
        public string AudienciaDescripcion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Observaciones { get; set; }
        public int? Resultado_de_Audiencia { get; set; }
        public string Resultado_de_AudienciaDescripcion { get; set; }
        public bool? Asignar_MP_Litigacion { get; set; }
        public int? MP_Litigacion { get; set; }
        public string MP_LitigacionName { get; set; }
        
    }
}

