using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Modalidad_de_Robo_de_VehiculoResources
    {
        //private static IResourceProvider resourceProviderModalidad_de_Robo_de_Vehiculo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Modalidad_de_Robo_de_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderModalidad_de_Robo_de_Vehiculo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modalidad_de_Robo_de_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderModalidad_de_Robo_de_Vehiculo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modalidad_de_Robo_de_VehiculoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Modalidad_de_Robo_de_Vehiculo</summary>
        public static string Modalidad_de_Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderModalidad_de_Robo_de_Vehiculo.GetResource("Modalidad_de_Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderModalidad_de_Robo_de_Vehiculo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderModalidad_de_Robo_de_Vehiculo.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderModalidad_de_Robo_de_Vehiculo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
