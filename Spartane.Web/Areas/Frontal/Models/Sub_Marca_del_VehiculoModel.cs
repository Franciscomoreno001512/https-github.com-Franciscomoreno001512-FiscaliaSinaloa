using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Sub_Marca_del_VehiculoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Marca_del_Vehiculo { get; set; }
        public string Marca_del_VehiculoDescripcion { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Sub_Marca_del_Vehiculo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Marca_del_Vehiculo { get; set; }
        public string Marca_del_VehiculoDescripcion { get; set; }
        public string Descripcion { get; set; }

    }


}

