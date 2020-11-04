using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_Tiempo_por_EstatusResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Tiempo_por_Estatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_Tiempo_por_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Tiempo_por_Estatus = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Tiempo_por_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Tiempo_por_Estatus = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Tiempo_por_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Tiempo_por_Estatus</summary>
        public static string Registro_de_Tiempo_por_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Registro_de_Tiempo_por_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Interno</summary>
        public static string Estatus_Interno
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Estatus_Interno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Destino</summary>
        public static string Estatus_Destino
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Estatus_Destino", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiempo_Transcurrido</summary>
        public static string Tiempo_Transcurrido
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("Tiempo_Transcurrido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Tiempo_por_Estatus.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
