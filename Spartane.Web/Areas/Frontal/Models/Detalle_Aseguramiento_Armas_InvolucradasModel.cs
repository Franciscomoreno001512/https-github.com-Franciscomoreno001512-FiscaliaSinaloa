using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Armas_InvolucradasModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public int? Tipo { get; set; }
        public string TipoNombre { get; set; }
        public string Descripcion_del_Arma { get; set; }
        public int? Marca { get; set; }
        public string MarcaNombre { get; set; }
        public short? Calibre { get; set; }
        public string CalibreDescripcion { get; set; }
        public string Matricula { get; set; }
        public string Serie { get; set; }
        public bool Arma_Oficial { get; set; }
        public string Inventario { get; set; }
        public int? Clasificacion { get; set; }
        public string ClasificacionDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Valor_Estimado { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Detalle_Aseguramiento_Armas_Involucradas_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public int? Tipo { get; set; }
        public string TipoNombre { get; set; }
        public string Descripcion_del_Arma { get; set; }
        public int? Marca { get; set; }
        public string MarcaNombre { get; set; }
        public short? Calibre { get; set; }
        public string CalibreDescripcion { get; set; }
        public string Matricula { get; set; }
        public string Serie { get; set; }
        public bool? Arma_Oficial { get; set; }
        public string Inventario { get; set; }
        public int? Clasificacion { get; set; }
        public string ClasificacionDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Valor_Estimado { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

    }


}

