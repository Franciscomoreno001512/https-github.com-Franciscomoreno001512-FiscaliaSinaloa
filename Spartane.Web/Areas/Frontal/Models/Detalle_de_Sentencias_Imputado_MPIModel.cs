using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Sentencias_Imputado_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Sentencia { get; set; }
        public string SentenciaDescripcion { get; set; }
        public string Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Repacion_del_Dano { get; set; }
        public string Resolucion { get; set; }

    }
	
	public class Detalle_de_Sentencias_Imputado_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Sentencia { get; set; }
        public string SentenciaDescripcion { get; set; }
        public string Fecha_de_Devolucion { get; set; }
        public string Hora_de_Devolucion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Repacion_del_Dano { get; set; }
        public string Resolucion { get; set; }

    }


}

