using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Medios_Prueba_AdmitidosResources
    {
        //private static IResourceProvider resourceProviderDetalle_Medios_Prueba_Admitidos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Medios_Prueba_AdmitidosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Medios_Prueba_Admitidos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medios_Prueba_AdmitidosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Medios_Prueba_Admitidos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medios_Prueba_AdmitidosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Medios_Prueba_Admitidos</summary>
        public static string Detalle_Medios_Prueba_Admitidos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Admitidos.GetResource("Detalle_Medios_Prueba_Admitidos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Admitidos.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Admitidos.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medio_de_Prueba_Presentado</summary>
        public static string Medio_de_Prueba_Presentado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Admitidos.GetResource("Medio_de_Prueba_Presentado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Admitido</summary>
        public static string Admitido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medios_Prueba_Admitidos.GetResource("Admitido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Medios_Prueba_Admitidos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
