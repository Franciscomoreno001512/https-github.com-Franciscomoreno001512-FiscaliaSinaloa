using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_subareas_responsable_servicio_apoyoResources
    {
        //private static IResourceProvider resourceProviderDetalle_subareas_responsable_servicio_apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_subareas_responsable_servicio_apoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_subareas_responsable_servicio_apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_subareas_responsable_servicio_apoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_subareas_responsable_servicio_apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_subareas_responsable_servicio_apoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_subareas_responsable_servicio_apoyo</summary>
        public static string Detalle_subareas_responsable_servicio_apoyo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_subareas_responsable_servicio_apoyo.GetResource("Detalle_subareas_responsable_servicio_apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_subareas_responsable_servicio_apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SubArea_Asignada</summary>
        public static string SubArea_Asignada
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_subareas_responsable_servicio_apoyo.GetResource("SubArea_Asignada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_subareas_responsable_servicio_apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
