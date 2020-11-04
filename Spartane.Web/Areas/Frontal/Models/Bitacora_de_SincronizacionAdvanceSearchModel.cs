using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Bitacora_de_SincronizacionAdvanceSearchModel
    {
        public Bitacora_de_SincronizacionAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters ID_DispositivoFilter { set; get; }
        public string ID_Dispositivo { set; get; }

        public Filters UsuarioFilter { set; get; }
        public string AdvanceUsuario { set; get; }
        public int[] AdvanceUsuarioMultiple { set; get; }

        public Filters Nombre_de_la_TablaFilter { set; get; }
        public string Nombre_de_la_Tabla { set; get; }

        public Filters Estatus_de_ReplicacionFilter { set; get; }
        public string AdvanceEstatus_de_Replicacion { set; get; }
        public int[] AdvanceEstatus_de_ReplicacionMultiple { set; get; }


    }
}
