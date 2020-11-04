using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Catalogo_de_Inicio_de_Cadena_de_CustodiaResources
    {
        //private static IResourceProvider resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Catalogo_de_Inicio_de_Cadena_de_CustodiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_de_Inicio_de_Cadena_de_CustodiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Catalogo_de_Inicio_de_Cadena_de_CustodiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Catalogo_de_Inicio_de_Cadena_de_Custodia</summary>
        public static string Catalogo_de_Inicio_de_Cadena_de_Custodia
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia.GetResource("Catalogo_de_Inicio_de_Cadena_de_Custodia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCatalogo_de_Inicio_de_Cadena_de_Custodia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
