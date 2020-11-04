using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Reporte_PrincipalGridModel
    {
        public int Clave { get; set; }
        public string Expediente { get; set; }
        public int? Total_de_Expedientes { get; set; }
        public string Fecha_de_Registro { get; set; }
        public int? Numero_de_Caso { get; set; }
        public int? Creciente { get; set; }
        public int? Folio { get; set; }
        
    }
}

