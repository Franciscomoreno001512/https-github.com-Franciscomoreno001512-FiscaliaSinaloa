using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_PlantiosGridModel
    {
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public int? No__de_Plantios { get; set; }
        public decimal? Kilogramos { get; set; }
        public short? Metodo_de_Destruccion { get; set; }
        public string Metodo_de_DestruccionDescripcion { get; set; }
        public string Superficie { get; set; }
        public string Altura { get; set; }
        public string Densidad { get; set; }
        public string Peso_por_planta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        
    }
}

