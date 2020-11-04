using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_documentosResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_documentos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_documentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_documentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_documentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_documentos</summary>
        public static string Detalle_de_documentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Detalle_de_documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Documento</summary>
        public static string Tipo_de_Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Tipo_de_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido</summary>
        public static string Requerido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_documentos.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_documentos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
