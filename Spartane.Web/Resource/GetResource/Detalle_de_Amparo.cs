using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_AmparoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Amparo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_AmparoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Amparo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_AmparoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Amparo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_AmparoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Amparo</summary>
        public static string Detalle_de_Amparo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Detalle_de_Amparo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Amparo</summary>
        public static string Tipo_de_Amparo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Tipo_de_Amparo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Amparo</summary>
        public static string Numero_de_Amparo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Numero_de_Amparo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Amparo</summary>
        public static string Fecha_Amparo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Fecha_Amparo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entidad_que_Emitio_Amparo</summary>
        public static string Entidad_que_Emitio_Amparo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Entidad_que_Emitio_Amparo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Amparo.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Amparo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
