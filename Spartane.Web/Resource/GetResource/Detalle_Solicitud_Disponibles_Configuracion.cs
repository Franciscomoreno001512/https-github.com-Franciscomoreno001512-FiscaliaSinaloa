using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Solicitud_Disponibles_ConfiguracionResources
    {
        //private static IResourceProvider resourceProviderDetalle_Solicitud_Disponibles_Configuracion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Solicitud_Disponibles_ConfiguracionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Solicitud_Disponibles_Configuracion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Solicitud_Disponibles_ConfiguracionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Solicitud_Disponibles_Configuracion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Solicitud_Disponibles_ConfiguracionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Solicitud_Disponibles_Configuracion</summary>
        public static string Detalle_Solicitud_Disponibles_Configuracion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Disponibles_Configuracion.GetResource("Detalle_Solicitud_Disponibles_Configuracion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Disponibles_Configuracion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Disponibles_Configuracion.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Solicitud_Disponibles_Configuracion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
