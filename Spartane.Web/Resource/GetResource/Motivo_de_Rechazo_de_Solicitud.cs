using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Motivo_de_Rechazo_de_SolicitudResources
    {
        //private static IResourceProvider resourceProviderMotivo_de_Rechazo_de_Solicitud = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Motivo_de_Rechazo_de_SolicitudResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMotivo_de_Rechazo_de_Solicitud = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Motivo_de_Rechazo_de_SolicitudResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMotivo_de_Rechazo_de_Solicitud = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Motivo_de_Rechazo_de_SolicitudResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Motivo_de_Rechazo_de_Solicitud</summary>
        public static string Motivo_de_Rechazo_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderMotivo_de_Rechazo_de_Solicitud.GetResource("Motivo_de_Rechazo_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMotivo_de_Rechazo_de_Solicitud.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderMotivo_de_Rechazo_de_Solicitud.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMotivo_de_Rechazo_de_Solicitud.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
