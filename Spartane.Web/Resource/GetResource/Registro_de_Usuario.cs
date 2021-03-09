using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_UsuarioResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Usuario = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Usuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Usuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Usuario</summary>
        public static string Registro_de_Usuario
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Registro_de_Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres</summary>
        public static string Nombres
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Nombres", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contrasena</summary>
        public static string Contrasena
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Contrasena", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Confirmar_Contrasena</summary>
        public static string Confirmar_Contrasena
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Confirmar_Contrasena", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo</summary>
        public static string Correo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Correo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Verificacion_Correo</summary>
        public static string Codigo_Verificacion_Correo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Codigo_Verificacion_Correo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Verificacion_Celular</summary>
        public static string Codigo_Verificacion_Celular
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Codigo_Verificacion_Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Reestablecer_Contrasena</summary>
        public static string Codigo_Reestablecer_Contrasena
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("Codigo_Reestablecer_Contrasena", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>El_correo_fue_Validado</summary>
        public static string El_correo_fue_Validado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("El_correo_fue_Validado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>El_Celular_fue_Validado</summary>
        public static string El_Celular_fue_Validado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Usuario.GetResource("El_Celular_fue_Validado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Usuario.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos para Iniciar Sesión</summary>	public static string TabDatos_para_Iniciar_Sesion 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Usuario.GetResource("TabDatos_para_Iniciar_Sesion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos para validar tu cuenta</summary>	public static string TabDatos_para_validar_tu_cuenta 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Usuario.GetResource("TabDatos_para_validar_tu_cuenta", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Validación</summary>	public static string TabValidacion 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Usuario.GetResource("TabValidacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Lógica</summary>	public static string TabLogica 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Usuario.GetResource("TabLogica", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
