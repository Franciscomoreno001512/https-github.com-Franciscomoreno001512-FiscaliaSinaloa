using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Resolucion_de_Mandamiento_JudicialResources
    {
        //private static IResourceProvider resourceProviderResolucion_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Resolucion_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderResolucion_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderResolucion_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Resolucion_de_Mandamiento_Judicial</summary>
        public static string Resolucion_de_Mandamiento_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_de_Mandamiento_Judicial.GetResource("Resolucion_de_Mandamiento_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_de_Mandamiento_Judicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_de_Mandamiento_Judicial.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderResolucion_de_Mandamiento_Judicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
