using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Aparato_Electronicos_y_MultimediaResources
    {
        //private static IResourceProvider resourceProviderAparato_Electronicos_y_Multimedia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Aparato_Electronicos_y_MultimediaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAparato_Electronicos_y_Multimedia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Aparato_Electronicos_y_MultimediaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAparato_Electronicos_y_Multimedia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Aparato_Electronicos_y_MultimediaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Aparato_Electronicos_y_Multimedia</summary>
        public static string Aparato_Electronicos_y_Multimedia
        {
            get
            {
                SetPath();
                return resourceProviderAparato_Electronicos_y_Multimedia.GetResource("Aparato_Electronicos_y_Multimedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAparato_Electronicos_y_Multimedia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAparato_Electronicos_y_Multimedia.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAparato_Electronicos_y_Multimedia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
