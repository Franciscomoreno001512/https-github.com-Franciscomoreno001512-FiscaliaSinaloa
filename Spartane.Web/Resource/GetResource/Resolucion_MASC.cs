using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Resolucion_MASCResources
    {
        //private static IResourceProvider resourceProviderResolucion_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Resolucion_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderResolucion_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderResolucion_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Resolucion_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Resolucion_MASC</summary>
        public static string Resolucion_MASC
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("Resolucion_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rechazo</summary>
        public static string Rechazo
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("Rechazo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_para_Solicitud</summary>
        public static string Resolucion_para_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("Resolucion_para_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion_para_Procedimiento</summary>
        public static string Resolucion_para_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("Resolucion_para_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ClaveFiscalia</summary>
        public static string ClaveFiscalia
        {
            get
            {
                SetPath();
                return resourceProviderResolucion_MASC.GetResource("ClaveFiscalia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderResolucion_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
