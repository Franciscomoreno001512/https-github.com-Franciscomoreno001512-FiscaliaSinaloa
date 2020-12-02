using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Unidad_de_Medida_de_Equipo_TacticoResources
    {
        //private static IResourceProvider resourceProviderUnidad_de_Medida_de_Equipo_Tactico = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Unidad_de_Medida_de_Equipo_TacticoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderUnidad_de_Medida_de_Equipo_Tactico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Unidad_de_Medida_de_Equipo_TacticoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderUnidad_de_Medida_de_Equipo_Tactico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Unidad_de_Medida_de_Equipo_TacticoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Unidad_de_Medida_de_Equipo_Tactico</summary>
        public static string Unidad_de_Medida_de_Equipo_Tactico
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Medida_de_Equipo_Tactico.GetResource("Unidad_de_Medida_de_Equipo_Tactico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Medida_de_Equipo_Tactico.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderUnidad_de_Medida_de_Equipo_Tactico.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderUnidad_de_Medida_de_Equipo_Tactico.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
