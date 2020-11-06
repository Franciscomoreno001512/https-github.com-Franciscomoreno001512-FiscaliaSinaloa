using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Probable_Responsable_de_DocumentosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Probable_Responsable_de_Documentos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Probable_Responsable_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Probable_Responsable_de_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Probable_Responsable_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Probable_Responsable_de_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Probable_Responsable_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Probable_Responsable_de_Documentos</summary>
        public static string Detalle_Probable_Responsable_de_Documentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Probable_Responsable_de_Documentos.GetResource("Detalle_Probable_Responsable_de_Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Probable_Responsable_de_Documentos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>IdDocumentos</summary>
        public static string IdDocumentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Probable_Responsable_de_Documentos.GetResource("IdDocumentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Probable_Responsable</summary>
        public static string Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Probable_Responsable_de_Documentos.GetResource("Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Probable_Responsable_de_Documentos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
