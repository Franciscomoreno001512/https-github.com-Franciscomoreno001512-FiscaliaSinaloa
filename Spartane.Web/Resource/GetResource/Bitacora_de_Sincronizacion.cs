using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Bitacora_de_SincronizacionResources
    {
        //private static IResourceProvider resourceProviderBitacora_de_Sincronizacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Bitacora_de_SincronizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderBitacora_de_Sincronizacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Bitacora_de_SincronizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderBitacora_de_Sincronizacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Bitacora_de_SincronizacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Bitacora_de_Sincronizacion</summary>
        public static string Bitacora_de_Sincronizacion
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Sincronizacion.GetResource("Bitacora_de_Sincronizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Sincronizacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_Dispositivo</summary>
        public static string ID_Dispositivo
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Sincronizacion.GetResource("ID_Dispositivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Sincronizacion.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_la_Tabla</summary>
        public static string Nombre_de_la_Tabla
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Sincronizacion.GetResource("Nombre_de_la_Tabla", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Replicacion</summary>
        public static string Estatus_de_Replicacion
        {
            get
            {
                SetPath();
                return resourceProviderBitacora_de_Sincronizacion.GetResource("Estatus_de_Replicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderBitacora_de_Sincronizacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
