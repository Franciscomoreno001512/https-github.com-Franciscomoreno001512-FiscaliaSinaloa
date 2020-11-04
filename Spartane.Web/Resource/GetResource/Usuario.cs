using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class UsuarioResources
    {
        //private static IResourceProvider resourceProviderUsuario = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderUsuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderUsuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_de_Acceso</summary>
        public static string Clave_de_Acceso
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Clave_de_Acceso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_de_Usuario</summary>
        public static string Grupo_de_Usuario
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Grupo_de_Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Empleado</summary>
        public static string Numero_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Numero_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Institucional</summary>
        public static string Correo_Institucional
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Correo_Institucional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CUIP</summary>
        public static string CUIP
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("CUIP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delegacion</summary>
        public static string Delegacion
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Delegacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carga_de_Trabajo</summary>
        public static string Carga_de_Trabajo
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Carga_de_Trabajo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Remitente</summary>
        public static string Nombre_Remitente
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Nombre_Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agencia</summary>
        public static string Agencia
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Agencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_de_Dispositivo</summary>
        public static string ID_de_Dispositivo
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("ID_de_Dispositivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_de_Huella</summary>
        public static string ID_de_Huella
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("ID_de_Huella", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fotografia</summary>
        public static string Fotografia
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Fotografia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folios_Asignados</summary>
        public static string Folios_Asignados
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Folios_Asignados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Registro</summary>
        public static string Estatus_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderUsuario.GetResource("Estatus_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUsuario.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
