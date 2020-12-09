using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Situacion_FisicaResources
    {
        //private static IResourceProvider resourceProviderSituacion_Fisica = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Situacion_FisicaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSituacion_Fisica = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Situacion_FisicaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSituacion_Fisica = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Situacion_FisicaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderSituacion_Fisica.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSituacion_Fisica.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderSituacion_Fisica.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Justicia</summary>
        public static string Justicia
        {
            get
            {
                SetPath();
                return resourceProviderSituacion_Fisica.GetResource("Justicia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSituacion_Fisica.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
