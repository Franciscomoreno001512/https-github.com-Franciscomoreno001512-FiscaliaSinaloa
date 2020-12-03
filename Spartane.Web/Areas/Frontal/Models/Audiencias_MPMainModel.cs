using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Audiencias_MPMainModel
    {
        public Audiencias_MPModel Audiencias_MPInfo { set; get; }
        public Detalle_Audiencia_Defensor_ImputadoGridModelPost Detalle_Audiencia_Defensor_ImputadoGridInfo { set; get; }
        public Detalle_Audiencia_Defensor_VictimaGridModelPost Detalle_Audiencia_Defensor_VictimaGridInfo { set; get; }
        public Detalle_Audiencia_Archivos_AdjuntosGridModelPost Detalle_Audiencia_Archivos_AdjuntosGridInfo { set; get; }

    }

    public class Detalle_Audiencia_Defensor_ImputadoGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre_Del_Imputado { get; set; }
        public string Abogado { get; set; }
        public string Cedula_Profesional { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Audiencia_Defensor_VictimaGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre_del_Imputado { get; set; }
        public string Abogado { get; set; }
        public string Cedula_Profesional { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Audiencia_Archivos_AdjuntosGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre_Archivo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoInfo { set; get; }

        public bool Removed { set; get; }
    }



}

