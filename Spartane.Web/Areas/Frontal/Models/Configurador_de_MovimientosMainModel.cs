using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configurador_de_MovimientosMainModel
    {
        public Configurador_de_MovimientosModel Configurador_de_MovimientosInfo { set; get; }
        public Detalle_Datos_Adicionales_MovimientoGridModelPost Detalle_Datos_Adicionales_MovimientoGridInfo { set; get; }

    }

    public class Detalle_Datos_Adicionales_MovimientoGridModelPost
    {
        public int Clave { get; set; }
        public string Dato { get; set; }
        public int? Tipo_de_Dato { get; set; }
        public string Query_para_llenado { get; set; }
        public bool? Obligatorio { get; set; }

        public bool Removed { set; get; }
    }



}

