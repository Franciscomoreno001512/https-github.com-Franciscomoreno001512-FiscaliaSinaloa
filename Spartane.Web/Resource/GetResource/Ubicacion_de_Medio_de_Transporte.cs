using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Ubicacion_de_Medio_de_TransporteResources
    {
        //private static IResourceProvider resourceProviderUbicacion_de_Medio_de_Transporte = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Ubicacion_de_Medio_de_TransporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderUbicacion_de_Medio_de_Transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Ubicacion_de_Medio_de_TransporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderUbicacion_de_Medio_de_Transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Ubicacion_de_Medio_de_TransporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Ubicacion_de_Medio_de_Transporte</summary>
        public static string Ubicacion_de_Medio_de_Transporte
        {
            get
            {
                SetPath();
                return resourceProviderUbicacion_de_Medio_de_Transporte.GetResource("Ubicacion_de_Medio_de_Transporte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderUbicacion_de_Medio_de_Transporte.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderUbicacion_de_Medio_de_Transporte.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUbicacion_de_Medio_de_Transporte.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
