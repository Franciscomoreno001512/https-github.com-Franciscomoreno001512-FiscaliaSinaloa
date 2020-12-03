using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Plan_de_InvestigacionMainModel
    {
        public Plan_de_InvestigacionModel Plan_de_InvestigacionInfo { set; get; }
        public Detalle_Plan_Actos_de_InvestigacionGridModelPost Detalle_Plan_Actos_de_InvestigacionGridInfo { set; get; }

    }

    public class Detalle_Plan_Actos_de_InvestigacionGridModelPost
    {
        public int Clave { get; set; }
        public short? Categoria { get; set; }
        public int? Servicio_a_Solicitar { get; set; }
        public string Hecho_Delictivo_Acreditado { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }
        public string Fecha_Contestacion { get; set; }
        public string Hora_Contestacion { get; set; }
        public string Contestacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoInfo { set; get; }
        public int? Usuario_que_Contesta { get; set; }

        public bool Removed { set; get; }
    }



}

