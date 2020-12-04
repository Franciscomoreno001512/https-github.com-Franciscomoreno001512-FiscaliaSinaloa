using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Plazo_de_Investigacion_ComplementariaResources
    {
        //private static IResourceProvider resourceProviderPlazo_de_Investigacion_Complementaria = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Plazo_de_Investigacion_ComplementariaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderPlazo_de_Investigacion_Complementaria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Plazo_de_Investigacion_ComplementariaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderPlazo_de_Investigacion_Complementaria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Plazo_de_Investigacion_ComplementariaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Plazo_de_Investigacion_Complementaria</summary>
        public static string Plazo_de_Investigacion_Complementaria
        {
            get
            {
                SetPath();
                return resourceProviderPlazo_de_Investigacion_Complementaria.GetResource("Plazo_de_Investigacion_Complementaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderPlazo_de_Investigacion_Complementaria.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderPlazo_de_Investigacion_Complementaria.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderPlazo_de_Investigacion_Complementaria.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
