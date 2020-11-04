using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Aseguradora_de_VehiculoResources
    {
        //private static IResourceProvider resourceProviderAseguradora_de_Vehiculo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Aseguradora_de_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAseguradora_de_Vehiculo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Aseguradora_de_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAseguradora_de_Vehiculo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Aseguradora_de_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Aseguradora_de_Vehiculo</summary>
        public static string Aseguradora_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderAseguradora_de_Vehiculo.GetResource("Aseguradora_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAseguradora_de_Vehiculo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderAseguradora_de_Vehiculo.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SNSP</summary>
        public static string SNSP
        {
            get
            {
                SetPath();
                return resourceProviderAseguradora_de_Vehiculo.GetResource("SNSP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAseguradora_de_Vehiculo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
