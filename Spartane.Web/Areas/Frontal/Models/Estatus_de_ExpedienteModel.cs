using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Estatus_de_ExpedienteModel
    {
        [Required]
        public int Clave { get; set; }
        public string Estatus_General { get; set; }
        public string Estatus_Especifico { get; set; }
        public string Estatus_Tipo_Caso { get; set; }
        public string Estatus_Descripcion_General { get; set; }
        public string Estatus_Descripcion_Especifico { get; set; }
        public string Estatus_Completo { get; set; }

    }
	
	public class Estatus_de_Expediente_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Estatus_General { get; set; }
        public string Estatus_Especifico { get; set; }
        public string Estatus_Tipo_Caso { get; set; }
        public string Estatus_Descripcion_General { get; set; }
        public string Estatus_Descripcion_Especifico { get; set; }
        public string Estatus_Completo { get; set; }

    }


}

