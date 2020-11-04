using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Sentencias_Imputado_MPIGridModel
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Sentencia { get; set; }
        public string SentenciaDescripcion { get; set; }
        public string Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        public decimal? Repacion_del_Dano { get; set; }
        public string Resolucion { get; set; }
        
    }
}

