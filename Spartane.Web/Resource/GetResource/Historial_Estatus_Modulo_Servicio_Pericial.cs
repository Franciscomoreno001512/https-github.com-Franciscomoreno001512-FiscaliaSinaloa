using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Historial_Estatus_Modulo_Servicio_PericialResources
    {
        //private static IResourceProvider resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Historial_Estatus_Modulo_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Historial_Estatus_Modulo_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Historial_Estatus_Modulo_Servicio_PericialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Historial_Estatus_Modulo_Servicio_Pericial</summary>
        public static string Historial_Estatus_Modulo_Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Historial_Estatus_Modulo_Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Servicio_Pericial</summary>
        public static string Estatus_Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Estatus_Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Registro</summary>
        public static string Fecha_Registro
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Fecha_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Activo</summary>
        public static string Activo
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Activo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Cierre</summary>
        public static string Fecha_Cierre
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Fecha_Cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Servicio_Pericial</summary>
        public static string Modulo_Servicio_Pericial
        {
            get
            {
                SetPath();
                return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("Modulo_Servicio_Pericial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderHistorial_Estatus_Modulo_Servicio_Pericial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
