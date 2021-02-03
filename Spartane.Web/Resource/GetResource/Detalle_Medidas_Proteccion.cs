using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Medidas_ProteccionResources
    {
        //private static IResourceProvider resourceProviderDetalle_Medidas_Proteccion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Medidas_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Medidas_Proteccion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medidas_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Medidas_Proteccion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medidas_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Medidas_Proteccion</summary>
        public static string Detalle_Medidas_Proteccion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Proteccion.GetResource("Detalle_Medidas_Proteccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Proteccion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Seleccionar</summary>
        public static string Seleccionar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Proteccion.GetResource("Seleccionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medida</summary>
        public static string Medida
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Proteccion.GetResource("Medida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Medidas_Proteccion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
