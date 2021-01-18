using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Autoridad_Servicio_PericialResources
    {
        //private static IResourceProvider resourceProviderAutoridad_Servicio_Pericial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Autoridad_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAutoridad_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Autoridad_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAutoridad_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Autoridad_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Autoridad_Servicio_Pericial</summary>
        public static string Autoridad_Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderAutoridad_Servicio_Pericial.GetResource("Autoridad_Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAutoridad_Servicio_Pericial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAutoridad_Servicio_Pericial.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAutoridad_Servicio_Pericial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
