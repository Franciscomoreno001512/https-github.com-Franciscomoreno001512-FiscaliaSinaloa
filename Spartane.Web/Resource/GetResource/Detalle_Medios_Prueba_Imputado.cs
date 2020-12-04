using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Medios_Prueba_ImputadoResources
    {
        //private static IResourceProvider resourceProviderDetalle_Medios_Prueba_Imputado = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Medios_Prueba_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Medios_Prueba_Imputado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medios_Prueba_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Medios_Prueba_Imputado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medios_Prueba_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Medios_Prueba_Imputado</summary>
        public static string Detalle_Medios_Prueba_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Imputado.GetResource("Detalle_Medios_Prueba_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Imputado.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medio_de_Prueba_Presentado</summary>
        public static string Medio_de_Prueba_Presentado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Imputado.GetResource("Medio_de_Prueba_Presentado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Presentacion</summary>
        public static string Fecha_de_Presentacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Imputado.GetResource("Fecha_de_Presentacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Imputado.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Medios_Prueba_Imputado.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
