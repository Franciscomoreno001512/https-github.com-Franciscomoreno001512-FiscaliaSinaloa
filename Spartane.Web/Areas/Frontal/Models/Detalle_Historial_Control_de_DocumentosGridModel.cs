using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Historial_Control_de_DocumentosGridModel
    {
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Modificaciones_Realizadas { get; set; }
        public string Cuerpo_del_Documento { get; set; }
        
    }
}

