using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Generador_de_NUATResources
    {
        //private static IResourceProvider resourceProviderGenerador_de_NUAT = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Generador_de_NUATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderGenerador_de_NUAT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_de_NUATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderGenerador_de_NUAT = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Generador_de_NUATResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Generador_de_NUAT</summary>
        public static string Generador_de_NUAT
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Generador_de_NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Generador_de_NUAT</summary>
        public static string Fecha_de_Generador_de_NUAT
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Fecha_de_Generador_de_NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anio_de_Generador_de_NUAT</summary>
        public static string Anio_de_Generador_de_NUAT
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Anio_de_Generador_de_NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Denuncia</summary>
        public static string Tipo_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Tipo_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo</summary>
        public static string Consecutivo
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("Consecutivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT_Ultimo_Generado</summary>
        public static string NUAT_Ultimo_Generado
        {
            get
            {
                SetPath();
                return resourceProviderGenerador_de_NUAT.GetResource("NUAT_Ultimo_Generado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderGenerador_de_NUAT.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
