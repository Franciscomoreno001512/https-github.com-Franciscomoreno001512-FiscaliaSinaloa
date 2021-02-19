using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Generador_Folio_Documentos_ATResources
    {
        //private static IResourceProvider resourceProviderGenerador_Folio_Documentos_AT = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Generador_Folio_Documentos_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderGenerador_Folio_Documentos_AT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_Folio_Documentos_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderGenerador_Folio_Documentos_AT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_Folio_Documentos_ATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Generador_Folio_Documentos_AT</summary>
        public static string Generador_Folio_Documentos_AT
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Generador_Folio_Documentos_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Genera</summary>
        public static string Fecha_Genera
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Fecha_Genera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anio_Genera</summary>
        public static string Anio_Genera
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Anio_Genera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo</summary>
        public static string Consecutivo
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Consecutivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_Ultimo_Generado</summary>
        public static string Folio_Ultimo_Generado
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Folio_Documentos_AT.GetResource("Folio_Ultimo_Generado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderGenerador_Folio_Documentos_AT.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
