using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class NotificacionesResources
    {
        //private static IResourceProvider resourceProviderNotificaciones = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\NotificacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderNotificaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\NotificacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderNotificaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\NotificacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Notificaciones</summary>
        public static string Notificaciones
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Notificaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo</summary>
        public static string Titulo
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Titulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Notificacion</summary>
        public static string Notificacion
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Notificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Destinatario</summary>
        public static string Destinatario
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Destinatario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Enviado</summary>
        public static string Enviado
        {
            get
            {
                SetPath();
                return resourceProviderNotificaciones.GetResource("Enviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderNotificaciones.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
