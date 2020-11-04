using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Fotos_CCResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Fotos_CC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Fotos_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Fotos_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Fotos_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Fotos_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Fotos_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Fotos_CC</summary>
        public static string Detalle_de_Fotos_CC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos_CC.GetResource("Detalle_de_Fotos_CC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos_CC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fotos</summary>
        public static string Fotos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos_CC.GetResource("Fotos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pie_de_Foto</summary>
        public static string Pie_de_Foto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Fotos_CC.GetResource("Pie_de_Foto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Fotos_CC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
