using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DelitoGridModel
    {
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
        public int? delitox { get; set; }
        public string ARTICULO { get; set; }
        public string DETALLE { get; set; }
        public int? TIPO_AGENCIA { get; set; }
        public string ESTADISTICO_SSP { get; set; }
        public string VAL_VEHICULO { get; set; }
        public string TIPO_DELITO { get; set; }
        public int? circunstancia_clasif { get; set; }
        public int? PRINCIPAL { get; set; }
        public int? orden { get; set; }
        
    }
}

