using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Citatorio_AudienciasResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Citatorio_Audiencias = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Citatorio_AudienciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Citatorio_Audiencias = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Citatorio_AudienciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Citatorio_Audiencias = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Citatorio_AudienciasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Citatorio_Audiencias</summary>
        public static string Detalle_de_Citatorio_Audiencias
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Detalle_de_Citatorio_Audiencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_audiencia_citatorio</summary>
        public static string Numero_de_audiencia_citatorio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Numero_de_audiencia_citatorio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Aceptacion</summary>
        public static string Fecha_de_Aceptacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Fecha_de_Aceptacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Aceptacion</summary>
        public static string Hora_de_Aceptacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("Hora_de_Aceptacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Citatorio_Audiencias.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
