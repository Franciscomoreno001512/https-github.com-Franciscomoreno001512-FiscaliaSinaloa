using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Involucrados_en_DocumentosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Involucrados_en_Documentos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Involucrados_en_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Involucrados_en_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Involucrados_en_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Involucrados_en_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Involucrados_en_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Involucrados_en_Documentos</summary>
        public static string Detalle_Involucrados_en_Documentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Involucrados_en_Documentos.GetResource("Detalle_Involucrados_en_Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Involucrados_en_Documentos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>IdDocumentos</summary>
        public static string IdDocumentos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Involucrados_en_Documentos.GetResource("IdDocumentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Involucrado</summary>
        public static string Involucrado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Involucrados_en_Documentos.GetResource("Involucrado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Involucrados_en_Documentos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
