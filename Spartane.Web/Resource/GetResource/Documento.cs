using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class DocumentoResources
    {
        //private static IResourceProvider resourceProviderDocumento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\DocumentoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDocumento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DocumentoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDocumento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DocumentoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia</summary>
        public static string Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Documento</summary>
        public static string Tipo_de_Documento
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Tipo_de_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SubArea_de_Servicios_de_Apoyo</summary>
        public static string SubArea_de_Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("SubArea_de_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idFormato</summary>
        public static string idFormato
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("idFormato", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido</summary>
        public static string Requerido
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido_o_Solicitante</summary>
        public static string Requerido_o_Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Requerido_o_Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitar_Archivo_Adjunto</summary>
        public static string Solicitar_Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Solicitar_Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitar_Numero_de_Oficio</summary>
        public static string Solicitar_Numero_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderDocumento.GetResource("Solicitar_Numero_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDocumento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
