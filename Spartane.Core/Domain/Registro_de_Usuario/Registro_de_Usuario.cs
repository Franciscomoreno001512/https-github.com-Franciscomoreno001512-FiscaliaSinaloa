using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Registro_de_Usuario
{
    /// <summary>
    /// Registro_de_Usuario table
    /// </summary>
    public class Registro_de_Usuario: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Confirmar_Contrasena { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Codigo_Verificacion_Correo { get; set; }
        public string Codigo_Verificacion_Celular { get; set; }
        public string Codigo_Reestablecer_Contrasena { get; set; }
        public bool? El_correo_fue_Validado { get; set; }
        public bool? El_Celular_fue_Validado { get; set; }


    }
	
	public class Registro_de_Usuario_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }

		
    }

	public class Registro_de_Usuario_Datos_para_Iniciar_Sesion
    {
                public int Clave { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Confirmar_Contrasena { get; set; }

		
    }

	public class Registro_de_Usuario_Datos_para_validar_tu_cuenta
    {
                public int Clave { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }

		
    }

	public class Registro_de_Usuario_Validacion
    {
                public int Clave { get; set; }
        public string Codigo_Verificacion_Correo { get; set; }
        public string Codigo_Verificacion_Celular { get; set; }
        public string Codigo_Reestablecer_Contrasena { get; set; }

		
    }

	public class Registro_de_Usuario_Logica
    {
                public int Clave { get; set; }
        public bool? El_correo_fue_Validado { get; set; }
        public bool? El_Celular_fue_Validado { get; set; }

		
    }


}

