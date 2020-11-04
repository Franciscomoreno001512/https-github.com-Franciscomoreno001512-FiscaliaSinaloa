using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class CorporacionResources
    {
        //private static IResourceProvider resourceProviderCorporacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\CorporacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCorporacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\CorporacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCorporacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\CorporacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Corporacion</summary>
        public static string Corporacion
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Corporacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Municipio</summary>
        public static string Clave_Municipio
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Clave_Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Policia</summary>
        public static string Clave_Policia
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Clave_Policia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vigencia</summary>
        public static string Vigencia
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Vigencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Uso_Vehiculo</summary>
        public static string Uso_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Uso_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderCorporacion.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCorporacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
