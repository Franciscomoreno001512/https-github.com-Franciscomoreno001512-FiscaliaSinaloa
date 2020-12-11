using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Objetos_AseguradosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public string Numero { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public string Serie { get; set; }
        public string IMEI { get; set; }

    }
	
	public class Detalle_Aseguramiento_Objetos_Asegurados_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public string Motivo_de_RegistroDescripcion { get; set; }
        public string Numero { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public string Serie { get; set; }
        public string IMEI { get; set; }

    }


}

