using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Requeridos_que_no_AsistenResources
    {
        //private static IResourceProvider resourceProviderRequeridos_que_no_Asisten = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Requeridos_que_no_AsistenResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRequeridos_que_no_Asisten = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Requeridos_que_no_AsistenResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRequeridos_que_no_Asisten = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Requeridos_que_no_AsistenResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Requeridos_que_no_Asisten</summary>
        public static string Requeridos_que_no_Asisten
        {
            get
            {
                SetPath();
                return resourceProviderRequeridos_que_no_Asisten.GetResource("Requeridos_que_no_Asisten", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRequeridos_que_no_Asisten.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requeridos</summary>
        public static string Requeridos
        {
            get
            {
                SetPath();
                return resourceProviderRequeridos_que_no_Asisten.GetResource("Requeridos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderRequeridos_que_no_Asisten.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRequeridos_que_no_Asisten.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
