using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Canalizar_EstatusResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Canalizar_Estatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Canalizar_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Canalizar_Estatus = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Canalizar_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Canalizar_Estatus = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Canalizar_EstatusResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Canalizar_Estatus</summary>
        public static string Detalle_de_Canalizar_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("Detalle_de_Canalizar_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cambio_de_Estatus</summary>
        public static string Fecha_de_Cambio_de_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("Fecha_de_Cambio_de_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Cambio_de_Estatus</summary>
        public static string Hora_de_Cambio_de_Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("Hora_de_Cambio_de_Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Interno</summary>
        public static string Estatus_Interno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("Estatus_Interno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Canalizacion</summary>
        public static string Estatus_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("Estatus_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Canalizar_Estatus.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
