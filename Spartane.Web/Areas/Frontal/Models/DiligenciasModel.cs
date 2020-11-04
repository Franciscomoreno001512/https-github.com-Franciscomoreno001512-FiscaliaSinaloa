using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DiligenciasModel
    {
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        [Range(0, 9999999999)]
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Estatus_del_DictamenDescripcion { get; set; }
        public string Fecha_del_Dictamen { get; set; }
        [Range(0, 9999999999)]
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }
        [Required]
        public int Clave { get; set; }
        public string Clave_Diligencia { get; set; }

    }
	
	public class Diligencias_Datos_GeneralesModel
    {
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        [Range(0, 9999999999)]
        public int? Especialista { get; set; }
        public int? Estatus_del_Dictamen { get; set; }
        public string Estatus_del_DictamenDescripcion { get; set; }
        public string Fecha_del_Dictamen { get; set; }
        [Range(0, 9999999999)]
        public short? Dictamen { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }
        [Required]
        public int Clave { get; set; }
        public string Clave_Diligencia { get; set; }

    }


}

