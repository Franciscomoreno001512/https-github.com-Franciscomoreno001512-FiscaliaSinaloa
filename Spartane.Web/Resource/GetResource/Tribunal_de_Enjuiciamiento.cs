using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Tribunal_de_EnjuiciamientoResources
    {
        //private static IResourceProvider resourceProviderTribunal_de_Enjuiciamiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Tribunal_de_EnjuiciamientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderTribunal_de_Enjuiciamiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Tribunal_de_EnjuiciamientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderTribunal_de_Enjuiciamiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Tribunal_de_EnjuiciamientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Tribunal_de_Enjuiciamiento</summary>
        public static string Tribunal_de_Enjuiciamiento
        {
            get
            {
                SetPath();
                return resourceProviderTribunal_de_Enjuiciamiento.GetResource("Tribunal_de_Enjuiciamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderTribunal_de_Enjuiciamiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderTribunal_de_Enjuiciamiento.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderTribunal_de_Enjuiciamiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
