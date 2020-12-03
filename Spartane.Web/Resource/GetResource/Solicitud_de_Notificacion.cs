using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Solicitud_de_NotificacionResources
    {
        //private static IResourceProvider resourceProviderSolicitud_de_Notificacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Solicitud_de_NotificacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud_de_Notificacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_NotificacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud_de_Notificacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_NotificacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud_de_Notificacion</summary>
        public static string Solicitud_de_Notificacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Solicitud_de_Notificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Solicitud</summary>
        public static string Fecha_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Fecha_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Solicitud</summary>
        public static string Hora_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Hora_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Solicita</summary>
        public static string Usuario_que_Solicita
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Usuario_que_Solicita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_Atencion_Temprana</summary>
        public static string Expediente_Atencion_Temprana
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Expediente_Atencion_Temprana", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_Mecanismos_Alternos</summary>
        public static string Expediente_Mecanismos_Alternos
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Expediente_Mecanismos_Alternos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carpeta_de_Investigacion</summary>
        public static string Carpeta_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Carpeta_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Invitacion</summary>
        public static string Numero_de_Invitacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Numero_de_Invitacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_la_cita</summary>
        public static string Fecha_de_la_cita
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Fecha_de_la_cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_la_Cita</summary>
        public static string Hora_de_la_Cita
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Hora_de_la_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_la_Cita</summary>
        public static string Lugar_de_la_Cita
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Lugar_de_la_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Invitados</summary>
        public static string Invitados
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Invitados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Notificacion</summary>
        public static string Fecha_de_Notificacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Fecha_de_Notificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Notificacion</summary>
        public static string Hora_de_Notificacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Hora_de_Notificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Notificador</summary>
        public static string Notificador
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Notificador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Invitacion</summary>
        public static string Forma_de_Invitacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Forma_de_Invitacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado</summary>
        public static string Resultado
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Resultado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incidente_en_la_Recepcion</summary>
        public static string Incidente_en_la_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Incidente_en_la_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Notificacion.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Notificacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resultado de Notificación</summary>	public static string TabResultado_de_Notificacion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Notificacion.GetResource("TabResultado_de_Notificacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
