using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Hechos_Audiencia_InicialResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Hechos_Audiencia_Inicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Hechos_Audiencia_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Hechos_Audiencia_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Hechos_Audiencia_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Hechos_Audiencia_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Hechos_Audiencia_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Hechos_Audiencia_Inicial</summary>
        public static string Detalle_de_Hechos_Audiencia_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Hechos_Audiencia_Inicial.GetResource("Detalle_de_Hechos_Audiencia_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Hechos_Audiencia_Inicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_del_Hecho</summary>
        public static string Descripcion_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Hechos_Audiencia_Inicial.GetResource("Descripcion_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Si</summary>
        public static string Si
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Hechos_Audiencia_Inicial.GetResource("Si", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Hechos_Audiencia_Inicial.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Hechos_Audiencia_Inicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
