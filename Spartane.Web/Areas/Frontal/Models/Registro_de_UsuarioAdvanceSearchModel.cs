using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_UsuarioAdvanceSearchModel
    {
        public Registro_de_UsuarioAdvanceSearchModel()
        {
            El_correo_fue_Validado = RadioOptions.NoApply;
            El_Celular_fue_Validado = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters NombresFilter { set; get; }
        public string Nombres { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        public Filters UsuarioFilter { set; get; }
        public string Usuario { set; get; }

        public Filters ContrasenaFilter { set; get; }
        public string Contrasena { set; get; }

        public Filters Confirmar_ContrasenaFilter { set; get; }
        public string Confirmar_Contrasena { set; get; }

        public Filters CorreoFilter { set; get; }
        public string Correo { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Codigo_Verificacion_CorreoFilter { set; get; }
        public string Codigo_Verificacion_Correo { set; get; }

        public Filters Codigo_Verificacion_CelularFilter { set; get; }
        public string Codigo_Verificacion_Celular { set; get; }

        public Filters Codigo_Reestablecer_ContrasenaFilter { set; get; }
        public string Codigo_Reestablecer_Contrasena { set; get; }

        public RadioOptions El_correo_fue_Validado { set; get; }

        public RadioOptions El_Celular_fue_Validado { set; get; }


    }
}
