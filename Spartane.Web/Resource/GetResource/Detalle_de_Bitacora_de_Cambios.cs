using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Bitacora_de_CambiosResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Bitacora_de_Cambios = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Bitacora_de_CambiosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Bitacora_de_Cambios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Bitacora_de_CambiosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Bitacora_de_Cambios = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Bitacora_de_CambiosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Bitacora_de_Cambios</summary>
        public static string Detalle_de_Bitacora_de_Cambios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Bitacora_de_Cambios.GetResource("Detalle_de_Bitacora_de_Cambios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Bitacora_de_Cambios.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Entrada</summary>
        public static string Fecha_de_Entrada
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Bitacora_de_Cambios.GetResource("Fecha_de_Entrada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Entrada</summary>
        public static string Hora_de_Entrada
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Bitacora_de_Cambios.GetResource("Hora_de_Entrada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Bitacora_de_Cambios.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Bitacora_de_Cambios.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
