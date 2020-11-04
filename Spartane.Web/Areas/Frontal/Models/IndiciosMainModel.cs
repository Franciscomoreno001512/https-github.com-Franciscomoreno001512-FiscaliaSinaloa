using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class IndiciosMainModel
    {
        public IndiciosModel IndiciosInfo { set; get; }
        public Detalle_del_IndicioGridModelPost Detalle_del_IndicioGridInfo { set; get; }
        public Detalle_de_Solicitud_de_IndicioGridModelPost Detalle_de_Solicitud_de_IndicioGridInfo { set; get; }
        public Detalle_de_Devolucion_de_IndiciosGridModelPost Detalle_de_Devolucion_de_IndiciosGridInfo { set; get; }

    }

    public class Detalle_del_IndicioGridModelPost
    {
        public int Clave { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_del_Indicio { get; set; }
        public string Descripcion_del_Indicio { get; set; }
        public string Motivo { get; set; }
        public int? Estatus { get; set; }
        public string Ubicacion_de_Indicio { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Solicitud_de_IndicioGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public string Nombre_del_Solicitante { get; set; }
        public string Motivo { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Entrega_de_Indicio { get; set; }
        public int? Diligencia_que_Solicita { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Devolucion_de_IndiciosGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        public string Nombre_de_Persona_que_Entrega { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Devolucion_de_Indicio { get; set; }
        public int? Diligencia_que_Devuelve { get; set; }

        public bool Removed { set; get; }
    }



}

