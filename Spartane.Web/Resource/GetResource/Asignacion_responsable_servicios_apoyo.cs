using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Asignacion_responsable_servicios_apoyoResources
    {
        //private static IResourceProvider resourceProviderAsignacion_responsable_servicios_apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Asignacion_responsable_servicios_apoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAsignacion_responsable_servicios_apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_responsable_servicios_apoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAsignacion_responsable_servicios_apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_responsable_servicios_apoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Asignacion_responsable_servicios_apoyo</summary>
        public static string Asignacion_responsable_servicios_apoyo
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_responsable_servicios_apoyo.GetResource("Asignacion_responsable_servicios_apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_responsable_servicios_apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_responsable_servicios_apoyo.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area_Asignada</summary>
        public static string Area_Asignada
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_responsable_servicios_apoyo.GetResource("Area_Asignada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SubAreas</summary>
        public static string SubAreas
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_responsable_servicios_apoyo.GetResource("SubAreas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAsignacion_responsable_servicios_apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
