using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Audiencia_Archivos_AdjuntosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Audiencia_Archivos_Adjuntos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Audiencia_Archivos_AdjuntosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Audiencia_Archivos_Adjuntos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Audiencia_Archivos_AdjuntosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Audiencia_Archivos_Adjuntos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Audiencia_Archivos_AdjuntosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Audiencia_Archivos_Adjuntos</summary>
        public static string Detalle_Audiencia_Archivos_Adjuntos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Archivos_Adjuntos.GetResource("Detalle_Audiencia_Archivos_Adjuntos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Archivos_Adjuntos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Archivo</summary>
        public static string Nombre_Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Archivos_Adjuntos.GetResource("Nombre_Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Audiencia_Archivos_Adjuntos.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Audiencia_Archivos_Adjuntos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
