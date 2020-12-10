using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Generador_Folio_EncuestaResources
    {
        //private static IResourceProvider resourceProviderGenerador_Folio_Encuesta = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Generador_Folio_EncuestaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderGenerador_Folio_Encuesta = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_Folio_EncuestaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderGenerador_Folio_Encuesta = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_Folio_EncuestaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Generador_Folio_Encuesta</summary>
        public static string Generador_Folio_Encuesta
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Generador_Folio_Encuesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Genera</summary>
        public static string Fecha_Genera
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Fecha_Genera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anio_Genera</summary>
        public static string Anio_Genera
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Anio_Genera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Encuesta</summary>
        public static string Modulo_Encuesta
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Modulo_Encuesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo</summary>
        public static string Consecutivo
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Consecutivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_Encuesta_Ultimo_Generado</summary>
        public static string Folio_Encuesta_Ultimo_Generado
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Encuesta.GetResource("Folio_Encuesta_Ultimo_Generado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderGenerador_Folio_Encuesta.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
