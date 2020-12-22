using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class CanalizacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Expediente_AT { get; set; }
        public string Expediente_ATFolio { get; set; }
        public string Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? Usuario_que_Canaliza { get; set; }
        public string Usuario_que_CanalizaName { get; set; }
        public int? Relacion_a_Canalizar { get; set; }
        public string Relacion_a_CanalizarDescripcion { get; set; }
        public int? Canalizar_a { get; set; }
        public string Canalizar_aDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public string Fecha_de_Resolucion { get; set; }
        public string Hora_de_Resolucion { get; set; }
        public bool Hubo_modificacion_en_la_relacion { get; set; }
        public string Nueva_Relacion { get; set; }
        [Range(0, 9999999999)]
        public int? ResolucionId { get; set; }
        public string Resolucion { get; set; }
        public string Detalle_de_la_Resolucion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Canalizacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Expediente_AT { get; set; }
        public string Expediente_ATFolio { get; set; }
        public string Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? Usuario_que_Canaliza { get; set; }
        public string Usuario_que_CanalizaName { get; set; }
        public int? Relacion_a_Canalizar { get; set; }
        public string Relacion_a_CanalizarDescripcion { get; set; }
        public int? Canalizar_a { get; set; }
        public string Canalizar_aDescripcion { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }

    }

	public class Canalizacion_ResolucionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Resolucion { get; set; }
        public string Hora_de_Resolucion { get; set; }
        public bool? Hubo_modificacion_en_la_relacion { get; set; }
        public string Nueva_Relacion { get; set; }
        [Range(0, 9999999999)]
        public int? ResolucionId { get; set; }
        public string Resolucion { get; set; }
        public string Detalle_de_la_Resolucion { get; set; }
        public string Observaciones { get; set; }

    }


}

