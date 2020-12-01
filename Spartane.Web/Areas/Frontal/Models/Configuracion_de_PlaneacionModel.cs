using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configuracion_de_PlaneacionModel
    {
        [Required]
        public int Folio { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        public string Entregable { get; set; }
        [Range(0, 9999999999)]
        public short? Tiempo_Estandar { get; set; }
        [Range(0, 9999999999)]
        public short? Ponderacion { get; set; }

    }
	
	public class Configuracion_de_Planeacion_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Servicio { get; set; }
        public string ServicioServicio { get; set; }
        public string Entregable { get; set; }
        [Range(0, 9999999999)]
        public short? Tiempo_Estandar { get; set; }
        [Range(0, 9999999999)]
        public short? Ponderacion { get; set; }

    }


}

