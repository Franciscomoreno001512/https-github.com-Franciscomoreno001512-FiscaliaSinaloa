using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Especifica_VehiculoResources
    {
        //private static IResourceProvider resourceProviderEspecifica_Vehiculo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Especifica_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderEspecifica_Vehiculo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Especifica_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderEspecifica_Vehiculo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Especifica_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Especifica_Vehiculo</summary>
        public static string Especifica_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderEspecifica_Vehiculo.GetResource("Especifica_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_Vehiculo</summary>
        public static string Circunstancia_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderEspecifica_Vehiculo.GetResource("Circunstancia_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderEspecifica_Vehiculo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderEspecifica_Vehiculo.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderEspecifica_Vehiculo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
