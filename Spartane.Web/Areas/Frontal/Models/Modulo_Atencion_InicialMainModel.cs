using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_Atencion_InicialMainModel
    {
        public Modulo_Atencion_InicialModel Modulo_Atencion_InicialInfo { set; get; }
        public Detalle_de_coincidencias_aGridModelPost Detalle_de_coincidencias_aGridInfo { set; get; }
        public Detalle_Historico_MPOGridModelPost Detalle_Historico_MPOGridInfo { set; get; }

    }

    public class Detalle_de_coincidencias_aGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string NUAT { get; set; }
        public string Fuente_de_Origen { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Historico_MPOGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Estatus { get; set; }

        public bool Removed { set; get; }
    }



}

