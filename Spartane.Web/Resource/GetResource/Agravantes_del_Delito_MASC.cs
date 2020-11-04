using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Agravantes_del_Delito_MASCResources
    {
        //private static IResourceProvider resourceProviderAgravantes_del_Delito_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Agravantes_del_Delito_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAgravantes_del_Delito_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Agravantes_del_Delito_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAgravantes_del_Delito_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Agravantes_del_Delito_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Agravantes_del_Delito_MASC</summary>
        public static string Agravantes_del_Delito_MASC
        {
            get
            {
                SetPath();
                return resourceProviderAgravantes_del_Delito_MASC.GetResource("Agravantes_del_Delito_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAgravantes_del_Delito_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agravante</summary>
        public static string Agravante
        {
            get
            {
                SetPath();
                return resourceProviderAgravantes_del_Delito_MASC.GetResource("Agravante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAgravantes_del_Delito_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
