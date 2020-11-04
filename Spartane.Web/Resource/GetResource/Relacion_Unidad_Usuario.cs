using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Relacion_Unidad_UsuarioResources
    {
        //private static IResourceProvider resourceProviderRelacion_Unidad_Usuario = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Relacion_Unidad_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRelacion_Unidad_Usuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Relacion_Unidad_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRelacion_Unidad_Usuario = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Relacion_Unidad_UsuarioResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Relacion_Unidad_Usuario</summary>
        public static string Relacion_Unidad_Usuario
        {
            get
            {
                SetPath();
                return resourceProviderRelacion_Unidad_Usuario.GetResource("Relacion_Unidad_Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRelacion_Unidad_Usuario.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderRelacion_Unidad_Usuario.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderRelacion_Unidad_Usuario.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRelacion_Unidad_Usuario.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
