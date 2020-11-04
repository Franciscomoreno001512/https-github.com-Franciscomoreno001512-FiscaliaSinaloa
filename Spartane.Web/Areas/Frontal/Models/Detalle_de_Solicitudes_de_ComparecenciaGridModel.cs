using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitudes_de_ComparecenciaGridModel
    {
        public int Clave { get; set; }
        public short? Archivo { get; set; }
        public int? Nombre { get; set; }
        public string NombreDescripcion { get; set; }
        public string Fecha_de_la_Comparecencia { get; set; }
        public string Hora_de_la_Comparecencia { get; set; }
        
    }
}

