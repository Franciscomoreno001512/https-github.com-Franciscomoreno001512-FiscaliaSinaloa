using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Servicios_PericialesResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Servicios_Periciales = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Servicios_PericialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Servicios_Periciales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicios_PericialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Servicios_Periciales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Servicios_PericialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Servicios_Periciales</summary>
        public static string Detalle_de_Servicios_Periciales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Detalle_de_Servicios_Periciales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio</summary>
        public static string Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialista</summary>
        public static string Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_del_Dictamen</summary>
        public static string Estatus_del_Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Estatus_del_Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Dictamen</summary>
        public static string Fecha_del_Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Fecha_del_Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Rol_de_Donde_Proviene</summary>
        public static string Rol_de_Donde_Proviene
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("Rol_de_Donde_Proviene", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ObservacionesD</summary>
        public static string ObservacionesD
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Servicios_Periciales.GetResource("ObservacionesD", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Servicios_Periciales.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
