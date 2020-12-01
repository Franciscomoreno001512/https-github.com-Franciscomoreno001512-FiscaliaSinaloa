using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configuracion_de_PlaneacionGridModel
    {
        public int Folio { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        public string Entregable { get; set; }
        public short? Tiempo_Estandar { get; set; }
        public short? Ponderacion { get; set; }
        
    }
}

