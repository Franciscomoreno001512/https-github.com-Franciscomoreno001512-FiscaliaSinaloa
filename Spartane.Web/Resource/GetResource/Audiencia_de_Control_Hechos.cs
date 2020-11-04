using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Audiencia_de_Control_HechosResources
    {
        //private static IResourceProvider resourceProviderAudiencia_de_Control_Hechos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Audiencia_de_Control_HechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAudiencia_de_Control_Hechos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_de_Control_HechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAudiencia_de_Control_Hechos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Audiencia_de_Control_HechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Audiencia_de_Control_Hechos</summary>
        public static string Audiencia_de_Control_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Hechos.GetResource("Audiencia_de_Control_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Hechos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAudiencia_de_Control_Hechos.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAudiencia_de_Control_Hechos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
