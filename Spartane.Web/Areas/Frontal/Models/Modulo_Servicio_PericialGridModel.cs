using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_Servicio_PericialGridModel
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public int? Servicio_Pericial { get; set; }
        public string Servicio_PericialResponsable { get; set; }
        public int? Usuario_Asignado { get; set; }
        public string Usuario_AsignadoName { get; set; }
        public int? Modulo_Mecanismos_Alternos { get; set; }
        public string Modulo_Mecanismos_AlternosCDI { get; set; }
        public int? Modulo_Ministerio_Publico { get; set; }
        public string Modulo_Ministerio_Publiconic { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public string Descripcion { get; set; }
        
    }
}

