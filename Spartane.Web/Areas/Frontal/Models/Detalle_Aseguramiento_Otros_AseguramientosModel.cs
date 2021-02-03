using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Otros_AseguramientosModel
    {
        [Required]
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
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Detalle_Aseguramiento_Otros_Aseguramientos_Datos_GeneralesModel
    {
        [Required]
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
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }

    }


}

