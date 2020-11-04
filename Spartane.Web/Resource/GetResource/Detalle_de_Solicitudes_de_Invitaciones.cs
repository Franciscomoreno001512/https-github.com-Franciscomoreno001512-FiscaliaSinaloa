using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitudes_de_InvitacionesResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitudes_de_Invitaciones = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitudes_de_InvitacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitudes_de_Invitaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitudes_de_InvitacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitudes_de_Invitaciones = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitudes_de_InvitacionesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitudes_de_Invitaciones</summary>
        public static string Detalle_de_Solicitudes_de_Invitaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Detalle_de_Solicitudes_de_Invitaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Invitacion</summary>
        public static string Fecha_de_Invitacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Fecha_de_Invitacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Invitacion</summary>
        public static string Numero_de_Invitacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Numero_de_Invitacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Oficio</summary>
        public static string Numero_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Numero_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Formato_de_Invitacion</summary>
        public static string Formato_de_Invitacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Formato_de_Invitacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Participacion</summary>
        public static string Tipo_de_Participacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Tipo_de_Participacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_la_cita</summary>
        public static string Fecha_de_la_cita
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Fecha_de_la_cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_la_Cita</summary>
        public static string Hora_de_la_Cita
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Hora_de_la_Cita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio</summary>
        public static string Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>nombre_del_interviniente_solicitante</summary>
        public static string nombre_del_interviniente_solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("nombre_del_interviniente_solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>nombre_del_interviniente_requerido</summary>
        public static string nombre_del_interviniente_requerido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("nombre_del_interviniente_requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Recepcion</summary>
        public static string Fecha_de_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Fecha_de_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Aceptacion</summary>
        public static string Fecha_de_Aceptacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Fecha_de_Aceptacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cumplimiento</summary>
        public static string Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incidente</summary>
        public static string Incidente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Incidente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>A_Tiempo</summary>
        public static string A_Tiempo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("A_Tiempo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitudes_de_Invitaciones.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
