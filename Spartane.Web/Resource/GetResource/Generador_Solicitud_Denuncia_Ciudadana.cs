using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Generador_Solicitud_Denuncia_CiudadanaResources
    {
        //private static IResourceProvider resourceProviderGenerador_Solicitud_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Generador_Solicitud_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderGenerador_Solicitud_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_Solicitud_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderGenerador_Solicitud_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_Solicitud_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Generador_Solicitud_Denuncia_Ciudadana</summary>
        public static string Generador_Solicitud_Denuncia_Ciudadana
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("Generador_Solicitud_Denuncia_Ciudadana", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Genera</summary>
        public static string Fecha_Genera
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("Fecha_Genera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anio_Genera</summary>
        public static string Anio_Genera
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("Anio_Genera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo</summary>
        public static string Consecutivo
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("Consecutivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_Denuncia_Ultimo_Generado</summary>
        public static string Folio_Denuncia_Ultimo_Generado
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("Folio_Denuncia_Ultimo_Generado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderGenerador_Solicitud_Denuncia_Ciudadana.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
