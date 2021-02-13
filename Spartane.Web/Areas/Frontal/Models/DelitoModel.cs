using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DelitoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Titulo_del_Delito { get; set; }
        public string Titulo_del_DelitoDescripcion { get; set; }
        public int? Grupo_del_Delito { get; set; }
        public string Grupo_del_DelitoDescripcion { get; set; }
        public string Descripcion { get; set; }
        public bool Grave { get; set; }
        public bool Alto_Impacto { get; set; }
        public bool Alta_Incidencia { get; set; }
        public bool Tentativa { get; set; }
        public bool Activo { get; set; }
        public bool Robo_de_Vehiculo { get; set; }
        [Range(0, 9999999999)]
        public int? delitox { get; set; }
        public string ARTICULO { get; set; }
        public string DETALLE { get; set; }
        [Range(0, 9999999999)]
        public int? TIPO_AGENCIA { get; set; }
        public string ESTADISTICO_SSP { get; set; }
        public string VAL_VEHICULO { get; set; }
        public string TIPO_DELITO { get; set; }
        [Range(0, 9999999999)]
        public int? circunstancia_clasif { get; set; }
        [Range(0, 9999999999)]
        public int? PRINCIPAL { get; set; }
        [Range(0, 9999999999)]
        public int? orden { get; set; }

    }
	
	public class Delito_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Titulo_del_Delito { get; set; }
        public string Titulo_del_DelitoDescripcion { get; set; }
        public int? Grupo_del_Delito { get; set; }
        public string Grupo_del_DelitoDescripcion { get; set; }
        public string Descripcion { get; set; }
        public bool? Grave { get; set; }
        public bool? Alto_Impacto { get; set; }
        public bool? Alta_Incidencia { get; set; }
        public bool? Tentativa { get; set; }
        public bool? Activo { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        [Range(0, 9999999999)]
        public int? delitox { get; set; }
        public string ARTICULO { get; set; }
        public string DETALLE { get; set; }
        [Range(0, 9999999999)]
        public int? TIPO_AGENCIA { get; set; }
        public string ESTADISTICO_SSP { get; set; }
        public string VAL_VEHICULO { get; set; }
        public string TIPO_DELITO { get; set; }
        [Range(0, 9999999999)]
        public int? circunstancia_clasif { get; set; }
        [Range(0, 9999999999)]
        public int? PRINCIPAL { get; set; }
        [Range(0, 9999999999)]
        public int? orden { get; set; }

    }


}

