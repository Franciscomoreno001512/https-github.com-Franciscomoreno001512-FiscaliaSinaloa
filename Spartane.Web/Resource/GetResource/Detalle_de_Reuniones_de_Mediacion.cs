using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Reuniones_de_MediacionResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Reuniones_de_Mediacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Reuniones_de_MediacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Reuniones_de_Mediacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Reuniones_de_MediacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Reuniones_de_Mediacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Reuniones_de_MediacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Reuniones_de_Mediacion</summary>
        public static string Detalle_de_Reuniones_de_Mediacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Detalle_de_Reuniones_de_Mediacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar</summary>
        public static string Lugar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Lugar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialista</summary>
        public static string Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mecanismo_Alterno</summary>
        public static string Mecanismo_Alterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Mecanismo_Alterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Sesion</summary>
        public static string Tipo_de_Sesion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Tipo_de_Sesion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitanter</summary>
        public static string Solicitanter
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Solicitanter", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requeridor</summary>
        public static string Requeridor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Requeridor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cumplimiento</summary>
        public static string Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_adjunto</summary>
        public static string Archivo_adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Archivo_adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Reuniones_de_Mediacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
