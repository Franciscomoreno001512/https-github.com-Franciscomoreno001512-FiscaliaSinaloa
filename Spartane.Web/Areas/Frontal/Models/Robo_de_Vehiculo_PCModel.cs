using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Robo_de_Vehiculo_PCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudFolio { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public string Tipo_de_SolicitudDescripcion { get; set; }
        public bool Robo_de_Vehiculo { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Tipo_de_VehiculoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public string Senas_Particulares { get; set; }

    }
	
	public class Robo_de_Vehiculo_PC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudFolio { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public string Tipo_de_SolicitudDescripcion { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Tipo_de_VehiculoDescripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public string Senas_Particulares { get; set; }

    }


}

