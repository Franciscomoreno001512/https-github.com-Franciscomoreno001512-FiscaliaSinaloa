using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Configuracion_de_Servicios_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderConfiguracion_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Configuracion_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderConfiguracion_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Configuracion_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderConfiguracion_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Configuracion_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Configuracion_de_Servicios_de_Apoyo</summary>
        public static string Configuracion_de_Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Configuracion_de_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area</summary>
        public static string Area
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Area", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SubArea</summary>
        public static string SubArea
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("SubArea", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acreditada</summary>
        public static string Acreditada
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Acreditada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Centralizada</summary>
        public static string Centralizada
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Centralizada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitudes_Disponibles</summary>
        public static string Solicitudes_Disponibles
        {
            get
            {
                SetPath();
                return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("Solicitudes_Disponibles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderConfiguracion_de_Servicios_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
