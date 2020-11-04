using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Documento_MPOResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Documento_MPO = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Documento_MPOResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Documento_MPO = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Documento_MPOResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Documento_MPO = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Documento_MPOResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Documento_MPO</summary>
        public static string Detalle_de_Documento_MPO
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documento_MPO.GetResource("Detalle_de_Documento_MPO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documento_MPO.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documento_MPO.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documento_MPO.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documento_MPO.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Documento_MPO.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
