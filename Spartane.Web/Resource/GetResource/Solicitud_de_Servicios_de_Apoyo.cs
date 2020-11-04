using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Solicitud_de_Servicios_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderSolicitud_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Solicitud_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud_de_Servicios_de_Apoyo</summary>
        public static string Solicitud_de_Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Solicitud_de_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable</summary>
        public static string Responsable
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_MR</summary>
        public static string Clave_MR
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Clave_MR", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Compareciente</summary>
        public static string Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
