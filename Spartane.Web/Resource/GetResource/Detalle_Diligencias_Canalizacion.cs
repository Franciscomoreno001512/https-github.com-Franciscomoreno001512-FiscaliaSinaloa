using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Diligencias_CanalizacionResources
    {
        //private static IResourceProvider resourceProviderDetalle_Diligencias_Canalizacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Diligencias_CanalizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Diligencias_Canalizacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Diligencias_CanalizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Diligencias_Canalizacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Diligencias_CanalizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Diligencias_Canalizacion</summary>
        public static string Detalle_Diligencias_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_Canalizacion.GetResource("Detalle_Diligencias_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_Canalizacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia</summary>
        public static string Diligencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_Canalizacion.GetResource("Diligencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ver_Documento</summary>
        public static string Ver_Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_Canalizacion.GetResource("Ver_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Diligencias_Canalizacion.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Diligencias_Canalizacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
