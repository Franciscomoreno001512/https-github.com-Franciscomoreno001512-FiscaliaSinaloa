using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Unidad_de_Medida_de_pirateriaResources
    {
        //private static IResourceProvider resourceProviderUnidad_de_Medida_de_pirateria = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Unidad_de_Medida_de_pirateriaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderUnidad_de_Medida_de_pirateria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Unidad_de_Medida_de_pirateriaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderUnidad_de_Medida_de_pirateria = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Unidad_de_Medida_de_pirateriaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Unidad_de_Medida_de_pirateria</summary>
        public static string Unidad_de_Medida_de_pirateria
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Medida_de_pirateria.GetResource("Unidad_de_Medida_de_pirateria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Medida_de_pirateria.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Medida_de_pirateria.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUnidad_de_Medida_de_pirateria.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
