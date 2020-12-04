using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Proceso_PenalMainModel
    {
        public Proceso_PenalModel Proceso_PenalInfo { set; get; }
        public Detalle_Delitos_Proceso_PenalGridModelPost Detalle_Delitos_Proceso_PenalGridInfo { set; get; }
        public Detalle_Medidas_Cautelares_Proceso_PenalGridModelPost Detalle_Medidas_Cautelares_Proceso_PenalGridInfo { set; get; }
        public Detalle_Medios_Prueba_ImputadoGridModelPost Detalle_Medios_Prueba_ImputadoGridInfo { set; get; }
        public Detalle_Medios_Prueba_VictimaGridModelPost Detalle_Medios_Prueba_VictimaGridInfo { set; get; }
        public Detalle_Medios_Prueba_AdmitidosGridModelPost Detalle_Medios_Prueba_AdmitidosGridInfo { set; get; }
        public Detalle_Condiciones_Proceso_PenalGridModelPost Detalle_Condiciones_Proceso_PenalGridInfo { set; get; }

    }

    public class Detalle_Delitos_Proceso_PenalGridModelPost
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Medidas_Cautelares_Proceso_PenalGridModelPost
    {
        public int Clave { get; set; }
        public int? Medida_Cautelar { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Medios_Prueba_ImputadoGridModelPost
    {
        public int Clave { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public string Fecha_de_Presentacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoInfo { set; get; }

        public bool Removed { set; get; }
    }

    public class Detalle_Medios_Prueba_VictimaGridModelPost
    {
        public int Clave { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public string Fecha_de_Presentacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoInfo { set; get; }

        public bool Removed { set; get; }
    }

    public class Detalle_Medios_Prueba_AdmitidosGridModelPost
    {
        public int Clave { get; set; }
        public string Origen { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public bool? Admitido { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Condiciones_Proceso_PenalGridModelPost
    {
        public int Clave { get; set; }
        public int? Medida_Cautelar { get; set; }

        public bool Removed { set; get; }
    }



}

