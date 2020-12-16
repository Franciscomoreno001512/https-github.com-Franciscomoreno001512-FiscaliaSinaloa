using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Electronicos_y_MultimediaModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Aparatos { get; set; }
        public string AparatosDescripcion { get; set; }
        public short? Documentos_Multimedia { get; set; }
        public string Documentos_MultimediaDescripcion { get; set; }
        public string Descripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string A_resguardo { get; set; }

    }
	
	public class Detalle_Aseguramiento_Electronicos_y_Multimedia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public short? Aparatos { get; set; }
        public string AparatosDescripcion { get; set; }
        public short? Documentos_Multimedia { get; set; }
        public string Documentos_MultimediaDescripcion { get; set; }
        public string Descripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string A_resguardo { get; set; }

    }


}

