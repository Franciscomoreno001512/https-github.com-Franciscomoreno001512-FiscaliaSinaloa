using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_SeguimientoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Seguimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_SeguimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Seguimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_SeguimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Seguimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_SeguimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Seguimiento</summary>
        public static string Detalle_de_Seguimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Detalle_de_Seguimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialista</summary>
        public static string Especialista
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Especialista", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido</summary>
        public static string Requerido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cumplimiento</summary>
        public static string Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Seguimiento</summary>
        public static string Tipo_de_Seguimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Tipo_de_Seguimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_del_Monto</summary>
        public static string Cantidad_del_Monto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Cantidad_del_Monto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cumplimiento</summary>
        public static string Fecha_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Seguimiento.GetResource("Fecha_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Seguimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
