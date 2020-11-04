using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Carga_de_Documentos_Lectura_de_DerechosResources
    {
        //private static IResourceProvider resourceProviderCarga_de_Documentos_Lectura_de_Derechos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Carga_de_Documentos_Lectura_de_DerechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCarga_de_Documentos_Lectura_de_Derechos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Carga_de_Documentos_Lectura_de_DerechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCarga_de_Documentos_Lectura_de_Derechos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Carga_de_Documentos_Lectura_de_DerechosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Carga_de_Documentos_Lectura_de_Derechos</summary>
        public static string Carga_de_Documentos_Lectura_de_Derechos
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Carga_de_Documentos_Lectura_de_Derechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Adjuntar_Documento</summary>
        public static string Adjuntar_Documento
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Adjuntar_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Actualizacion</summary>
        public static string Estatus_de_Actualizacion
        {
            get
            {
                SetPath();
                return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("Estatus_de_Actualizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCarga_de_Documentos_Lectura_de_Derechos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
