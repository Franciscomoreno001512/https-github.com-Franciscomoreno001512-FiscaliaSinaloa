using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Servicios_PericialesResources
    {
        //private static IResourceProvider resourceProviderServicios_Periciales = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Servicios_PericialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderServicios_Periciales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_PericialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderServicios_Periciales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Servicios_PericialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Servicios_Periciales</summary>
        public static string Servicios_Periciales
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Periciales.GetResource("Servicios_Periciales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Periciales.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio</summary>
        public static string Servicio
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Periciales.GetResource("Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rol_de_Donde_Proviene</summary>
        public static string Rol_de_Donde_Proviene
        {
            get
            {
                SetPath();
                return resourceProviderServicios_Periciales.GetResource("Rol_de_Donde_Proviene", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderServicios_Periciales.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
