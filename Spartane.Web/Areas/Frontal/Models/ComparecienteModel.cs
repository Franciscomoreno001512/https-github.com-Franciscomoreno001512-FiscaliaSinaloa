using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ComparecienteModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        [Range(0, 9999999999)]
        public int? Registro_de_Atencion_Inicial { get; set; }
        public string AVPR_NAVPR { get; set; }
        public string AVPR_APBIS { get; set; }
        public string AVPR_CVEMU { get; set; }
        public string AVPR_CVEAG { get; set; }
        public string OFEN_CONOF { get; set; }
        public string OFEN_OPATE { get; set; }
        public string OFEN_OMATE { get; set; }
        public string OFEN_ONOMB { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? OFEN_INSTI { get; set; }
        public string OFEN_ESTAD { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? OFEN_EDAD { get; set; }
        public string OFEN_OCUPA { get; set; }
        public string FECHAREGIS { get; set; }
        public string USUARIO { get; set; }
        public string HORAREGIST { get; set; }
        [Range(0, 9999999999)]
        public int? fuente { get; set; }
        public string fecenvio { get; set; }
        [Range(0, 9999999999)]
        public int? OFEN_PROBABLE { get; set; }
        public string OFEN_RSOMENOR { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? REPR_Sexo { get; set; }
        [Range(0, 9999999999)]
        public int? REPR_NACIONALIDAD { get; set; }
        [Range(0, 9999999999)]
        public int? REPR_ESCOLARIDAD { get; set; }
        [Range(0, 9999999999)]
        public int? TIPO_EDAD { get; set; }
        [Range(0, 9999999999)]
        public int? IdEstadoInstitucion { get; set; }

    }
	
	public class Compareciente_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        [Range(0, 9999999999)]
        public int? Registro_de_Atencion_Inicial { get; set; }
        public string AVPR_NAVPR { get; set; }
        public string AVPR_APBIS { get; set; }
        public string AVPR_CVEMU { get; set; }
        public string AVPR_CVEAG { get; set; }
        public string OFEN_CONOF { get; set; }
        public string OFEN_OPATE { get; set; }
        public string OFEN_OMATE { get; set; }
        public string OFEN_ONOMB { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? OFEN_INSTI { get; set; }
        public string OFEN_ESTAD { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? OFEN_EDAD { get; set; }
        public string OFEN_OCUPA { get; set; }
        public string FECHAREGIS { get; set; }
        public string USUARIO { get; set; }
        public string HORAREGIST { get; set; }
        [Range(0, 9999999999)]
        public int? fuente { get; set; }
        public string fecenvio { get; set; }
        [Range(0, 9999999999)]
        public int? OFEN_PROBABLE { get; set; }
        public string OFEN_RSOMENOR { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? REPR_Sexo { get; set; }
        [Range(0, 9999999999)]
        public int? REPR_NACIONALIDAD { get; set; }
        [Range(0, 9999999999)]
        public int? REPR_ESCOLARIDAD { get; set; }
        [Range(0, 9999999999)]
        public int? TIPO_EDAD { get; set; }
        [Range(0, 9999999999)]
        public int? IdEstadoInstitucion { get; set; }

    }


}

