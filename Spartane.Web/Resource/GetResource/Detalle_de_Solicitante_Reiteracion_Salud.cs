using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitante_Reiteracion_SaludResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitante_Reiteracion_Salud = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitante_Reiteracion_SaludResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitante_Reiteracion_Salud = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitante_Reiteracion_SaludResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitante_Reiteracion_Salud = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitante_Reiteracion_SaludResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitante_Reiteracion_Salud</summary>
        public static string Detalle_de_Solicitante_Reiteracion_Salud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitante_Reiteracion_Salud.GetResource("Detalle_de_Solicitante_Reiteracion_Salud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitante_Reiteracion_Salud.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitante_Reiteracion_Salud.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Si</summary>
        public static string Si
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitante_Reiteracion_Salud.GetResource("Si", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitante_Reiteracion_Salud.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitante_Reiteracion_Salud.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
