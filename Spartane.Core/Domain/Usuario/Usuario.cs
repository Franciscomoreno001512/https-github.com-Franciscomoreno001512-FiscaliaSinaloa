using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Especialidad_MP;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Usuario
{
    /// <summary>
    /// Usuario table
    /// </summary>
    public class Usuario: BaseEntity
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string Clave_de_Acceso { get; set; }
        public short? Grupo_de_Usuario { get; set; }
        public string Numero_de_Empleado { get; set; }
        public string Correo_Institucional { get; set; }
        public string CUIP { get; set; }
        public int? Delegacion { get; set; }
        public short? Carga_de_Trabajo { get; set; }
        public string Nombre_Remitente { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public int? Agencia { get; set; }
        public int? Especialidad { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public string ID_de_Huella { get; set; }
        public short? Fotografia { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Estatus_de_Registro { get; set; }

        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Nombre_Spartan_User { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }
        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad_MP.Especialidad_MP Especialidad_Especialidad_MP { get; set; }

    }
	
	public class Usuario_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string Clave_de_Acceso { get; set; }
        public short? Grupo_de_Usuario { get; set; }
        public string Numero_de_Empleado { get; set; }
        public string Correo_Institucional { get; set; }
        public string CUIP { get; set; }
        public int? Delegacion { get; set; }
        public short? Carga_de_Trabajo { get; set; }
        public string Nombre_Remitente { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public int? Agencia { get; set; }
        public int? Especialidad { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public string ID_de_Huella { get; set; }
        public short? Fotografia { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Estatus_de_Registro { get; set; }

		        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Nombre_Spartan_User { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }
        [ForeignKey("Especialidad")]
        public virtual Spartane.Core.Domain.Especialidad_MP.Especialidad_MP Especialidad_Especialidad_MP { get; set; }

    }


}

