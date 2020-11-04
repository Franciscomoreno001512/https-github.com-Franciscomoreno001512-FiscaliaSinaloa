using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class TTFolioConsecutivoResources
    {
        //private static IResourceProvider resourceProviderTTFolioConsecutivo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\TTFolioConsecutivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderTTFolioConsecutivo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\TTFolioConsecutivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderTTFolioConsecutivo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\TTFolioConsecutivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>TTFolioConsecutivo</summary>
        public static string TTFolioConsecutivo
        {
            get
            {
                SetPath();
                return resourceProviderTTFolioConsecutivo.GetResource("TTFolioConsecutivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderTTFolioConsecutivo.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Texto</summary>
        public static string Texto
        {
            get
            {
                SetPath();
                return resourceProviderTTFolioConsecutivo.GetResource("Texto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderTTFolioConsecutivo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
