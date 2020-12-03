using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Asignacion_de_AgenteResources
    {
        //private static IResourceProvider resourceProviderAsignacion_de_Agente = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Asignacion_de_AgenteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAsignacion_de_Agente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_AgenteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAsignacion_de_Agente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_AgenteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Asignacion_de_Agente</summary>
        public static string Asignacion_de_Agente
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Asignacion_de_Agente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Asignacion</summary>
        public static string Fecha_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Fecha_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Asignacion</summary>
        public static string Hora_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Hora_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Asigna</summary>
        public static string Usuario_que_Asigna
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Usuario_que_Asigna", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agente_Asignado</summary>
        public static string Agente_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Agente_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Agente.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAsignacion_de_Agente.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
