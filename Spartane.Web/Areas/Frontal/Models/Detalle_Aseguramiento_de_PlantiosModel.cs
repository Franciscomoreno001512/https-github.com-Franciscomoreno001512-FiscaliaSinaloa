using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_PlantiosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? No__de_Plantios { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Kilogramos { get; set; }
        public short? Metodo_de_Destruccion { get; set; }
        public string Metodo_de_DestruccionDescripcion { get; set; }
        public string Superficie { get; set; }
        public string Altura { get; set; }
        public string Densidad { get; set; }
        public string Peso_por_planta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Largo { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Ancho { get; set; }

    }
	
	public class Detalle_Aseguramiento_de_Plantios_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? No__de_Plantios { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Kilogramos { get; set; }
        public short? Metodo_de_Destruccion { get; set; }
        public string Metodo_de_DestruccionDescripcion { get; set; }
        public string Superficie { get; set; }
        public string Altura { get; set; }
        public string Densidad { get; set; }
        public string Peso_por_planta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Largo { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Ancho { get; set; }

    }


}

