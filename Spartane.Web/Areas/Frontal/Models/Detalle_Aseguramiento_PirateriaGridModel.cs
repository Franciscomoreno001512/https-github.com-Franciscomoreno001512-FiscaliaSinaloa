using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_PirateriaGridModel
    {
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public short? Unidad_de_Medicion { get; set; }
        public string Unidad_de_MedicionDescripcion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

