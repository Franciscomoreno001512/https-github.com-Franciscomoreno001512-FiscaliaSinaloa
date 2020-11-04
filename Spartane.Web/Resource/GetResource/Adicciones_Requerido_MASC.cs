using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Adicciones_Requerido_MASCResources
    {
        //private static IResourceProvider resourceProviderAdicciones_Requerido_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Adicciones_Requerido_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAdicciones_Requerido_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Adicciones_Requerido_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAdicciones_Requerido_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Adicciones_Requerido_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Adicciones_Requerido_MASC</summary>
        public static string Adicciones_Requerido_MASC
        {
            get
            {
                SetPath();
                return resourceProviderAdicciones_Requerido_MASC.GetResource("Adicciones_Requerido_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAdicciones_Requerido_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAdicciones_Requerido_MASC.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAdicciones_Requerido_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
