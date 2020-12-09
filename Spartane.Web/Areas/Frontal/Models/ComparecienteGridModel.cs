using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ComparecienteGridModel
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Registro_de_Atencion_Inicial { get; set; }
        public string AVPR_NAVPR { get; set; }
        public string AVPR_APBIS { get; set; }
        public string AVPR_CVEMU { get; set; }
        public string AVPR_CVEAG { get; set; }
        public string OFEN_CONOF { get; set; }
        public string OFEN_OPATE { get; set; }
        public string OFEN_OMATE { get; set; }
        public string OFEN_ONOMB { get; set; }
        public decimal? OFEN_INSTI { get; set; }
        public string OFEN_ESTAD { get; set; }
        public decimal? OFEN_EDAD { get; set; }
        public string OFEN_OCUPA { get; set; }
        public string FECHAREGIS { get; set; }
        public string USUARIO { get; set; }
        public string HORAREGIST { get; set; }
        public int? fuente { get; set; }
        public string fecenvio { get; set; }
        public int? OFEN_PROBABLE { get; set; }
        public string OFEN_RSOMENOR { get; set; }
        public decimal? REPR_Sexo { get; set; }
        public int? REPR_NACIONALIDAD { get; set; }
        public int? REPR_ESCOLARIDAD { get; set; }
        public int? TIPO_EDAD { get; set; }
        public int? IdEstadoInstitucion { get; set; }
        
    }
}

