using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Solicitud_Historial_de_AsignacionesResources
    {
        //private static IResourceProvider resourceProviderDetalle_Solicitud_Historial_de_Asignaciones = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Solicitud_Historial_de_AsignacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Solicitud_Historial_de_Asignaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Solicitud_Historial_de_AsignacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Solicitud_Historial_de_Asignaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Solicitud_Historial_de_AsignacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Solicitud_Historial_de_Asignaciones</summary>
        public static string Detalle_Solicitud_Historial_de_Asignaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Detalle_Solicitud_Historial_de_Asignaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_cambio</summary>
        public static string Fecha_cambio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Fecha_cambio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_cambio</summary>
        public static string Hora_cambio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Hora_cambio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Facilitador_Asignado</summary>
        public static string Facilitador_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Facilitador_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_cambio</summary>
        public static string Motivo_de_cambio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("Motivo_de_cambio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Solicitud_Historial_de_Asignaciones.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
