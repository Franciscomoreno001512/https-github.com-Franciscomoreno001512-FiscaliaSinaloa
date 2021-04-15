using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class RegionResources
    {
        //private static IResourceProvider resourceProviderRegion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\RegionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\RegionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\RegionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abreviacion</summary>
        public static string Abreviacion
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Abreviacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>recepcion_servicios_apoyo</summary>
        public static string recepcion_servicios_apoyo
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("recepcion_servicios_apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo_CDI</summary>
        public static string Consecutivo_CDI
        {
            get
            {
                SetPath();
                return resourceProviderRegion.GetResource("Consecutivo_CDI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
