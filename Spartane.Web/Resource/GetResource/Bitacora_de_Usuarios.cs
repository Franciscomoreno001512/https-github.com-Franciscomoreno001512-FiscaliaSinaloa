using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Bitacora_de_UsuariosResources
    {
        //private static IResourceProvider resourceProviderBitacora_de_Usuarios = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Bitacora_de_UsuariosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderBitacora_de_Usuarios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Bitacora_de_UsuariosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderBitacora_de_Usuarios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Bitacora_de_UsuariosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Bitacora_de_Usuarios</summary>
        public static string Bitacora_de_Usuarios
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("Bitacora_de_Usuarios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Empleado</summary>
        public static string Numero_de_Empleado
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("Numero_de_Empleado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_de_Huella</summary>
        public static string ID_de_Huella
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("ID_de_Huella", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_de_Dispositivo</summary>
        public static string ID_de_Dispositivo
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("ID_de_Dispositivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Usuarios.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderBitacora_de_Usuarios.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
