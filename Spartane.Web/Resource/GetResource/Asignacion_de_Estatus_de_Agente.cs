using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Asignacion_de_Estatus_de_AgenteResources
    {
        //private static IResourceProvider resourceProviderAsignacion_de_Estatus_de_Agente = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Asignacion_de_Estatus_de_AgenteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAsignacion_de_Estatus_de_Agente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_Estatus_de_AgenteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAsignacion_de_Estatus_de_Agente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_Estatus_de_AgenteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Asignacion_de_Estatus_de_Agente</summary>
        public static string Asignacion_de_Estatus_de_Agente
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Estatus_de_Agente.GetResource("Asignacion_de_Estatus_de_Agente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Estatus_de_Agente.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MP</summary>
        public static string MP
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Estatus_de_Agente.GetResource("MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Estatus_de_Agente.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Estatus_de_Agente.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAsignacion_de_Estatus_de_Agente.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
