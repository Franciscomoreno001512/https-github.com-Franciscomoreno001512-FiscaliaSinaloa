using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Plan_Actos_de_InvestigacionGridModel
    {
        public int Clave { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Servicio_a_Solicitar { get; set; }
        public string Servicio_a_SolicitarServicio { get; set; }
        public string Hecho_Delictivo_Acreditado { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }
        public string Fecha_Contestacion { get; set; }
        public string Hora_Contestacion { get; set; }
        public string Contestacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        public int? Usuario_que_Contesta { get; set; }
        public string Usuario_que_ContestaName { get; set; }
        
    }
}

