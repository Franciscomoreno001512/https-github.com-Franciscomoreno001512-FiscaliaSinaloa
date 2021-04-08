using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Contestacion_de_Portal_CiudadanoResources
    {
        //private static IResourceProvider resourceProviderContestacion_de_Portal_Ciudadano = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Contestacion_de_Portal_CiudadanoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderContestacion_de_Portal_Ciudadano = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Contestacion_de_Portal_CiudadanoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderContestacion_de_Portal_Ciudadano = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Contestacion_de_Portal_CiudadanoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Contestacion_de_Portal_Ciudadano</summary>
        public static string Contestacion_de_Portal_Ciudadano
        {
            get
            {
                SetPath();
                return resourceProviderContestacion_de_Portal_Ciudadano.GetResource("Contestacion_de_Portal_Ciudadano", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderContestacion_de_Portal_Ciudadano.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderContestacion_de_Portal_Ciudadano.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderContestacion_de_Portal_Ciudadano.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
