using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel
    {
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Suelo { get; set; }
        public string Descripcion { get; set; }
        public string Localizacion_1 { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Orientacion_de { get; set; }
        public string Orientacion_deDescripcion { get; set; }
        public int? Orientacion { get; set; }
        public string OrientacionDescripcion { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        
    }
}

