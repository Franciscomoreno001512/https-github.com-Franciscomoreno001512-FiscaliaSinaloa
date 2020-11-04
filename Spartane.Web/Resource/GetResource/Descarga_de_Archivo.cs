using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Descarga_de_ArchivoResources
    {
        //private static IResourceProvider resourceProviderDescarga_de_Archivo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Descarga_de_ArchivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDescarga_de_Archivo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Descarga_de_ArchivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDescarga_de_Archivo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Descarga_de_ArchivoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Descarga_de_Archivo</summary>
        public static string Descarga_de_Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDescarga_de_Archivo.GetResource("Descarga_de_Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDescarga_de_Archivo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos</summary>
        public static string Documentos
        {
            get
            {
                SetPath();
                return resourceProviderDescarga_de_Archivo.GetResource("Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDescarga_de_Archivo.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDescarga_de_Archivo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
