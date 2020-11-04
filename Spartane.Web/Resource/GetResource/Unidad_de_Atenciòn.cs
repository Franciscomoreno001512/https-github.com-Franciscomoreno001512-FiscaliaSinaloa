using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Unidad_de_AtenciònResources
    {
        //private static IResourceProvider resourceProviderUnidad_de_Atenciòn = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Unidad_de_AtenciònResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderUnidad_de_Atenciòn = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Unidad_de_AtenciònResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderUnidad_de_Atenciòn = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Unidad_de_AtenciònResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Unidad_de_Atenciòn</summary>
        public static string Unidad_de_Atenciòn
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Atenciòn.GetResource("Unidad_de_Atenciòn", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Atenciòn.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Atenciòn.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUnidad_de_Atenciòn.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
