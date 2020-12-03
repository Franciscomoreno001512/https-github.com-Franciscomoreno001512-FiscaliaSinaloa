using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Objetos_AseguradosGridModel
    {
        public int Clave { get; set; }
        public string Numero { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public string Serie { get; set; }
        public string IMEI { get; set; }
        
    }
}

