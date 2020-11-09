using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitud_Datos_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitud_Datos_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_Datos_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_Datos_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitud_Datos_de_Apoyo</summary>
        public static string Detalle_de_Solicitud_Datos_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Detalle_de_Solicitud_Datos_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_registra</summary>
        public static string Usuario_que_registra
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Usuario_que_registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable</summary>
        public static string Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lengua_Originaria</summary>
        public static string Lengua_Originaria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Lengua_Originaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia_a_Enviar</summary>
        public static string Diligencia_a_Enviar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Diligencia_a_Enviar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Datos_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
