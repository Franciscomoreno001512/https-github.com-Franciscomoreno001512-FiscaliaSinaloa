using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Submarca_de_medio_de_transporteResources
    {
        //private static IResourceProvider resourceProviderSubmarca_de_medio_de_transporte = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Submarca_de_medio_de_transporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSubmarca_de_medio_de_transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Submarca_de_medio_de_transporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSubmarca_de_medio_de_transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Submarca_de_medio_de_transporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Submarca_de_medio_de_transporte</summary>
        public static string Submarca_de_medio_de_transporte
        {
            get
            {
                SetPath();
                return resourceProviderSubmarca_de_medio_de_transporte.GetResource("Submarca_de_medio_de_transporte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSubmarca_de_medio_de_transporte.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderSubmarca_de_medio_de_transporte.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSubmarca_de_medio_de_transporte.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
