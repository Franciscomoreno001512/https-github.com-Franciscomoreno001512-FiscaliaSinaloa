using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class SolicitudMainModel
    {
        public SolicitudModel SolicitudInfo { set; get; }
        public Detalle_Solicitud_Historial_de_AsignacionesGridModelPost Detalle_Solicitud_Historial_de_AsignacionesGridInfo { set; get; }
        public Detalle_de_Solicitud_Bitacora_de_CoincidGridModelPost Detalle_de_Solicitud_Bitacora_de_CoincidGridInfo { set; get; }
        public Detalle_Historico_JAGridModelPost Detalle_Historico_JAGridInfo { set; get; }

    }

    public class Detalle_Solicitud_Historial_de_AsignacionesGridModelPost
    {
        public int Folio { get; set; }
        public string Fecha_cambio { get; set; }
        public string Hora_cambio { get; set; }
        public int? Usuario { get; set; }
        public int? Facilitador_Asignado { get; set; }
        public string Motivo_de_cambio { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Solicitud_Bitacora_de_CoincidGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Fuente_de_Origen { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public bool? Cumplido { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Historico_JAGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Estatus { get; set; }

        public bool Removed { set; get; }
    }



}

