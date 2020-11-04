using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Lugares_Frecuentes_Probable_ResponsableResources
    {
        //private static IResourceProvider resourceProviderLugares_Frecuentes_Probable_Responsable = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Lugares_Frecuentes_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderLugares_Frecuentes_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Lugares_Frecuentes_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderLugares_Frecuentes_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Lugares_Frecuentes_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Lugares_Frecuentes_Probable_Responsable</summary>
        public static string Lugares_Frecuentes_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderLugares_Frecuentes_Probable_Responsable.GetResource("Lugares_Frecuentes_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderLugares_Frecuentes_Probable_Responsable.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar</summary>
        public static string Tipo_de_Lugar
        {
            get
            {
                SetPath();
                return resourceProviderLugares_Frecuentes_Probable_Responsable.GetResource("Tipo_de_Lugar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderLugares_Frecuentes_Probable_Responsable.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderLugares_Frecuentes_Probable_Responsable.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
