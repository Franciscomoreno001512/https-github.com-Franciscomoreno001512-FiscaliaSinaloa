using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Institucion_EmisoraResources
    {
        //private static IResourceProvider resourceProviderInstitucion_Emisora = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Institucion_EmisoraResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderInstitucion_Emisora = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Institucion_EmisoraResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderInstitucion_Emisora = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Institucion_EmisoraResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Institucion_Emisora</summary>
        public static string Institucion_Emisora
        {
            get
            {
                SetPath();
                return resourceProviderInstitucion_Emisora.GetResource("Institucion_Emisora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderInstitucion_Emisora.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderInstitucion_Emisora.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderInstitucion_Emisora.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
