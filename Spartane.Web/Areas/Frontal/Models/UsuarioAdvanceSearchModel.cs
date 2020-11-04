using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class UsuarioAdvanceSearchModel
    {
        public UsuarioAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters NombreFilter { set; get; }
        public string AdvanceNombre { set; get; }
        public int[] AdvanceNombreMultiple { set; get; }

        public Filters Clave_de_AccesoFilter { set; get; }
        public string Clave_de_Acceso { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromGrupo_de_Usuario { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromGrupo_de_Usuario", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToGrupo_de_Usuario { set; get; }

        public Filters Numero_de_EmpleadoFilter { set; get; }
        public string Numero_de_Empleado { set; get; }

        public Filters Correo_InstitucionalFilter { set; get; }
        public string Correo_Institucional { set; get; }

        public Filters CUIPFilter { set; get; }
        public string CUIP { set; get; }

        public Filters DelegacionFilter { set; get; }
        public string AdvanceDelegacion { set; get; }
        public int[] AdvanceDelegacionMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCarga_de_Trabajo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCarga_de_Trabajo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCarga_de_Trabajo { set; get; }

        public Filters Nombre_RemitenteFilter { set; get; }
        public string Nombre_Remitente { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters AgenciaFilter { set; get; }
        public string AdvanceAgencia { set; get; }
        public int[] AdvanceAgenciaMultiple { set; get; }

        public Filters EspecialidadFilter { set; get; }
        public string AdvanceEspecialidad { set; get; }
        public int[] AdvanceEspecialidadMultiple { set; get; }

        public Filters ID_de_DispositivoFilter { set; get; }
        public string ID_de_Dispositivo { set; get; }

        public Filters ID_de_HuellaFilter { set; get; }
        public string ID_de_Huella { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFotografia { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFotografia", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFotografia { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromUsuario_que_Registra { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromUsuario_que_Registra", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToUsuario_que_Registra { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Estatus_de_RegistroFilter { set; get; }
        public string Estatus_de_Registro { set; get; }


    }
}
