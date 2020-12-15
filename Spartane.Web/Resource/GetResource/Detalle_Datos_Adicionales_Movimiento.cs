using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Datos_Adicionales_MovimientoResources
    {
        //private static IResourceProvider resourceProviderDetalle_Datos_Adicionales_Movimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Datos_Adicionales_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Datos_Adicionales_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Datos_Adicionales_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Datos_Adicionales_Movimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Datos_Adicionales_MovimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Datos_Adicionales_Movimiento</summary>
        public static string Detalle_Datos_Adicionales_Movimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("Detalle_Datos_Adicionales_Movimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dato</summary>
        public static string Dato
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("Dato", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Dato</summary>
        public static string Tipo_de_Dato
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("Tipo_de_Dato", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion</summary>
        public static string Relacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Obligatorio</summary>
        public static string Obligatorio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("Obligatorio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Datos_Adicionales_Movimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
