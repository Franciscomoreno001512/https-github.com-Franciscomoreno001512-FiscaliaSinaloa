using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Vinculacion_a_ProcesoResources
    {
        //private static IResourceProvider resourceProviderVinculacion_a_Proceso = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Vinculacion_a_ProcesoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderVinculacion_a_Proceso = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Vinculacion_a_ProcesoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderVinculacion_a_Proceso = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Vinculacion_a_ProcesoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Vinculacion_a_Proceso</summary>
        public static string Vinculacion_a_Proceso
        {
            get
            {
                SetPath();
                return resourceProviderVinculacion_a_Proceso.GetResource("Vinculacion_a_Proceso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderVinculacion_a_Proceso.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderVinculacion_a_Proceso.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderVinculacion_a_Proceso.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
