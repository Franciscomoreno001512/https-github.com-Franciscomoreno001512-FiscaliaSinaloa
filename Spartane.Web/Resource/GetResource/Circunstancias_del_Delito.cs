using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Circunstancias_del_DelitoResources
    {
        //private static IResourceProvider resourceProviderCircunstancias_del_Delito = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Circunstancias_del_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCircunstancias_del_Delito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Circunstancias_del_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCircunstancias_del_Delito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Circunstancias_del_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Circunstancias_del_Delito</summary>
        public static string Circunstancias_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancias_del_Delito.GetResource("Circunstancias_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancias_del_Delito.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar</summary>
        public static string Tipo_de_Lugar
        {
            get
            {
                SetPath();
                return resourceProviderCircunstancias_del_Delito.GetResource("Tipo_de_Lugar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCircunstancias_del_Delito.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
