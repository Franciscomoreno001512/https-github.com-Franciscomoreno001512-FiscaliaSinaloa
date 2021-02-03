using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_MonedaModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public short? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }

    }
	
	public class Detalle_Aseguramiento_Moneda_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public short? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }

    }


}

