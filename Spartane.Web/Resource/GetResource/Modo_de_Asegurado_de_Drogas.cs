using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Modo_de_Asegurado_de_DrogasResources
    {
        //private static IResourceProvider resourceProviderModo_de_Asegurado_de_Drogas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Modo_de_Asegurado_de_DrogasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderModo_de_Asegurado_de_Drogas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modo_de_Asegurado_de_DrogasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderModo_de_Asegurado_de_Drogas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modo_de_Asegurado_de_DrogasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Modo_de_Asegurado_de_Drogas</summary>
        public static string Modo_de_Asegurado_de_Drogas
        {
            get
            {
                SetPath();
                return resourceProviderModo_de_Asegurado_de_Drogas.GetResource("Modo_de_Asegurado_de_Drogas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderModo_de_Asegurado_de_Drogas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderModo_de_Asegurado_de_Drogas.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderModo_de_Asegurado_de_Drogas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
