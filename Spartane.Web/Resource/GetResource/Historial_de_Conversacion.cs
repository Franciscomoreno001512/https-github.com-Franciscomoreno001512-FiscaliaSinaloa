using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Historial_de_ConversacionResources
    {
        //private static IResourceProvider resourceProviderHistorial_de_Conversacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Historial_de_ConversacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderHistorial_de_Conversacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Historial_de_ConversacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderHistorial_de_Conversacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Historial_de_ConversacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Historial_de_Conversacion</summary>
        public static string Historial_de_Conversacion
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_de_Conversacion.GetResource("Historial_de_Conversacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_de_Conversacion.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Remitente</summary>
        public static string Remitente
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_de_Conversacion.GetResource("Remitente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Destinatario</summary>
        public static string Destinatario
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_de_Conversacion.GetResource("Destinatario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_de_Conversacion.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mensaje</summary>
        public static string Mensaje
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_de_Conversacion.GetResource("Mensaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderHistorial_de_Conversacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
