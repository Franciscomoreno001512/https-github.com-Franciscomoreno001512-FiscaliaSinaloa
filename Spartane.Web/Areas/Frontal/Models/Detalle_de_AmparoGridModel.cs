using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_AmparoGridModel
    {
        public int Clave { get; set; }
        public int? Orden_de_Aprehension { get; set; }
        public string Orden_de_AprehensionNumero_de_Mandamiento { get; set; }
        public int? Tipo_de_Amparo { get; set; }
        public string Tipo_de_AmparoDescripcion { get; set; }
        public string Numero_de_Amparo { get; set; }
        public string Fecha_Amparo { get; set; }
        public int? Entidad_que_Emitio_Amparo { get; set; }
        public string Entidad_que_Emitio_AmparoNombre { get; set; }
        public int? Resolucion { get; set; }
        public string ResolucionDescripcion { get; set; }
        
    }
}

