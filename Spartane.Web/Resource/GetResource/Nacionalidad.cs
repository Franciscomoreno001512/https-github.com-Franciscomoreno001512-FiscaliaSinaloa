using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class NacionalidadResources
    {
        //private static IResourceProvider resourceProviderNacionalidad = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\NacionalidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderNacionalidad = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\NacionalidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderNacionalidad = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\NacionalidadResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderNacionalidad.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderNacionalidad.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NacionalidadC</summary>
        public static string NacionalidadC
        {
            get
            {
                SetPath();
                return resourceProviderNacionalidad.GetResource("NacionalidadC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_Estadistica</summary>
        public static string Descripcion_Estadistica
        {
            get
            {
                SetPath();
                return resourceProviderNacionalidad.GetResource("Descripcion_Estadistica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderNacionalidad.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
