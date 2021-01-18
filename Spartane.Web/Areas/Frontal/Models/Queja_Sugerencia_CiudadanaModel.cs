using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Queja_Sugerencia_CiudadanaModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Registro { get; set; }
        public string Tipo_de_RegistroDescripcion { get; set; }
        public string Queja { get; set; }
        public string Sugerencia { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Motivo_de_Eliminacion { get; set; }
        public string Contestacion { get; set; }

    }
	
	public class Queja_Sugerencia_Ciudadana_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Registro { get; set; }
        public string Tipo_de_RegistroDescripcion { get; set; }
        public string Queja { get; set; }
        public string Sugerencia { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Motivo_de_Eliminacion { get; set; }
        public string Contestacion { get; set; }

    }


}

