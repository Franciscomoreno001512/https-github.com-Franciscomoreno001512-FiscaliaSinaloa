using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Control_de_Tiempos_JAResources
    {
        //private static IResourceProvider resourceProviderControl_de_Tiempos_JA = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Control_de_Tiempos_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderControl_de_Tiempos_JA = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_Tiempos_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderControl_de_Tiempos_JA = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_Tiempos_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Control_de_Tiempos_JA</summary>
        public static string Control_de_Tiempos_JA
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Control_de_Tiempos_JA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Destino</summary>
        public static string Estatus_Destino
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Estatus_Destino", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiempo_Transcurrido</summary>
        public static string Tiempo_Transcurrido
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Tiempos_JA.GetResource("Tiempo_Transcurrido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderControl_de_Tiempos_JA.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
