using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Clasificacion_de_Artefacto_y_ExplosivoResources
    {
        //private static IResourceProvider resourceProviderClasificacion_de_Artefacto_y_Explosivo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Clasificacion_de_Artefacto_y_ExplosivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderClasificacion_de_Artefacto_y_Explosivo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Clasificacion_de_Artefacto_y_ExplosivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderClasificacion_de_Artefacto_y_Explosivo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Clasificacion_de_Artefacto_y_ExplosivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Clasificacion_de_Artefacto_y_Explosivo</summary>
        public static string Clasificacion_de_Artefacto_y_Explosivo
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_de_Artefacto_y_Explosivo.GetResource("Clasificacion_de_Artefacto_y_Explosivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_de_Artefacto_y_Explosivo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_de_Artefacto_y_Explosivo.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderClasificacion_de_Artefacto_y_Explosivo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
