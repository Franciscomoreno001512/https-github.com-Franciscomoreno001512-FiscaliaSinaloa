using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Catalogo_Tipo_de_Cargo_CCResources
    {
        //private static IResourceProvider resourceProviderCatalogo_Tipo_de_Cargo_CC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Catalogo_Tipo_de_Cargo_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCatalogo_Tipo_de_Cargo_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_Tipo_de_Cargo_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCatalogo_Tipo_de_Cargo_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_Tipo_de_Cargo_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Catalogo_Tipo_de_Cargo_CC</summary>
        public static string Catalogo_Tipo_de_Cargo_CC
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Tipo_de_Cargo_CC.GetResource("Catalogo_Tipo_de_Cargo_CC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Tipo_de_Cargo_CC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Cargo</summary>
        public static string Tipo_de_Cargo
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Tipo_de_Cargo_CC.GetResource("Tipo_de_Cargo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCatalogo_Tipo_de_Cargo_CC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
