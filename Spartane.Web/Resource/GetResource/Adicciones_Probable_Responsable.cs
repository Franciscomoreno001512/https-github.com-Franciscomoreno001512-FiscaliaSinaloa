using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Adicciones_Probable_ResponsableResources
    {
        //private static IResourceProvider resourceProviderAdicciones_Probable_Responsable = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Adicciones_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAdicciones_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Adicciones_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAdicciones_Probable_Responsable = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Adicciones_Probable_ResponsableResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Adicciones_Probable_Responsable</summary>
        public static string Adicciones_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderAdicciones_Probable_Responsable.GetResource("Adicciones_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAdicciones_Probable_Responsable.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAdicciones_Probable_Responsable.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAdicciones_Probable_Responsable.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
