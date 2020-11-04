using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Catalogo_Unidad_PolicialResources
    {
        //private static IResourceProvider resourceProviderCatalogo_Unidad_Policial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Catalogo_Unidad_PolicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCatalogo_Unidad_Policial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_Unidad_PolicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCatalogo_Unidad_Policial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_Unidad_PolicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Catalogo_Unidad_Policial</summary>
        public static string Catalogo_Unidad_Policial
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Unidad_Policial.GetResource("Catalogo_Unidad_Policial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Unidad_Policial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_Policial</summary>
        public static string Unidad_Policial
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_Unidad_Policial.GetResource("Unidad_Policial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCatalogo_Unidad_Policial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	} 
    }
}
