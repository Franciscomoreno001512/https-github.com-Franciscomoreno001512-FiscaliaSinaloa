using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_coincidencias_aResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_coincidencias_a = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_coincidencias_aResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_coincidencias_a = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_coincidencias_aResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_coincidencias_a = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_coincidencias_aResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_coincidencias_a</summary>
        public static string Detalle_de_coincidencias_a
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_coincidencias_a.GetResource("Detalle_de_coincidencias_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_coincidencias_a.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_coincidencias_a.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_coincidencias_a.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_coincidencias_a.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fuente_de_Origen</summary>
        public static string Fuente_de_Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_coincidencias_a.GetResource("Fuente_de_Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_coincidencias_a.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
