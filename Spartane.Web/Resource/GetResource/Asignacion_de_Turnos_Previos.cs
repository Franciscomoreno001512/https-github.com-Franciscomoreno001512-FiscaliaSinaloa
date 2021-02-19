using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Asignacion_de_Turnos_PreviosResources
    {
        //private static IResourceProvider resourceProviderAsignacion_de_Turnos_Previos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Asignacion_de_Turnos_PreviosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAsignacion_de_Turnos_Previos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_Turnos_PreviosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAsignacion_de_Turnos_Previos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_Turnos_PreviosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Asignacion_de_Turnos_Previos</summary>
        public static string Asignacion_de_Turnos_Previos
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos_Previos.GetResource("Asignacion_de_Turnos_Previos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos_Previos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos_Previos.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave_Asignacion_Turno</summary>
        public static string Clave_Asignacion_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos_Previos.GetResource("Clave_Asignacion_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Turno</summary>
        public static string Numero_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos_Previos.GetResource("Numero_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAsignacion_de_Turnos_Previos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
