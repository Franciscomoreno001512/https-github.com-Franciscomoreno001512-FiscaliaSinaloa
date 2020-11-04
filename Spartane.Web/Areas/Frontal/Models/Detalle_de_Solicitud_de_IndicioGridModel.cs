using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_de_IndicioGridModel
    {
        public int Clave { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public string Nombre_del_Solicitante { get; set; }
        public string Motivo { get; set; }
        public int? Numero_de_Indicio { get; set; }
        public string Numero_de_IndicioDescripcion { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Entrega_de_Indicio { get; set; }
        public int? Diligencia_que_Solicita { get; set; }
        public string Diligencia_que_SolicitaServicio { get; set; }
        
    }
}

