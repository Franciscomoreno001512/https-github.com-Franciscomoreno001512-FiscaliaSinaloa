using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitud_Bitacora_de_CoincidResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitud_Bitacora_de_CoincidResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_Bitacora_de_CoincidResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_Bitacora_de_CoincidResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitud_Bitacora_de_Coincid</summary>
        public static string Detalle_de_Solicitud_Bitacora_de_Coincid
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Detalle_de_Solicitud_Bitacora_de_Coincid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fuente_de_Origen</summary>
        public static string Fuente_de_Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Fuente_de_Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Acuerdo</summary>
        public static string Tipo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Tipo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cumplido</summary>
        public static string Cumplido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Cumplido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_de_Incumplimiento</summary>
        public static string Razon_de_Incumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Razon_de_Incumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Bitacora_de_Coincid.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
