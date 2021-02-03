using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Otros_AseguramientosGridModel
    {
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public int? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Inventario { get; set; }
        public string Serie { get; set; }
        public short? Unidad_de_Medida { get; set; }
        public string Unidad_de_MedidaDescripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        
    }
}

