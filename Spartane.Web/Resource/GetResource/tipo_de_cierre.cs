using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class tipo_de_cierreResources
    {
        //private static IResourceProvider resourceProvidertipo_de_cierre = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\tipo_de_cierreResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProvidertipo_de_cierre = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\tipo_de_cierreResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProvidertipo_de_cierre = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\tipo_de_cierreResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>tipo_de_cierre</summary>
        public static string tipo_de_cierre
        {
            get
            {
                SetPath();
                return resourceProvidertipo_de_cierre.GetResource("tipo_de_cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>clave</summary>
        public static string clave
        {
            get
            {
                SetPath();
                return resourceProvidertipo_de_cierre.GetResource("clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>descripcion</summary>
        public static string descripcion
        {
            get
            {
                SetPath();
                return resourceProvidertipo_de_cierre.GetResource("descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProvidertipo_de_cierre.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
