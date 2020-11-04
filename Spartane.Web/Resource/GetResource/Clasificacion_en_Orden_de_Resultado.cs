using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Clasificacion_en_Orden_de_ResultadoResources
    {
        //private static IResourceProvider resourceProviderClasificacion_en_Orden_de_Resultado = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Clasificacion_en_Orden_de_ResultadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderClasificacion_en_Orden_de_Resultado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Clasificacion_en_Orden_de_ResultadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderClasificacion_en_Orden_de_Resultado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Clasificacion_en_Orden_de_ResultadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Clasificacion_en_Orden_de_Resultado</summary>
        public static string Clasificacion_en_Orden_de_Resultado
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_en_Orden_de_Resultado.GetResource("Clasificacion_en_Orden_de_Resultado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_en_Orden_de_Resultado.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_en_Orden_de_Resultado.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_en_Orden_de_Resultado.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderClasificacion_en_Orden_de_Resultado.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderClasificacion_en_Orden_de_Resultado.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
